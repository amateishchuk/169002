using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _169002.Forms
{
    public partial class Order : Form
    {

        public Order()
        {
            
            InitializeComponent();
            
        }


        private void Order_Load(object sender, EventArgs e)
        {
            prices = LoadPrices();
            this.priceDisabledTextBox.Text = prices[DEFAULTSIZE, DEFAULTSTYLE].ToString();
        }


        private void styleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceDisabledTextBox.Text = prices[styleComboBox.SelectedIndex, sizeComboBox.SelectedIndex].ToString();
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceDisabledTextBox.Text = prices[styleComboBox.SelectedIndex, sizeComboBox.SelectedIndex].ToString();
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            SetDefaultParameters();
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (QtyValidation())
            {
                decimal price = prices[styleComboBox.SelectedIndex, sizeComboBox.SelectedIndex];
                int qty = int.Parse(qtyTextBox.Text);
                

                summaryTextBox.Text = CheckoutResult(price, qty);
            }
            else MessageBox.Show("Quantity format error");
             
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
