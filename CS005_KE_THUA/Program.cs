using System;

namespace CS005_KE_THUA
{

    public class Animals
    {
        public int leg;
        public double weigh { get; set; }



        public void talk(string language)
        {
            System.Console.WriteLine(language);
        }
    }
    class Cat : Animals
    {
        public string ability;

        public void specialSkill()
        {
            System.Console.WriteLine("climb the tree");
        }
    }
    class YellowCat : Cat
    {
        public string color;

        public void food()
        {
            System.Console.WriteLine("climb the tree");
        }
    }
    /// <summary>
    /// HÀM DỰNG TĨNH
    /// </summary>
    class StaticConstructor
    {
        public static int num;
        public static int num1;
        public static int num2;

        static StaticConstructor()
        {
            num = 1;
            num1 = 2;
            num2 = 3;
        }
    }


    public abstract class People
    {
        int variable1 = 1;

        public abstract void go();
        public abstract void run(string vanToc, string location);
    }
    interface IAppearane
    {
        void hair(string length, string color);
        void face(string length, string color);
        void clothes(string pant, string t_shirt);
    }
    interface IBehavior
    {
        void read(string language);
        void eat(string food);
        void drink(string bevarage);
    }

    class AsiaPeople : People, IAppearane, IBehavior
    {
        public void clothes(string pant, string t_shirt)
        {
            throw new NotImplementedException();
        }

        public void drink(string bevarage)
        {
            throw new NotImplementedException();
        }

        public void eat(string food)
        {
            throw new NotImplementedException();
        }

        public void face(string length, string color)
        {
            throw new NotImplementedException();
        }

        public override void go()
        {
            System.Console.WriteLine(
                "di bang 2 chan vang"
            );
        }

        public void hair(string length, string color)
        {
            throw new NotImplementedException();
        }

        public void read(string language)
        {
            throw new NotImplementedException();
        }

        public override void run(string vanToc, string location)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// main
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new YellowCat();
            c.weigh = 10.4;

        }
    }
}
