namespace Online_Buyirtma
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
            label1 = new Label();
            tx2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            tx1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(342, 230);
            label1.Name = "label1";
            label1.Size = new Size(174, 41);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // tx2
            // 
            tx2.BackColor = SystemColors.Info;
            tx2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            tx2.Location = new Point(579, 233);
            tx2.Name = "tx2";
            tx2.Size = new Size(294, 43);
            tx2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(455, 305);
            button1.Name = "button1";
            button1.Size = new Size(195, 54);
            button1.TabIndex = 4;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(44, 41);
            button2.TabIndex = 5;
            button2.Text = "<-\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(94, 166);
            label2.Name = "label2";
            label2.Size = new Size(433, 41);
            label2.TabIndex = 6;
            label2.Text = "Royxattan otgan raqam:+998";
            // 
            // tx1
            // 
            tx1.BackColor = SystemColors.Info;
            tx1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            tx1.Location = new Point(579, 169);
            tx1.Name = "tx1";
            tx1.Size = new Size(294, 43);
            tx1.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1158, 491);
            Controls.Add(tx1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tx2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tx2;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox tx1;
    }
}