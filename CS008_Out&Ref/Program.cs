using System;

namespace CS008_Out_Ref
{
    // interface Animals
    // {
    //     void bake();
    // }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         int a;
    //         //Console.WriteLine("Gia tri cua a la: " +a);
    //         DemoOut(out a);
    //         Console.WriteLine("Gia tri cua a bay gio la: " + a);
    //         Console.ReadLine();

    //     }
    //     static void DemoOut(out int value)
    //     {
    //         value = 5;
    //         value += 5;

    //         Console.WriteLine("Gia tri cua a sau khi thay doi la: " + value);
    //     }
    // }

    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sc = new SampleClass();
            IControl ctrl = new SampleClass();
            ISurface srfc = new SampleClass();

            sc.Paint();
            ctrl.Paint();
            srfc.Paint();
        }

        interface IControl
        {
            void Paint();
        }
        interface ISurface
        {
            void Paint();
        }



        public abstract class Human
        {
            String body = "xx";
            String so_thich = "xx";
            public abstract void eat();
            public virtual string uongSua()
            {
                return "xxx";
            }
        }
        class SampleClass : Human, IControl, ISurface
        {
            public override void eat()
            {
                throw new NotImplementedException();
            }

            public void Paint()
            {
                Console.WriteLine("Paint method in SampleClass");
                Console.ReadKey();
            }


            void IControl.Paint()
            {
                Console.WriteLine("Paint method in IControl");
                Console.ReadKey();
            }

            void ISurface.Paint()
            {
                Console.WriteLine("Paint method in ISurface");
                Console.ReadKey();
            }
        }
    }


}
