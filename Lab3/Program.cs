using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    partial class Car
    {
        readonly Guid id;
        string Marka;
        private string Model;
        private int age;
        const string color = "Black";
        private string number;
        public Guid idd;
        static int count = 0;
        public void vivod()
        {
            Console.WriteLine(age);
        }
        


        string Marka_;
        private string Model_;
        private int age_;
        private string number_;
    }
    partial class Program
    {
        static void Main(string[] args)
        {
            Car forExample = new Car();
            forExample.GetInfo();
            Console.WriteLine("----------------------------");
            Car BMW = new Car("BMW", "X5", 7);
            BMW.GetInfo();
            Console.WriteLine("----------------------------");
            Car Mazda = new Car();
            Mazda.GetInfo();
            Console.WriteLine("----------------------------");


            Car machine = new Car();
            machine.Age = 44;
            //machine.marka = "Lamborgini";
            machine.model = "Diablo";
            machine.Number = "993ZXC";
            int a = machine.Age;
            string b = machine.marka;
            string c = machine.model;
            string d = machine.Number;
            
            Console.WriteLine($"Get-set\n-------------------\nИнфа о машине:\nМарка - {b}\nМашине {a} лет\nМодель машины - {c}\nНомер машины - {d} ");
            Console.WriteLine("\n\n\n-----------------------");

            
            
            Console.WriteLine("---------------------------");
            Console.WriteLine("Действия с объектами:");
            Console.WriteLine($"Тип объекта forExample: {forExample.GetType().Name}");
            Console.WriteLine($"Тип объекта machine: {machine.GetType().Name}");
            if (forExample.GetType() == typeof(Car))
            {
                Console.WriteLine("for Example Type = Type Class");
            }
            if (machine.GetType() == typeof(Car))
            {
                Console.WriteLine("machine Type = Type Class");
            }

            Console.WriteLine("Сравнение объектов---------------");
            if (forExample.Equals(machine) == false)
            {
                Console.WriteLine("Объект fEx != machine");
            }
            else Console.WriteLine("Объекты равны");

            Console.WriteLine("\n\n\n\n\nСтроковое представление объектов:");
            Console.WriteLine($"obj1 = {forExample.ToString()}");
            Console.WriteLine($"obj2 = {machine.ToString()}");
            Console.WriteLine("Хэш-коды объектов");
            Console.WriteLine($"obj1 = {forExample.GetHashCode()}");
            Console.WriteLine($"obj2 = {machine.GetHashCode()}");
            Console.WriteLine($"\n\n\nКоличество созданных объектов = ");
            Car count = new Car();
            count.Count();

            Console.WriteLine("------Массив объектов------");
            int size = 5;
            Car[] anoth = new Car[size];
            anoth[0] = new Car("Mazda", "tx", 12);
            anoth[1] = new Car("Mazda", "sd", 5);
            anoth[2] = new Car("BMW", "sd", 22);
            anoth[3] = new Car("BMW", "X5", 2);
            anoth[4] = new Car("Mazda", "X5", 14);
            Console.WriteLine("Введите марку автомобиля (Mazda, BMW)");
            string s = Console.ReadLine();
            if (s == "Mazda")
            {
                anoth[0].GetInfo();
                anoth[1].GetInfo();
                anoth[4].GetInfo();
                
            }
            else if (s == "BMW")
            {
                anoth[2].GetInfo();
                anoth[3].GetInfo();

            }
            else Console.WriteLine("Отсутствует в БД");
            Console.WriteLine("Введите выбранную модель (tx, sd, X5)");
            string k = Console.ReadLine();
            Console.WriteLine("Укажите срок эксплуатации");
            string n = Console.ReadLine();
            int m = Convert.ToInt32(n);
            if (k == "tx" && m >= 10)
            {
                anoth[0].GetInfo();
            }
            else if (k == "sd" && m >= 10)
            {
                anoth[2].GetInfo();
            }
            else if (k == "BMW" && m >= 10)
            {
                anoth[4].GetInfo();
            }
            else Console.WriteLine("Таких машин нет");
            int x = 22;
            int y = 35;
            int z;
            reff_out(ref x, y, out z);
            Console.WriteLine($"ref-out в методе: { z}");
            Console.WriteLine("Анонимный тип:");
            
            
        var autocar = new { Markaa = "Lambogrini", Model = "Diablo", agee = 7, color = "Green", numb = "1000-7" };
            Console.WriteLine(autocar);      
        Console.ReadKey();
        }
        static void reff_out(ref int x, int y, out int z )
            {
                z = x-y;
            }
    }
}
