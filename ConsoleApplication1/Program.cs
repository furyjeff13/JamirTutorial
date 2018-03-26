using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamirTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            MainFunction _mainFunction = new MainFunction();
            _mainFunction.TestFunctionCall();
        }
    }
}

class MainFunction
{

    public void TestFunctionCall()
    {
        int cellNumber = Sum(5, 5);
    }

    int Sum(int number1, int number2)
    {
        int _sum = number1 + number2;

        return _sum;
    }

}
