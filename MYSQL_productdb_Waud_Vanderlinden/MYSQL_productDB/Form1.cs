using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYSQL_productDB
{
    public partial class Form1 : Form
    {
        public delegate void openForm(List<String> klantNamen, List<String> producten, Form1 parent);
        public event openForm del;

        ConnectionStringSettingsCollection connectionStringSettings = new ConnectionStringSettingsCollection();
        Dictionary<string, string> connStringsDict = new Dictionary<string, string>();
        MySqlConnection mySqlConnection;

        //MySQL Connectie variabelen
        string mySqlConnStr = null;
        MySqlConnection mySqlConn;
        MySqlCommand mySqlComm;
        DataTable myDatatable;
        MySqlDataAdapter myAdapter;


        addOrdersForm newForm = new addOrdersForm();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "productID";
            dataGridView1.Columns[1].Name = "productNaam";
            dataGridView1.Columns[2].Name = "productStock";
            dataGridView1.Columns[3].Name = "Beschikbaarheid";

            connectionStringSettings = GetConnectionStrings();
            connStringsDict = UpdateConnectionsComboBox(cmbMySQLConnecties, connectionStringSettings);
            mySqlConnStr = cmbMySQLConnecties.SelectedValue.ToString();
        }

        private Dictionary<string, string> UpdateConnectionsComboBox(ComboBox cb, ConnectionStringSettingsCollection cssc)
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
                //LogtekstToevoegen(tbLoggingText, "App.config uitgelezen. Connecties geladen...");
            }
            catch (ConfigurationErrorsException err)
            {
                MessageBox.Show(err.Message, "Configuratie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return settings;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void open_mysql_connection_button_Click(object sender, EventArgs e)
        {
            try
            {
                mySqlConn = OpenMySQLverbinding(mySqlConnStr);

                try
                {
                    if (mySqlConn.State == ConnectionState.Open)
                    {
                        connectionStatusLabel.Text = "verbinding met database gemaakt";
                    }
                    else
                    {
                        connectionStatusLabel.Text = "Geen verbinding met database";
                    }
                }
                catch (NullReferenceException err)
                {
                    MessageBox.Show(err.Message, "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException)
            {
                connectionStatusLabel.Text = "Fout bij verbinden met database";
            }
        }

        private void closeMySqlConnectionButton_Click(object sender, EventArgs e)
        {
            if (SluitMySQLverbinding(mySqlConn))
            {
                connectionStatusLabel.Text = "Verbinding met database gesloten";
            }
            else
            {
                connectionStatusLabel.Text = "Fout bij het sluiten van verbinding met database";
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

        private void readTableButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                    if (mySqlConn.State == ConnectionState.Open)
                    {
                        connectionStatusLabel.Text= "verbinding met database gemaakt. Start lezen data...";

                        mySqlComm = new MySqlCommand();
                        mySqlComm.Connection = mySqlConn;
                        mySqlComm.CommandText = "select * from orders;";
                        mySqlComm.CommandType = CommandType.Text;


                        using (MySqlDataReader mySqlDr = mySqlComm.ExecuteReader())
                        {
                            while (mySqlDr.Read())
                            {
                                databaseOrders.Text += (int)mySqlDr[0] + "\t"
                                    + Convert.ToString((DateTime)mySqlDr[1]) + "\t"
                                    + (int)mySqlDr[2] + "\t"
                                    + Convert.ToByte(mySqlDr[3]) + "\t"
                                    + (int)mySqlDr[4] + "\t"
                                    + mySqlDr[5] + "\r\n";
                            }

                            mySqlDr.Close();
                        }

                        connectionStatusLabel.Text = "Vaardigheden uit database geladen.";
                    }
                    else
                    {
                        connectionStatusLabel.Text = "Geen verbinding met database";
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

        private void productToevoegenButton_Click(object sender, EventArgs e)
        {
            using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
            {
                if (mySqlConn.State == ConnectionState.Open)
                {
                    using (mySqlComm = new MySqlCommand())
                    {
                        mySqlComm = new MySqlCommand();
                        mySqlComm.Connection = mySqlConn;
                        mySqlComm.CommandText = "insert into producten(productNaam, productStock)" +
                            "values" +
                            "(@productNaam, @productStock);";
                        mySqlComm.Parameters.AddWithValue("@productNaam", productNameTxtBox.Text);
                        mySqlComm.Parameters.AddWithValue("@productStock", productStockTxBox.Text);
                        mySqlComm.CommandType = CommandType.Text;
                        mySqlComm.ExecuteNonQuery();
                        connectionStatusLabel.Text = "Product is toegevoegd!";
                    }
                }
                else
                {
                    connectionStatusLabel.Text = "Geen verbinding met de database";
                }
            }
        }

        private void leesProductenButton_Click(object sender, EventArgs e)
        {
            InlezenEnWegSchrijvenInTabel();
        }

        private void InlezenEnWegSchrijvenInTabel()
        {
            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                    dataGridView1.Rows.Clear();
                    if (mySqlConn.State == ConnectionState.Open)
                    {
                        mySqlComm = new MySqlCommand();
                        mySqlComm.Connection = mySqlConn;
                        mySqlComm.CommandText = "select * from producten;";
                        mySqlComm.CommandType = CommandType.Text;

                        connectionStatusLabel.Text = "VERBONDEN";

                        using (MySqlDataReader mySqlDr = mySqlComm.ExecuteReader())
                        {
                            while (mySqlDr.Read())
                            {
                                dataGridView1.Rows.Add(mySqlDr[0].ToString(), mySqlDr[1].ToString(), mySqlDr[2].ToString(), mySqlDr[3].ToString());
                            }

                            mySqlDr.Close();
                        }
                        dataGridView1.Visible = true;
                        mySqlConn.Close();
                    }
                    else
                    {

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


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection geselecteerdeRecords = dataGridView1.SelectedRows;
            verwijderProductenButton.Enabled = (geselecteerdeRecords.Count > 0) ? true : false;
        }

        private void verwijderProductenButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                string productID = dataGridView1[0,index].Value.ToString();

                DialogResult boxResult = MessageBox.Show("WILT U HET PRODUCT:" + Convert.ToString(dataGridView1.SelectedRows[0].Cells["ProductNaam"].Value).ToUpper() + " VERWIJDEREN?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (boxResult == DialogResult.Yes)
                {
                    dataGridView1.Rows.Clear();
                    try
                    {
                        using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                        {
                            if (mySqlConn.State == ConnectionState.Open)
                            {
                                using (mySqlComm = new MySqlCommand())
                                {
                                    mySqlComm.Connection = mySqlConn;
                                    mySqlComm.Parameters.AddWithValue("@productID", productID);
                                    mySqlComm.CommandText = "set foreign_key_checks = 0;" +
                                        "DELETE FROM producten " +
                                        "WHERE(productID = @productID);" +
                                        "set foreign_key_checks = 1;";
                                    mySqlComm.CommandType = CommandType.Text;

                                    mySqlComm.ExecuteNonQuery();

                                    mySqlConn.Close();
                                    InlezenEnWegSchrijvenInTabel();
                                }
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
            }
            else
                if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("U MOET EERST EEN RIJ SELECTEREN", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                if (dataGridView1.SelectedRows.Count > 1)
                MessageBox.Show("VERWIJDER RIJ PER RIJ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public List<String> readKlantNamen()
        {
            List<String> klantNamen = new List<string>();
            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                    if(mySqlConn.State == ConnectionState.Open)
                    {
                        mySqlComm = new MySqlCommand();
                        mySqlComm.Connection = mySqlConn;
                        mySqlComm.CommandText = "select klantNaam from klanten;";
                        mySqlComm.CommandType = CommandType.Text;

                        using (MySqlDataReader mySqlOut = mySqlComm.ExecuteReader())
                        {
                            while(mySqlOut.Read())
                            {
                                klantNamen.Add(mySqlOut[0].ToString());
                            }

                            mySqlOut.Close();
                        }

                        mySqlConn.Close();

                    }
                }
            }
            catch(Exception ex)
            {
                if (ex is NullReferenceException || ex is MySqlException)
                {
                    MessageBox.Show(ex.Message, "MySQL Connecite", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else throw;
            }
            return klantNamen;
        }

        public List<String> readProductNamen()
        {
            List<String> productNamen = new List<string>();
            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                    if (mySqlConn.State == ConnectionState.Open)
                    {
                        mySqlComm = new MySqlCommand();
                        mySqlComm.Connection = mySqlConn;
                        mySqlComm.CommandText = "select productNaam from producten;";
                        mySqlComm.CommandType = CommandType.Text;

                        using (MySqlDataReader mySqlOut = mySqlComm.ExecuteReader())
                        {
                            while (mySqlOut.Read())
                            {
                                productNamen.Add(mySqlOut[0].ToString());
                            }

                            mySqlOut.Close();
                        }

                        mySqlConn.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException || ex is MySqlException)
                {
                    MessageBox.Show(ex.Message, "MySQL Connecite", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else throw;
            }
            return productNamen;
        }

        private void openAddOrderFrom_Click(object sender, EventArgs e)
        {
            del += newForm.processData;
            del(readKlantNamen(), readProductNamen(), this);
            newForm.Show();
        }

        public void addOrder(String klantNaam, String productNaam, int hoeveelheid, String datum)
        {
            try
            {
                using (mySqlConn = OpenMySQLverbinding(mySqlConnStr))
                {
                    if(mySqlConn.State == ConnectionState.Open)
                    {
                        using (mySqlComm = new MySqlCommand())
                        {
                            mySqlComm.Connection = mySqlConn;
                            mySqlComm.Parameters.AddWithValue("@datum", datum);
                            mySqlComm.Parameters.AddWithValue("@klantNaam", klantNaam);
                            mySqlComm.Parameters.AddWithValue("@productNaam", productNaam);
                            mySqlComm.Parameters.AddWithValue("@hoeveelheid", hoeveelheid);
                            mySqlComm.CommandText = "insert into orders(bestelDatum, klantID, productID, bestelHoeveelheid, afgehandeld)" +
                                "values" +
                                "(@datum, (select klantID from klanten where klantNaam = @klantNaam)," +
                                "(select productID from producten where productNaam = @productNaam), @hoeveelheid, 0);";
                            mySqlComm.CommandType = CommandType.Text;
                            mySqlComm.ExecuteNonQuery();

                            mySqlConn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geen connectie met database", "MySQL Connectie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
