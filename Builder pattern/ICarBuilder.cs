using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern
{
    interface ICarBuilder
    {
        Car GetResult();

        void BuildEngine();

        void BuildWheels();

        void BuildCarSkeleton();

        void BuildCarWindows();
       
    }
}
