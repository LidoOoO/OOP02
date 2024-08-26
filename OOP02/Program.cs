namespace OOP02
{
    internal class Program
    {
        #region Part 01

        //internal struct Employee
        //{


        //    private int Id;
        //    private string Name;
        //    private string Phone;


        //    public int GetId()
        //    {
        //        return Id;
        //    }

        //    public void SetId(int value)
        //    {
        //        Id = value;
        //    }



        //    public Employee(int id, string name, string phone)
        //    {
        //        Id = id;
        //        Name = name;
        //        Phone = phone;
        //    }



        //    public override string ToString()
        //    {
        //        return $"Name = {Name}\nId = {Id}\nphone = {Phone}";
        //    }
        //}

        //internal struct PhoneBook
        //{
        //    #region Attributes

        //    private string[] Names;
        //    private int[] Numbers;
        //    #endregion

        //    #region Properties

        //    public int Size { get; }

        //    #endregion

        //    #region Constructor

        //    public PhoneBook(int size)
        //    {
        //        Size = size;
        //        Names = new string[Size];
        //        Numbers = new int[Size];    
        //    }


        //    public int this[string name]
        //    {
        //        get {
        //        if(Names is not null && Numbers is not null)
        //                for(int i = 0; i < Numbers.Length; i++)
        //                    if (Names[i] == name)
        //                        return Numbers[i];
        //        return -1;
        //        }
        //        set {
        //            if (Names is not null && Numbers is not null)
        //                for (int i = 0; i < Numbers.Length; i++)
        //                    if (Names[i] == name)
        //                    {
        //                        Numbers[i] = value;
        //                        break;
        //                    }
        //        }
        //    }
        //    #endregion

        //    #region Methods

        //    public void AddPerson(int Position , string PersonName , int PhoneNumber)
        //    {
        //        if(Names is not null && Numbers is not null)
        //        {
        //            if((Position - 1) <= Size && (Position - 1) >= 0)
        //            {
        //                Names[Position - 1] = PersonName;
        //                Numbers[Position - 1] = PhoneNumber;
        //                //Console.WriteLine("true {0}" , Position);
        //            }
        //        }
        //    }


        //    public int GetPerson(string PersonName)
        //    {
        //        if (Names is not null && Numbers is not null)
        //        {
        //            for (int i = 0; i < Numbers.Length; i++)
        //            {
        //                if (Names[i] == PersonName)
        //                {
        //                    return Numbers[i];
        //                }
        //            }
        //        }
        //            return -1;
        //    }


        //    public void SetNewNumber(string PersonName , int NewNumber)
        //    {
        //        if(Names is not null && Numbers is not null)
        //        {
        //            for(int i = 0; i < Numbers.Length; i++)
        //            {
        //                if (Names[i] == PersonName)
        //                {
        //                    Numbers[i] = NewNumber;
        //                    break;
        //                }
        //            }
        //        }
        //    }


        //    public override string ToString()
        //    {
        //        string result = "";

        //        for (int i = 0; i < Numbers.Length; i++)
        //        {
        //            result += $"This Name: {Names[i]}\nThis Number: {Numbers[i]}\n===========\n";
        //        }

        //        return result;
        //    }
        //    #endregion
        //}

        #endregion

        static void Main(string[] args)
        {
            #region Part 01

            #region Ex 01
            //Employee employee = new Employee(22, "Waleed", "01229210418");


            // Console.WriteLine(employee);

            #endregion

            #region Ex 02

            //PhoneBook Note = new PhoneBook(3);

            //Note.AddPerson(1, "Waleed", 123);
            //Note.AddPerson(2, "Mahmoud", 456);
            //Note.AddPerson(3, "Mohamed", 789);


            //int number = Note.GetPerson("Mahmoud");
            ////Console.WriteLine(number == -1 ? "Not Found" : number);
            //Note.SetNewNumber("Mahmoud", 999);
            //number = Note.GetPerson("Mahmoud");
            //Console.WriteLine(number == -1 ? "Not Found" : number);
            #endregion

            #region Ex 03

            //Console.WriteLine(Note["Waleed"]);
            //Note["Waleed"] = 666;
            //Console.WriteLine(Note["Waleed"]);
            //Console.WriteLine(Note);
            #endregion

            #endregion

            #region Part 02

            #region 1. Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] persons = new Person[3];

            //persons[0] = new Person{ Name = "waleed", Age = 22 };
            //persons[1] = new Person{ Name = "Mahmoud", Age = 57 };
            //persons[2] = new Person{ Name = "Ali", Age = 14 };

            //for(int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine(persons[i].ToString());
            //}

            #endregion


            #region 2. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] persons = new Person[3];


            //for (int i = 0; i < persons.Length; i++)
            //{
            //    string Name = "";
            //    int Age = 0;
            //    bool flag = false;
            //    do
            //    {


            //        Console.Write($"please Enter A Name For Person {i + 1} : ");

            //        Name = Console.ReadLine();

            //    } while (int.TryParse(Name, out _) || double.TryParse(Name, out _) || string.IsNullOrEmpty(Name));
            //    do
            //    {
            //        Console.Write($"please Enter A Age For Person {i + 1} : ");

            //        flag = int.TryParse(Console.ReadLine(), out Age);

            //    } while (!flag || Age <= 0);
            //    Console.WriteLine("==================");
            //    persons[i] = new Person { Name = Name, Age = Age };
            //}

            //int max = 0;
            //int index = 0;

            //for (int i = 0; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > max)
            //    {
            //        max = persons[i].Age;
            //        index = i;
            //    }
            //}

            //Console.WriteLine($"{persons[index]}\nThis Is Max" );




            #endregion

            #endregion

            #region Part 03

            Employee[] employees = new Employee[3];

            employees[0] = new Employee { 
            ID = 1,
            Name = "Waleed",
            SecurityLevel = SecurityLevel.DBA,
            Salary = 8740,
            HireDate = new HireDate(13 , 11 , 2022),
            Gender = Gender.Male
            };
            
            employees[1] = new Employee { 
            ID = 2,
            Name = "Mahmoud",
            SecurityLevel = SecurityLevel.Secretary,
            Salary = 45678m,
            HireDate = new HireDate(5 , 12 , 2000),
            Gender = Gender.Male
            };
            
            employees[2] = new Employee { 
            ID = 3,
            Name = "Hanin",
            SecurityLevel = SecurityLevel.Guest,
            Salary = 7646,
            HireDate = new HireDate(5 , 1 , 2006),
            Gender = Gender.Female
            };



            Array.Sort(employees);

            for(int i = 0; i < employees.Length; i++)
            {
            Console.WriteLine($"        Emloyee {i + 1}\n\n{employees[i]}\n");
            

            }

            #endregion



        }
    }
}
