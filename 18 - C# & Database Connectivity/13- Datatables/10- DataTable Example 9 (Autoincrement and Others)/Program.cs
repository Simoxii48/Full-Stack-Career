using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10__DataTable_Example_9__Autoincrement_and_Others_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DataTable creation for Emmployees
            DataTable EmployeesDataTable = new DataTable();
            
            // New Column creation for ID
            DataColumn dtColumn = new DataColumn();

            dtColumn.DataType = typeof(int);
            dtColumn.ColumnName = "ID";
            dtColumn.AutoIncrement = true;
            dtColumn.AutoIncrementSeed = 1;
            dtColumn.AutoIncrementStep = 1;
            
            dtColumn.Caption = "EmployeeID";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;

                // Add ID to the DataTable
                EmployeesDataTable.Columns.Add(dtColumn);

            // New Column creation for Name
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Name";
            dtColumn.Caption = "EmployeeName";
            dtColumn.AutoIncrement = false;
            dtColumn.Unique = false;
            dtColumn.ReadOnly = false;

                // Add Name to the DataTable
                EmployeesDataTable.Columns.Add(dtColumn);

            // New Column creation for Country
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Country";
            dtColumn.Caption = "EmployeeCountry";
            dtColumn.AutoIncrement = false;
            dtColumn.Unique = false;
            dtColumn.ReadOnly = false;

                // Add Country to the DataTable
                EmployeesDataTable.Columns.Add(dtColumn);

            // New Column creation for Salary
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(double);
            dtColumn.ColumnName = "Salary";
            dtColumn.Caption = "EmployeeSlary";
            dtColumn.AutoIncrement = false;
            dtColumn.Unique = false;
            dtColumn.ReadOnly = false;

                // Add Salary to the DataTable
                EmployeesDataTable.Columns.Add(dtColumn);

            // New Column creation for Date
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(DateTime);
            dtColumn.ColumnName = "Date";
            dtColumn.Caption = "Date";
            dtColumn.AutoIncrement = false;
            dtColumn.Unique = false;
            dtColumn.ReadOnly = false;

                // Add Date to the DataTable
                EmployeesDataTable.Columns.Add(dtColumn);

            // Make ID Primary Key
            DataColumn[] PrimaryColumns = new DataColumn[1];
            PrimaryColumns[0] = EmployeesDataTable.Columns["ID"];
            EmployeesDataTable.PrimaryKey = PrimaryColumns;

            // Add Rows
            EmployeesDataTable.Rows.Add(null, "Mohammed AbuHadhoud", "Jordan", 9000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null, "Maher Ali", "Koweit", 4855, DateTime.Now);
            EmployeesDataTable.Rows.Add(null, "Hassan Darfoufi", "Morocco", 5000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null, "Hussein AbuAli", "Saudi Arabia", 19000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null, "Alae Jaber", "Jordan", 5065, DateTime.Now);

            Console.WriteLine("\n Employees List : \n");

            foreach(DataRow dataRecord in EmployeesDataTable.Rows)
            {
                Console.WriteLine("ID : {0} \t Name : {1} \t Country : {2} \t Salary : {3} \t Date : {4}", 
                    dataRecord["ID"], dataRecord["Name"], dataRecord["Country"], dataRecord["Salary"], dataRecord["Date"]);
            }
        }
    }
}
