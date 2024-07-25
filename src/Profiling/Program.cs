namespace Profiling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? inputLine;

            uint n = 0; // N
            double sumX = 0;
            double sumXPow = 0;

            while ((inputLine = Console.ReadLine()) != null)
            {
                inputLine = inputLine.Replace(".", ",");    // Replace dots with commas for both compatibilities

                // Separed numbers by whitespace characters
                string[] separatedNumbers = inputLine.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string separatedText in separatedNumbers)
                {
                    double parsedNumber;

                    if (!double.TryParse(separatedText, out parsedNumber))                                      // Not double parsable input
                    {
                        Console.Error.WriteLine("ERROR: wrong input format.");

                        Environment.ExitCode = 1;
                        return;
                    }

                    sumX = MathLib.MathLib.Addition(sumX, parsedNumber);                                        // Accumulates sum of x
                    sumXPow = MathLib.MathLib.Addition(sumXPow, MathLib.MathLib.Power(parsedNumber, 2));        // Accumulates sum of x pow 2

                    n++;
                }
            }

            if(n < 2)
            {
                Console.Error.WriteLine("ERROR: you have to pass 2 or more numbers");

                Environment.ExitCode = 1;
                return;
            }

            double signedX = MathLib.MathLib.Division(sumX, n);                                                 // X with complement sign above
            double rightSiteOfSub = MathLib.MathLib.Multiplication(n, MathLib.MathLib.Power(signedX, 2));
            
            double rightSiteOfRoot = MathLib.MathLib.Subtraction(sumXPow, rightSiteOfSub);

            double underRoot = MathLib.MathLib.Division(rightSiteOfRoot, MathLib.MathLib.Subtraction(n, 1));

            Console.WriteLine(MathLib.MathLib.Root(underRoot, 2));
        }
    }
}