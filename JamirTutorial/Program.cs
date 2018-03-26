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
        //Add double slashes to comment on code
        //Calls SumInt
        int _sumInt = SumInt(5, 5);

        //Calls SumFloat
        float _sumFloat = SumFloat(2.340f, 1.659f);

        //Adds sum of SumInt and SumFloat
        float sumOfBoth = _sumInt + _sumFloat;

        Console.WriteLine("Sum Int: " + _sumInt);
        Console.WriteLine("Sum Float: " + _sumFloat);
        Console.WriteLine("Sum of both: " + sumOfBoth);
        Console.ReadLine();
    }

    int SumInt(int number1, int number2)
    {
        int _sum = number1 + number2;

        return _sum;
    }

    float SumFloat(float number1, float number2)
    {
        float _sum = number1 + number2;

        return _sum;
    }

}
