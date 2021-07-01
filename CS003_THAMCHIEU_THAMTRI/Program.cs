using System;

namespace CS003_THAMCHIEU_THAMTRI
{
    class Program
    {
        // TRUYỀN THAM SÔ VỚI TÊN
        public static string getFullName(string ten, string tenDem, string ho)
        {
            return ho + (tenDem.Equals("") ? " " : " " + tenDem + " ") + ten;
        }
        //THAM CHIẾU


        public static void getMultifyThamChieu(ref int a)
        {
            a = a * a;
            System.Console.WriteLine(a);
        }
        public static void getMultifyThamTri(int a)
        {

            a = a * a;
            System.Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // THAM TRỊ
            // CASE1: KHÔNG CÓ TÊN ĐỆM
            System.Console.WriteLine(getFullName(ten: "Hoa", ho: "Le", tenDem: ""));
            // CASE2: CÓ TÊN ĐỆM
            System.Console.WriteLine(getFullName(ten: "Hoa", ho: "Le", tenDem: "Van"));





            // System.Console.WriteLine(getMultify1(2));

            // System.Console.WriteLine(intValue);

            int intValue = 2;
            // THAM CHIẾU
            // getMultifyThamChieu(ref intValue);

            // System.Console.WriteLine(intValue);
            // THAM TRỊ
            getMultifyThamTri(intValue);

            System.Console.WriteLine(intValue);
        }
    }
}
