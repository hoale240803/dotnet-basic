using System;

namespace CS007_IDisposed
{


    class FileManager : IDisposable
    {
        public void getFileFromCloud(string id, string cloud)
        {
            System.Console.WriteLine($"getFileFromCloud:::::: đang lấy file {id} từ {cloud}............");
            System.Console.WriteLine("getFileFromCloud::::: lấy xong rồi");
        }
        public void Dispose()
        {
            System.Console.WriteLine("hàm này tự động gọi sau khi hết using");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bắt đầu xử lý file.......");
            using (var a = new FileManager())
            {
                System.Console.WriteLine("do somthing");
                a.getFileFromCloud("01", "aws");

            }
        }
    }
}
