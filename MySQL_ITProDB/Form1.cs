using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace MySQL_ITProDB
{
    public partial class ITProDBManager : Form
    {

        ConnectionStringSettingsCollection connectionStringSettings = new ConnectionStringSettingsCollection();
        Dictionary<string, string> connStringsDict = new Dictionary<string, string>();

        //MySQL Connectie variabelen
        string mySqlConnStr = null;
        MySqlConnection mySqlConn;
        MySqlCommand mySqlComm;
        DataTable myDatatable;
        MySqlDataAdapter myAdapter;

        public ITProDBManager()
        {
            InitializeComponent();
            connectionStringSettings = GetConnectionStrings();
            connStringsDict = UpdateConnectionsComboBox(cmbMySQLConnecties, connectionStringSettings);
            mySqlConnStr = cmbMySQLConnecties.SelectedValue.ToString();
            tbLoggingText.Text += mySqlConnStr + Environment.NewLine;
        }

        private Dictionary<string, string> UpdateConnectionsComboBox(ComboBox cb,ConnectionStringSettingsCollection cssc)
        {
            Dictionary<string, string> csd = new Dictionary<string, string>();

            if (cssc != null)
            {
                foreach (ConnectionStringSettings cs in cssc)
                {
                    csd.Add(cs.Name, cs.ConnectionString);
                }

                cb.DataSource = new BindingSource(csd, null);
                cb.DisplayMember = "Key";
                cb.ValueMember = "Value";
            }
            else
            {
                cb.Enabled = false;
            }
            return csd;
        }

        private ConnectionStringSettingsCollection GetConnectionStrings()
        {
            ConnectionStringSettingsCollection settings = new ConnectionStringSettingsCollection();

            try
            {
                settings = ConfigurationManager.ConnectionStrings;
                LogtekstToevoegen(tbLoggingText, "App.config uitgelezen. Connecties geladen...");
            }
            catch (ConfigurationErrorsException err)
            {
                MessageBox.Show(err.Message, "Configuratie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return settings;
        }

        private void cmbMySQLConnecties_SelectedValueChanged(object sender, EventArgs e)
        {
            mySqlConnStr = cmbMySQLConnecties.SelectedValue.ToString();
            String[] strlist = mySqlConnStr.Split(';');
            string str = string.Empty;

            foreach (String s in strlist)
            {
                if (!s.Contains("password"))
                {
                    str += s + " , ";
                }
            }

            LogtekstToevoegen(tbLoggingText, str);
        }

        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConn = OpenMySQLverbinding(mySqlConnStr);

                try
                {
                    if (mySqlConn.State == ConnectionState.Open)
                    {
                        tmrVerbindingsTijd.Enabled = true;
                        updateButtonsOnOpenConnection();
                        LogtekstToevoegen(tbLoggingText, "verbinding met database gemaakt");
                    }
                    else
                    {
                        LogtekstToevoegen(tbLoggingText, "Geen verbinding met database");
                    }
                }
                catch(NullReferenceException err)
                {
                    MessageBox.Show(err.Message, "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(MySqlException)
            {
                LogtekstToevoegen(tbLoggingText, "Fout bij verbinden met database");
            }
  
        }

        private void btnCloseDB_Click(object sender, EventArgs e)
        {
            if (SluitMySQLverbinding(mySqlConn))
            {
                LogtekstToevoegen(tbLoggingText, "Verbinding met database gesloten");
                tmrVerbindingsTijd.Enabled = false;
                updateButtonsOnCloseConnection();
            }
            else
            {
                LogtekstToevoegen(tbLoggingText, "Fout bij het sluiten van verbinding met database");
            }
        }

        private bool SluitMySQLverbinding(MySqlConnection mijnVerbinding)
        {
            bool succes = false;

            if (mijnVerbinding.State == ConnectionState.Open)
            {
                try
                {
                    mijnVerbinding.Close();
                    succes = true;
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Fout bij het sluiten van verbinding met database", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Geen open SQL-verbinding", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return succes;
        }

        private MySqlConnection OpenMySQLverbinding(string connectieString)
        {
            MySqlConnection mijnVerbinding = null;


            try
            {
                mijnVerbinding = new MySqlConnection(connectieString);

                try
                {
                    mijnVerbinding.Open();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Fout bij het maken van verbinding met database", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (mijnVerbinding != null)
                    {
                        mijnVerbinding.Dispose();
                    }
                }
            }
            catch (ArgumentException err)
            {
                MessageBox.Show(err.Message, "SQL-verbinding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (mijnVerbinding != null)
                {
                    mijnVerbinding.Dispose();
                }
            }

            return mijnVerbinding;
        }

        private void updateButtonsOnCloseConnection()
        {
            btnOpenDB.Enabled = true;
            btnCloseDB.Enabled = false;
            lblSqlVerbindingsStatus.Visible = false;
        }

        private void updateButtonsOnOpenConnection()
        {
            btnOpenDB.Enabled = false;
            btnCloseDB.Enabled = true;
            lblSqlVerbindingsStatus.Visible = true;
        }

        //gecontroleerd en try-catch verplaatst
        private void LeesData()
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            myDatatable = new DataTable();

            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                        if (mySqlConn.State == ConnectionState.Open)
                        {
                            LogtekstToevoegen(tbLoggingText, "verbinding met database gemaakt. Start lezen data...");

                            using (mySqlComm = new MySqlCommand())
                            {
                                mySqlComm.Connection = mySqlConn;
                                mySqlComm.CommandText = "GetPersonenMetVaardigheden";
                                mySqlComm.CommandType = CommandType.StoredProcedure;

                                mySqlComm.Parameters.Add(new MySqlParameter("vaardigheid", MySqlDbType.VarChar));
                                mySqlComm.Parameters["vaardigheid"].Value = cmbVaardigheden.Text;
                                mySqlComm.Parameters["vaardigheid"].Direction = ParameterDirection.Input;

                                LogtekstToevoegen(tbLoggingText, "Zoeken naar vaardigheid : " + cmbVaardigheden.Text);                          

                                myDatatable.Load(mySqlComm.ExecuteReader());
                                dataGridView1.DataSource = myDatatable;
                                LogtekstToevoegen(tbLoggingText, "Gegevens uit database geladen. " + myDatatable.Rows.Count + " rijen gevonden");
                            }
                        }
                        else
                        {
                            LogtekstToevoegen(tbLoggingText, "Geen verbinding met database");
                        }
                }
            }
            catch(Exception ex)
            {
                if (ex is NullReferenceException || ex is MySqlException)
                {
                    MessageBox.Show(ex.Message, "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else throw;
            }

            dataGridView1.ClearSelection();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }


        private void LeesDataDecoupled()
        {
            dataGridView1.SelectionChanged -= dataGridView1_SelectionChanged;
            
            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                    if (mySqlConn.State == ConnectionState.Open)
                    {
                        LogtekstToevoegen(tbLoggingText, "verbinding met database gemaakt. Start lezen data...");

                        using (mySqlComm = new MySqlCommand())
                        {
                            mySqlComm.Connection = mySqlConn;
                            mySqlComm.CommandText = "GetPersonenMetVaardigheden";
                            mySqlComm.CommandType = CommandType.StoredProcedure;

                            mySqlComm.Parameters.Add(new MySqlParameter("vaardigheid", MySqlDbType.VarChar));
                            mySqlComm.Parameters["vaardigheid"].Value = cmbVaardigheden.Text;
                            mySqlComm.Parameters["vaardigheid"].Direction = ParameterDirection.Input;

                            LogtekstToevoegen(tbLoggingText, "Zoeken naar vaardigheid : " + cmbVaardigheden.Text);
                            using(myAdapter = new MySqlDataAdapter(mySqlComm))
                            {
                                using(myDatatable = new DataTable())
                                {
                                    myAdapter.Fill(myDatatable);
                                    dataGridView1.DataSource = myDatatable;
                                    LogtekstToevoegen(tbLoggingText, "Gegevens uit database geladen. " + myDatatable.Rows.Count + " rijen gevonden");
                                }
                            }
                        }
                    }
                    else
                    {
                        LogtekstToevoegen(tbLoggingText, "Geen verbinding met database");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException || ex is MySqlException)
                {
                    MessageBox.Show(ex.Message, "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else throw;
            }

            dataGridView1.ClearSelection();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        //tabel lezen zonder MySqlDataAdapter
        private void btnLeesData_Click(object sender, EventArgs e)
        {
            LeesData();
        }

        //tabel lezen met MySqlDataAdapter
        private void btnLeesDataDecoupled_Click(object sender, EventArgs e)
        {
            LeesDataDecoupled();
        }

        //gecontroleerd en try-catch verplaatst
        private void LaadVaardigheden()
        {
            Dictionary<int, string> csd = new Dictionary<int, string>();
            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                        if (mySqlConn.State == ConnectionState.Open)
                        {
                            LogtekstToevoegen(tbLoggingText, "verbinding met database gemaakt. Start lezen data...");

                            mySqlComm = new MySqlCommand();
                            mySqlComm.Connection = mySqlConn;
                            mySqlComm.CommandText = "select * from vaardigheden;";
                            mySqlComm.CommandType = CommandType.Text;
                        

                            using (MySqlDataReader mySqlDr = mySqlComm.ExecuteReader())
                            {
                                while (mySqlDr.Read())
                                {
                                    csd.Add((int)mySqlDr[0], (string)mySqlDr[1]);
                                }

                                mySqlDr.Close();

                                cmbVaardigheden.DataSource = new BindingSource(csd, null);
                                cmbVaardigheden.DisplayMember = "Value";
                                cmbVaardigheden.ValueMember = "Key";
                                //copy voor tabblad database aanpassen
                                cmbVaardigheden2.DataSource = new BindingSource(csd, null);
                                cmbVaardigheden2.DisplayMember = "Value";
                                cmbVaardigheden2.ValueMember = "Key";
                            }

                            LogtekstToevoegen(tbLoggingText, "Vaardigheden uit database geladen.");
                            btnLeesData.Enabled = true;
                        }
                        else
                        {
                            LogtekstToevoegen(tbLoggingText, "Geen verbinding met database");
                        }
                }
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException || ex is MySqlException)
                {
                    MessageBox.Show(ex.Message, "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else throw;
            }
        }

        private void btnLaadVaardigheden_Click(object sender, EventArgs e)
        {
            LaadVaardigheden();
        }

        private void LogtekstToevoegen(TextBox tb, string tekst)
        {
            tb.Text += DateTime.Now.ToString() + " : " + tekst + Environment.NewLine; 
        }

        //gecontroleerd en try-catch verplaatst
        private void btnVaardigheidToevoegen_Click(object sender, EventArgs e)
        {

            if (tbVaardigheidToevoegen.Text != string.Empty)
            {
                try
                {
                    using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                    {
                        if (mySqlConn.State == ConnectionState.Open)
                        {
                            LogtekstToevoegen(tbLoggingText, "verbinding met database gemaakt. toevoegen van record...");


                            using (mySqlComm = new MySqlCommand())
                            {
                                mySqlComm = new MySqlCommand();
                                mySqlComm.Connection = mySqlConn;
                                mySqlComm.Parameters.AddWithValue("vaardigheidNaam", tbVaardigheidToevoegen.Text);
                                mySqlComm.CommandText = "INSERT INTO vaardigheden(vaardigheidNaam) VALUES(@vaardigheidNaam)";
                                mySqlComm.CommandType = CommandType.Text;

                                try
                                {
                                    mySqlComm.ExecuteNonQuery();
                                    LogtekstToevoegen(tbLoggingText, "Vaardigheid '" + tbVaardigheidToevoegen.Text + "' naar database geschreven.");
                                    MessageBox.Show("Vaardigheid '" + tbVaardigheidToevoegen.Text + "'" + Environment.NewLine + "naar database geschreven.", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (MySqlException)
                                {
                                    MessageBox.Show("Fout bij schrijven naar database", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Geen connectie met database ", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    LaadVaardigheden();
                }
                catch(Exception ex)
                {
                    if (ex is NullReferenceException || ex is MySqlException)
                    {
                        MessageBox.Show(ex.Message, "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else throw;
                }
            }
            else
            {
                MessageBox.Show("Geen vaardigheidnaam ingegeven...", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //gecontroleerd en try-catch verplaatst
        private void btnVaardigheidVerwijderen_Click(object sender, EventArgs e)
        {
            if (cmbVaardigheden2.SelectedItem != null)
            {
                int selectedKey = (int)cmbVaardigheden2.SelectedValue;
                string selectedValue = cmbVaardigheden2.SelectedItem.ToString();

                DialogResult dialogResult = MessageBox.Show("Vaardigheid '" + selectedValue + "' verwijderen?", "Record verwijderen", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                        {
                            if (mySqlConn.State == ConnectionState.Open)
                            {
                                LogtekstToevoegen(tbLoggingText, "verbinding met database gemaakt. Verwijderen van record gestart...");


                                using (mySqlComm = new MySqlCommand())
                                {
                                    mySqlComm.Connection = mySqlConn;
                                    mySqlComm.Parameters.AddWithValue("@vaardigheidID", selectedKey);
                                    mySqlComm.CommandText = "DELETE FROM vaardigheden WHERE vaardigheidID = @vaardigheidID";
                                    mySqlComm.CommandType = CommandType.Text;

                                    mySqlComm.ExecuteNonQuery();
                                    LogtekstToevoegen(tbLoggingText, "Vaardigheid " + selectedKey + " : " + selectedValue + " is verwijderd.");
                                    MessageBox.Show("Vaardigheid '" + selectedValue + "'" + Environment.NewLine + " is verwijderd.", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                LaadVaardigheden();
                            }              
                            else
                            {
                                MessageBox.Show("Geen connectie met database ", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }                          
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex is NullReferenceException || ex is MySqlException)
                        {
                            MessageBox.Show(ex.Message, "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else throw;
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //doe iets anders...hier even niets.
                }
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection geselecteerdeRecords = dataGridView1.SelectedRows;

            btnVerwijderRecordPV.Enabled = (geselecteerdeRecords.Count > 0) ? true : false;

            foreach (DataGridViewRow r in geselecteerdeRecords)
            {
                Console.WriteLine("geselecteerde 'persoon_vaardigheidID' = " + r.Cells[0].Value + " , ");
            }
        }

        private void btnDeselecteerRecords_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        //gecontroleerd en try-catch verplaatst
        private void btnVerwijderRecordPV_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection geselecteerdeRecords = dataGridView1.SelectedRows;

            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                        if (mySqlConn.State == ConnectionState.Open)
                        {
                            LogtekstToevoegen(tbLoggingText, "verbinding met database gemaakt. Start verwijderen data...");

                            foreach (DataGridViewRow r in geselecteerdeRecords)
                            {
                                int selectedPersoon_VaardigheidID = (int)r.Cells[0].Value;
                                DialogResult dialogResult = MessageBox.Show("Record met persoon_vaardigheidID = '" + selectedPersoon_VaardigheidID + "' verwijderen?", "Record verwijderen", MessageBoxButtons.YesNo);

                                if (dialogResult == DialogResult.Yes)
                                {

                                    using (mySqlComm = new MySqlCommand())
                                    {
                                        mySqlComm = new MySqlCommand();
                                        mySqlComm.Connection = mySqlConn;
                                        mySqlComm.CommandText = "DELETE FROM vaardigheden_personen WHERE persoon_vaardigheidID = @vaardigheidID;";
                                        mySqlComm.Parameters.AddWithValue("@vaardigheidID", selectedPersoon_VaardigheidID);
                                        mySqlComm.CommandType = CommandType.Text;
                                        mySqlComm.ExecuteNonQuery();
                                        LogtekstToevoegen(tbLoggingText, "Record " + selectedPersoon_VaardigheidID + " is verwijderd uit tabel vaardigheid_personen.");

                                    }
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    //doe iets anders...nu niets dus...
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Geen connectie met database ", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                }

                LeesData();
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException || ex is MySqlException)
                {
                    MessageBox.Show(ex.Message, "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else throw;
            }

        }

        private void tmrVerbindingsTijd_Tick(object sender, EventArgs e)
        {
            if (mySqlConn.State == ConnectionState.Open)
            {
                try
                {
                    mySqlConn.Close();
                    LogtekstToevoegen(tbLoggingText, "Verbinding met database verbroken");
                    updateButtonsOnCloseConnection();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Fout bij het verbreken van verbinding met database", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LogtekstToevoegen(tbLoggingText, "Fout bij het verbreken van verbinding met database");
                }
            }
            else
            {
                MessageBox.Show("Geen open SQL-verbinding", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LogtekstToevoegen(tbLoggingText, "Geen open SQL-verbinding");
            }

            (sender as Timer).Enabled = false;
        }

        private void tmrKlokTimer_Tick(object sender, EventArgs e)
        {
            lblTijdWeergave.Text = DateTime.Now.ToLongTimeString();
        }

        private void tbLoggingText_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.SelectionStart = tb.TextLength;
            tb.ScrollToCaret();
        }

        private void btnVaardigheidAanpassen_Click(object sender, EventArgs e)
        {
            if (cmbVaardigheden2.SelectedItem != null)
            {
                int selectedKey = (int)cmbVaardigheden2.SelectedValue;
                string selectedValue = cmbVaardigheden2.SelectedItem.ToString();

                DialogResult dialogResult = MessageBox.Show("VaardigheidNaam '" + selectedValue + "' Aanpassen?", "Record aanpassen", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                        {
                            if (mySqlConn.State == ConnectionState.Open)
                            {
                                LogtekstToevoegen(tbLoggingText, "verbinding met database gemaakt. Aanpassen van record gestart...");


                                using (mySqlComm = new MySqlCommand())
                                {
                                    mySqlComm.Connection = mySqlConn;
                                    mySqlComm.Parameters.AddWithValue("vaardigheidID", selectedKey);
                                    mySqlComm.Parameters.AddWithValue("vaardigheidNaam", tbNieuweVaardigheidnaam.Text);
                                    mySqlComm.CommandText = "UPDATE vaardigheden SET vaardigheidNaam = @vaardigheidNaam WHERE vaardigheidID = @vaardigheidID";
                                    mySqlComm.CommandType = CommandType.Text;

                                    mySqlComm.ExecuteNonQuery();
                                    LogtekstToevoegen(tbLoggingText, "Vaardigheid " + selectedKey + " : " + selectedValue + " is aangepast.");
                                    MessageBox.Show("Vaardigheid '" + selectedValue + "'" + Environment.NewLine + " is aangepast.", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                LaadVaardigheden();
                            }
                            else
                            {
                                MessageBox.Show("Geen connectie met database ", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex is NullReferenceException || ex is MySqlException)
                        {
                            MessageBox.Show(ex.Message, "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else throw;
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //doe iets anders...hier even niets.
                }
            }
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            tbVaardigheidToevoegen.Clear();
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            tbNieuweVaardigheidnaam.Clear();
        }


    }
}
