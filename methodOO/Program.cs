using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOO
{
    class Father
    {
        public virtual void Address()
        {
            Console.WriteLine("Father Address");
        }
    }
    class Son:Father
    {
        public new void Address()       // use new keyword to hide the mtd
        {
            Console.WriteLine("Son Address");
        }
    }
    class Mother:Father
    {
        public override void Address()
        {
            Console.WriteLine("Mother Address");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Father fobj = new Father();
            fobj.Address();

            fobj = new Son();
            fobj.Address();     // mtd hiding

            fobj = new Mother();
            fobj.Address();         // calling overriding mtd

            Mthdverload mo = new Mthdverload();   //mtd overloading
            int x= mo.Add(10, 20);
            double y = mo.Add(10.7, 20.12);
            Console.WriteLine(x);
            Console.WriteLine(y);


            Console.ReadLine();
        }
    }
}
