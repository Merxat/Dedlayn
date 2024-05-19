using Online_Buyirtma.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Buyirtma
{
    public class Funktions
    {
        public List<Employe> employeList = new List<Employe>();
        public string EmployesListPath = @"D:\Users\User 2022\Desktop\Dasturiy injinering ga kirish\Online Buyirtma\Online Buyirtma\txt.files\EmployeList.txt";
        public List<Product> productList = new List<Product>();
        public string ProductListPath = @"D:\Users\User 2022\Desktop\Dasturiy injinering ga kirish\Online Buyirtma\Online Buyirtma\txt.files\Product.txt";
        public List<SalesProduct>salesProductsList = new List<SalesProduct>();
        public string SalesPath = @"D:\Users\User 2022\Desktop\Dasturiy injinering ga kirish\Online Buyirtma\Online Buyirtma\txt.files\SalaesProduct.txt";

        public Funktions()
        {
            string[] EmployesList = File.ReadAllLines(EmployesListPath);
            for (int i = 0; i < EmployesList.Length; i++)
            {
                string[] EmployesListLine = EmployesList[i].Split(",");
                employeList.Add(new Employe() { Id = int.Parse(EmployesListLine[0]), UserName = EmployesListLine[1], Raqami = EmployesListLine[1] });
            }
            string[]ProductList=File.ReadAllLines(ProductListPath);
            for(int i = 0;i<ProductList.Length;i++)
            {
                string[]ProductListLine= ProductList[i].Split(",");
                productList.Add(new Product() { Id = int.Parse(ProductListLine[0]), Nomi = ProductListLine[1], Soni = int.Parse(ProductListLine[2]) ,Narxi = int.Parse(ProductListLine[3]), });
            }
            string[] SalesPoductList = File.ReadAllLines(ProductListPath);
            for( int i = 0;i < SalesPoductList.Length; )
            {
                string[] SalesListLine= SalesPoductList[i].Split(',');
                salesProductsList.Add(new SalesProduct() { Id = int.Parse(SalesListLine[0]), Nomi = SalesListLine[1], Soni = int.Parse(SalesListLine[2]), Narxi = int.Parse(SalesListLine[3]) });
            }
        }
        public bool CheckNumber(string str)
        {
            if (str.Length > 0)
            {
                int sanoq = 0;
                char FirstChar = '1';
                for (int i = 0; i < str.Length; i++)
                {
                    FirstChar = str[0];
                    if (str[i] >= 48 && str[i] <= 57)
                    {
                        sanoq++;
                    }
                }
                if (FirstChar != '0' && sanoq == str.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
