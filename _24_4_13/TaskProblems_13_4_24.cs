using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstProject._24_4_13
{
    internal class TaskProblems_13_4_24
    {
        // problem-1
        public void FileOpeartion(string filepath)
        {
            string dataFromFile = "";
            if (File.Exists(filepath))
            {
                dataFromFile = File.ReadAllText(filepath);
            }
            else
            {
                //File.Create(filepath);
                string data = "Hello, \nThis is text data to add into file";
                File.WriteAllText(filepath, data);

                dataFromFile = File.ReadAllText(filepath);
            }

            Console.WriteLine($"Data from file is: {dataFromFile}");
        }

        // problem-2
        public bool DateFormatValidation(string date)
        {
            // Date format: yyyy-mm-dd, yyyy/mm/dd, dd-mm-yyyy, dd/mm/yyyy
            string DatePattern = @"((\b\d{4}(-|/)\d{1,2}(-|/)\d{1,2}\b)|(\b\d{1,2}(-|/)\d{1,2}(-|/)\d{4}\b))";

            //if (Regex.IsMatch(date, DatePattern))
            //    return true;
            //else
            //    return false;

            return Regex.IsMatch(date, DatePattern);
        }

        // problem-3 MSTest






        //static bool IsValidDate(string date)
        //{
        //    // Regular expression for date formats (YYYY-MM-DD, MM/DD/YYYY, DD-MM-YYYY, YYYY/MM/DD)
        //    string pattern = @"^(?:\d{4}-\d{2}-\d{2}|\d{2}/\d{2}/\d{4}|\d{2}-\d{2}-\d{4}|\d{4}/\d{2}/\d{2})$";

        //    return Regex.IsMatch(date, pattern);
        //}

        // 16-4-2024 -> Database
        // 17-4-2024 -> ADO.NET -> connects consoleapp code to database


    }
}
