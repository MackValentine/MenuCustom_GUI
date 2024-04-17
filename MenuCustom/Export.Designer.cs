namespace MenuCustom
{
    partial class Export
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
            textContents = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textContents
            // 
            textContents.Location = new Point(12, 12);
            textContents.Name = "textContents";
            textContents.Size = new Size(441, 164);
            textContents.TabIndex = 0;
            textContents.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(194, 182);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Export
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 213);
            Controls.Add(button1);
            Controls.Add(textContents);
            Name = "Export";
            ShowInTaskbar = false;
            Text = "Export";
            FormClosing += Form2_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox textContents;
        private Button button1;
    }
}