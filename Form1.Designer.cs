namespace Shopcards
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chb_Coffee = new CheckBox();
            chb_Greentea = new CheckBox();
            tb_Coffee_Price = new TextBox();
            tb_Coffee_Quantity = new TextBox();
            tb_Greentea_Price = new TextBox();
            tb_Greentea_Quantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tb_total = new TextBox();
            tb_cash = new TextBox();
            tb_change = new TextBox();
            tb_1000 = new TextBox();
            tb_500 = new TextBox();
            tb_100 = new TextBox();
            tb_50 = new TextBox();
            tb_20 = new TextBox();
            tb_10 = new TextBox();
            tb_5 = new TextBox();
            tb_1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // chb_Coffee
            // 
            chb_Coffee.AutoSize = true;
            chb_Coffee.Location = new Point(59, 23);
            chb_Coffee.Name = "chb_Coffee";
            chb_Coffee.Size = new Size(75, 24);
            chb_Coffee.TabIndex = 19;
            chb_Coffee.Text = "Coffee";
            chb_Coffee.UseVisualStyleBackColor = true;
            // 
            // chb_Greentea
            // 
            chb_Greentea.AutoSize = true;
            chb_Greentea.Location = new Point(59, 88);
            chb_Greentea.Name = "chb_Greentea";
            chb_Greentea.Size = new Size(98, 24);
            chb_Greentea.TabIndex = 20;
            chb_Greentea.Text = "Green Tea";
            chb_Greentea.UseVisualStyleBackColor = true;
            chb_Greentea.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // tb_Coffee_Price
            // 
            tb_Coffee_Price.Location = new Point(244, 20);
            tb_Coffee_Price.Name = "tb_Coffee_Price";
            tb_Coffee_Price.Size = new Size(146, 27);
            tb_Coffee_Price.TabIndex = 21;
            tb_Coffee_Price.TextChanged += textBox1_TextChanged;
            // 
            // tb_Coffee_Quantity
            // 
            tb_Coffee_Quantity.Location = new Point(472, 23);
            tb_Coffee_Quantity.Name = "tb_Coffee_Quantity";
            tb_Coffee_Quantity.Size = new Size(146, 27);
            tb_Coffee_Quantity.TabIndex = 22;
            // 
            // tb_Greentea_Price
            // 
            tb_Greentea_Price.Location = new Point(244, 85);
            tb_Greentea_Price.Name = "tb_Greentea_Price";
            tb_Greentea_Price.Size = new Size(146, 27);
            tb_Greentea_Price.TabIndex = 23;
            tb_Greentea_Price.TextChanged += textBox3_TextChanged;
            // 
            // tb_Greentea_Quantity
            // 
            tb_Greentea_Quantity.Location = new Point(472, 85);
            tb_Greentea_Quantity.Name = "tb_Greentea_Quantity";
            tb_Greentea_Quantity.Size = new Size(146, 27);
            tb_Greentea_Quantity.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(942, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 25;
            label1.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(942, 74);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 26;
            label2.Text = "Cash";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(942, 124);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 27;
            label3.Text = "Change";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(942, 179);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 28;
            label4.Text = "1000";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(942, 232);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 29;
            label5.Text = "500";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(942, 289);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 30;
            label6.Text = "100";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(942, 351);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 31;
            label7.Text = "50";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(942, 415);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 32;
            label8.Text = "20";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(942, 471);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 33;
            label9.Text = "10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(942, 524);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 34;
            label10.Text = "5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(942, 581);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 35;
            label11.Text = "1";
            // 
            // tb_total
            // 
            tb_total.Location = new Point(1019, 19);
            tb_total.Name = "tb_total";
            tb_total.Size = new Size(146, 27);
            tb_total.TabIndex = 36;
            tb_total.TextChanged += textBox5_TextChanged;
            // 
            // tb_cash
            // 
            tb_cash.Location = new Point(1019, 67);
            tb_cash.Name = "tb_cash";
            tb_cash.Size = new Size(146, 27);
            tb_cash.TabIndex = 37;
            // 
            // tb_change
            // 
            tb_change.Location = new Point(1019, 117);
            tb_change.Name = "tb_change";
            tb_change.Size = new Size(146, 27);
            tb_change.TabIndex = 38;
            // 
            // tb_1000
            // 
            tb_1000.Location = new Point(1019, 172);
            tb_1000.Name = "tb_1000";
            tb_1000.Size = new Size(146, 27);
            tb_1000.TabIndex = 39;
            // 
            // tb_500
            // 
            tb_500.Location = new Point(1019, 225);
            tb_500.Name = "tb_500";
            tb_500.Size = new Size(146, 27);
            tb_500.TabIndex = 40;
            // 
            // tb_100
            // 
            tb_100.Location = new Point(1019, 282);
            tb_100.Name = "tb_100";
            tb_100.Size = new Size(146, 27);
            tb_100.TabIndex = 41;
            // 
            // tb_50
            // 
            tb_50.Location = new Point(1019, 344);
            tb_50.Name = "tb_50";
            tb_50.Size = new Size(146, 27);
            tb_50.TabIndex = 42;
            // 
            // tb_20
            // 
            tb_20.Location = new Point(1019, 408);
            tb_20.Name = "tb_20";
            tb_20.Size = new Size(146, 27);
            tb_20.TabIndex = 43;
            // 
            // tb_10
            // 
            tb_10.Location = new Point(1019, 464);
            tb_10.Name = "tb_10";
            tb_10.Size = new Size(146, 27);
            tb_10.TabIndex = 44;
            // 
            // tb_5
            // 
            tb_5.Location = new Point(1019, 517);
            tb_5.Name = "tb_5";
            tb_5.Size = new Size(146, 27);
            tb_5.TabIndex = 45;
            // 
            // tb_1
            // 
            tb_1.Location = new Point(1019, 574);
            tb_1.Name = "tb_1";
            tb_1.Size = new Size(146, 27);
            tb_1.TabIndex = 46;
            // 
            // button1
            // 
            button1.Location = new Point(671, 36);
            button1.Name = "button1";
            button1.Size = new Size(236, 593);
            button1.TabIndex = 47;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 674);
            Controls.Add(button1);
            Controls.Add(tb_1);
            Controls.Add(tb_5);
            Controls.Add(tb_10);
            Controls.Add(tb_20);
            Controls.Add(tb_50);
            Controls.Add(tb_100);
            Controls.Add(tb_500);
            Controls.Add(tb_1000);
            Controls.Add(tb_change);
            Controls.Add(tb_cash);
            Controls.Add(tb_total);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_Greentea_Quantity);
            Controls.Add(tb_Greentea_Price);
            Controls.Add(tb_Coffee_Quantity);
            Controls.Add(tb_Coffee_Price);
            Controls.Add(chb_Greentea);
            Controls.Add(chb_Coffee);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox chb_Coffee;
        private CheckBox chb_Greentea;
        private TextBox tb_Coffee_Price;
        private TextBox tb_Coffee_Quantity;
        private TextBox tb_Greentea_Price;
        private TextBox tb_Greentea_Quantity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tb_total;
        private TextBox tb_cash;
        private TextBox tb_change;
        private TextBox tb_1000;
        private TextBox tb_500;
        private TextBox tb_100;
        private TextBox tb_50;
        private TextBox tb_20;
        private TextBox tb_10;
        private TextBox tb_5;
        private TextBox tb_1;
        private Button button1;
    }
}
