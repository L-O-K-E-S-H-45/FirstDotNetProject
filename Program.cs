// See https://aka.ms/new-console-template for more information
using FirstProject;
using FirstProject._24_3_28;
using FirstProject._24_3_28.OOP;
using FirstProject._24_3_29;
using FirstProject._24_3_30;
using FirstProject._24_4_1;
using FirstProject._24_4_1.DataStructure;
using static FirstProject._24_4_2.TaskProblems_2_4_24;
using static FirstProject._24_4_4.TaskProblems_4_4_24;
using static FirstProject._24_4_4.LINQ_Problems.Problem1;
using static FirstProject._24_4_6.Problem1;
using static FirstProject._24_4_6.Problem2;
using FirstProject._24_4_4.LINQ_Problems;
using FirstProject._24_4_8.File_IO;
using FirstProject._24_4_10;
using FirstProject._24_4_13;
using FirstProject._24_4_20;
using static FirstProject._24_4_20.TaskProblems_20_4_24;

/*
 * Ctrl+d -> to copy paste line below
 * Ctrl+l or Ctrl+x -> to delete line
 * Ctrl+k+c -> to commenet selection
 * Ctrl+k+u -> to uncomment selection
 * cw -> for Console>WriteLine();
 * Ctrl+Enter -> to add line above wherever cursor is
 * Ctrl+Shift+Enter -> to add line below wherever cursor is
 * Ctrl+r+r -> to edit multiple lines but not for identifier (place cursor where you want to edit) 
 * Alt+Shift+. again . again. goes on -> to edit multiple lines
 * left/right Alt+upArraow/downArraow -> to move single or multiple lines up/down
 * Ctrl+k+d -> to formtat entire code in that tab
 * Ctrl+k+s -> to surround the entire seleced code into if/for/foreacch/while...
 * Ctrl+m+o -> to collapse code(shrink)
 * Ctrl+r+g -> to organise & remove unused code
 * Ctrl+.(period) -> to get fixation in interface
 * Ctrl+r+m -> to reduce larger slected code to new smaller code with newMethod
 * Alt+slect using mouce or touchpad -> to selct multiple verticle section
 * Alt+Ctrl+clict wherever want -> to create multiple cursor to edit/write/delete something
 * Ctrl+lt+l -> to open solution explorer (seach bar)
 * Shift+Alt+e -> to get unity project explorer (no seach bar)
 * 
 * ----------------
 * Rename (Anything):  CTRL + [R, R]
Go To Definition: F12
Find All References: SHIFT + F12
Refactor to Method:  CTRL + [R, M]
Move Code Up/Down: ALT + Up / ALT + Down
Format Document:  CTRL + [K, D]
Surround with Snippet:  CTRL + [K, S]
Collapse Class to Definitions: CTRL + [M, O]
Organize Using Statements: CTRL + [R, G]
Quick Fix (Add Methods, implement interface, etc): CTRL + . (period)
Solution Explorer:  CTRL + ALT + L
Search to class or file: CTRL + ;
Unity Project Explorer: SHIFT + ALT + E
 * 
 */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine();
        // ctrl + l -> to remove line
        // ctrl + d -> copy & paste line in next line

        /*
        BasicPrograms basicPrograms = new BasicPrograms();

        int[] MyArray = { 52, 24, 36, 14, 85 };

        int lageestElement = basicPrograms.GetLargesl̥tElement(MyArray);
        Console.WriteLine(lageestElement);

        int smallestElemnt = basicPrograms.GetSmallestElement(MyArray);
        Console.WriteLine(smallestElemnt);

        Console.WriteLine(MyArray.Max());
        Console.WriteLine(MyArray.Min());

        int sum = basicPrograms.SumOfElements(MyArray);
        Console.WriteLine(sum);

        basicPrograms.BubbleSort(MyArray);
        */

        // 28-3-2024
        //Animal animal = new Dog();
        //animal.MakeSound();

        //animal = new Cat();
        //animal.MakeSound();

        //animal = new Cow();
        //animal.MakeSound();
        //--------------------------
        //Console.WriteLine("2nd problem IShape interface");
        //IShape shape = new Circle();
        //Console.WriteLine($"Area of circle: {shape.CalculateArea()}");

        //shape = new Rectangle();
        //Console.WriteLine($"Area of rectangle: {shape.CalculateArea()}");

        //--------------
        //Console.WriteLine("----------- 3rd problem BankaAccount -----------");
        ////BankAccount account = new BankAccount(1000);  // it is internl access modifier still can access

        //BankAccountRunner bankAccount = new BankAccountRunner(5000);

        //bankAccount.CheckBalance();

        //bankAccount.DepositBalance();

        //bankAccount.WithDrawBalance();

        //--- OOP Problems
        //---- 1st
        //Manager manager = new Manager("Tom", 1234, 80000, "Development");
        //Developer developer = new Developer("Scott", 4563, 45000, "C#");
        //HR hr = new HR("Allen", 3326, 65000, "Recruitment");

        //Console.WriteLine("Manager Information:");
        //manager.DisplayEmployeeInfo();

        //Console.WriteLine("\nDeveloper Information:");
        //developer.DisplayEmployeeInfo();

        //Console.WriteLine("\nHR Information:");
        //hr.DisplayEmployeeInfo();

        //---- 7th problem
        //TemperatureConverter converter = new TemperatureConverter();

        //double celsiusTemp = 25;
        //double fahrenheitTemp = 98.6;

        //Console.WriteLine($"Celsius: {celsiusTemp} -> Fahrenheit: {converter.CelsiusToFahrenheit(celsiusTemp):F2}");
        //Console.WriteLine($"Fahrenheit: {fahrenheitTemp} -> Celsius: {converter.FahrenheitToCelsius(fahrenheitTemp):F2}");

        // 29-3-2024
        // 1st poblem
        //ArrayProblems arrayProblem = new ArrayProblems();
        ////arrayProblem.ReadAndPrintIntegerArray();

        ////arrayProblem.ReadAndPrintCharacterArray();

        ////arrayProblem.ReadAndPrintDoubleArray();

        //int[] arr1 = { 2, 4, 2, 67, 9 };
        //char[] arr2 = { 's', 'h', 'j', 'h' };
        //double[] arr3 = { 43.3, 3.2, 56.35, 7.8 };
        //arrayProblem.PrinArray(arr1);
        //arrayProblem.PrinArray<char>(arr2);
        //arrayProblem.PrinArray(arr3);

        //// 2nd problem
        //Calculator calculator = new Calculator();
        ////calculator.calculate();
        //calculator.calculate('-', 23, 72);
        //calculator.calculate('*', 64, 86);
        //calculator.calculate('+', 10, 34);
        //calculator.calculate('/', 25, 6);
        //calculator.calculate('/', 87, 0);
        //calculator.calculate('#', 75, 35);

        //FindMax findMax = new FindMax();
        //Console.WriteLine(findMax.FindMaxNumber(34, 82, 26));
        //Console.WriteLine(findMax.FindMaxNumber(34.9f, 12.7f, 82.3f));
        //Console.WriteLine(findMax.FindMaxString("hff1", "jgk", "ghfs"));

        //Console.WriteLine(value: findMax.FindMaxValue("hff1", "jgk", "0"));

        //Console.WriteLine("Max integer value: " + findMax.FindMaxValue(38, 79, 84));

        //Console.WriteLine("Max double value: " + findMax.FindMaxValue(3.5, 7.2, 2.8));

        //Console.WriteLine("Longest string: " + findMax.FindMaxValue("apple", "banana", "cherry"));

        // 30-3-2024
        //TaskProblems basicPrograms = new TaskProblems();
        ////basicPrograms.FrequencyCount("a hello world hii");

        //int[] arr = { 1, 4, 2, 3,  4, 7, 3 };
        ////basicPrograms.RemoveDuplicates(arr);
        //basicPrograms.RemoveDuplicates2(arr);

        ////basicPrograms.FindAgeOfPerson(1998, 1, 9);

        // 1-4-2024
        //TaskProblems_1_4_24 programs = new TaskProblems_1_4_24();
        //int x=10, y=20;
        //programs.Swap("hello", "world");
        //programs.Swap(x, y);
        //programs.Swap(5.2,8.3);

        //Console.WriteLine(x +" " + y);
        //programs.Swap1(ref x, ref y);
        //Console.WriteLine(x + " " + y);

        //Console.WriteLine("------ 2nd Problem ----------");

        //int[] arr1 = { 1, 2, 3, 4, 5 };
        //char[] arr2 = { 'a', 'b', 'c', 'd', 'e' };
        //double[] arr3 = { 1.2, 5.3, 6.8, 4.7, 9.0 };

        //programs.ReverseArray(arr1);
        //programs.ReverseArray(arr2);
        //programs.ReverseArray(arr3);

        //SinglyLinkedList list = new SinglyLinkedList();
        //list.AddLast(63);
        //list.AddLast(84);
        //list.AddLast(38);
        //list.Display();

        //list.AddFirst(52);
        //list.AddFirst(37);
        //list.AddFirst(24);
        //list.Display();
        //Console.WriteLine("Size of list: " + list.Count());

        //list.Add(-3,56);
        //list.Add(0,56);
        //list.Add(1,11);
        //list.Add(8,21);
        //list.Add(9,31);
        //list.Add(11,81);
        //list.Display();

        //list.DeleteFirst();
        //list.Display();
        //Console.WriteLine("Size of list: " + list.Count());
        //list.DeleteLast();
        //list.Display();
        //Console.WriteLine("Size of list: " + list.Count());
        //list.Delete(-8);
        //list.Delete(0);
        //list.Display();
        //Console.WriteLine(list.Delete(7));
        //list.Display();
        //Console.WriteLine("----- Reverse1 -----");
        //list.ReverseSLL();
        //list.Display();
        //Console.WriteLine("----- Reverse2 -----");
        //list.ReverseSLL2();
        //list.Display();

        //StackUsingArray stack = new StackUsingArray(5);
        //stack.Push(10);
        //stack.Push(20);
        //stack.Push(30);
        //stack.Display();
        //Console.WriteLine("Size of Stack: " + stack.Count());

        //stack.Push(40);
        //stack.Push(50);
        //stack.Push(60);
        //stack.Display();
        //Console.WriteLine("Size of Stack: " + stack.Count());

        //Console.WriteLine(stack.Pop());
        //stack.Display();
        //Console.WriteLine(stack.Pop());
        //stack.Display();
        //stack.Pop();
        //stack.Pop();
        //stack.Pop();
        //stack.Pop();
        //stack.Pop();
        //stack.Display();

        //StackUsingSLL stack = new StackUsingSLL();
        //stack.Push(10);
        //stack.Push(20);
        //stack.Push(30);
        //stack.Display();
        //Console.WriteLine("Size of Stack: " + stack.Count());

        //Console.WriteLine("Peek element: " + stack.Peek());
        //stack.Display();

        //stack.Push(40);
        //stack.Push(50);
        //stack.Push(60);
        //stack.Display();
        //Console.WriteLine("Size of Stack: " + stack.Count());

        //Console.WriteLine(stack.Pop());
        //stack.Display();
        //Console.WriteLine(stack.Pop());
        //stack.Display();

        //Console.WriteLine("Peek element: " + stack.Peek());
        //stack.Display();

        //stack.Pop();
        //stack.Pop();
        //stack.Pop();
        //stack.Pop();
        //stack.Pop();
        //stack.Display();

        //Queue queue = new Queue();
        //queue.Push(16);
        //queue.Push(47);
        //queue.Push(82);
        //queue.Push(23);
        //queue.Display();

        //Console.WriteLine(queue.Poll());
        //queue.Display();

        //Console.WriteLine(queue.Poll());
        //queue.Display();

        //Console.WriteLine("Peek element: " + queue.Peek());
        //queue.Display();

        //BinarySeachTree tree = new BinarySeachTree();
        //tree.Insert(20);
        //tree.Insert(10);
        //tree.Insert(30);
        //tree.Insert(60);
        //tree.Insert(40);
        //tree.Display();

        // 2-4-2024
        //SinglyLinkedList1 list = new SinglyLinkedList1();
        //list.AddLast("ajay");
        //list.AddLast("bheem");
        //list.AddLast("kiran");
        //list.Display();

        // 4-4-2024       =>  Lambda Expression & LINQ Methods
        /*
        //List<int> list = new List<int>();
        //list.Add(1);
        //list.Add(6);
        //list.Add(5);
        //list.Add(3);
        //list.Add(2);
        //list.Add(8);

        // or 
        List<int> ints = new List<int>()
        {
            1,2,3,4,5,
        };

        MyList ml = new MyList();
        //ml.FindOddAndEvenNumbers(list);
        // ----- OR ------
        var OddNumbers = ints.Where(x => x % 2 != 0).ToList();   // ********** ToList()
        Console.WriteLine($"Odd numbers-1: ");
        ml.PrintList(OddNumbers);

        var EvenNumbers = ints.Where(x => x%2 == 0).ToList();
        Console.WriteLine("Even numbers-1: ");
        ml.PrintList(EvenNumbers);

        // ----- OR -----
        var OddNumbers2 = from num in ints where num % 2 != 0 select num;
        var EvenNumbers2 = from num in ints where num % 2 == 0 select num;
        Console.WriteLine($"Odd numbers-2: ");
        ml.PrintList(OddNumbers2.ToList());  // ********** ToList()
        Console.WriteLine("Even numbers-2: ");
        ml.PrintList(EvenNumbers2.ToList());

        List<string> list2 = new List<string>();
        list2.Add("Tom");
        list2.Add("John");
        list2.Add("Scott");
        list2.Add("Miller");
        list2.Add("smithh");
        list2.Add("Smith");

        string max = ml.FindMaxString(list2);
        Console.WriteLine($"Max string value-1: {max}");
        // -------- OR -------
        var maxString2 = list2.OrderByDescending(str => str.Length).FirstOrDefault(); // First() will give runtime error if elements are not present
        Console.WriteLine($"Max string value-2: {maxString2}");
        // -------- OR -------
        var maxString3 = (from str in list2 orderby str.Length descending select str).FirstOrDefault();
        Console.WriteLine($"Max string value-3: {maxString3}");
        */

        /*
        // Problem-1
        Console.WriteLine("-------- problem-1 -------");
        Customer_P1 customer_P1 = new Customer_P1();

        //var lastMonthCustomers = customer_P1.GetAllCustomers().Where(c => c.LastPurchaseDate.Month == DateTime.Now.AddMonths(-1).Month).ToList();
        //var recentCustomers = lastMonthCustomers.Select(c => new { Name = c.Name, TotalPurchageAmount = c.TotalPurchaseAmount }).ToList();
        // ---- OR---
        var recentCustomers = customer_P1.GetAllCustomers().Where(c => c.LastPurchaseDate.Month == DateTime.Now.AddMonths(-1).Month)
                              .Select(c => new { c.Name, c.TotalPurchaseAmount });

        foreach (var customer in recentCustomers)
        {
            Console.WriteLine($"Name: {customer.Name}, TotalPurchageAmmount: {customer.TotalPurchaseAmount}");
        }

        Console.WriteLine("---------- Problem-2 ---------");
        // Prolem-2 -> Manage a list of orders and group them by product category. Calculate the total sales for each category.
        Order_P2 order_P2 = new Order_P2();
        var catagorySales = order_P2.GetAllOrders().GroupBy(o => o.Catagory)
                            .Select(grp => new { Catagory = grp.Key, TotalSales = grp.Sum(p => p.Price) });
        Console.WriteLine("Total catagory sales: ");
        foreach (var catagory in catagorySales)
        {
            Console.WriteLine($"Product catagory: {catagory.Catagory}, Total sales: {catagory.TotalSales} Rs.");
        }

        // Problem-3 -> Sort a list of products based on their prices using a lambda expression for custom sorting criteria.
        Console.WriteLine("-------- Problem-3 ------");
        Product_P3 product_P3 = new Product_P3();
        var sortedProducts = product_P3.GetAllProducts().OrderBy(p => p.ProductPrice);
        Console.WriteLine("List of Sorted products: ");
        foreach (var product in sortedProducts)
            Console.WriteLine($"Product name: {product.ProductName}, price: {product.ProductPrice}");

        //Problem 4 -> Filter a list of employees based on certain criteria using lambda expressions, such as selecting all employees with a salary above a certain threshold.
        Console.WriteLine("----- Problem-4 ------");
        Employee_P4 employee_P4 = new Employee_P4();
        decimal salaryThreshold = 55000;
        //var filteredEmployees = employee_P4.GetAllEmployees().Where(e => e.Salary > salaryThreshold);
        var filteredEmployees = employee_P4.GetAllEmployees().Where(e => e.Salary > 50000 && e.Salary < 70000);
        Console.WriteLine("Filtered employees based on salary: "); 
        foreach (var employee in filteredEmployees)
        {
            Console.WriteLine($"Employee name: {employee.Name}, salary: {employee.Salary}");
        }

        // Problem-5 -> Join two collections of data, such as a list of customers and their orders, to create a result set with combined information.
        Console.WriteLine("----- Problem-5 ------");
        Customer_P5 customer_P5 = new Customer_P5();
        Order_P5 order_P5 = new Order_P5();

        //var result = from customer in customer_P5.GeAllCustomers()
        //             join order in order_P5.GetAllOrders() on customer.Id equals order.CustomerId
        //             select new
        //             {
        //                 customer.Name,
        //                 customer.Id,
        //                 order.OrderId,
        //                 order.Amount
        //             };
        //Console.WriteLine("Customer details along with order details: ");
        //foreach (var item in result)
        //    Console.WriteLine($"Customer_Name: {item.Name}, Customer_Id: {item.Id}, " +
        //        $"Order_Id: {item.OrderId}, Order_Price: {item.Amount}");


        var result = customer_P5.GeAllCustomers().Join(order_P5.GetAllOrders(),  // GroupJoin will not work
                     customer => customer.Id,
                     order => order.CustomerId,
                     (customer, order) => new 
                     {
                         customer_Name = customer.Name,
                         customer.Id,
                         order_Id = order.OrderId,
                         order.Amount
                     });
        Console.WriteLine("Customer details along with order details: ");
        foreach (var item in result)
            Console.WriteLine($"Customer_Name: {item.customer_Name}, Customer_Id: {item.Id}, " +
                $"Order_Id: {item.order_Id}, Order_Price: {item.Amount}");

        // Problem-6 -> Utilize LINQ to group a list of transactions by date and calculate the total transaction amount for each date.
        Console.WriteLine("------ Problem-6 ------");
        Transactions_P6 transactions_P6 = new Transactions_P6();
        var ressult = transactions_P6.GetAllTransactions().GroupBy(t => t.TransactionDate)
                      .Select(grp => new
                      {
                          TransactionDate = grp.Key,
                          Total_Transactions_Amount = grp.Sum(g =>  g.Amount),
                      });
        Console.WriteLine("Transaction details: ");
        foreach (var transaction in ressult)
        {
            Console.WriteLine($"TransactionDate: {transaction.TransactionDate.ToString("dd-MM-yyyy")} -> Total_Transactions_Amount: {transaction.Total_Transactions_Amount}");
            //Console.WriteLine($"TransactionDate: {transaction.TransactionDate.ToShortDateString()} -> Total_Transactions_Amount: {transaction.Total_Transactions_Amount}");
           // Console.WriteLine($"TransactionDate: {transaction.TransactionDate.ToLongDateString()} -> Total_Transactions_Amount: {transaction.Total_Transactions_Amount}");
        }
        */

        //Console.WriteLine();

        // 6-4-2024
        // Problem - 1
        /*
        List<Student> students = new List<Student>()
        {
            new Student(){StudentId = 101, StudentName = "Tom", StudentGrades = new List<int>(){65,50,73,48,80,63}},
            new Student(){StudentId = 102, StudentName = "John", StudentGrades = new List<int>(){83,47,85,62,55,74}},
            new Student(){StudentId = 103, StudentName = "Scott", StudentGrades = new List<int>(){75,47,58,62,96,74}},
            new Student(){StudentId = 104, StudentName = "Miller", StudentGrades = new List<int>(){86,59,60,53,75,57}},

        };

        foreach (Student student in students)
        {
            var Gradesaverage = student.StudentGrades.Average();
            var MaxGrade = student.StudentGrades.Max();
            var MinGrade = student.StudentGrades.Min();

            Console.WriteLine("Student Name: " + student.StudentName);
            Console.WriteLine($"Grades average: {Gradesaverage}, Max grade: {MaxGrade}, Min grade: {MinGrade}");

        }

        Console.WriteLine("--------2nd problem ----------");

        // Problem - 2
        List<Product> products = new List<Product>()
        {
            new Product(){ProductId = 1, ProductName = "Mobile", ProductPrice = 15000, ProductQuantity = 45, CategoryId = 11, SupplierId = 21},
            new Product(){ProductId = 2, ProductName = "Shirt", ProductPrice = 650, ProductQuantity = 125, CategoryId = 12, SupplierId = 22},
            new Product(){ProductId = 3, ProductName = "Shoe", ProductPrice = 1499, ProductQuantity = 96, CategoryId = 13, SupplierId = 23},
            new Product(){ProductId = 4, ProductName = "Bluetooth", ProductPrice = 999, ProductQuantity = 36, CategoryId = 14, SupplierId = 24},

        };
        List<Catagory> categories = new List<Catagory>
        {
            new Catagory() { Id = 11, CatagoryName = "Electronics" },
            new Catagory { Id = 12, CatagoryName = "Clothing" },
            new Catagory { Id = 13, CatagoryName = "Shoes" }
        };

        List<Supplier> suppliers = new List<Supplier>
        {
            new Supplier { Id = 21, SupplierName = "Vivo" },
            new Supplier { Id = 22, SupplierName = "Puma" },
            new Supplier { Id = 23, SupplierName = "Nike" }
        };

        // Find low stock products
        var lowStockProducts = products.Where(product => product.ProductQuantity < 50);
        Console.WriteLine("Low stock products: ");
        foreach (var product in lowStockProducts)
            Console.WriteLine($"Product Name: {product.ProductName}, Product Quantity: {product.ProductQuantity}");
        Console.WriteLine("---------------------");

        
        foreach (Product product1 in products)
        {
            Console.Write("Product Name: " + product1.ProductName);
            Console.WriteLine(", Total Products price: " + (product1.ProductPrice * product1.ProductQuantity));
        }

        var TotalProductPrice = products.Sum(product => product.ProductPrice * product.ProductQuantity);
        Console.WriteLine("Total inventory value: " + TotalProductPrice);

        Console.WriteLine("-----------------------");
        var result = products.GroupBy(p => p.CategoryId);

        var result1 = products.GroupJoin(categories,
                product => product.CategoryId,
                catagory => catagory.Id,
                (product, catagory) => new { product, catagory }
            );
        //.Select(s=> new { })
        foreach(var grp in result1)
        {
            Console.WriteLine($"Name: {grp.product.ProductName}, count: {grp.catagory.Count()}");
        }


        // Problem-3
        //var numbers = Enumerable.Range(1, 100).Select(n =>
        //    {
        //        if (n % 3 == 0 && n % 5 == 0)
        //            return "FizzBuzz";
        //        else if (n % 3 == 0)
        //            return "Fizz";
        //        else if (n % 5 == 0)
        //            return "Buzz";
        //        else
        //            return n.ToString();
        //    });

        //foreach (var number in numbers)
        //{
        //    Console.WriteLine(number);
        //}
        */

        // 8-4-2024 -> FILE I/O
        //FileOperationsClass fileOperaions = new FileOperationsClass();
        //fileOperaions.FileOperations();
        //fileOperaions.CSVFileOperations();
        //fileOperaions.CS_JSON_FileOperations();

        // 10-4-2024 -> Data annotations & Regular expressions
        //DataAnnotations dataAnnotations = new DataAnnotations();
        //dataAnnotations.DataAnnotaionOperations();
        //dataAnnotations.DataAnnotaionOperations2();

        // 12-4-2024 -> MS Testing



        // 13-4-2024  -> Review day -> tasks
        //TaskProblems_13_4_24 taskProblems = new TaskProblems_13_4_24();

        //// Problem-1 -> file io
        //string filepath = @"F:\DotNet\DotNetProjects\FirstFroject\_24_4_13\file1.txt";
        //taskProblems.FileOpeartion(filepath);

        //// Problem-2 -> date format vaalidaation
        //string[] dates = { "2024-04-13", "04/5/1900", "13-04-24", "13-04-2024", "2024/04/13", "20324-04-13", "04/143/2024", "123-04-2024", "2024 04 13",
        //                 "2024-2-25", "8/10/2004", "13.04.1862", "1-4-1857", "2024/7/7"};

        //List<string> matchedDates = new List<string>();
        //foreach (string date in dates)
        //{
        //    if (taskProblems.DateFormatValidation(date)) 
        //        matchedDates.Add(date);
        //    else
        //        Console.WriteLine($"Incorrect date: {date}");
        //}

        //Console.WriteLine("Matched Dates: ");
        //foreach (string date in matchedDates)
        //    Console.WriteLine(date);

        //// Problem-3 -> MS Testing
        ///

        // 15-4-2024

        // 20-4-2024 -> 4th Review -> complete topics till now

        TaskProblems_20_4_24 taskProblems_20_4_24 = new TaskProblems_20_4_24();

        // Problem-1
        Console.WriteLine("------- Problem-1 ---------");
        int cost = taskProblems_20_4_24.CalculateShippingCost(20,"domestic",8);
        Console.WriteLine("Cost: " + cost);

        // Problem-2
        Console.WriteLine("------- Problem-2 ---------");
        int[] intArr = { 1, 4, 2, 6, 0, 8, 6, 8, 9 };
        string[] stringArr = { "white", "yellow", "green", "red" };

        object[] objectArr = { 1, "hgd", 34.74, 'u' };

        taskProblems_20_4_24.ReverseArray(intArr);
        taskProblems_20_4_24.ReverseArray(stringArr);
        taskProblems_20_4_24.ReverseArray(objectArr);

        // Problem-3
        Console.WriteLine("------- Problem-3 ---------");
        List<Sales> sales = new List<Sales>
        {
            new Sales {ProductName = "Mobile", ProductQuantity = 10, ProductPrice = 18000},
            new Sales {ProductName = "Watch", ProductQuantity = 15, ProductPrice = 1200},
            new Sales {ProductName = "Shoe", ProductQuantity = 50, ProductPrice = 1500},
            new Sales {ProductName = "Mobile", ProductQuantity = 5, ProductPrice = 15000},
            new Sales {ProductName = "Watch", ProductQuantity = 20, ProductPrice = 900},
            new Sales {ProductName = "Mobile", ProductQuantity = 30, ProductPrice = 25000},
        };

        var saleTransaction = sales.GroupBy(product => product.ProductName)
                            .Select(grp => new {
                                name=grp.Key, 
                                TotalQuantities=grp.Sum(p=>p.ProductQuantity),
                                TotalCount = grp.Count(),
                                TotalRevenue = grp.Sum(p => (p.ProductQuantity * p.ProductPrice) 
                                )});

        foreach (var product in saleTransaction)
        {
            Console.WriteLine($"ProductName: {product.name}, ProductCount: {product.TotalCount}, " +
                $"TotalProductQuantities: {product.TotalQuantities}, " +
                $"TotalProductRevenue: {product.TotalRevenue}");
        }


        // Problem-4
        Console.WriteLine("------- Problem-4 ---------");




    }
}








