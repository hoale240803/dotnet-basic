using System;

namespace CS004_DELEGATE
{
    class Program
    {

        public delegate void ShowLog(string message);

        public static void ShowWarning(string warning)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("warning: " + warning);
            Console.ResetColor();
        }
        public static void ShowInfo(string info)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("info " + info);
            Console.ResetColor();
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static void TinhTong(int a, int b)
        {
            Func<int, int, int> TinhTongDelegate;

            TinhTongDelegate = Sum;
            int result = TinhTongDelegate(a, b);
            System.Console.WriteLine($"tong là:{result}");

        }



        public static void TinhTongCallback(int a, int b, Action<string> tinhNhan)
        {
            int tong = a + b;
            tinhNhan((tong * 2).ToString());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ShowLog showLog = null;
            // showLog = ShowInfo;
            // showLog("Warning !!!");

            // showLog = ShowWarning;
            // showLog("Info !!!");

            // GÁN NHIỀU PHƯƠNG THỨC VÀO DELEGATE

            showLog += ShowInfo;
            showLog += ShowInfo;
            showLog += ShowWarning;

            showLog -= ShowInfo;

            showLog("xxx");


            // Func và Action mà không cần khai báo
            //Action tương tự như Func, điều khác duy nhất là nó ***không có kiểu trả về***
            TinhTong(6, 3);
            // CALLBACK
            TinhTongCallback(2, 4, ((x) => { System.Console.WriteLine($"tồng 2 số và nhân 2 là : {x}"); }));

        }
    }
}
