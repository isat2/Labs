using System;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {  //1A--------------------------
           //int a = -7;
           //uint a1 = 3;
           //long b = -3994;
           //ulong b1 = 4433;
           //float c = 16.43F;
           //double d = 22.345;
           //short asd = -22;
           //Console.WriteLine($"int = { a},  uint =  { a1},  long =  {b},  ulong =  {  b1},  float =  {c},  double =  {d}, short =  {asd}");
           //ushort asds = 22;
           //char x = 'y';
           //Console.WriteLine("Введите строку");
           //string xx = Console.ReadLine();
           //Console.WriteLine($"string = {xx}");
           //byte f = 255;
           //bool l = false;
           //sbyte f1 = -13;
           //decimal cc = 33.8m;
           //Console.WriteLine($"ushort = { asds},  char =  { x},  byte =  {f},  bool =  {  l},  sbyte =  {f1},  decimal =  {cc}");

            ////---------------------------

            ////1B--------------------

            //ushort A = 4;
            //uint B = (uint)A;

            //byte A1 = 243;
            //int B1 = (int)A1;

            //sbyte A2 = -13;
            //int B2 = (int)A2;

            //double A3 = 2.88;
            //float B3 = (float)A3;

            //sbyte A4 = 22;
            //ushort B4 = (ushort)A4;

            //Console.WriteLine($"B = { B},  B1 =  { B1},  B2 =  {B2},  B3 =  {  B3},  B4 =  {B4}");
            ////----------------------------Yavnoe/neyavnoe;

            //int AA = 2;
            //float BB = AA;

            //byte AA1 = 2;
            //ushort BB1 = AA1;

            //sbyte AA2 = -4;
            //short BB2 = AA2;

            //int AA3 = 10;
            //long BB3 = AA3;

            //char AA4 = '2';
            //decimal BB4 = AA4;
            //Console.WriteLine($"BB = { BB},  BB1 =  { BB1},  BB2 =  {BB2},  BB3 =  {  BB3},  BB4 =  {BB4}");
            ////--------------Convert

            //int n = Convert.ToInt32(2.33);
            //sbyte p = Convert.ToSByte("123");
            //Console.WriteLine($"n = {n}, p = {p}");



            ////1C------------------Boxing/unboxing

            //int X = 5;
            //object T = X;
            //byte R = (byte)(int)T;
            //Console.WriteLine($"R = {R}");

            ////1D--------------

            //var V = 25;
            //var Q = "QQ";
            //Console.WriteLine(V.GetType());
            //Console.WriteLine(Q.GetType());
            //Console.WriteLine($"V + Q = {V}+{Q}");

            ////1E------------------

            //int? m = 32;
            //Nullable<int> m1 = 64;
            //int? dd = m + m1;
            //float? n1 = 44.3F;
            //Nullable<float> nn = 33.22f;
            //float? ff = n1 + nn;
            //Console.WriteLine($"Nullable ints: {dd}; \nNullable Floats: {ff}");

            //1F-----------------

            //var Da = 48;
            //char x3 = Da;
            //Console.WriteLine($"Var: {x3}");






            ////2A----------------------------------------------------------


            //Console.WriteLine("Введите строки для сравнения");
            //string one = Console.ReadLine();
            //string two = Console.ReadLine(); ;
            //int result = string.Compare(one, two);
            //if (result > 0)
            //{
            //    Console.WriteLine($"Вторая строка выше первой - {result}");
            //}
            //else if (result < 0)
            //{
            //    Console.WriteLine($"Первая строка выше второй - {result}");
            //}
            //else
            //{
            //    Console.WriteLine($"Строки идентичны - {result}");
            //}


            //2B------------------------

            //            string odin = "I enjoy C#";
            //            string dva = " I don't hate rap ";
            //            string tri = " C#,is,cool ";
            //            Console.WriteLine(odin);
            //            Console.WriteLine(dva);
            //            Console.WriteLine(tri);


            //            Console.WriteLine(odin + dva + tri + " - Объединение строк");

            //            string chetire = string.Copy(dva);
            //            Console.WriteLine($"Copied string: {chetire}");

            //            dva = dva.Substring(5);
            //            Console.WriteLine($"Выделение подстроки:  {dva}");


            //            char[] delChars = {','};
            //            string[] words = tri.Split(delChars);
            //            foreach(var word in words)
            //{
            //               Console.WriteLine($"-{word}-");
            //            }

            //            string shest = odin.Insert(5, tri);
            //            Console.WriteLine("Вставка подстроки: ");
            //            Console.WriteLine(shest);


            //            string sem = odin.Remove(0, 8);
            //            Console.WriteLine("Удаление элементов в строке \"I enjoy C#\": " + sem);


            //            //2C-----------------------

            //            string empty = "";
            //            string nul = null;
            //            string sum = nul + empty;

            //            Console.WriteLine("Пустая строка:" + string.IsNullOrEmpty(empty));
            //            Console.WriteLine("Null-строка:" + string.IsNullOrEmpty(nul));
            //            Console.WriteLine("Null+empty-string = " + sum);
            //            int result = string.Compare(empty, nul);
            //            Console.WriteLine($"Сравнение нулевой и пустой строки - " + result);

            //            //2D------------------------------

            //            StringBuilder sb = new StringBuilder("ZXCGHOUL1000-7", 50);
            //            sb.Remove(3, 5);
            //            Console.WriteLine("Удаление символов: " + sb);
            //            sb.Insert(0, "Упырь");
            //            sb.Insert(14, "Shadow");
            //            Console.WriteLine("Добавление в начало и конец: " + sb);
            //            Console.ReadKey();



            //3A--------------------------------

            //int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //int rows = arr.GetUpperBound(0) + 1;
            //int colums = arr.Length / rows;
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < colums; j++)
            //    {
            //        Console.Write($"{arr[i, j]} \t");
            //    }
            //    Console.WriteLine();

            //}

            //3B---------------------------

            //string[] arrString = { "One", "Two", "Three", "Four" };

            //foreach (string y in arrString)
            //{
            //    Console.Write(y + "\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Длина строкового массива: " + arrString.Length);



            //Console.WriteLine("Какой элемент массива нужно поменять?");
            //string p = Console.ReadLine();
            //int p1 = Convert.ToInt32(p);

            //switch (p1)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("Что вставить вместо этого элемента?");
            //            string qq = Console.ReadLine();
            //            string [] newarrString = { qq, "Two", "Three", "Four" };
            //            for (int m = 0; m < 4; m++)
            //            {
            //                Console.Write(newarrString[m] + "\t");
            //            }
            //            break;
            //        }
            //    case 2:
            //        { 
            //        Console.WriteLine("Что вставить вместо этого элемента?");
            //        string qq = Console.ReadLine();
            //            string[] newarrString = { "One", qq, "Three", "Four" };
            //            for (int m = 0; m < 4; m++)
            //            {
            //                Console.Write(newarrString[m] + "\t");
            //            }
            //            break;
            //        }
            //    case 3:
            //        { 
            //        Console.WriteLine("Что вставить вместо этого элемента?");
            //        string qq = Console.ReadLine();
            //            string[] newarrString = { "One", "Two", qq, "Four" };
            //            for (int m = 0; m < 4; m++)
            //            {
            //                Console.Write(newarrString[m]+"\t");
            //            }
            //            break;
            //         }
            //    case 4:
            //        {
            //            Console.WriteLine("Что вставить вместо этого элемента?");
            //            string qq = Console.ReadLine();
            //            string[] newarrString = { "One", "Two", "Three", qq };
            //            for (int m = 0; m < 4; m++)
            //            {
            //                Console.Write(newarrString[m] + "\t");
            //            }
            //            break;
            //        }
            //    default:
            //        Console.WriteLine("Ошибка");
            //        break;
            //}


            //3C-----------------------

            //double[][] mas = new double[3][];
            //mas[0] = new double[2];
            //mas[1] = new double[3];
            //mas[2] = new double[4];

            //Console.WriteLine("Введите значения для ступенчатого массива: ");

            //for (int i = 0; i<mas.Length;i++)
            //{
            //    for (int j=0; j<mas[i].Length;j++)
            //    {
            //        mas[i][j] = double.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < mas.Length; i++)
            //{
            //    for (int j = 0; j < mas[i].Length; j++)
            //    {
            //        Console.Write(mas[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.ReadKey();
            //}

            //3D-------------------

            //var A = new[] { 'a', 'b', 'c', 'd' };
            //var B = new[] { 1, 2, 3, 4, 5 };
            //var C = new[] { "Yes", "Of course", "I did it" };
            //var Stroka = "Hello guys!)";

            //Console.WriteLine(A);
            //for (int i = 0; i < B.Length; i++)
            //{
            //    Console.Write(B[i]);
            //}
            //Console.WriteLine();
            //for (int k = 0; k < C.Length; k++)
            //{
            //    Console.Write(C[k] + '\t');
            //}
            //Console.WriteLine();
            //Console.WriteLine(Stroka);





            //4A------------------------------------

            (int, string, char, string, ulong) tuple = (22, "Vladik", 'A', "AlohaDance", 38838392);

            //4B--------------------------------
            Console.WriteLine("Кортёж целиком: " + tuple);
            Console.WriteLine("Кортёж выборочно: " + tuple.Item1 + ' ' + tuple.Item3 + ' ' + tuple.Item4);

            //4C------------------------
            var (numb, name, symn, nickname, longnumb) = (22, "Vlad", 's', "resp", 22282);
            Console.WriteLine("Первый элемент кортежа: " + numb);

            int qq;
            string ww;
            float ee;
            (qq, ww, ee) = (11, "Yes", 45f);
            Console.WriteLine($"{qq} + {ww} + {ee}");

            Console.WriteLine("Введите значение для \"_\"");
            var _ = int.Parse(Console.ReadLine());
            Console.WriteLine(_);


            //4D-----------------

            var Tuple2 = (33, "ASD", 'A');
            var Tuple3 = (2, "ss", 'B');
            if (Tuple2 == Tuple3)
            {
                Console.WriteLine("Первый кортеж равен второму");
            }
            else
            {
                Console.WriteLine("Кортежи не равны");
            }
            Console.WriteLine(((IComparable)Tuple2).CompareTo(Tuple3));





            Console.ReadKey();


        }
  
    }

}
