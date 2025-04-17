namespace Gra___programowanie_wizualne_5
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            button1 = new Button();
            comboBox5 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 92);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 0;
            label1.Text = "Plansza";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(483, 92);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 1;
            label2.Text = "Dydlefy";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 237);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 2;
            label3.Text = "Krokodyle";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 158);
            label4.Name = "label4";
            label4.Size = new Size(28, 32);
            label4.TabIndex = 3;
            label4.Text = "X";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 287);
            label5.Name = "label5";
            label5.Size = new Size(27, 32);
            label5.TabIndex = 4;
            label5.Text = "Y";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 389);
            label6.Name = "label6";
            label6.Size = new Size(62, 32);
            label6.TabIndex = 5;
            label6.Text = "Czas";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboBox1.Location = new Point(467, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 40);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "0", "1" });
            comboBox2.Location = new Point(467, 287);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 40);
            comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox3.Location = new Point(111, 158);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(242, 40);
            comboBox3.TabIndex = 8;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox4.Location = new Point(111, 287);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(242, 40);
            comboBox4.TabIndex = 9;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(111, 457);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(242, 31);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(483, 389);
            label7.Name = "label7";
            label7.Size = new Size(77, 32);
            label7.TabIndex = 11;
            label7.Text = "Szopy";
            // 
            // button1
            // 
            button1.Location = new Point(292, 575);
            button1.Name = "button1";
            button1.Size = new Size(225, 66);
            button1.TabIndex = 12;
            button1.Text = "Zatwierdź";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8" });
            comboBox5.Location = new Point(467, 448);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 40);
            comboBox5.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 681);
            Controls.Add(comboBox5);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private RichTextBox richTextBox1;
        private Label label7;
        private Button button1;
        private ComboBox comboBox5;
    }
}