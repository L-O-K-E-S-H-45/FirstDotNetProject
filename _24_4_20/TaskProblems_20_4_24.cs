using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_4_20
{
    internal class TaskProblems_20_4_24
    {
        //Problem-1
        public int CalculateShippingCost(int packages, string destination, int weight)
        {
            if (destination.Equals("domestic"))
            {
                if (weight >= 5)
                    return packages * 10;
                else
                    return packages * 5;
            }
            else if (destination.Equals("international"))
            {
                if (weight >= 5)
                    return packages * 20;
                else
                    return packages * 10;
            }
            else // if invalid destination
                return 0;
        }

        // Problem-2
        public void ReverseArray<T>(T[] arr)
        {
            Console.WriteLine("Array before reverse: ");
            PrintArray(arr);

            var reversedArr = arr.Reverse().ToArray();

            Console.WriteLine("Array after reverse: ");
            PrintArray(reversedArr);
        }
        private void PrintArray<T>(T[] arr)
        {
            //Console.Write("[ ");
            //foreach (var item in arr)
            //    Console.Write(item + " ");
            //Console.WriteLine("]");
            //---------------
            Console.Write("[ ");
            Console.Write(string.Join(", ",arr));
            Console.WriteLine(" ]");
        }

        // Problem-3
        internal class Sales
        {
            public string ProductName {  get; set; }
            public int ProductQuantity {  get; set; }
            public double ProductPrice { get; set; }
        }

        // Problem-4
        public void DatabaseOperations()
        {

            string connectionString = @"Data Source=DESKTOP-4OR4SUH\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;";
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Connection established!!!");

                //string 

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("-----------");
                Console.WriteLine(ex.StackTrace);
            }
        }


    }
}
