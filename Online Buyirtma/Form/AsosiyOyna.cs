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

namespace Online_Buyirtma
{
    public partial class AsosiyOyna : Form
    {
        public AsosiyOyna()
        {
            InitializeComponent();
            List<Product> products = new List<Product>();
            string path = @"D:\Users\User 2022\Desktop\Dasturiy injinering ga kirish\Online Buyirtma\Online Buyirtma\txt.files\Product.txt";
            string[]productList=File.ReadAllLines(path);
           for(int i = 0; i < productList.Length; i++)
            {
                string[] proLine = productList[i].Split(",");
                products.Add(new Product {Id=i,Nomi = proLine[1],Narxi = proLine[2], Soni = proLine[3] });            
            }
           dataGridView1.DataSource=products;
           //dataGrid
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
