namespace Spawner_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.txtAmount1 = new System.Windows.Forms.TextBox();
            this.txtSell1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSell2 = new System.Windows.Forms.TextBox();
            this.txtAmount2 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSell3 = new System.Windows.Forms.TextBox();
            this.txtAmount3 = new System.Windows.Forms.TextBox();
            this.txtPrice3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSps1 = new System.Windows.Forms.Label();
            this.lblMps1 = new System.Windows.Forms.Label();
            this.lblSps2 = new System.Windows.Forms.Label();
            this.lblMps2 = new System.Windows.Forms.Label();
            this.lblSps3 = new System.Windows.Forms.Label();
            this.lblMps3 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spawner Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drop Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sell Price";
            // 
            // txtPrice1
            // 
            this.txtPrice1.Location = new System.Drawing.Point(145, 38);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(100, 20);
            this.txtPrice1.TabIndex = 3;
            this.txtPrice1.Text = "0";
            // 
            // txtAmount1
            // 
            this.txtAmount1.Location = new System.Drawing.Point(145, 67);
            this.txtAmount1.Name = "txtAmount1";
            this.txtAmount1.Size = new System.Drawing.Size(100, 20);
            this.txtAmount1.TabIndex = 4;
            this.txtAmount1.Text = "0";
            this.txtAmount1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSell1
            // 
            this.txtSell1.Location = new System.Drawing.Point(145, 93);
            this.txtSell1.Name = "txtSell1";
            this.txtSell1.Size = new System.Drawing.Size(100, 20);
            this.txtSell1.TabIndex = 5;
            this.txtSell1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Spawner 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Spawner 2";
            // 
            // txtSell2
            // 
            this.txtSell2.Location = new System.Drawing.Point(256, 93);
            this.txtSell2.Name = "txtSell2";
            this.txtSell2.Size = new System.Drawing.Size(100, 20);
            this.txtSell2.TabIndex = 9;
            this.txtSell2.Text = "0";
            // 
            // txtAmount2
            // 
            this.txtAmount2.Location = new System.Drawing.Point(256, 67);
            this.txtAmount2.Name = "txtAmount2";
            this.txtAmount2.Size = new System.Drawing.Size(100, 20);
            this.txtAmount2.TabIndex = 8;
            this.txtAmount2.Text = "0";
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(256, 38);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(100, 20);
            this.txtPrice2.TabIndex = 7;
            this.txtPrice2.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Spawner 3";
            // 
            // txtSell3
            // 
            this.txtSell3.Location = new System.Drawing.Point(367, 93);
            this.txtSell3.Name = "txtSell3";
            this.txtSell3.Size = new System.Drawing.Size(100, 20);
            this.txtSell3.TabIndex = 13;
            this.txtSell3.Text = "0";
            // 
            // txtAmount3
            // 
            this.txtAmount3.Location = new System.Drawing.Point(367, 67);
            this.txtAmount3.Name = "txtAmount3";
            this.txtAmount3.Size = new System.Drawing.Size(100, 20);
            this.txtAmount3.TabIndex = 12;
            this.txtAmount3.Text = "0";
            // 
            // txtPrice3
            // 
            this.txtPrice3.Location = new System.Drawing.Point(367, 38);
            this.txtPrice3.Name = "txtPrice3";
            this.txtPrice3.Size = new System.Drawing.Size(100, 20);
            this.txtPrice3.TabIndex = 11;
            this.txtPrice3.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Spawns Per Spawner";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Money per 1000 spawns";
            // 
            // lblSps1
            // 
            this.lblSps1.AutoSize = true;
            this.lblSps1.Location = new System.Drawing.Point(145, 137);
            this.lblSps1.Name = "lblSps1";
            this.lblSps1.Size = new System.Drawing.Size(13, 13);
            this.lblSps1.TabIndex = 17;
            this.lblSps1.Text = "0";
            // 
            // lblMps1
            // 
            this.lblMps1.AutoSize = true;
            this.lblMps1.Location = new System.Drawing.Point(145, 162);
            this.lblMps1.Name = "lblMps1";
            this.lblMps1.Size = new System.Drawing.Size(13, 13);
            this.lblMps1.TabIndex = 18;
            this.lblMps1.Text = "0";
            // 
            // lblSps2
            // 
            this.lblSps2.AutoSize = true;
            this.lblSps2.Location = new System.Drawing.Point(256, 137);
            this.lblSps2.Name = "lblSps2";
            this.lblSps2.Size = new System.Drawing.Size(13, 13);
            this.lblSps2.TabIndex = 19;
            this.lblSps2.Text = "0";
            // 
            // lblMps2
            // 
            this.lblMps2.AutoSize = true;
            this.lblMps2.Location = new System.Drawing.Point(256, 162);
            this.lblMps2.Name = "lblMps2";
            this.lblMps2.Size = new System.Drawing.Size(13, 13);
            this.lblMps2.TabIndex = 20;
            this.lblMps2.Text = "0";
            // 
            // lblSps3
            // 
            this.lblSps3.AutoSize = true;
            this.lblSps3.Location = new System.Drawing.Point(364, 138);
            this.lblSps3.Name = "lblSps3";
            this.lblSps3.Size = new System.Drawing.Size(13, 13);
            this.lblSps3.TabIndex = 21;
            this.lblSps3.Text = "0";
            // 
            // lblMps3
            // 
            this.lblMps3.AutoSize = true;
            this.lblMps3.Location = new System.Drawing.Point(364, 162);
            this.lblMps3.Name = "lblMps3";
            this.lblMps3.Size = new System.Drawing.Size(13, 13);
            this.lblMps3.TabIndex = 22;
            this.lblMps3.Text = "0";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(486, 12);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 163);
            this.Calculate.TabIndex = 23;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 187);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.lblMps3);
            this.Controls.Add(this.lblSps3);
            this.Controls.Add(this.lblMps2);
            this.Controls.Add(this.lblSps2);
            this.Controls.Add(this.lblMps1);
            this.Controls.Add(this.lblSps1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSell3);
            this.Controls.Add(this.txtAmount3);
            this.Controls.Add(this.txtPrice3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSell2);
            this.Controls.Add(this.txtAmount2);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSell1);
            this.Controls.Add(this.txtAmount1);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spawner Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox txtAmount1;
        private System.Windows.Forms.TextBox txtSell1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSell2;
        private System.Windows.Forms.TextBox txtAmount2;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSell3;
        private System.Windows.Forms.TextBox txtAmount3;
        private System.Windows.Forms.TextBox txtPrice3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSps1;
        private System.Windows.Forms.Label lblMps1;
        private System.Windows.Forms.Label lblSps2;
        private System.Windows.Forms.Label lblMps2;
        private System.Windows.Forms.Label lblSps3;
        private System.Windows.Forms.Label lblMps3;
        private System.Windows.Forms.Button Calculate;
    }
}

