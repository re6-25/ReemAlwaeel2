namespace project2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            sumion = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numbers = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // sumion
            // 
            sumion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sumion.BackColor = Color.LightSeaGreen;
            sumion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            sumion.ForeColor = SystemColors.ButtonHighlight;
            sumion.Location = new Point(198, 134);
            sumion.Name = "sumion";
            sumion.Size = new Size(150, 50);
            sumion.TabIndex = 0;
            sumion.Text = "sum";
            sumion.UseVisualStyleBackColor = false;
            sumion.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.LightSeaGreen;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(198, 228);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 1;
            button2.Text = "fact";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.LightSeaGreen;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(198, 308);
            button3.Name = "button3";
            button3.Size = new Size(150, 50);
            button3.TabIndex = 2;
            button3.Text = "Root";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSeaGreen;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(44, 134);
            label1.Name = "label1";
            label1.Size = new Size(108, 50);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.LightSeaGreen;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(44, 228);
            label2.Name = "label2";
            label2.Size = new Size(108, 50);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSeaGreen;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(44, 308);
            label3.Name = "label3";
            label3.Size = new Size(108, 50);
            label3.TabIndex = 5;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numbers
            // 
            numbers.Anchor = AnchorStyles.None;
            numbers.BackColor = Color.Aquamarine;
            numbers.Font = new Font("Akhbar MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            numbers.ForeColor = SystemColors.ButtonShadow;
            numbers.Location = new Point(82, 70);
            numbers.Name = "numbers";
            numbers.Size = new Size(190, 43);
            numbers.TabIndex = 6;
            numbers.TextAlign = HorizontalAlignment.Center;
            numbers.TextChanged += numbers_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.LightSeaGreen;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(82, 23);
            label4.Name = "label4";
            label4.Size = new Size(190, 36);
            label4.TabIndex = 7;
            label4.Text = "enter the number here";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(449, 450);
            Controls.Add(label4);
            Controls.Add(numbers);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(sumion);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sumion;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox numbers;
        private Label label4;
    }
}