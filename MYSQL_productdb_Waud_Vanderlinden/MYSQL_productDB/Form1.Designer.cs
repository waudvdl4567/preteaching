namespace MYSQL_productDB
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.testConnection = new System.Windows.Forms.TabPage();
            this.closeMySqlConnectionButton = new System.Windows.Forms.Button();
            this.open_mysql_connection_button = new System.Windows.Forms.Button();
            this.cmbMySQLConnecties = new System.Windows.Forms.ComboBox();
            this.ReadTableOrders = new System.Windows.Forms.TabPage();
            this.databaseOrders = new System.Windows.Forms.TextBox();
            this.readTableButton = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.TabPage();
            this.productToevoegenButton = new System.Windows.Forms.Button();
            this.productStockTxBox = new System.Windows.Forms.TextBox();
            this.productStockLabel = new System.Windows.Forms.Label();
            this.productNaamLabel = new System.Windows.Forms.Label();
            this.productNameTxtBox = new System.Windows.Forms.TextBox();
            this.manageTableProducts = new System.Windows.Forms.TabPage();
            this.verwijderProductenButton = new System.Windows.Forms.Button();
            this.leesProductenButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.openAddOrderFrom = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.testConnection.SuspendLayout();
            this.ReadTableOrders.SuspendLayout();
            this.addProduct.SuspendLayout();
            this.manageTableProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.testConnection);
            this.tabControl1.Controls.Add(this.ReadTableOrders);
            this.tabControl1.Controls.Add(this.addProduct);
            this.tabControl1.Controls.Add(this.manageTableProducts);
            this.tabControl1.Location = new System.Drawing.Point(55, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 306);
            this.tabControl1.TabIndex = 0;
            // 
            // testConnection
            // 
            this.testConnection.Controls.Add(this.openAddOrderFrom);
            this.testConnection.Controls.Add(this.closeMySqlConnectionButton);
            this.testConnection.Controls.Add(this.open_mysql_connection_button);
            this.testConnection.Controls.Add(this.cmbMySQLConnecties);
            this.testConnection.Location = new System.Drawing.Point(4, 22);
            this.testConnection.Name = "testConnection";
            this.testConnection.Padding = new System.Windows.Forms.Padding(3);
            this.testConnection.Size = new System.Drawing.Size(673, 280);
            this.testConnection.TabIndex = 0;
            this.testConnection.Text = "Verbinding Testen";
            this.testConnection.UseVisualStyleBackColor = true;
            // 
            // closeMySqlConnectionButton
            // 
            this.closeMySqlConnectionButton.Location = new System.Drawing.Point(468, 87);
            this.closeMySqlConnectionButton.Name = "closeMySqlConnectionButton";
            this.closeMySqlConnectionButton.Size = new System.Drawing.Size(167, 71);
            this.closeMySqlConnectionButton.TabIndex = 2;
            this.closeMySqlConnectionButton.Text = "Sluit MySQL Verbinding";
            this.closeMySqlConnectionButton.UseVisualStyleBackColor = true;
            this.closeMySqlConnectionButton.Click += new System.EventHandler(this.closeMySqlConnectionButton_Click);
            // 
            // open_mysql_connection_button
            // 
            this.open_mysql_connection_button.Location = new System.Drawing.Point(278, 87);
            this.open_mysql_connection_button.Name = "open_mysql_connection_button";
            this.open_mysql_connection_button.Size = new System.Drawing.Size(145, 71);
            this.open_mysql_connection_button.TabIndex = 1;
            this.open_mysql_connection_button.Text = "Open MySQL Verbinding";
            this.open_mysql_connection_button.UseVisualStyleBackColor = true;
            this.open_mysql_connection_button.Click += new System.EventHandler(this.open_mysql_connection_button_Click);
            // 
            // cmbMySQLConnecties
            // 
            this.cmbMySQLConnecties.FormattingEnabled = true;
            this.cmbMySQLConnecties.Location = new System.Drawing.Point(6, 113);
            this.cmbMySQLConnecties.Name = "cmbMySQLConnecties";
            this.cmbMySQLConnecties.Size = new System.Drawing.Size(245, 21);
            this.cmbMySQLConnecties.TabIndex = 0;
            this.cmbMySQLConnecties.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ReadTableOrders
            // 
            this.ReadTableOrders.Controls.Add(this.databaseOrders);
            this.ReadTableOrders.Controls.Add(this.readTableButton);
            this.ReadTableOrders.Location = new System.Drawing.Point(4, 22);
            this.ReadTableOrders.Name = "ReadTableOrders";
            this.ReadTableOrders.Padding = new System.Windows.Forms.Padding(3);
            this.ReadTableOrders.Size = new System.Drawing.Size(673, 280);
            this.ReadTableOrders.TabIndex = 1;
            this.ReadTableOrders.Text = "Uitlezen Tabel Orders";
            this.ReadTableOrders.UseVisualStyleBackColor = true;
            this.ReadTableOrders.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // databaseOrders
            // 
            this.databaseOrders.Location = new System.Drawing.Point(257, 19);
            this.databaseOrders.Multiline = true;
            this.databaseOrders.Name = "databaseOrders";
            this.databaseOrders.Size = new System.Drawing.Size(383, 133);
            this.databaseOrders.TabIndex = 1;
            // 
            // readTableButton
            // 
            this.readTableButton.Location = new System.Drawing.Point(26, 19);
            this.readTableButton.Name = "readTableButton";
            this.readTableButton.Size = new System.Drawing.Size(211, 53);
            this.readTableButton.TabIndex = 0;
            this.readTableButton.Text = "Lees tabel uit";
            this.readTableButton.UseVisualStyleBackColor = true;
            this.readTableButton.Click += new System.EventHandler(this.readTableButton_Click);
            // 
            // addProduct
            // 
            this.addProduct.Controls.Add(this.productToevoegenButton);
            this.addProduct.Controls.Add(this.productStockTxBox);
            this.addProduct.Controls.Add(this.productStockLabel);
            this.addProduct.Controls.Add(this.productNaamLabel);
            this.addProduct.Controls.Add(this.productNameTxtBox);
            this.addProduct.Location = new System.Drawing.Point(4, 22);
            this.addProduct.Name = "addProduct";
            this.addProduct.Padding = new System.Windows.Forms.Padding(3);
            this.addProduct.Size = new System.Drawing.Size(673, 280);
            this.addProduct.TabIndex = 2;
            this.addProduct.Text = "Toevoegen Product";
            this.addProduct.UseVisualStyleBackColor = true;
            // 
            // productToevoegenButton
            // 
            this.productToevoegenButton.Location = new System.Drawing.Point(63, 193);
            this.productToevoegenButton.Name = "productToevoegenButton";
            this.productToevoegenButton.Size = new System.Drawing.Size(121, 46);
            this.productToevoegenButton.TabIndex = 4;
            this.productToevoegenButton.Text = "Product toevoegen";
            this.productToevoegenButton.UseVisualStyleBackColor = true;
            this.productToevoegenButton.Click += new System.EventHandler(this.productToevoegenButton_Click);
            // 
            // productStockTxBox
            // 
            this.productStockTxBox.Location = new System.Drawing.Point(72, 150);
            this.productStockTxBox.Name = "productStockTxBox";
            this.productStockTxBox.Size = new System.Drawing.Size(112, 20);
            this.productStockTxBox.TabIndex = 3;
            // 
            // productStockLabel
            // 
            this.productStockLabel.AutoSize = true;
            this.productStockLabel.Location = new System.Drawing.Point(69, 125);
            this.productStockLabel.Name = "productStockLabel";
            this.productStockLabel.Size = new System.Drawing.Size(72, 13);
            this.productStockLabel.TabIndex = 2;
            this.productStockLabel.Text = "ProductStock";
            // 
            // productNaamLabel
            // 
            this.productNaamLabel.AutoSize = true;
            this.productNaamLabel.Location = new System.Drawing.Point(69, 31);
            this.productNaamLabel.Name = "productNaamLabel";
            this.productNaamLabel.Size = new System.Drawing.Size(70, 13);
            this.productNaamLabel.TabIndex = 1;
            this.productNaamLabel.Text = "Productnaam";
            // 
            // productNameTxtBox
            // 
            this.productNameTxtBox.Location = new System.Drawing.Point(72, 47);
            this.productNameTxtBox.Multiline = true;
            this.productNameTxtBox.Name = "productNameTxtBox";
            this.productNameTxtBox.Size = new System.Drawing.Size(201, 56);
            this.productNameTxtBox.TabIndex = 0;
            // 
            // manageTableProducts
            // 
            this.manageTableProducts.Controls.Add(this.verwijderProductenButton);
            this.manageTableProducts.Controls.Add(this.leesProductenButton);
            this.manageTableProducts.Controls.Add(this.dataGridView1);
            this.manageTableProducts.Location = new System.Drawing.Point(4, 22);
            this.manageTableProducts.Name = "manageTableProducts";
            this.manageTableProducts.Padding = new System.Windows.Forms.Padding(3);
            this.manageTableProducts.Size = new System.Drawing.Size(673, 280);
            this.manageTableProducts.TabIndex = 3;
            this.manageTableProducts.Text = "Beheer Tabel Producten";
            this.manageTableProducts.UseVisualStyleBackColor = true;
            // 
            // verwijderProductenButton
            // 
            this.verwijderProductenButton.Location = new System.Drawing.Point(454, 233);
            this.verwijderProductenButton.Name = "verwijderProductenButton";
            this.verwijderProductenButton.Size = new System.Drawing.Size(153, 23);
            this.verwijderProductenButton.TabIndex = 2;
            this.verwijderProductenButton.Text = "Verwijder product";
            this.verwijderProductenButton.UseVisualStyleBackColor = true;
            this.verwijderProductenButton.Click += new System.EventHandler(this.verwijderProductenButton_Click);
            // 
            // leesProductenButton
            // 
            this.leesProductenButton.Location = new System.Drawing.Point(26, 233);
            this.leesProductenButton.Name = "leesProductenButton";
            this.leesProductenButton.Size = new System.Drawing.Size(175, 23);
            this.leesProductenButton.TabIndex = 1;
            this.leesProductenButton.Text = "Lees tabel producten";
            this.leesProductenButton.UseVisualStyleBackColor = true;
            this.leesProductenButton.Click += new System.EventHandler(this.leesProductenButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionStatusLabel.Location = new System.Drawing.Point(81, 21);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(531, 41);
            this.connectionStatusLabel.TabIndex = 1;
            this.connectionStatusLabel.Text = "CONNECTION STATUS";
            this.connectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openAddOrderFrom
            // 
            this.openAddOrderFrom.Location = new System.Drawing.Point(279, 177);
            this.openAddOrderFrom.Name = "openAddOrderFrom";
            this.openAddOrderFrom.Size = new System.Drawing.Size(145, 74);
            this.openAddOrderFrom.TabIndex = 3;
            this.openAddOrderFrom.Text = "Order toeveoegen";
            this.openAddOrderFrom.UseVisualStyleBackColor = true;
            this.openAddOrderFrom.Click += new System.EventHandler(this.openAddOrderFrom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectionStatusLabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.testConnection.ResumeLayout(false);
            this.ReadTableOrders.ResumeLayout(false);
            this.ReadTableOrders.PerformLayout();
            this.addProduct.ResumeLayout(false);
            this.addProduct.PerformLayout();
            this.manageTableProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage testConnection;
        private System.Windows.Forms.TabPage ReadTableOrders;
        private System.Windows.Forms.TabPage addProduct;
        private System.Windows.Forms.TabPage manageTableProducts;
        private System.Windows.Forms.ComboBox cmbMySQLConnecties;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Button closeMySqlConnectionButton;
        private System.Windows.Forms.Button open_mysql_connection_button;
        private System.Windows.Forms.Button readTableButton;
        private System.Windows.Forms.TextBox databaseOrders;
        private System.Windows.Forms.Button productToevoegenButton;
        private System.Windows.Forms.TextBox productStockTxBox;
        private System.Windows.Forms.Label productStockLabel;
        private System.Windows.Forms.Label productNaamLabel;
        private System.Windows.Forms.TextBox productNameTxtBox;
        private System.Windows.Forms.Button verwijderProductenButton;
        private System.Windows.Forms.Button leesProductenButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button openAddOrderFrom;
    }
}

