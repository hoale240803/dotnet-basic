using System;

namespace CS006_Exception
{
    class Program
    {



        class DataToolong : Exception
        {

            const string TOO_LONG_MESSAGE = "DỮ LIỆU QUÁ DÀI";
            public DataToolong() : base(TOO_LONG_MESSAGE)
            {

            }
        }
        static void Main(string[] args)
        {
            // try
            // {
            //     int[] arr = new int[] { 1, 3, 3 };
            //     int temp = arr[10];
            //     System.Console.WriteLine(temp);
            // }
            // catch (System.Exception ex)
            // {

            //     System.Console.WriteLine(ex.Message);
            //     System.Console.WriteLine("stacktrace");
            //     System.Console.WriteLine(ex.StackTrace);
            //     System.Console.WriteLine("source");
            //     System.Console.WriteLine(ex.Source);
            // }

            //CUSTOM EXCEPTION
            System.Console.WriteLine("Nhập tên của bạn");
            string name = Console.ReadLine();

            if (name.ToString().Length > 10)
            {
                throw new DataToolong();
            }
            else
            {

                System.Console.WriteLine("không có chuyện gì xảy ra");
            }



        }
    }
}
