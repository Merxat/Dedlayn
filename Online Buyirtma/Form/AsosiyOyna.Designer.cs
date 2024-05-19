namespace Online_Buyirtma
{
    partial class AsosiyOyna
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
            dataGridView1 = new DataGridView();
            Maxsulotn = new TextBox();
            label1 = new Label();
            MaxsulotS = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(552, 514);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Maxsulotn
            // 
            Maxsulotn.BackColor = SystemColors.Info;
            Maxsulotn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Maxsulotn.Location = new Point(581, 50);
            Maxsulotn.Name = "Maxsulotn";
            Maxsulotn.Size = new Size(335, 43);
            Maxsulotn.TabIndex = 2;
            Maxsulotn.TextChanged += Maxsulotn_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(581, 9);
            label1.Name = "label1";
            label1.Size = new Size(355, 38);
            label1.TabIndex = 3;
            label1.Text = "Maxsulot nomini kiriting:";
            // 
            // MaxsulotS
            // 
            MaxsulotS.AutoSize = true;
            MaxsulotS.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            MaxsulotS.Location = new Point(581, 124);
            MaxsulotS.Name = "MaxsulotS";
            MaxsulotS.Size = new Size(341, 38);
            MaxsulotS.TabIndex = 4;
            MaxsulotS.Text = "Maxsulot sonini kiriting:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(581, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(103, 43);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button2.Location = new Point(728, 183);
            button2.Name = "button2";
            button2.Size = new Size(208, 43);
            button2.TabIndex = 6;
            button2.Text = "Savatga qoshish";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AsosiyOyna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1094, 597);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(MaxsulotS);
            Controls.Add(label1);
            Controls.Add(Maxsulotn);
            Controls.Add(dataGridView1);
            Name = "AsosiyOyna";
            Text = "AsosiyOyna";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox Maxsulotn;
        private Label label1;
        private Label MaxsulotS;
        private TextBox textBox1;
        private Button button2;
    }
}