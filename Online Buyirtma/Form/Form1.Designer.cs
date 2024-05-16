namespace Online_Buyirtma
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
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(397, 164);
            button1.Name = "button1";
            button1.Size = new Size(287, 59);
            button1.TabIndex = 0;
            button1.Text = "Kirish";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.Location = new Point(466, 241);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(147, 28);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Royxattan otish";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1172, 540);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private LinkLabel linkLabel1;
    }
}
