using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    partial class Car
    {

        public string marka
        {
            get { return Marka_;  }
            private set { Marka_ = value; }
        }
        public int Age
        {
            get { return age_; count++; }
            set { age_ = value; }
        }
        public string model
        {
            get { return Model_; }
            set { Model_ = value; }
        }
        public string Number
        {
            get { return number_; }
            set { number_ = value; }
        }



        public void GetInfo()
        {
            Console.WriteLine($"Марка машины - {Marka} \nМодель машины - {Model}\nВозраст машины - {age}");
            count++;
        }
        public Car(string n, string m, int k) { Marka = n; Model = m; age = k; count++; }

        public Car() { Marka = "Mazda"; Model = "RX-8"; age = 5; count++; }

        public void  Count()
        {
            Console.WriteLine($"the number of objects = {count}");
        }


        private Car(object k)
        {
            Console.WriteLine($"Вызван закрытый конструктор\n-----------------------");
        }
        static Car()
        {
            Console.WriteLine($"Вызов static конструктора с CONST переменной - {color}\n-------------------");
            object a = new Car(25);
        }

    }
}

    
