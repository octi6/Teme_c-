using System;
using System.Collections.Generic;
using System.Text;

namespace RecapitulareC_3
{
    interface IPrintable
    {
        void Print();
    }

    class Document : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Document tiparit");
        }
    }
}
