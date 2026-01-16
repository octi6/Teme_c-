using System;
using System.Collections.Generic;
using System.Text;

namespace RecapitulareC_3
{
    class Animal
    {
        public virtual void Sunet()
        {
            Console.WriteLine("Animalul scoate un sunet");
        }
    }

    class Caine : Animal
    {
        public override void Sunet()
        {
            Console.WriteLine("Cainele latra");
        }
    }
}
