using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._01_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Micinka");
            Spider spider = new Spider("Pavoucek");
            SpiderForm spforma = new SpiderForm("Bubak");

            // SpiderForm spiderform = new SpiderForm("Bubacek");

            //cat.numoflegs = 4;
            //cat.Name = "Micka";
            //cat.Srst = "Hebka";
            //spider.numoflegs = 8;
            spider.Name = "Odula";
            spforma.Sized = "Big";

            Console.WriteLine(spider.Name+", "+spider.numoflegs );
            Console.WriteLine(cat.Srst + ", " + cat.Name + ", " + cat.numoflegs);
            Console.WriteLine(spforma.Sized+", "+spforma.Name + ", " + spforma.numoflegs);
        }
    }

    class Animal
    {
        public int numoflegs;
        public string Name;
        public Animal(string name)
        {
            this.Name = name;
        }
    }

    class Cat : Animal 
    {
        public string Srst;
        public Cat(string name) :base(name)
        {
            this.numoflegs = 4;
        }
    }

    class Spider : Animal 
    {
        public Spider(string name) :base(name)
        {
            this.numoflegs = 8;
        }
    }

    class SpiderForm : Spider
    {
        public string Sized;
        public SpiderForm(string name) : base(name)
        {
            this.numoflegs = 8;
        }

    }
}
