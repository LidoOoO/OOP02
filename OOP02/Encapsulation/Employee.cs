using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Encapsulation
{
    internal struct Employee
    {
        #region Atributes

        public int Id;
        private string? EmpName;
        private decimal Empsalary;

        #endregion

        //Encapsulation => Separate data Defination [Definiton]
        //From Its Use [Getter , Setter] - [property]

        #region 1. Apply Encapsulation [Getter , Setter]
        // a. Private attributes
        // b. two Functions Getter - Setter

        //Getter

        public string? GetName()
        {
            return EmpName;
        }

        //Setter

        public void SetName(string? name)
        {
            EmpName = name?.Length > 5 ? name.Substring(0, 5) : name;
        }


        #endregion

        #region 2. Apply Encapsulation [Property]

        //2.1 Full Property
        //2.2 Automatic Property 
        //2.3 Indexer

        public decimal Salary
        {
            get { return Empsalary; }
            set { Empsalary = value; }
        }

        //// Full Property [ Attribute - Property ]
        //private int age; 
        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }

        //}

        //public int Age; // Attribute

        //Automatic Property
        public int Age { get; set; } //Property  
                                     // Compiler Will Generate Hidden Private Attribute [Backing Field]

        // Full Property => PropFull

        // Automatic Property => Prop

        public string? Test { get; set; }

        #endregion


        //private decimal deduction; // [Derived Attribute]

        public decimal Deduction //Readonly Property
        {
            get { return Salary * 0.2M; }

        }



        #region Constructors
        public Employee(int id, string name, decimal salary, int age)
        {
            Id = id;
            EmpName = name;
            Empsalary = salary;
            Age = age;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id = {Id} \nName = {EmpName} \nSalary = {Empsalary:c}\nAge = {Age}";
        }
        #endregion

    }
}
