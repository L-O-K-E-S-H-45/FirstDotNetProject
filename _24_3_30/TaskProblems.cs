using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject._24_3_30
{
    internal class TaskProblems
    {
        public void FrequencyCount(string str)
        {
            str = str.ToLower();
            int[] cf = new int[128];
            for (int i = 0; i< str.Length; i++)
            {
                cf[str[i]]++; // a=97 = cf[97] ++; ccf[97]=1;
            }
            for (int i = 0; i<128; i++) 
            { 
                if (cf[i] != 0)
                {
                    Console.Write( ((char)i) + " -> " + cf[i] + ", ");
                }
            }
            Console.WriteLine();
        }

        public void RemoveDuplicates(int[] arr)
        {
            ISet<int> set = new HashSet<int>();

            foreach (int ele in arr)
            {
                set.Add(ele);
            }

            foreach (int ele in set)
            {
                Console.Write( ele + " " );
            }
            Console.WriteLine();
        }

        public void RemoveDuplicates2(int[] arr)
        {
            bool[] bools = new bool[arr.Length];
            int[] temp = new int[arr.Length];
            int k = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                if (!bools[i])
                {
                    bool b = true;
                    for (int j=0; j<k; j++)
                    {
                        if (arr[i] == temp[j])
                        {
                            bools[j] = true;
                            b = false;
                        }
                    }
                    if (b)
                    {
                        temp[k++] = arr[i];
                    }
                }
            }
            int[] res = new int[k];
            for (int i = 0; i < k; i++)
                res[i] = temp[i];

            //  To print array
            foreach(int ele in res)
                Console.Write(ele +" ");
            Console.WriteLine();
        }

        public void FindAgeOfPerson(int year, int month, int date) 
        { 
            DateTime dateOfBirth = new DateTime(year, month, date);

            Console.WriteLine("Date of birth: " + dateOfBirth.ToString("dd/MM/yyyy"));

            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Current Date: " + currentDate.ToString("dd/MM/yyyy"));

            int ageYear = currentDate.Year - dateOfBirth.Year;

            if (currentDate.Month < dateOfBirth.Month ||
                currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day)
            {
                ageYear--;

            }

            int ageMonth = (currentDate.Month < dateOfBirth.Month) ? dateOfBirth.Month - currentDate.Month : 
                currentDate.Month - dateOfBirth.Month;

            int ageDay = currentDate.Day < dateOfBirth.Day ? dateOfBirth.Day - currentDate.Day : 
                currentDate.Day - dateOfBirth.Day;

            Console.WriteLine("Age of Person is: " + ageYear + " years, " + ageMonth + " months, " + ageDay + " days");

        }

    }
}
