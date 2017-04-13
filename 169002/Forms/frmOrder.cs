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
    public partial class frmOrder : Form
    {

        public frmOrder()
        {
            
            InitializeComponent();
            
        }


        private void frmOrder_Load(object sender, EventArgs e)
        {
            prices = LoadPrices();
            this.lblPrice.Text = String.Format("{0:C2}", prices[DEFAULTSIZE, DEFAULTSTYLE]);
        }


        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrice.Text = String.Format("{0:C2}", prices[cbStyle.SelectedIndex, cbSize.SelectedIndex]);
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrice.Text = String.Format("{0:C2}", prices[cbStyle.SelectedIndex, cbSize.SelectedIndex]);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            SetDefaultParameters();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (QtyValidation())
            {
                decimal price = prices[cbStyle.SelectedIndex, cbSize.SelectedIndex];
                int qty = int.Parse(txtQty.Text);
                

                lblSummary.Text = CheckoutResult(price, qty);
            }
            else MessageBox.Show("Quantity format error");
             
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
