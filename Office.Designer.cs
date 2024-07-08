namespace activator
{
    partial class Office
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Office));
            label3 = new Label();
            cancel = new Button();
            startActivation = new Button();
            label1 = new Label();
            homeStu2021Btn = new Button();
            kms_KEY_VALUE = new TextBox();
            customKMS_value = new TextBox();
            customKMS = new CheckBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            OfficeInstall = new FolderBrowserDialog();
            label4 = new Label();
            installDir = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 39;
            label3.Text = "Product Key:";
            // 
            // cancel
            // 
            cancel.Location = new Point(318, 266);
            cancel.Name = "cancel";
            cancel.Size = new Size(90, 23);
            cancel.TabIndex = 38;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // startActivation
            // 
            startActivation.Location = new Point(419, 266);
            startActivation.Name = "startActivation";
            startActivation.Size = new Size(153, 23);
            startActivation.TabIndex = 37;
            startActivation.Text = "Begin Activation";
            startActivation.UseVisualStyleBackColor = true;
            startActivation.Click += startActivation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 200);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 29;
            label1.Text = "Autofill product key box for:";
            // 
            // homeStu2021Btn
            // 
            homeStu2021Btn.Location = new Point(13, 218);
            homeStu2021Btn.Name = "homeStu2021Btn";
            homeStu2021Btn.Size = new Size(555, 23);
            homeStu2021Btn.TabIndex = 28;
            homeStu2021Btn.Text = "Office 2021 (All Versions)";
            homeStu2021Btn.UseVisualStyleBackColor = true;
            homeStu2021Btn.Click += homeStu2021Btn_Click;
            // 
            // kms_KEY_VALUE
            // 
            kms_KEY_VALUE.Location = new Point(92, 151);
            kms_KEY_VALUE.Name = "kms_KEY_VALUE";
            kms_KEY_VALUE.Size = new Size(476, 23);
            kms_KEY_VALUE.TabIndex = 27;
            // 
            // customKMS_value
            // 
            customKMS_value.Enabled = false;
            customKMS_value.Location = new Point(179, 122);
            customKMS_value.Name = "customKMS_value";
            customKMS_value.Size = new Size(389, 23);
            customKMS_value.TabIndex = 26;
            customKMS_value.Text = "kms8.msguides.com";
            // 
            // customKMS
            // 
            customKMS.AutoSize = true;
            customKMS.Location = new Point(12, 124);
            customKMS.Name = "customKMS";
            customKMS.Size = new Size(161, 19);
            customKMS.TabIndex = 25;
            customKMS.Text = "Use a custom KMS server:";
            customKMS.UseVisualStyleBackColor = true;
            customKMS.CheckedChanged += customKMS_CheckedChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(13, 297);
            label2.Name = "label2";
            label2.Size = new Size(559, 17);
            label2.TabIndex = 24;
            label2.Text = "(C) Copyright 2024 Ben Daws. Open-source via GNU GPL 3.0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(209, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 15);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 5);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 42;
            label5.Text = "MSActivate - Office";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Red;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(537, 1);
            button1.Name = "button1";
            button1.Size = new Size(45, 23);
            button1.TabIndex = 43;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.Location = new Point(12, 27);
            label6.Name = "label6";
            label6.Size = new Size(560, 49);
            label6.TabIndex = 45;
            label6.Text = resources.GetString("label6.Text");
            // 
            // OfficeInstall
            // 
            OfficeInstall.Description = "Select the location of your Office installation. The folder is named \"Office16\"";
            OfficeInstall.InitialDirectory = "C:\\Program Files\\";
            OfficeInstall.OkRequiresInteraction = true;
            OfficeInstall.ShowHiddenFiles = true;
            OfficeInstall.ShowNewFolderButton = false;
            OfficeInstall.ShowPinnedPlaces = false;
            OfficeInstall.UseDescriptionForTitle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 82);
            label4.Name = "label4";
            label4.Size = new Size(151, 15);
            label4.TabIndex = 47;
            label4.Text = "Office Installation Directory";
            // 
            // installDir
            // 
            installDir.Location = new Point(169, 79);
            installDir.Name = "installDir";
            installDir.Size = new Size(320, 23);
            installDir.TabIndex = 46;
            // 
            // button2
            // 
            button2.Location = new Point(495, 79);
            button2.Name = "button2";
            button2.Size = new Size(71, 23);
            button2.TabIndex = 48;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Office
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 323);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(installDir);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(cancel);
            Controls.Add(startActivation);
            Controls.Add(label1);
            Controls.Add(homeStu2021Btn);
            Controls.Add(kms_KEY_VALUE);
            Controls.Add(customKMS_value);
            Controls.Add(customKMS);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Office";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "MSActivate (office)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button cancel;
        private Button startActivation;
        private Button enterprise10Btn;
        private Button pro10Btn;
        private Button home10Btn;
        private Button EnterpriseBtn;
        private Button ProBtn;
        private Label label1;
        private Button homeStu2021Btn;
        private TextBox kms_KEY_VALUE;
        private TextBox customKMS_value;
        private CheckBox customKMS;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button1;
        private Label label6;
        private FolderBrowserDialog OfficeInstall;
        private Label label4;
        private TextBox installDir;
        private Button button2;
    }
}