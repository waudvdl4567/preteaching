using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MYSQL_productDB
{
    public partial class addOrdersForm : Form
    {
        public delegate void openForm(String klantNaam, String productNaam,
            int hoeveelheid ,String datum);
        public event openForm del;


        Form1 parentForm;
        public addOrdersForm()
        {
            InitializeComponent();
            klantNameComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            productNameComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);

        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            checkButtonOk();
        }

        private void hoeveelheidTextBox_TextChanged(object sender, EventArgs e)
        {
            checkButtonOk();
        }


        private void checkButtonOk()
        {
            if(klantNameComboBox.SelectedItem != null &&
                productNameComboBox.SelectedItem != null &&
                hoeveelheidTextBox.TextLength != 0)
            {
                createOrderButton.Enabled = true;
            }
            else
            {
                createOrderButton.Enabled = false;
            }
        }

        private void hoeveelheidTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void processData(List<String>klantNamen, List<String> producten, Form1 parent)
        {
            klantNameComboBox.Items.AddRange(klantNamen.ToArray());
            productNameComboBox.Items.AddRange(producten.ToArray());
            parentForm = parent;
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            del += parentForm.addOrder;
            Console.WriteLine(klantNameComboBox.Text);
            Console.WriteLine(productNameComboBox.Text);
            Console.WriteLine(Int32.Parse(hoeveelheidTextBox.Text));
            Console.WriteLine(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
            del(klantNameComboBox.Text, productNameComboBox.Text, Int32.Parse(hoeveelheidTextBox.Text), monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
            this.Hide();
        }
    }
}
