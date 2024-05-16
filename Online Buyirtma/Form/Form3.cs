using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Online_Buyirtma
{
    public partial class Form3 : Form
    {
        public List<Employe> employeList = new List<Employe>();
        public int SmsPassword { get; set; }
        public string NewLogin { get; set; }
        public Form3()
        {
            Random random = new Random();
            InitializeComponent();
            SmsPassword = random.Next(1000, 10000);
        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txNumber.Text.Length == 9)
            {
                Funktions funktions = new Funktions();
                Thread.Sleep(2000);
                MessageBox.Show($"Ushbu kodni hech kimga yubormang: {SmsPassword}\n   ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txNumber.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Bunday qiymat berish mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funktions funktions2 = new Funktions();
     
            if (txNumber.Text.Length == 9)
            {
                if (Txsms.Text == SmsPassword.ToString())
                {
                    if(txUserName.Text.Length>0)
                    {
                        string EmployesListPath = @"D:\Users\User 2022\Desktop\Dasturiy injinering ga kirish\Online Buyirtma\Online Buyirtma\txt.files\EmployeList.txt";
                        string[] Id = File.ReadAllLines(EmployesListPath);
                         File.AppendAllText(EmployesListPath,Id.Length.ToString()
                             +","+txUserName.Text
                             + ","+txNumber.Text
                             +"\n");
                     MessageBox.Show("Muvofaqqiyatli royxattan ottingiz", "online buyirtma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Bunday qiymat berish mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Tasdiqlash kodi noto'g'ri", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("UserName kiriting", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Register qismi


        }
    }
}


       
    


