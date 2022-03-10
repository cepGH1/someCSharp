using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEPWindowsFormApp1
{
    internal class CEPclass2
    {
        string myName;
        int myID;
        string colour;

        public CEPclass2(string name, int identity, string colour)
        {
            myName = name;
            myID = identity;
            colour = colour;
        }

         void setColour(string colour2)
        {
            colour = colour2;
        }
    }
}
