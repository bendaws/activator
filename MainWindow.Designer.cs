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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            advanced = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(12, 104);
            button1.Name = "button1";
            button1.Size = new Size(268, 23);
            button1.TabIndex = 2;
            button1.Text = "Start Activation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(545, 54);
            label1.TabIndex = 3;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.Location = new Point(12, 154);
            label2.Name = "label2";
            label2.Size = new Size(545, 17);
            label2.TabIndex = 6;
            label2.Text = "(C) Copyright 2024 Ben Daws. Open-source via GNU GPL 3.0";
            // 
            // advanced
            // 
            advanced.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            advanced.Location = new Point(286, 104);
            advanced.Name = "advanced";
            advanced.Size = new Size(271, 23);
            advanced.TabIndex = 7;
            advanced.Text = "Advanced..";
            advanced.UseVisualStyleBackColor = true;
            advanced.Click += advanced_Click;
            // 
            // MainWindow
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 183);
            Controls.Add(advanced);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            ShowIcon = false;
            Text = "MSActivator";
            Load += MainWindow_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label2;
        private Button advanced;
    }
}
