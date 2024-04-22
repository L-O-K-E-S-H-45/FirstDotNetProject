using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstProject._24_4_10
{
    internal class DataAnnotations
    {

        class Author
        {
            [Required(ErrorMessage = "{0} is required")]
            [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} should be minimum 3 characters & max 50 chars")]
            [DataType(DataType.Text)]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "{0} is required")]
            [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} should be minimum 3 characters & max 50 chars")]
            [DataType(DataType.Text)]
            public string LastName { get; set; }

            [DataType(DataType.PhoneNumber)]  // this checks for numbers but not length
            [Phone]
            public string PhoneNumber { get; set; }

            [DataType(DataType.EmailAddress)]  // true if @ char is present in between
            [EmailAddress]
            public string Email { get; set; }

        }

        bool ValidateUserInputData<T>(T userObject)
        {
            ValidationContext validationContext = new ValidationContext(userObject, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(userObject, validationContext, validationResults, true);
            if (!valid)
            {
                foreach (ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine(validationResult.ErrorMessage);
                }
                return false;
            }
            else
            {
                Console.WriteLine("User input data is valid.");
                return true;
            }
        }


        // custom validation attribute
        [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
        class IsEmptyAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                var inputValue = value as string;
                return !string.IsNullOrEmpty(inputValue);
            }
        }

        class Author1
        {
            [IsEmpty(ErrorMessage = "{0} should not be null & empty")]
            public string FirstName { get; set;}

            [IsEmpty(ErrorMessage = "{0} should not be null & empty")]
            public string LastName { get; set;}
        }

        public void DataAnnotaionOperations()
        {
            //Author author = new Author();
            //author.FirstName = "Scott";
            //author.LastName = "stefan";
            //author.PhoneNumber = "12345678765690";  // true
            //author.Email = "4scott123@gmail";  // true
            //Console.WriteLine("Is user input data valid: " + ValidateUserInputData(author));

            //Author1 author1 = new Author1();
            //author1.FirstName = "jhj";
            //author1.LastName = "jyjfgv";
            //Console.WriteLine(new IsEmptyAttribute().IsValid(author1));  // still getting false, why?
            ////Console.WriteLine("Is user input data valid using custom attribute: " + ValidateUserInputData(author1));

            //----------------------
            //string pattern = @"\b[M]\w+";
            //string pattern = @"^[M][a-z]{0,}"; // starts with M & that word only -> Mahesh
            //Regex regex = new Regex(pattern);
            //Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            //string authours = "Mahesh Rao, Raj kumar, mike gold, Allen stew";
            //MatchCollection matchAuthors = regex.Matches(authours);
            //for (int count = 0; count < matchAuthors.Count; count++)
            //{
            //    Console.WriteLine(matchAuthors[count].Value);
            //}

            //string badString = "Here is  a string   with tons  of white spaces  ";
            ////string cleanedString = Regex.Replace(badString, "\\s+", " ");
            //string cleanedString = Regex.Replace(badString, "\\s+", "-");
            //Console.WriteLine(cleanedString);

            //string strWithSpecialChars = "hello, world!!!. How: are you?";
            ////string cleanedStr = Regex.Replace(strWithSpecialChars, @"[^0-9a-zA-Z]+", "");
            //string cleanedStr = Regex.Replace(strWithSpecialChars, @"[^0-9a-zA-Z:,]+", "");
            //Console.WriteLine(cleanedStr);

        }

        public void DataAnnotaionOperations2()
        {

            //string testString = "regular expressions are sometime called as regex or regexp";
            //Console.Write("Match \"regex\" in test sting: ");
            //foreach (var myMatch in Regex.Matches(testString,"regex"))
            //    Console.Write($"{myMatch} ");
            //Console.Write("\n\nMatch \"regex\" \"regexp\" by making 'p' optional in test sting: ");
            //foreach (var myMatch in Regex.Matches(testString, "regexp?"))
            //    Console.Write($"{myMatch} ");

            //string pattern = "Tim";
            //Console.WriteLine("Tim corey " + Regex.IsMatch("Tim corey ", pattern)); // True
            //Console.WriteLine("Timothy corey " + Regex.IsMatch("Timothy corey ", pattern));  // T
            //Console.WriteLine("Sometimes " + Regex.IsMatch("Sometimes ", pattern));  // F
            //Console.WriteLine("tim corey " + Regex.IsMatch("tim corey ", pattern));  // F

            //Console.WriteLine("-----------------------------");

            //string pattern = "[Tt]im";
            //Console.WriteLine("Tim corey " + Regex.IsMatch("Tim corey ", pattern));  // T
            //Console.WriteLine("Timothy corey " + Regex.IsMatch("Timothy corey ", pattern)); // T
            //Console.WriteLine("Sometimes " + Regex.IsMatch("Sometimes ", pattern)); // T
            //Console.WriteLine("tim corey " + Regex.IsMatch("tim corey ", pattern)); // T

            //----------------------------
            //string pattern = "Tim";
            //Console.WriteLine("Tim corey " + Regex.IsMatch("Tim corey ", pattern, RegexOptions.IgnoreCase));  // T
            //Console.WriteLine("Timothy corey " + Regex.IsMatch("Timothy corey ", pattern, RegexOptions.IgnoreCase)); // T
            //Console.WriteLine("Sometimes " + Regex.IsMatch("Sometimes ", pattern, RegexOptions.IgnoreCase)); // T
            //Console.WriteLine("tim corey " + Regex.IsMatch("tim corey ", pattern, RegexOptions.IgnoreCase)); // T

            //-----------------
            //string pattern = "^Tim";
            //Console.WriteLine("Tim corey " + Regex.IsMatch("Tim corey ", pattern));  // T
            //Console.WriteLine("Timothy corey " + Regex.IsMatch("Timothy corey ", pattern)); // T
            //Console.WriteLine("I am Tim cory " + Regex.IsMatch("I am Tim cory ", pattern)); // F
            //Console.WriteLine("tim corey " + Regex.IsMatch("tim corey ", pattern)); // F

            //-----------------
            //string pattern = @"\sTim\s";
            //Console.WriteLine("Tim corey " + Regex.IsMatch("Tim corey ", pattern));  // F
            //Console.WriteLine("Timothy corey " + Regex.IsMatch("Timothy corey ", pattern)); // F
            //Console.WriteLine("I am Tim cory " + Regex.IsMatch("I am Tim cory ", pattern)); // T
            //Console.WriteLine("tim corey " + Regex.IsMatch("tim corey ", pattern)); // F

            ///-------------------
            //string pattern = @"(\s|^)Tim(\s|^)";
            //Console.WriteLine("Tim corey " + Regex.IsMatch("Tim corey ", pattern));  // T
            //Console.WriteLine("Timothy corey " + Regex.IsMatch("Timothy corey ", pattern)); // F
            //Console.WriteLine("I am Tim cory " + Regex.IsMatch("I am Tim cory ", pattern)); // T
            //Console.WriteLine("tim corey " + Regex.IsMatch("tim corey ", pattern)); // F

            //----- Bench mark -----------
            //string pattern = @"(\s|^)Tim(\s|^)";

            ////Stopwatch stopwatch = Stopwatch.StartNew();
            //Stopwatch stopwatch = new();
            //stopwatch.Start();
            ////Regex regex = new Regex(pattern, RegexOptions.Compiled);
            //Regex regex = new Regex(pattern);

            //for (int i = 0; i < 100000; i++)
            //{
            //    //Regex.IsMatch("I am Tim cory ", pattern);
            //    regex.IsMatch("I am Tim cory ");
            //}

            //stopwatch.Stop();

            //Console.WriteLine("Time Elapsed in ms: " + stopwatch.ElapsedMilliseconds);

            //--- Phone number 
            ////string tosearch = File.ReadAllText("text.txt");
            //string toSearch = "(253) 624 7252 , (253)-624-7252 , (253) 624.7252 , 258.624 7252 , (253 624.7252 , 3537243575 , 253 542 2754 , 2542 363 342 , 26536353676535363";
            //string pattern1 = @"\(?\d{3}\)?(-|.|\s)?\d{3}(-|.|\s)?\d{4}\b";  // this will not check for length
            //MatchCollection matches = Regex.Matches(toSearch, pattern1);
            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.Value);
            //}

            //Console.WriteLine("-------------------------");
            //// Indian phone nuumber pattern matching
            //string[] phoneNumbers = { "6234567890", "1234567890", "46611536274567", "85362 74567", "95362 7456997", "4536274567", "+91-8765435678", "+91 - 8765435678", "+91 7647658793", "+91 81225647658793" };

            //string PhoneNumberPattern = @"^(\+91(-|\s))?[6-9]\d{4}\s?\d{5}\b";

            //List<string> matchedPhoneNumbers = new List<string>();
            //foreach (var phoneNumber in phoneNumbers) {
            //    if (Regex.IsMatch(phoneNumber, PhoneNumberPattern)) 
            //        matchedPhoneNumbers.Add(phoneNumber);
            //    else
            //        Console.WriteLine("Incorrect phone number: " + phoneNumber);
            //}
            //Console.WriteLine("Matched phone numbers: ");
            //foreach (var phoneNumber in matchedPhoneNumbers)
            //{
            //    Console.WriteLine(phoneNumber);
            //}

            //Console.WriteLine("---------------------");
            ////Email pattern matching
            //string Emails = "a@gmail.com, ab@gmail.com, a2@gmail.com, abc@gmail.com, @gmail.com, 3abc@gmail.com, abc@gmhail.com, Agd@gmail.com, aHsj@gmail.com, assj@gmail.coms, afsj@gt.in, adsj@g.in, assj@g.ind";
            //string EmilPattern = @"^[a-z][a-z0-9]{1,}[\@]((gmail.com)|([a-z][a-z0-9]{1,}.(in)))\b";
            //List<string> CorrectEmails = new List<string>();
            //foreach (var email in Emails.Split(", "))
            //{
            //    if (Regex.IsMatch(email, EmilPattern))
            //        CorrectEmails.Add(email);
            //    else
            //        Console.WriteLine($"Incorrect email: {email}");
            //}

            //Console.WriteLine("Correct emaails: ");
            //foreach (var email in CorrectEmails)
            //{
            //    //Console.WriteLine(email is string);
            //    //Console.WriteLine(email is int);
            //    //Console.WriteLine(email.GetType() == typeof(string));
            //    Console.WriteLine(email);
            //}

            // First name pattern matching
            //string names = "A,Ag,Ahf,AhFd,a,Ajhchgc,afdhs,fafhDhs,2fss,Ahd3f";
            //string FirstNamePattern = @"^[A-Z][a-z]{2,}\b";
            //List<string> CorrectNmes = new List<string>();
            //foreach (var name in names.Split(","))
            //{
            //    if (Regex.IsMatch(name, FirstNamePattern))
            //        CorrectNmes.Add(name);
            //    else
            //        Console.WriteLine($"Incorrect name: {name}");
            //}

            //Console.WriteLine("Correct names: ");
            //foreach (var name in CorrectNmes)
            //    Console.WriteLine(name);

        }


    }
}
