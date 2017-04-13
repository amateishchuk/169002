namespace _169002.Forms
{
    partial class Order
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
            this.styleLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceDisabledTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.styleLabel.Location = new System.Drawing.Point(30, 27);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(158, 27);
            this.styleLabel.TabIndex = 11;
            this.styleLabel.Text = "Choose style:";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeLabel.Location = new System.Drawing.Point(30, 87);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(150, 27);
            this.sizeLabel.TabIndex = 10;
            this.sizeLabel.Text = "Choose size:";
            // 
            // styleComboBox
            // 
            this.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Items.AddRange(new object[] {
            "Plain Black/White",
            "Plain Colour",
            "White w/Black Logo",
            "Colour w/Black Logo ",
            "Black w/Silver Logo",
            "Colour w/Silver Logo"});
            this.styleComboBox.Location = new System.Drawing.Point(209, 27);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(215, 21);
            this.styleComboBox.TabIndex = 0;
            styleComboBox.SelectedIndex = 0;
            this.styleComboBox.SelectedIndexChanged += new System.EventHandler(this.styleComboBox_SelectedIndexChanged);
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.sizeComboBox.Location = new System.Drawing.Point(209, 87);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(215, 21);
            this.sizeComboBox.TabIndex = 1;
            sizeComboBox.SelectedIndex = 0;
            this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantityLabel.Location = new System.Drawing.Point(30, 209);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(160, 27);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "Input quanity:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(30, 151);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(73, 27);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price:";
            // 
            // priceDisabledTextBox
            // 
            this.priceDisabledTextBox.Enabled = false;
            this.priceDisabledTextBox.Location = new System.Drawing.Point(209, 151);
            this.priceDisabledTextBox.Name = "priceDisabledTextBox";
            this.priceDisabledTextBox.Size = new System.Drawing.Size(61, 20);
            this.priceDisabledTextBox.TabIndex = 7;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(127, 354);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(124, 46);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear!";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkoutButton.Location = new System.Drawing.Point(300, 151);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(124, 78);
            this.checkoutButton.TabIndex = 5;
            this.checkoutButton.Text = "Checkout!";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summaryLabel.Location = new System.Drawing.Point(95, 269);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(122, 27);
            this.summaryLabel.TabIndex = 4;
            this.summaryLabel.Text = "Summary:";
            // 
            // summaryTextBox
            // 
            this.summaryTextBox.Enabled = false;
            this.summaryTextBox.Location = new System.Drawing.Point(260, 269);
            this.summaryTextBox.Name = "summaryTextBox";
            this.summaryTextBox.Size = new System.Drawing.Size(90, 20);
            this.summaryTextBox.TabIndex = 3;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(209, 209);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(61, 20);
            this.qtyTextBox.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(300, 354);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 46);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 441);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.summaryTextBox);
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.priceDisabledTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.styleLabel);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label styleLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceDisabledTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.TextBox summaryTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}