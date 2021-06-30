using System;

namespace CS002_VariablesConstantsIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            string a = "hello world, my name is Hoa";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine(a);
            Console.ResetColor();
            System.Console.WriteLine("after reset color");


            //WRITELINE WITH VALUE

            int aa = 12;
            double b = 1.12321;
            System.Console.WriteLine($"a={aa}, b={b}");

            // READLINE()
            // string name = "";
            // System.Console.WriteLine("Enter name:");
            // name = Console.ReadLine();
            // System.Console.WriteLine($"Welcome {name} to my world!");

            // CONVERT DATA TYPE

            int intValue = 123;
            float floatValue = 123.345f;
            string strValue = "14123";
            string errValue = "sdfa";

            System.Console.WriteLine("HIEN THI CONVERT DATA TO INT");
            System.Console.WriteLine($"Gia tri cua strValue la: {Convert.ToInt32(strValue)}");
            System.Console.WriteLine($"Gia tri cua floatValue la: {Convert.ToInt32(floatValue)}");
            // try
            // {
            //     System.Console.WriteLine($"Gia tri cua floatValue la: {Convert.ToInt32(errValue)}");
            // }
            // catch (System.Exception ex)
            // {

            //     System.Console.WriteLine(ex);
            // }


            // BIẾN NGẦM ĐỊNH

            var bien1 = 3.14;                                           // biến sẽ có kiểu double
            var bien2 = 3;                                              // biến sẽ có kiểu int
            var bien3 = "Biến khai báo với var phải khởi tạo ngay";     // string
            var bien4 = (5 < 4);                                        // bool

            Console.ReadKey();
        }
    }
}
