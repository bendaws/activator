namespace activator
{
    partial class Advanced
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
            label2 = new Label();
            customKMS = new CheckBox();
            customKMS_value = new TextBox();
            kms_KEY_VALUE = new TextBox();
            label1 = new Label();
            ProBtn = new Button();
            homeBtn = new Button();
            EnterpriseBtn = new Button();
            enterprise10Btn = new Button();
            pro10Btn = new Button();
            home10Btn = new Button();
            fullActivation = new RadioButton();
            limitedActivation = new RadioButton();
            startActivation = new Button();
            cancel = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(12, 400);
            label2.Name = "label2";
            label2.Size = new Size(631, 17);
            label2.TabIndex = 7;
            label2.Text = "(C) Copyright 2024 Ben Daws. Open-source via GNU GPL 3.0";
            // 
            // customKMS
            // 
            customKMS.AutoSize = true;
            customKMS.Location = new Point(12, 12);
            customKMS.Name = "customKMS";
            customKMS.Size = new Size(161, 19);
            customKMS.TabIndex = 8;
            customKMS.Text = "Use a custom KMS server:";
            customKMS.UseVisualStyleBackColor = true;
            customKMS.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // customKMS_value
            // 
            customKMS_value.Enabled = false;
            customKMS_value.Location = new Point(179, 10);
            customKMS_value.Name = "customKMS_value";
            customKMS_value.Size = new Size(389, 23);
            customKMS_value.TabIndex = 9;
            customKMS_value.Text = "kms8.msguides.com";
            // 
            // kms_KEY_VALUE
            // 
            kms_KEY_VALUE.Location = new Point(92, 39);
            kms_KEY_VALUE.Name = "kms_KEY_VALUE";
            kms_KEY_VALUE.Size = new Size(476, 23);
            kms_KEY_VALUE.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 13;
            label1.Text = "Autofill product key box for:";
            // 
            // ProBtn
            // 
            ProBtn.Location = new Point(26, 131);
            ProBtn.Name = "ProBtn";
            ProBtn.Size = new Size(142, 23);
            ProBtn.TabIndex = 14;
            ProBtn.Text = "Windows 11 Pro";
            ProBtn.UseVisualStyleBackColor = true;
            ProBtn.Click += ProBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.Location = new Point(26, 102);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(142, 23);
            homeBtn.TabIndex = 12;
            homeBtn.Text = "Windows 11 Home";
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // EnterpriseBtn
            // 
            EnterpriseBtn.Location = new Point(26, 160);
            EnterpriseBtn.Name = "EnterpriseBtn";
            EnterpriseBtn.Size = new Size(142, 23);
            EnterpriseBtn.TabIndex = 15;
            EnterpriseBtn.Text = "Windows 11 Enterprise";
            EnterpriseBtn.UseVisualStyleBackColor = true;
            EnterpriseBtn.Click += EnterpriseBtn_Click;
            // 
            // enterprise10Btn
            // 
            enterprise10Btn.Location = new Point(193, 160);
            enterprise10Btn.Name = "enterprise10Btn";
            enterprise10Btn.Size = new Size(142, 23);
            enterprise10Btn.TabIndex = 18;
            enterprise10Btn.Text = "Windows 10 Enterprise";
            enterprise10Btn.UseVisualStyleBackColor = true;
            enterprise10Btn.Click += EnterpriseBtn_Click;
            // 
            // pro10Btn
            // 
            pro10Btn.Location = new Point(193, 131);
            pro10Btn.Name = "pro10Btn";
            pro10Btn.Size = new Size(142, 23);
            pro10Btn.TabIndex = 17;
            pro10Btn.Text = "Windows 10 Pro";
            pro10Btn.UseVisualStyleBackColor = true;
            pro10Btn.Click += ProBtn_Click;
            // 
            // home10Btn
            // 
            home10Btn.Location = new Point(193, 102);
            home10Btn.Name = "home10Btn";
            home10Btn.Size = new Size(142, 23);
            home10Btn.TabIndex = 16;
            home10Btn.Text = "Windows 10 Home";
            home10Btn.UseVisualStyleBackColor = true;
            home10Btn.Click += homeBtn_Click;
            // 
            // fullActivation
            // 
            fullActivation.AutoSize = true;
            fullActivation.Location = new Point(12, 208);
            fullActivation.Name = "fullActivation";
            fullActivation.Size = new Size(328, 19);
            fullActivation.TabIndex = 19;
            fullActivation.TabStop = true;
            fullActivation.Text = "Install the product key, KMS server, and activate Windows";
            fullActivation.UseVisualStyleBackColor = true;
            fullActivation.CheckedChanged += fullActivation_CheckedChanged;
            // 
            // limitedActivation
            // 
            limitedActivation.AutoSize = true;
            limitedActivation.Location = new Point(12, 233);
            limitedActivation.Name = "limitedActivation";
            limitedActivation.Size = new Size(357, 19);
            limitedActivation.TabIndex = 20;
            limitedActivation.TabStop = true;
            limitedActivation.Text = "Install the product key, KMS server, but don't activate Windows";
            limitedActivation.UseVisualStyleBackColor = true;
            // 
            // startActivation
            // 
            startActivation.Location = new Point(415, 365);
            startActivation.Name = "startActivation";
            startActivation.Size = new Size(153, 23);
            startActivation.TabIndex = 21;
            startActivation.Text = "Begin Activation";
            startActivation.UseVisualStyleBackColor = true;
            startActivation.Click += startActivation_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(314, 365);
            cancel.Name = "cancel";
            cancel.Size = new Size(90, 23);
            cancel.TabIndex = 22;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 42);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 23;
            label3.Text = "Product Key:";
            // 
            // Advanced
            // 
            AcceptButton = startActivation;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = startActivation;
            ClientSize = new Size(580, 426);
            Controls.Add(label3);
            Controls.Add(cancel);
            Controls.Add(startActivation);
            Controls.Add(limitedActivation);
            Controls.Add(fullActivation);
            Controls.Add(enterprise10Btn);
            Controls.Add(pro10Btn);
            Controls.Add(home10Btn);
            Controls.Add(EnterpriseBtn);
            Controls.Add(ProBtn);
            Controls.Add(label1);
            Controls.Add(homeBtn);
            Controls.Add(kms_KEY_VALUE);
            Controls.Add(customKMS_value);
            Controls.Add(customKMS);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Advanced";
            Text = "MSActivator (advanced)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private CheckBox customKMS;
        private TextBox customKMS_value;
        private TextBox kms_KEY_VALUE;
        private Label label1;
        private Button ProBtn;
        private Button homeBtn;
        private Button EnterpriseBtn;
        private Button enterprise10Btn;
        private Button pro10Btn;
        private Button home10Btn;
        private RadioButton fullActivation;
        private RadioButton limitedActivation;
        private Button startActivation;
        private Button cancel;
        private Label label3;
    }
}