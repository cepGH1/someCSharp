using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEPWindowsFormApp1
{
    internal class Calculator
    {
        double calcRunningTotal = 0.0;
        double myAddition(double myInput)
        {
            calcRunningTotal = calcRunningTotal + myInput;
            return calcRunningTotal;
        }

        double mySubtraction(double myInputS)
        {
            calcRunningTotal = -myInputS;
            return calcRunningTotal;
        }


    }
}
