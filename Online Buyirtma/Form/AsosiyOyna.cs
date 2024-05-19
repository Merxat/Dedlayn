using Online_Buyirtma.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Runtime.InteropServices.JavaScript.JSType.Function;

namespace Online_Buyirtma
{
    public partial class AsosiyOyna : Form
    {

        public AsosiyOyna()
        {
            InitializeComponent();
            List<Product> products = new List<Product>();
            string path = @"D:\Users\User 2022\Desktop\Dasturiy injinering ga kirish\Online Buyirtma\Online Buyirtma\txt.files\Product.txt";
            string[] productList = File.ReadAllLines(path);
            for (int i = 0; i < productList.Length; i++)
            {
                string[] proLine = productList[i].Split(",");
                products.Add(new Product { Id = i, Nomi = proLine[1], Narxi = int.Parse(proLine[2]), Soni =int.Parse( proLine[3]) });
            }
            dataGridView1.DataSource = products;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Maxsulotn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funktions funktions = new Funktions();
            int sanoq = 0;
            foreach (Product product in funktions.productList)
            {
                if (Maxsulotn.Text.ToLower() == product.Nomi.ToLower())
                {
                    sanoq = 1;
                    if (funktions.CheckNumber(MaxsulotS.Text))
                    {
                        if (product.Soni - int.Parse(MaxsulotS.Text) >= 0)
                        { 
                            File.AppendAllText(funktions.ProductListPath,  product.Nomi + "," + textBox1.Text + "," + product.Narxi * int.Parse(textBox1.Text) + "\n");
                            MessageBox.Show($"Savatga qo'shildi", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Maxsulotn.Clear();
                            textBox1.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Maxsulot soni yetmadi", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Maxsulot sonini tog'ri kiriting", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                }
            }
            if (sanoq == 0)
            {
                MessageBox.Show("Maxsulot nomini toliq kiriting", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
