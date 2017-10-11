using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СsharpPlayground
{
    struct @struct
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return x + "," + y;
        }

        public static bool operator ==(@struct l, @struct r)
        {
            return l.x == r.x && l.y == r.y;
        }

        public static bool operator !=(@struct l, @struct r)
        {
            return l.x != r.x || l.y != r.y;
        }
        //Необязательные методы (не влияют на остальной код)
        //public override bool Equals(object obj)
        //{
        //    return (obj is @class) && (((@struct)obj) == this);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
    }
    class @class
    {
        public int x;
        public int y;
        public override string ToString()
        {
            return x + "," + y;
        }
        //Если раскомментировать, результат изменится
        //public static bool operator ==(@class l, @class r)
        //{
        //    return l.x == r.x && l.y == r.y;
        //}

        //public static bool operator !=(@class l, @class r)
        //{
        //    return l.x != r.x || l.y != r.y;
        //}

        public override bool Equals(object obj)
        {
            return (obj is @class) && (((@class)obj) == this);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            @struct s = new @struct();
            s.x = 1;
            s.y = 1;
            @struct s1 = s;
            @struct s2 = new @struct();
            s2.x = 1;
            s2.y = 1;
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 == s1 {0}", s2 == s);
            s1.x = 4;
            Console.WriteLine("s = {0}", s);

            @class c = new @class();
            c.x = 1;
            c.y = 1;
            @class c1 = c;
            @class c2 = new @class();
            c2.x = 1;
            c2.y = 1;
            Console.WriteLine("c1 = {0}", c1);
            Console.WriteLine("c2 == c1 {0}", c2 == c);
            c1.x = 4;
            Console.WriteLine("c = {0}", c);

            Console.ReadKey();
        }
    }
}
