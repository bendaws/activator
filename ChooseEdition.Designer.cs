namespace activator
{
    partial class ChooseEdition
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
            home11 = new RadioButton();
            pro11 = new RadioButton();
            enterprise11 = new RadioButton();
            home10 = new RadioButton();
            pro10 = new RadioButton();
            enterprise10 = new RadioButton();
            enterButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 15);
            label1.TabIndex = 0;
            label1.Text = "Please choose what edition of Windows you are using.";
            // 
            // home11
            // 
            home11.AutoSize = true;
            home11.Location = new Point(21, 35);
            home11.Name = "home11";
            home11.Size = new Size(125, 19);
            home11.TabIndex = 1;
            home11.TabStop = true;
            home11.Text = "Windows 11 Home";
            home11.UseVisualStyleBackColor = true;
            // 
            // pro11
            // 
            pro11.AutoSize = true;
            pro11.Location = new Point(21, 60);
            pro11.Name = "pro11";
            pro11.Size = new Size(110, 19);
            pro11.TabIndex = 2;
            pro11.TabStop = true;
            pro11.Text = "Windows 11 Pro";
            pro11.UseVisualStyleBackColor = true;
            // 
            // enterprise11
            // 
            enterprise11.AutoSize = true;
            enterprise11.Location = new Point(21, 85);
            enterprise11.Name = "enterprise11";
            enterprise11.Size = new Size(144, 19);
            enterprise11.TabIndex = 3;
            enterprise11.TabStop = true;
            enterprise11.Text = "Windows 11 Enterprise";
            enterprise11.UseVisualStyleBackColor = true;
            // 
            // home10
            // 
            home10.AutoSize = true;
            home10.Location = new Point(21, 125);
            home10.Name = "home10";
            home10.Size = new Size(125, 19);
            home10.TabIndex = 4;
            home10.TabStop = true;
            home10.Text = "Windows 10 Home";
            home10.UseVisualStyleBackColor = true;
            // 
            // pro10
            // 
            pro10.AutoSize = true;
            pro10.Location = new Point(21, 150);
            pro10.Name = "pro10";
            pro10.Size = new Size(110, 19);
            pro10.TabIndex = 5;
            pro10.TabStop = true;
            pro10.Text = "Windows 10 Pro";
            pro10.UseVisualStyleBackColor = true;
            // 
            // enterprise10
            // 
            enterprise10.AutoSize = true;
            enterprise10.Location = new Point(21, 175);
            enterprise10.Name = "enterprise10";
            enterprise10.Size = new Size(144, 19);
            enterprise10.TabIndex = 6;
            enterprise10.TabStop = true;
            enterprise10.Text = "Windows 10 Enterprise";
            enterprise10.UseVisualStyleBackColor = true;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(311, 178);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(91, 23);
            enterButton.TabIndex = 7;
            enterButton.Text = "Continue";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // ChooseEdition
            // 
            AcceptButton = enterButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 213);
            ControlBox = false;
            Controls.Add(enterButton);
            Controls.Add(enterprise10);
            Controls.Add(pro10);
            Controls.Add(home10);
            Controls.Add(enterprise11);
            Controls.Add(pro11);
            Controls.Add(home11);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChooseEdition";
            Text = "activator.exe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton home11;
        private RadioButton pro11;
        private RadioButton enterprise11;
        private RadioButton home10;
        private RadioButton pro10;
        private RadioButton enterprise10;
        private Button enterButton;
    }
}