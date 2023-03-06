using System;
class Program
{
    public static int Main()
    {
        int n = 0, m = 0; // number and power
        try
        {
            Console.Write("Enter the number   : ");
            n = int.Parse(Console.ReadLine()); // input number

            Console.Write("Enter the power: ");
            m = int.Parse(Console.ReadLine()); // input power

            
        }
        catch
        {
            Console.WriteLine("Incorrect input!");
            System.Environment.Exit(0);
        }

        int result = n, subn = n; // result and current n

        // exceptions
        switch (m)
        {
            case < 0: // negative power
                Console.Write("Negative power!"); 
                System.Environment.Exit(0);
                break;

            case 0: // n^0 = 1
                result = 1;
                Console.Write("Result: {0}", result);
                System.Environment.Exit(0);
                break;

           case 1: // n^1 = n
                Console.Write("Result: {0}", result);
                System.Environment.Exit(0);
                break;
        }

        switch (n)
        {
            case 0: // 0^m = 0
            case 1: // 1^m = 1
                Console.Write("Result: {0}", result);
                System.Environment.Exit(0);
                break;
            
            case < 0: // negative number
                if (m % 2 == 0)
                {
                    subn = Math.Abs(subn);
                    result = subn;
                }
                n = Math.Abs(n);
                break;

        }
        
        for (int i = 1; i < m; i++) // raising to the power
        {
            for (int j = 1; j < n; j++) // multiplication
            {
                try
                {
                    checked
                    {
                        result += subn;
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Overflow exception!");
                    System.Environment.Exit(0);
                }

            }
            subn = result;
        }

        Console.WriteLine("Result: {0}", result);
        return 0;
    }
}
