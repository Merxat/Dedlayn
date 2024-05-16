namespace Online_Buyirtma
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
            label1 = new Label();
            txNumber = new TextBox();
            label2 = new Label();
            Txsms = new TextBox();
            label3 = new Label();
            txUserName = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(131, 61);
            label1.Name = "label1";
            label1.Size = new Size(451, 41);
            label1.TabIndex = 0;
            label1.Text = "Telefon raqam kiriting:    +998\r\n";
            // 
            // txNumber
            // 
            txNumber.BackColor = SystemColors.Info;
            txNumber.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            txNumber.Location = new Point(588, 61);
            txNumber.Name = "txNumber";
            txNumber.Size = new Size(227, 44);
            txNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(332, 147);
            label2.Name = "label2";
            label2.Size = new Size(215, 41);
            label2.TabIndex = 3;
            label2.Text = "Kodni kiriting";
            // 
            // Txsms
            // 
            Txsms.BackColor = SystemColors.Info;
            Txsms.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Txsms.Location = new Point(588, 147);
            Txsms.Name = "Txsms";
            Txsms.Size = new Size(227, 44);
            Txsms.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(131, 229);
            label3.Name = "label3";
            label3.Size = new Size(174, 41);
            label3.TabIndex = 5;
            label3.Text = "User Name";
            // 
            // txUserName
            // 
            txUserName.BackColor = SystemColors.Info;
            txUserName.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            txUserName.Location = new Point(332, 226);
            txUserName.Name = "txUserName";
            txUserName.Size = new Size(250, 44);
            txUserName.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button2.Location = new Point(402, 331);
            button2.Name = "button2";
            button2.Size = new Size(257, 59);
            button2.TabIndex = 7;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(866, 63);
            button1.Name = "button1";
            button1.Size = new Size(152, 42);
            button1.TabIndex = 8;
            button1.Text = "Tasdiqlash";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(1, 1);
            button3.Name = "button3";
            button3.Size = new Size(44, 41);
            button3.TabIndex = 9;
            button3.Text = "<-\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1162, 463);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(txUserName);
            Controls.Add(label3);
            Controls.Add(Txsms);
            Controls.Add(label2);
            Controls.Add(txNumber);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txNumber;
        private Label label2;
        private TextBox Txsms;
        private Label label3;
        private TextBox txUserName;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}