namespace MySQL_ITProDB
{
    partial class ITProDBManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnVaardigheidVerwijderen = new System.Windows.Forms.Button();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.cmbMySQLConnecties = new System.Windows.Forms.ComboBox();
            this.tbLoggingText = new System.Windows.Forms.TextBox();
            this.btnCloseDB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLeesData = new System.Windows.Forms.Button();
            this.cmbVaardigheden = new System.Windows.Forms.ComboBox();
            this.btnLaadVaardigheden = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTijdWeergave = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLeesDataDecoupled = new System.Windows.Forms.Button();
            this.btnDeselecteerRecords = new System.Windows.Forms.Button();
            this.btnVerwijderRecordPV = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnVaardigheidAanpassen = new System.Windows.Forms.Button();
            this.tbNieuweVaardigheidnaam = new System.Windows.Forms.TextBox();
            this.cmbVaardigheden2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.lblVaardigheidToevoegen = new System.Windows.Forms.Label();
            this.tbVaardigheidToevoegen = new System.Windows.Forms.TextBox();
            this.btnVaardigheidToevoegen = new System.Windows.Forms.Button();
            this.tmrVerbindingsTijd = new System.Windows.Forms.Timer(this.components);
            this.tmrKlokTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSqlVerbindingsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVaardigheidVerwijderen
            // 
            this.btnVaardigheidVerwijderen.Location = new System.Drawing.Point(21, 188);
            this.btnVaardigheidVerwijderen.Name = "btnVaardigheidVerwijderen";
            this.btnVaardigheidVerwijderen.Size = new System.Drawing.Size(113, 34);
            this.btnVaardigheidVerwijderen.TabIndex = 0;
            this.btnVaardigheidVerwijderen.Text = "Verwijderen";
            this.btnVaardigheidVerwijderen.UseVisualStyleBackColor = true;
            this.btnVaardigheidVerwijderen.Click += new System.EventHandler(this.btnVaardigheidVerwijderen_Click);
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Location = new System.Drawing.Point(25, 513);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(155, 55);
            this.btnOpenDB.TabIndex = 0;
            this.btnOpenDB.Text = "Open\r\nverbinding";
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // cmbMySQLConnecties
            // 
            this.cmbMySQLConnecties.FormattingEnabled = true;
            this.cmbMySQLConnecties.Location = new System.Drawing.Point(25, 27);
            this.cmbMySQLConnecties.Name = "cmbMySQLConnecties";
            this.cmbMySQLConnecties.Size = new System.Drawing.Size(328, 24);
            this.cmbMySQLConnecties.TabIndex = 2;
            this.cmbMySQLConnecties.SelectedValueChanged += new System.EventHandler(this.cmbMySQLConnecties_SelectedValueChanged);
            // 
            // tbLoggingText
            // 
            this.tbLoggingText.Location = new System.Drawing.Point(25, 57);
            this.tbLoggingText.Multiline = true;
            this.tbLoggingText.Name = "tbLoggingText";
            this.tbLoggingText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLoggingText.Size = new System.Drawing.Size(1191, 450);
            this.tbLoggingText.TabIndex = 3;
            this.tbLoggingText.WordWrap = false;
            this.tbLoggingText.TextChanged += new System.EventHandler(this.tbLoggingText_TextChanged);
            // 
            // btnCloseDB
            // 
            this.btnCloseDB.Enabled = false;
            this.btnCloseDB.Location = new System.Drawing.Point(186, 513);
            this.btnCloseDB.Name = "btnCloseDB";
            this.btnCloseDB.Size = new System.Drawing.Size(155, 55);
            this.btnCloseDB.TabIndex = 4;
            this.btnCloseDB.Text = "Sluit\r\nverbinding";
            this.btnCloseDB.UseVisualStyleBackColor = true;
            this.btnCloseDB.Click += new System.EventHandler(this.btnCloseDB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 464);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnLeesData
            // 
            this.btnLeesData.Enabled = false;
            this.btnLeesData.Location = new System.Drawing.Point(157, 493);
            this.btnLeesData.Name = "btnLeesData";
            this.btnLeesData.Size = new System.Drawing.Size(156, 55);
            this.btnLeesData.TabIndex = 6;
            this.btnLeesData.Text = "Lees data\r\nuit ITProDB met reader";
            this.btnLeesData.UseVisualStyleBackColor = true;
            this.btnLeesData.Click += new System.EventHandler(this.btnLeesData_Click);
            // 
            // cmbVaardigheden
            // 
            this.cmbVaardigheden.FormattingEnabled = true;
            this.cmbVaardigheden.Location = new System.Drawing.Point(6, 554);
            this.cmbVaardigheden.Name = "cmbVaardigheden";
            this.cmbVaardigheden.Size = new System.Drawing.Size(302, 24);
            this.cmbVaardigheden.TabIndex = 8;
            // 
            // btnLaadVaardigheden
            // 
            this.btnLaadVaardigheden.Location = new System.Drawing.Point(6, 493);
            this.btnLaadVaardigheden.Name = "btnLaadVaardigheden";
            this.btnLaadVaardigheden.Size = new System.Drawing.Size(145, 55);
            this.btnLaadVaardigheden.TabIndex = 9;
            this.btnLaadVaardigheden.Text = "Laad \r\nvaardigheden";
            this.btnLaadVaardigheden.UseVisualStyleBackColor = true;
            this.btnLaadVaardigheden.Click += new System.EventHandler(this.btnLaadVaardigheden_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1253, 651);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTijdWeergave);
            this.tabPage1.Controls.Add(this.btnCloseDB);
            this.tabPage1.Controls.Add(this.tbLoggingText);
            this.tabPage1.Controls.Add(this.cmbMySQLConnecties);
            this.tabPage1.Controls.Add(this.btnOpenDB);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1245, 619);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MySQL OPEN/CLOSE verbinding";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTijdWeergave
            // 
            this.lblTijdWeergave.AutoSize = true;
            this.lblTijdWeergave.Location = new System.Drawing.Point(1136, 532);
            this.lblTijdWeergave.Name = "lblTijdWeergave";
            this.lblTijdWeergave.Size = new System.Drawing.Size(46, 17);
            this.lblTijdWeergave.TabIndex = 5;
            this.lblTijdWeergave.Text = "label2";
            this.lblTijdWeergave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLeesDataDecoupled);
            this.tabPage2.Controls.Add(this.btnDeselecteerRecords);
            this.tabPage2.Controls.Add(this.btnVerwijderRecordPV);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnLaadVaardigheden);
            this.tabPage2.Controls.Add(this.btnLeesData);
            this.tabPage2.Controls.Add(this.cmbVaardigheden);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1245, 619);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MySQL SELECT/DELETE met DataGridView";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLeesDataDecoupled
            // 
            this.btnLeesDataDecoupled.Location = new System.Drawing.Point(319, 493);
            this.btnLeesDataDecoupled.Name = "btnLeesDataDecoupled";
            this.btnLeesDataDecoupled.Size = new System.Drawing.Size(181, 55);
            this.btnLeesDataDecoupled.TabIndex = 12;
            this.btnLeesDataDecoupled.Text = "Lees data uit ITProDB\r\nmet MySqlDataAdapter";
            this.btnLeesDataDecoupled.UseVisualStyleBackColor = true;
            this.btnLeesDataDecoupled.Click += new System.EventHandler(this.btnLeesDataDecoupled_Click);
            // 
            // btnDeselecteerRecords
            // 
            this.btnDeselecteerRecords.Location = new System.Drawing.Point(1038, 495);
            this.btnDeselecteerRecords.Name = "btnDeselecteerRecords";
            this.btnDeselecteerRecords.Size = new System.Drawing.Size(178, 54);
            this.btnDeselecteerRecords.TabIndex = 11;
            this.btnDeselecteerRecords.Text = "Deselecteer\r\nrecords";
            this.btnDeselecteerRecords.UseVisualStyleBackColor = true;
            this.btnDeselecteerRecords.Click += new System.EventHandler(this.btnDeselecteerRecords_Click);
            // 
            // btnVerwijderRecordPV
            // 
            this.btnVerwijderRecordPV.Enabled = false;
            this.btnVerwijderRecordPV.Location = new System.Drawing.Point(852, 495);
            this.btnVerwijderRecordPV.Name = "btnVerwijderRecordPV";
            this.btnVerwijderRecordPV.Size = new System.Drawing.Size(180, 55);
            this.btnVerwijderRecordPV.TabIndex = 10;
            this.btnVerwijderRecordPV.Text = "Verwijder geselecteerd\r\nrecords";
            this.btnVerwijderRecordPV.UseVisualStyleBackColor = true;
            this.btnVerwijderRecordPV.Click += new System.EventHandler(this.btnVerwijderRecordPV_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1245, 619);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MySQL INSERT/DELETE/UPDATE met TextBox en ComboBox";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear2);
            this.groupBox2.Controls.Add(this.btnVaardigheidAanpassen);
            this.groupBox2.Controls.Add(this.tbNieuweVaardigheidnaam);
            this.groupBox2.Controls.Add(this.cmbVaardigheden2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnVaardigheidVerwijderen);
            this.groupBox2.Location = new System.Drawing.Point(6, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1220, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vaardigheden verwijderen uit database";
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(974, 188);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(113, 34);
            this.btnClear2.TabIndex = 6;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // btnVaardigheidAanpassen
            // 
            this.btnVaardigheidAanpassen.Location = new System.Drawing.Point(141, 188);
            this.btnVaardigheidAanpassen.Name = "btnVaardigheidAanpassen";
            this.btnVaardigheidAanpassen.Size = new System.Drawing.Size(107, 34);
            this.btnVaardigheidAanpassen.TabIndex = 5;
            this.btnVaardigheidAanpassen.Text = "Aanpassen";
            this.btnVaardigheidAanpassen.UseVisualStyleBackColor = true;
            this.btnVaardigheidAanpassen.Click += new System.EventHandler(this.btnVaardigheidAanpassen_Click);
            // 
            // tbNieuweVaardigheidnaam
            // 
            this.tbNieuweVaardigheidnaam.Location = new System.Drawing.Point(21, 105);
            this.tbNieuweVaardigheidnaam.Multiline = true;
            this.tbNieuweVaardigheidnaam.Name = "tbNieuweVaardigheidnaam";
            this.tbNieuweVaardigheidnaam.Size = new System.Drawing.Size(1066, 77);
            this.tbNieuweVaardigheidnaam.TabIndex = 4;
            // 
            // cmbVaardigheden2
            // 
            this.cmbVaardigheden2.FormattingEnabled = true;
            this.cmbVaardigheden2.Location = new System.Drawing.Point(21, 61);
            this.cmbVaardigheden2.Name = "cmbVaardigheden2";
            this.cmbVaardigheden2.Size = new System.Drawing.Size(1070, 24);
            this.cmbVaardigheden2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kies een vaardigheid en druk op verwijderen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear1);
            this.groupBox1.Controls.Add(this.lblVaardigheidToevoegen);
            this.groupBox1.Controls.Add(this.tbVaardigheidToevoegen);
            this.groupBox1.Controls.Add(this.btnVaardigheidToevoegen);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vaardigheden toevoegen aan database";
            // 
            // btnClear1
            // 
            this.btnClear1.Location = new System.Drawing.Point(978, 134);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(113, 34);
            this.btnClear1.TabIndex = 3;
            this.btnClear1.Text = "Clear";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // lblVaardigheidToevoegen
            // 
            this.lblVaardigheidToevoegen.AutoSize = true;
            this.lblVaardigheidToevoegen.Location = new System.Drawing.Point(18, 29);
            this.lblVaardigheidToevoegen.Name = "lblVaardigheidToevoegen";
            this.lblVaardigheidToevoegen.Size = new System.Drawing.Size(432, 17);
            this.lblVaardigheidToevoegen.TabIndex = 2;
            this.lblVaardigheidToevoegen.Text = "Voer een vaardigheid in (max 255 karakters) en druk op toevoegen";
            // 
            // tbVaardigheidToevoegen
            // 
            this.tbVaardigheidToevoegen.Location = new System.Drawing.Point(21, 62);
            this.tbVaardigheidToevoegen.MaxLength = 255;
            this.tbVaardigheidToevoegen.Multiline = true;
            this.tbVaardigheidToevoegen.Name = "tbVaardigheidToevoegen";
            this.tbVaardigheidToevoegen.Size = new System.Drawing.Size(1070, 66);
            this.tbVaardigheidToevoegen.TabIndex = 1;
            // 
            // btnVaardigheidToevoegen
            // 
            this.btnVaardigheidToevoegen.Location = new System.Drawing.Point(21, 134);
            this.btnVaardigheidToevoegen.Name = "btnVaardigheidToevoegen";
            this.btnVaardigheidToevoegen.Size = new System.Drawing.Size(113, 34);
            this.btnVaardigheidToevoegen.TabIndex = 0;
            this.btnVaardigheidToevoegen.Text = "Toevoegen";
            this.btnVaardigheidToevoegen.UseVisualStyleBackColor = true;
            this.btnVaardigheidToevoegen.Click += new System.EventHandler(this.btnVaardigheidToevoegen_Click);
            // 
            // tmrVerbindingsTijd
            // 
            this.tmrVerbindingsTijd.Interval = 10000;
            this.tmrVerbindingsTijd.Tick += new System.EventHandler(this.tmrVerbindingsTijd_Tick);
            // 
            // tmrKlokTimer
            // 
            this.tmrKlokTimer.Enabled = true;
            this.tmrKlokTimer.Interval = 1000;
            this.tmrKlokTimer.Tick += new System.EventHandler(this.tmrKlokTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSqlVerbindingsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1253, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSqlVerbindingsStatus
            // 
            this.lblSqlVerbindingsStatus.BackColor = System.Drawing.Color.DarkGreen;
            this.lblSqlVerbindingsStatus.ForeColor = System.Drawing.Color.Lime;
            this.lblSqlVerbindingsStatus.Name = "lblSqlVerbindingsStatus";
            this.lblSqlVerbindingsStatus.Size = new System.Drawing.Size(112, 20);
            this.lblSqlVerbindingsStatus.Text = "SQL-verbinding";
            this.lblSqlVerbindingsStatus.Visible = false;
            // 
            // ITProDBManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 679);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ITProDBManager";
            this.Text = "ITProDBManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.ComboBox cmbMySQLConnecties;
        private System.Windows.Forms.TextBox tbLoggingText;
        private System.Windows.Forms.Button btnCloseDB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLeesData;
        private System.Windows.Forms.ComboBox cmbVaardigheden;
        private System.Windows.Forms.Button btnLaadVaardigheden;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbVaardigheidToevoegen;
        private System.Windows.Forms.Button btnVaardigheidToevoegen;
        private System.Windows.Forms.Label lblVaardigheidToevoegen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbVaardigheden2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVaardigheidVerwijderen;
        private System.Windows.Forms.Button btnVerwijderRecordPV;
        private System.Windows.Forms.Button btnDeselecteerRecords;
        private System.Windows.Forms.Label lblTijdWeergave;
        private System.Windows.Forms.Timer tmrVerbindingsTijd;
        private System.Windows.Forms.Timer tmrKlokTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSqlVerbindingsStatus;
        private System.Windows.Forms.Button btnVaardigheidAanpassen;
        private System.Windows.Forms.TextBox tbNieuweVaardigheidnaam;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnLeesDataDecoupled;
    }
}

