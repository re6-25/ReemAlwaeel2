namespace project2
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
            purple = new Button();
            BLACK = new Button();
            Blue = new Button();
            device1 = new Label();
            device2 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // purple
            // 
            purple.BackColor = Color.FromArgb(192, 192, 255);
            purple.Location = new Point(16, 160);
            purple.Name = "purple";
            purple.Size = new Size(94, 29);
            purple.TabIndex = 0;
            purple.Text = "purple";
            purple.UseVisualStyleBackColor = false;
            purple.Click += traingforsender;
            // 
            // BLACK
            // 
            BLACK.BackColor = Color.FromArgb(192, 192, 255);
            BLACK.Location = new Point(116, 160);
            BLACK.Name = "BLACK";
            BLACK.Size = new Size(94, 29);
            BLACK.TabIndex = 1;
            BLACK.Text = "BLACK";
            BLACK.UseVisualStyleBackColor = false;
            BLACK.Click += traingforsender;
            // 
            // Blue
            // 
            Blue.BackColor = Color.FromArgb(192, 192, 255);
            Blue.Location = new Point(228, 160);
            Blue.Name = "Blue";
            Blue.Size = new Size(94, 29);
            Blue.TabIndex = 2;
            Blue.Text = "Blue";
            Blue.UseVisualStyleBackColor = false;
            Blue.Click += traingforsender;
            // 
            // device1
            // 
            device1.AutoSize = true;
            device1.BackColor = Color.FromArgb(192, 192, 255);
            device1.Location = new Point(53, 102);
            device1.Name = "device1";
            device1.Size = new Size(60, 20);
            device1.TabIndex = 3;
            device1.Text = "device1";
            // 
            // device2
            // 
            device2.AutoSize = true;
            device2.BackColor = Color.FromArgb(192, 192, 255);
            device2.Location = new Point(171, 102);
            device2.Name = "device2";
            device2.Size = new Size(60, 20);
            device2.TabIndex = 4;
            device2.Text = "device2";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Info;
            button4.Location = new Point(93, 243);
            button4.Name = "button4";
            button4.Size = new Size(138, 39);
            button4.TabIndex = 5;
            button4.Text = "color";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.color;
            ClientSize = new Size(363, 450);
            Controls.Add(button4);
            Controls.Add(device2);
            Controls.Add(device1);
            Controls.Add(Blue);
            Controls.Add(BLACK);
            Controls.Add(purple);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button purple;
        private Button BLACK;
        private Button Blue;
        private Label device1;
        private Label device2;
        private Button button4;
    }
}