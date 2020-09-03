namespace _1730gcronceex1c
{
    partial class gcronce1c1
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
            this.txtHotDogs1 = new System.Windows.Forms.Label();
            this.txtHamburgers1 = new System.Windows.Forms.Label();
            this.txtHotDogs2 = new System.Windows.Forms.TextBox();
            this.txtHamburgers2 = new System.Windows.Forms.TextBox();
            this.txtHotDogsPrice = new System.Windows.Forms.Label();
            this.txtHamburgersPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtHotDogsSubtotal = new System.Windows.Forms.TextBox();
            this.txtHamburgersSubtotal = new System.Windows.Forms.TextBox();
            this.txtPretaxTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotalTotal = new System.Windows.Forms.TextBox();
            this.btcCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHotDogs1
            // 
            this.txtHotDogs1.AutoSize = true;
            this.txtHotDogs1.Location = new System.Drawing.Point(70, 55);
            this.txtHotDogs1.Name = "txtHotDogs1";
            this.txtHotDogs1.Size = new System.Drawing.Size(69, 17);
            this.txtHotDogs1.TabIndex = 0;
            this.txtHotDogs1.Text = "Hot dogs:";
            // 
            // txtHamburgers1
            // 
            this.txtHamburgers1.AutoSize = true;
            this.txtHamburgers1.Location = new System.Drawing.Point(70, 96);
            this.txtHamburgers1.Name = "txtHamburgers1";
            this.txtHamburgers1.Size = new System.Drawing.Size(90, 17);
            this.txtHamburgers1.TabIndex = 1;
            this.txtHamburgers1.Text = "Hamburgers:";
            // 
            // txtHotDogs2
            // 
            this.txtHotDogs2.Location = new System.Drawing.Point(166, 52);
            this.txtHotDogs2.Name = "txtHotDogs2";
            this.txtHotDogs2.Size = new System.Drawing.Size(100, 22);
            this.txtHotDogs2.TabIndex = 2;
            this.txtHotDogs2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHamburgers2
            // 
            this.txtHamburgers2.Location = new System.Drawing.Point(166, 98);
            this.txtHamburgers2.Name = "txtHamburgers2";
            this.txtHamburgers2.Size = new System.Drawing.Size(100, 22);
            this.txtHamburgers2.TabIndex = 3;
            // 
            // txtHotDogsPrice
            // 
            this.txtHotDogsPrice.AutoSize = true;
            this.txtHotDogsPrice.Location = new System.Drawing.Point(291, 60);
            this.txtHotDogsPrice.Name = "txtHotDogsPrice";
            this.txtHotDogsPrice.Size = new System.Drawing.Size(66, 17);
            this.txtHotDogsPrice.TabIndex = 4;
            this.txtHotDogsPrice.Text = "x $4.00 =";
            // 
            // txtHamburgersPrice
            // 
            this.txtHamburgersPrice.AutoSize = true;
            this.txtHamburgersPrice.Location = new System.Drawing.Point(291, 101);
            this.txtHamburgersPrice.Name = "txtHamburgersPrice";
            this.txtHamburgersPrice.Size = new System.Drawing.Size(66, 17);
            this.txtHamburgersPrice.TabIndex = 5;
            this.txtHamburgersPrice.Text = "x $5.00 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pretax Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tax:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(313, 218);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(44, 17);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "Total:";
            this.txtTotal.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtHotDogsSubtotal
            // 
            this.txtHotDogsSubtotal.Location = new System.Drawing.Point(371, 55);
            this.txtHotDogsSubtotal.Name = "txtHotDogsSubtotal";
            this.txtHotDogsSubtotal.ReadOnly = true;
            this.txtHotDogsSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtHotDogsSubtotal.TabIndex = 9;
            this.txtHotDogsSubtotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtHamburgersSubtotal
            // 
            this.txtHamburgersSubtotal.Location = new System.Drawing.Point(371, 101);
            this.txtHamburgersSubtotal.Name = "txtHamburgersSubtotal";
            this.txtHamburgersSubtotal.ReadOnly = true;
            this.txtHamburgersSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtHamburgersSubtotal.TabIndex = 10;
            // 
            // txtPretaxTotal
            // 
            this.txtPretaxTotal.Location = new System.Drawing.Point(371, 136);
            this.txtPretaxTotal.Name = "txtPretaxTotal";
            this.txtPretaxTotal.Size = new System.Drawing.Size(100, 22);
            this.txtPretaxTotal.TabIndex = 11;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(371, 181);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 22);
            this.txtTax.TabIndex = 12;
            // 
            // txtTotalTotal
            // 
            this.txtTotalTotal.Location = new System.Drawing.Point(371, 218);
            this.txtTotalTotal.Name = "txtTotalTotal";
            this.txtTotalTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotalTotal.TabIndex = 13;
            // 
            // btcCalculate
            // 
            this.btcCalculate.Location = new System.Drawing.Point(139, 261);
            this.btcCalculate.Name = "btcCalculate";
            this.btcCalculate.Size = new System.Drawing.Size(75, 23);
            this.btcCalculate.TabIndex = 14;
            this.btcCalculate.Text = "&Calculate;";
            this.btcCalculate.UseVisualStyleBackColor = true;
            this.btcCalculate.Click += new System.EventHandler(this.btcCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(267, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(396, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gcronce1c1
            // 
            this.AcceptButton = this.btcCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 359);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btcCalculate);
            this.Controls.Add(this.txtTotalTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtPretaxTotal);
            this.Controls.Add(this.txtHamburgersSubtotal);
            this.Controls.Add(this.txtHotDogsSubtotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHamburgersPrice);
            this.Controls.Add(this.txtHotDogsPrice);
            this.Controls.Add(this.txtHamburgers2);
            this.Controls.Add(this.txtHotDogs2);
            this.Controls.Add(this.txtHamburgers1);
            this.Controls.Add(this.txtHotDogs1);
            this.Name = "gcronce1c1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHotDogs1;
        private System.Windows.Forms.Label txtHamburgers1;
        private System.Windows.Forms.TextBox txtHotDogs2;
        private System.Windows.Forms.TextBox txtHamburgers2;
        private System.Windows.Forms.Label txtHotDogsPrice;
        private System.Windows.Forms.Label txtHamburgersPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.TextBox txtHotDogsSubtotal;
        private System.Windows.Forms.TextBox txtHamburgersSubtotal;
        private System.Windows.Forms.TextBox txtPretaxTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotalTotal;
        private System.Windows.Forms.Button btcCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

