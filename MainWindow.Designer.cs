namespace activator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            label2 = new Label();
            button1 = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            windowsBtn = new Button();
            officeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Location = new Point(21, 197);
            label2.Name = "label2";
            label2.Size = new Size(348, 17);
            label2.TabIndex = 6;
            label2.Text = "(C) Copyright 2024 Ben Daws. Open-source via GNU GPL 3.0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Red;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(327, -3);
            button1.Name = "button1";
            button1.Size = new Size(57, 23);
            button1.TabIndex = 46;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 5);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 45;
            label5.Text = "MSActivate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(244, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // windowsBtn
            // 
            windowsBtn.Location = new Point(21, 161);
            windowsBtn.Name = "windowsBtn";
            windowsBtn.Size = new Size(115, 23);
            windowsBtn.TabIndex = 49;
            windowsBtn.Text = "Windows";
            windowsBtn.UseVisualStyleBackColor = true;
            windowsBtn.Click += windowsBtn_Click;
            // 
            // officeBtn
            // 
            officeBtn.Location = new Point(244, 161);
            officeBtn.Name = "officeBtn";
            officeBtn.Size = new Size(115, 23);
            officeBtn.TabIndex = 50;
            officeBtn.Text = "Office";
            officeBtn.UseVisualStyleBackColor = true;
            officeBtn.Click += officeBtn_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 223);
            Controls.Add(officeBtn);
            Controls.Add(windowsBtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            ShowIcon = false;
            Text = "MSActivator";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button1;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button windowsBtn;
        private Button officeBtn;
    }
}
