using OOP02.Encapsulation;

namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation  


            //// Employee employee = new Employee(10 , "Waleed" , 21600);
            //Employee employee = new Employee(name : "Waleed" , id: 10 , salary: 2100 , age : 25);

            #region EX01

            ////// Id = 10
            ////// Name = Waleed
            ////// Salary = $21,600.00
            ////Console.WriteLine(employee);
            ////employee.Id = 20; // Set Directly Through Attribute
            ////Console.WriteLine(employee.Id); // Get Id Directly Through Attribute


            ////employee.Id = 2000; // Set Id Directly Through Attribute
            ////Console.WriteLine(employee.Id); // Get Id Directly Through Attribute


            //////employee.Name = "Mahmoud"; // Invalid
            ////employee.SetName("Mahmoud"); // Set Name Using Setter Method

            //////Console.WriteLine(employee.Name); // Invalid
            ////Console.WriteLine(employee.GetName()); // Get Name Using Getter Nethod
            ////employee.salary = 1000; // Invalid 

            //employee.Salary = 6000; // Set Salary Using Property [As a Setter]
            //Console.WriteLine(employee.Salary); // Get Salary Using Property [As a getter]
            ////Recommended => As It Easy To Use Like Attributes


            //employee.Age = 25;


            //Employee employee = new Employee(10 , "Waleed" , 6000 , 30);
            //Console.WriteLine(employee);
            //Console.WriteLine("==================");
            //Console.WriteLine(employee.Deduction);

            //Employee employee1 = new Employee(20 , "Ahmed" , 9000 , 25);

            //Console.WriteLine(employee1);

            //Console.WriteLine("=================");
            //Console.WriteLine(employee1.Deduction); 
            #endregion
            #endregion


            #region Getter - Setter

            Phonebook Note = new Phonebook(3);


            Note.AddPerson(0, "Waleed", 123);
            Note.AddPerson(1, "Mahmoud", 456);
            Note.AddPerson(2, "Mohamed", 789);

            int PhoneNumber = Note.GetPersonNumber("Mohamed"); //789

            Console.WriteLine(PhoneNumber == -1 ? "Not Found" : PhoneNumber);

            Note.SetPersonNumber("Mohamed", 999); // Set Number Using Setter Method

            Console.WriteLine(Note.GetPersonNumber("Mohamed")); // Get Number Using Getter 
            #endregion


        }
    }
}
