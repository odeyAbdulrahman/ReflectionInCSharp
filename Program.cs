using System;
using System.Reflection;

namespace topics
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Operation = Console.ReadLine();
                var CreateInstance = Activator.CreateInstance(Type.GetType("topics.Calculator"));
                MethodInfo methodInfo = CreateInstance.GetType().GetMethod(Operation);
                string result = methodInfo.Invoke(CreateInstance, new object[] { 34, 43 }).ToString();
                Console.WriteLine(result);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            //if (Operation == EnumOperation.Addition.ToString())
            //{
            //    Calculator op = new Calculator();
            //    Console.WriteLine(op.Addition(12, 14));
            //}
            //else
            //if (Operation == EnumOperation.Subtraction.ToString())
            //{
            //    Calculator op = new Calculator();
            //    Console.WriteLine(op.Subtraction(12, 14));
            //}
            //else
            //if (Operation == EnumOperation.Multiplication.ToString())
            //{
            //    Calculator op = new Calculator();
            //    Console.WriteLine(op.Multiplication(12, 14));
            //}
            //else
            //if (Operation == EnumOperation.Addition.ToString())
            //{
            //    Calculator op = new Calculator();
            //    Console.WriteLine(op.Division(12, 14));
            //}
            //else
            //{
            //    Console.WriteLine("):");
            //}
        }
    }

    class Calculator
    {
        public double Addition(double x, double y) => x + y;
        public double Subtraction(double x, double y) => x - y;
        public double Multiplication(double x, double y) => x * y;
        public double Division(double x, double y) => x / y;
    }
    enum EnumOperation
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
}
