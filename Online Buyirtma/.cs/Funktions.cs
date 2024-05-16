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
        public Funktions()
        {
            string[] EmployesList = File.ReadAllLines(EmployesListPath);
            for (int i = 0; i < EmployesList.Length; i++)
            {
                string[] EmployesListLine = EmployesList[i].Split(",");
                employeList.Add(new Employe() { Id = int.Parse(EmployesListLine[0]), UserName = EmployesListLine[1], Raqami = EmployesListLine[1] });
            }
        }
    }
}
