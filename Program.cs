using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    public  class G
    {
          public virtual void c()
        {
            Console.WriteLine("tttt");
        }
        


    }
    public class R : G
    {
        public override void c()
        {
            Console.WriteLine("teju");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            //G g;
            G g = new R();
            g.c();
            Console.ReadLine();
        }
    }
}
