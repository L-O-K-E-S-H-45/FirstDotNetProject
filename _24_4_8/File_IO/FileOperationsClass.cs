using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;
using FirstProject._24_3_28.OOP;

using SuperConvert.Extensions;

/*
File Method	Description
File.Exists	File exists method is used to check if a particular file exists.
File.ReadAlllines	The method is used to read all the lines one by one in a file.
File.ReadAllText	This method is used to read all the lines in a file at once.
File.Copy	The method is used to make a copy of an existing file.
File.Delete	The method is used to delete an existing file.
*/

namespace FirstProject._24_4_8.File_IO
{
    internal class FileOperationsClass
    {
        public void FileOperations()
        {
            //Console.WriteLine("----- FILE I/O Operations --------");

            //string path1 = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\file1.txt";
            //if (File.Exists(path1))
            //{
            //    Console.WriteLine("File exists");
            //}
            //else
            //{
            //    Console.WriteLine("File deosn't exists");
            //}

            //string path2 = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\file2.txt";
            //if (File.Exists(path2))
            //{
            //    Console.WriteLine("File exists");
            //}
            //else
            //{
            //    File.Create(path2);
            //    Console.WriteLine("File created");
            //}

            //// File.ReadAllLines(path1);
            //string[] lines = File.ReadAllLines(path1);
            //Console.WriteLine(lines[0]);
            //Console.WriteLine(lines[1]);

            //// File.ReadAllText(path1);
            //string dataFromFile = File.ReadAllText(path1);
            //Console.WriteLine("Data from file: " + dataFromFile);

            // File.Copy(originalPath, copyPath, true); or File.Copy(originalPath, copyPath);
            //string originalPath = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\file1.txt";
            //string copyPath = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\file3.txt";
            ////File.Copy(originalPath, copyPath, false); // this will create copyPth file if not present & copies data else gives runtime error(file not found) 
            ////File.Copy(originalPath, copyPath, true);  //  // this will create copyPth file if not present & copies data else overrides existing data with copy data
            //string copyPath = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\file3.txt";
            //File.Copy(originalPath, copyPath); //(,false) this will also create copyPth file if not present & copies data else gives runtime error(file not found) 
            //Console.WriteLine("Data in copyPath after copy: " + File.ReadAllText(copyPath));

            // File.Delete(path);
            //string path = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\file3.txt";
            //if (File.Exists(path))
            //    Console.WriteLine("file exists");
            //else
            //    Console.WriteLine("File doesnot exist");
            //File.Delete(path);  // this will delete file if exists else does nothing
            //if (File.Exists(path))
            //    Console.WriteLine("file exists");
            //else
            //    Console.WriteLine("File doesnot exist");

            //string path = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\file3.txt";
            //Console.WriteLine("Data from file before write: " + File.ReadAllText(path));
            //File.WriteAllText(path, "hello, How are you?"); // creates file if not exist & writes data else overrides existing data with new data
            //Console.WriteLine("Data from file after write: " + File.ReadAllText(path));

            //string sourceFileName = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\file1.txt";
            //string destinationFileName = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\file3.txt";
            //string destinationBackupFileName = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\file4.txt";
            //File.Replace(sourceFileName, destinationFileName, destinationBackupFileName); // this deletes the sourceFile

            // ------------------------------------------
            //string path = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\file1.txt";
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string data = "";
            //    string s = "";
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //        data += s;
            //    }
            //    Console.WriteLine("stream resder data: " + data);
            //}

            //using (Stream s = new FileStream(path, FileMode.Open))
            //{
            //    string data = "";
            //    int b;
            //    while ((b= s.ReadByte()) != -1)
            //    {
            //        data += (char)b;
            //    }
            //    Console.WriteLine("stream data: " + data);
            //}

        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Country { get; set; }
        } 

        void WriteToCsv(string flepath)
        {
            try
            {

                if (!File.Exists(flepath))
                { // using keyword tells that we do not need to worry about disposal of object 
                    using(File.Create(flepath)) { Console.WriteLine("File created"); }
                }

                List<Person> people = new List<Person>()
                {
                    new Person {Name="Tom", Age=24, Country="USA"},
                    new Person {Name="Scott", Age=37, Country="Canada"},
                    new Person {Name="John", Age=41, Country="UK"},
                };

                var configPersons = new CsvConfiguration(CultureInfo.InvariantCulture) // tells we are not culter dependent
                {
                    HasHeaderRecord = true  // false -> to disable header while appending
                };
                using (StreamWriter streamwriter = new StreamWriter(flepath)) // new StreamWriter(flepath,true) -> to append data, pass true
                using (CsvWriter csvWriter = new CsvWriter(streamwriter, configPersons))
                {
                    csvWriter.WriteRecords(people);
                }
                Console.WriteLine("Data written to csv successfully");

            }
            catch (Exception)
            {

                throw;
            }
        }

        void ReadFromCsv(string flepath)
        {
            try
            {

                if (File.Exists(flepath))
                {
                    var configPersons = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = true // true -> to ignore header else use false -> if header is not present
                    };
                    using (StreamReader streamReader = new StreamReader(flepath))
                    using (CsvReader csvReader = new CsvReader(streamReader, configPersons))
                    {
                        IEnumerable<Person> records = csvReader.GetRecords<Person>();

                        Console.WriteLine("Person records from CSV file: ");
                        foreach (Person record in records)
                        {
                            Console.WriteLine($"Name: {record.Name}, Age: {record.Age}, Country: {record.Country}");
                        }
                    }
                }
                else
                    Console.WriteLine("File doesn't exist");

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CSVFileOperations()
        {
            //string directoryPath = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO";
            //string fileName = "writeTocsv.csv";
            //string filePath = Path.Combine(directoryPath, fileName);
            //WriteToCsv(filePath);
            //Console.ReadKey();

            

            //---------------
            //string filepath = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\writeTocsv.csv";
            //Console.WriteLine(File.ReadAllText(filepath));
            //ReadFromCsv(filepath);
            //Console.ReadKey();
        }

        // -------------------------

        class Company
        {
            public int company_id { get; set; }
            public string company_name { get; set; }
            public List<Employee> employees { get; set; }
        }
        class Employee
        {
            public string first_name { get; set; }
            public string last_name { get; set; }
            public long phone { get; set; }
        }

        public void CS_JSON_FileOperations()
        {
            Convert_JsonToCs();

            Convert_CsToJson();
        }

        private void Convert_JsonToCs()
        {
            string filepath = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\CustomerWithEmployee.json";
            if (File.Exists(filepath))
            {
                string justText = File.ReadAllText(filepath);
                Company company = Newtonsoft.Json.JsonConvert.DeserializeObject<Company>(justText);
                // return customer;
                Console.WriteLine($"company_id: {company.company_id}, company_name: {company.company_name}, ");
                foreach (Employee employee in company.employees)
                    Console.WriteLine($"Employee_firstName: {employee.first_name}, Employee_lastName: {employee.last_name}, Employee_phone: {employee.phone} ");
            }
            else
                Console.WriteLine("File doesn't exist");
        }

        private void Convert_CsToJson()
        {
            Company company = new Company()
            {
                company_id = 101,
                company_name = "Acess Medi Tech",
                employees = new List<Employee>
                {
                    new Employee {first_name = "Santosh", last_name = "N.S", phone = 7568412634},
                    new Employee {first_name = "Shoaib", last_name = "S", phone = 6658412466},
                    new Employee {first_name = "Chiru", last_name = "C", phone = 7758412677},
                }
            };
            var jsonFormettedContent = Newtonsoft.Json.JsonConvert.SerializeObject(company);
            string filePath = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_8\File_IO\serializedfile.json";

            //if (File.Exists(filePath))
            //{
            //    File.WriteAllText(filePath, jsonFormettedContent);
            //}
            //else
            //{
            //    File.Delete(filePath);
            //    File.WriteAllText(filePath, jsonFormettedContent);
            //}
            File.WriteAllText(filePath, jsonFormettedContent);
            Console.WriteLine("Object serialized successfully & stored into file");

            string serializedData = File.ReadAllText(filePath);
            Console.WriteLine($"\nSerializedData: {serializedData}");

        }
        

    }
}
