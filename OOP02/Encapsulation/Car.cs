using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Encapsulation
{
    internal class Car
    {

        #region Properties

        public int Id { get; set; } // 4 Bytes

        public string? Model { get; set; } // 4 Bytes

        public double Speed { get; set; } // 8 Bytes

        #endregion


        #region Constructors


        public Car()
        {
            
        }
        public Car(int id, string model, double speed)
        {
            Console.WriteLine("CTOR1");
            Id = id;
            Model = model;
            Speed = speed;
        }

        // Constructor Chaining 
        public Car(int id , string model):this(id , model , 190){ Console.WriteLine("CTOR2"); }

        public Car(int id):this(id , "Audi" , 200){ Console.WriteLine("CTOR3"); }
        #endregion


        #region Methods

        public override string ToString()
        {
            return $"CarId : {Id}\nModel : {Model}\nSpeed : {Speed}";
        }
        #endregion
    }
}
