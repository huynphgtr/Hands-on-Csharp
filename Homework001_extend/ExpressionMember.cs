using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework001_extend; 

// Expression-bodied member 
public class ExpressionMember
{   
    public static bool isOdd(int number)
    {
        return number % 2 != 0;
    }
    public static bool IsEven(int number) => number % 2 == 0;
}


public class ExpressionTest
{
    public static void Run()
    {
        Console.WriteLine(ExpressionMember.isOdd(3)); // True
        Console.WriteLine(ExpressionMember.IsEven(4)); // True

    }
}
