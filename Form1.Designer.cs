
namespace project2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(192, 24);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "العدد الأول";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Location = new Point(192, 78);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 1;
            label2.Text = "العملية1";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.Location = new Point(192, 132);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 2;
            label3.Text = "العدد الثاني";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.Location = new Point(192, 179);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 3;
            label4.Text = "العملبة 2";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.Location = new Point(192, 225);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 4;
            label5.Text = "العدد الثالث";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.Location = new Point(192, 270);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 5;
            label6.Text = "الناتج";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.UseWaitCursor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(27, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 27);
            textBox1.TabIndex = 6;
            textBox1.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(27, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 27);
            textBox2.TabIndex = 7;
            textBox2.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(27, 127);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(133, 27);
            textBox3.TabIndex = 8;
            textBox3.UseWaitCursor = true;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(27, 177);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(133, 27);
            textBox4.TabIndex = 9;
            textBox4.UseWaitCursor = true;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(27, 220);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(133, 27);
            textBox5.TabIndex = 10;
            textBox5.UseWaitCursor = true;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Location = new Point(27, 268);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(133, 27);
            textBox6.TabIndex = 11;
            textBox6.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(27, 313);
            button1.Name = "button1";
            button1.Size = new Size(133, 43);
            button1.TabIndex = 12;
            button1.Text = "حساب";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(192, 313);
            button2.Name = "button2";
            button2.Size = new Size(115, 43);
            button2.TabIndex = 13;
            button2.Text = "إغلاق";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.فضاء;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(348, 372);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Purple;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            TopMost = true;
            TransparencyKey = Color.FromArgb(64, 0, 64);
            Load += Form1_Load;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
    }
}
