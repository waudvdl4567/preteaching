namespace MYSQL_productDB
{
    partial class addOrdersForm
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
            this.bestelDatumLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.klantNaamLabel = new System.Windows.Forms.Label();
            this.klantNameComboBox = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.hoeveelheidTextBox = new System.Windows.Forms.TextBox();
            this.bestelHoeveelheidLabel = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bestelDatumLabel
            // 
            this.bestelDatumLabel.AutoSize = true;
            this.bestelDatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestelDatumLabel.Location = new System.Drawing.Point(12, 9);
            this.bestelDatumLabel.Name = "bestelDatumLabel";
            this.bestelDatumLabel.Size = new System.Drawing.Size(102, 20);
            this.bestelDatumLabel.TabIndex = 0;
            this.bestelDatumLabel.Text = "BestelDatum";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(16, 38);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // klantNaamLabel
            // 
            this.klantNaamLabel.AutoSize = true;
            this.klantNaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klantNaamLabel.Location = new System.Drawing.Point(311, 9);
            this.klantNaamLabel.Name = "klantNaamLabel";
            this.klantNaamLabel.Size = new System.Drawing.Size(87, 20);
            this.klantNaamLabel.TabIndex = 2;
            this.klantNaamLabel.Text = "KlantNaam";
            // 
            // klantNameComboBox
            // 
            this.klantNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.klantNameComboBox.FormattingEnabled = true;
            this.klantNameComboBox.Location = new System.Drawing.Point(315, 32);
            this.klantNameComboBox.Name = "klantNameComboBox";
            this.klantNameComboBox.Size = new System.Drawing.Size(178, 21);
            this.klantNameComboBox.TabIndex = 3;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(311, 86);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(64, 20);
            this.productLabel.TabIndex = 4;
            this.productLabel.Text = "Product";
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(315, 109);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(178, 21);
            this.productNameComboBox.TabIndex = 5;
            // 
            // hoeveelheidTextBox
            // 
            this.hoeveelheidTextBox.Location = new System.Drawing.Point(25, 248);
            this.hoeveelheidTextBox.Name = "hoeveelheidTextBox";
            this.hoeveelheidTextBox.Size = new System.Drawing.Size(132, 20);
            this.hoeveelheidTextBox.TabIndex = 6;
            this.hoeveelheidTextBox.TextChanged += new System.EventHandler(this.hoeveelheidTextBox_TextChanged);
            this.hoeveelheidTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hoeveelheidTextBox_KeyPress);
            // 
            // bestelHoeveelheidLabel
            // 
            this.bestelHoeveelheidLabel.AutoSize = true;
            this.bestelHoeveelheidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestelHoeveelheidLabel.Location = new System.Drawing.Point(21, 225);
            this.bestelHoeveelheidLabel.Name = "bestelHoeveelheidLabel";
            this.bestelHoeveelheidLabel.Size = new System.Drawing.Size(97, 20);
            this.bestelHoeveelheidLabel.TabIndex = 7;
            this.bestelHoeveelheidLabel.Text = "Hoeveelheid";
            // 
            // createOrderButton
            // 
            this.createOrderButton.Enabled = false;
            this.createOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrderButton.Location = new System.Drawing.Point(345, 230);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(122, 53);
            this.createOrderButton.TabIndex = 8;
            this.createOrderButton.Text = "Create order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // addOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 390);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.bestelHoeveelheidLabel);
            this.Controls.Add(this.hoeveelheidTextBox);
            this.Controls.Add(this.productNameComboBox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.klantNameComboBox);
            this.Controls.Add(this.klantNaamLabel);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.bestelDatumLabel);
            this.Name = "addOrdersForm";
            this.Text = "addOrdersForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addOrdersForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bestelDatumLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label klantNaamLabel;
        private System.Windows.Forms.ComboBox klantNameComboBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.ComboBox productNameComboBox;
        private System.Windows.Forms.TextBox hoeveelheidTextBox;
        private System.Windows.Forms.Label bestelHoeveelheidLabel;
        private System.Windows.Forms.Button createOrderButton;
    }
}