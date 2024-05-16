using Online_Buyirtma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Buyirtma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (tx1.Text.Length==9 && tx2.Text.Length>=0)
            {
                int sanoq = 0;
                string path = @"D:\Users\User 2022\Desktop\Dasturiy injinering ga kirish\Online Buyirtma\Online Buyirtma\txt.files\EmployeList.txt";
                string ReadPath = File.ReadAllText(path);
                if (ReadPath.Contains(tx1.Text.ToLower()) && sanoq==0) 
                {
                   AsosiyOyna asosiyOyna = new AsosiyOyna();
                   asosiyOyna.Show();
                   this.Hide();
                }
                else
                {
                    MessageBox.Show("Bu raqam royxattan otmagan!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kataklarni toldiring!", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



//Funktions funktions = new Funktions();
//foreach (Employe employe in funktions.employeList)
//{
//    if (employe.UserName == tx1.Text && employe.Raqami == tx2.Text)
//    {
//        Form4 form4 = new Form4();
//        form4.Show();
//        this.Hide();
//    }
//    else
//    {
//        MessageBox.Show("Bu raqam royxattan otmagan:", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}
