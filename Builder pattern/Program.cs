using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDirector cd = new CarDirector(new Batmobile());
                    
            var b = cd.Construct();
            b.GetInfo();

            cd = new CarDirector(new SimpleBuilder());

            var a = cd.Construct();
            a.GetInfo();

            
        }
    }
}
