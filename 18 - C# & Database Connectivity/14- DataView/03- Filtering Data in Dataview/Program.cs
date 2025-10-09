using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeesDataTable = new DataTable();
            EmployeesDataTable.Columns.Add("ID", typeof(int));
            EmployeesDataTable.Columns.Add("Name", typeof(string));
            EmployeesDataTable.Columns.Add("Country", typeof(string));
            EmployeesDataTable.Columns.Add("Salary", typeof(Double));
            EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

            //Add rows 
            EmployeesDataTable.Rows.Add(1, "Mohammed Abu-Hadhoud", "Jordan", 5000, DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "Ali Maher", "KSA", 525.5, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "Lina Kamal", "Jordan", 730.5, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "Fadi JAmeel", "Egypt", 800, DateTime.Now);
            EmployeesDataTable.Rows.Add(5, "Omar Mahmoud", "Lebanon", 7000, DateTime.Now);

            Console.WriteLine("\nEmployees List:\n");

            foreach (DataRow RecordRow in EmployeesDataTable.Rows)
            {
                //Using Field Name
                Console.WriteLine(" ID: {0}\t Name : {1} \t Country: {2} \t Salary: {3} Date: {4} \t ", RecordRow["ID"], RecordRow["Name"], RecordRow["Country"], RecordRow["Salary"], RecordRow["Date"]);

            }

            // Create DataView
            DataView EmployeesDataView1 = EmployeesDataTable.DefaultView;
            Console.WriteLine("\n Employees List From DataView : \n");

            for(int i=0; i < EmployeesDataView1.Count; i++)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", EmployeesDataView1[i][0], EmployeesDataView1[i][1], EmployeesDataView1[i][2],
                    EmployeesDataView1[i][3], EmployeesDataView1[i][4]);
            }

            Console.WriteLine("\n Employees List From DataView after filtering 'Jordan Or Egypt' : \n");

            // Filtering
            EmployeesDataView1.RowFilter = "Country = 'Jordan' or Country = 'Egypt'";
            for (int i = 0; i < EmployeesDataView1.Count; i++)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", EmployeesDataView1[i][0], EmployeesDataView1[i][1], EmployeesDataView1[i][2],
                    EmployeesDataView1[i][3], EmployeesDataView1[i][4]);
            }
        }
    }
}
