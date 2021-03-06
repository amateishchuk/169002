﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _169002.Forms
{
    public partial class frmOrder : Form 
    {
        const int DEFAULTSIZE = 0;
        const int DEFAULTSTYLE = 0;
        decimal[,] prices;

        //when application start the method load prices from input text file
        private decimal[,] LoadPrices()
        {
            int rows = cbStyle.Items.Count;
            int columns = cbSize.Items.Count;
            decimal[,] prices = new decimal[rows, columns];

            using (StreamReader sr = new StreamReader(
                new FileStream("ABC_Textiles_Prices.txt", FileMode.Open, FileAccess.Read)))
            {
                for (int i = 0; i < rows; i++)
                {
                    string line = sr.ReadLine();
                    string[] array = line.Split(',');


                    for (int j = 0; j < columns; j++)
                    {
                        prices[i, j] = Decimal.Parse(array[j].Replace('.', ','));
                    }
                }
            }
            return prices;
        }

        //when user click "clear" button
        private void SetDefaultParameters()
        {
            this.cbSize.SelectedIndex = DEFAULTSIZE;
            this.cbStyle.SelectedIndex = DEFAULTSTYLE;
            this.txtQty.Text = "";
            this.lblPrice.Text = String.Format("{0:C2}", prices[DEFAULTSIZE, DEFAULTSTYLE]);
            this.lblSummary.Text = "";
        }

        //validation of user input quantity
        private bool QtyValidation()
        {
            int qty;
            if (int.TryParse(txtQty.Text, out qty) && qty > 0)
                return true;
            return false;
        }

        //apply checkout and 5% tax, currency format string
        private string CheckoutResult(decimal price, int qty)
        {
            decimal summary = (qty * price) * 1.05M;
            return String.Format("{0:C2}", summary);
        }
    }
}
