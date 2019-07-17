using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseParams();
            //UseRefModifier();
            //UsePoint();
            UseOutModifier();

            Console.ReadKey();
        }

        static void UseOutModifier()
        {
            int number;

            try
            {
                number = int.Parse("123");
            }
            catch (Exception)
            {
                Console.WriteLine("conversion failed.");
            }

            // when you use the TryPars Method we will not need a try catch block
            var result = int.TryParse("456", out number);

            if (result)
                Console.WriteLine($"result={result}, value={number}");
            else
                Console.WriteLine("conversion failed.");
        }

        static void UseParams()
        {
            // different ways to pass parameter to a method
            var calc = new Calculator();
            // use an array to pass values
            var result = calc.Add1(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine(result);

            // because Add2 uses the modifier params we do not need a new int[]
            result = calc.Add2(1, 2, 3, 4, 5);
            Console.WriteLine(result);

            var calculator = new Calculator();

            Console.WriteLine(calculator.Add2(1, 2));
            Console.WriteLine(calculator.Add2(1, 2, 3));
            Console.WriteLine(calculator.Add2(1, 2, 3, 4));
            Console.WriteLine(calculator.Add2(new int[] { 1, 2, 3, 4, 5 }));

        }

        static void UseRefModifier()
        {
            // the uses of modifier Ref
            // ref or not ref, this is ...
            var aValue = 1;
            SampleClass.aMethod(aValue);
            // aMethod did not change the value of aValue, just use it
            Console.WriteLine(aValue);

            WeiredDo.WeiredThings(ref aValue);
            // WeiredThings do things with aValue and change it!
            Console.WriteLine(aValue);

        }

        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine($"Point is at {point.X}, {point.Y}");

                point.Move(new Point(20, 30));
                Console.WriteLine($"Point is at {point.X}, {point.Y}");

                point.Move(100, 200);
                Console.WriteLine($"Point is at {point.X}, {point.Y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occured on {ex.Message}.");
            }
        }
    }
}
