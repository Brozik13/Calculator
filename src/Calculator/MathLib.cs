/**
 * @file MathLib.cs
 * @author Lucia Cengelová
 * @author Ondřej Broža
 * @author Vítek Mikulášek
 * 
 * @brief Implementace matematické knihovny MathLib
 */

/**
 * @brief Namespace matematické knihovny, implementuje třídu MathLib.
 */
namespace MathLib
{
    /**
     * @brief Statická třída implementující matematické funkce
     */
    public static class MathLib
    {
        /**
         * @brief Metoda pro součet dvou čísel double
         * 
         * @param num1 První číslo na sečtení
         * @param num2 Druhé číslo na sečtení
         * @return Vrací součet num1 a num2.
         */
        public static double Addition(double num1, double num2)
        {
            double addition_result = num1 + num2;
            return addition_result;
        }

        /**
         * @brief Metoda pro rozdíl dvou čísel double
         * 
         * @param num1 Číslo od kterého se odečítá
         * @param num2 Odečítané číslo
         * @return Vrací rozdíl num1 a num2.
         */
        public static double Subtraction(double num1, double num2)
        {
            double subtraction_result = num1 - num2;
            return subtraction_result;
        }
        
        /**
         * @brief Metoda pro součin dvou čísel double
         * 
         * @param num1 První číslo na součin
         * @param num2 Druhé číslo na součin
         * @return Vrací součin num1 a num2.
         */
        public static double Multiplication(double num1, double num2)
        {
            double multiplication_result = num1 * num2;
            return multiplication_result;
        }

        /**
         * @brief Metoda pro podíl dvou čísel double
         * 
         * @param num1 Dělenec
         * @param num2 Dělitel
         * @return Vrací podíl num1 a num2.
         */
        public static double Division(double num1, double num2)
        {
            double division_result = num1 / num2;
            return division_result;
        }

        /**
         * @brief Metoda pro výpočet faktoriálu čísla int
         * 
         * @param num Číslo ze kterého se vypočítá faktoriál
         * @return Vrací faktoriál num.
         */
        public static int Factorial(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }
            int result = 1;
            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        /**
         * @brief Metoda pro výpočet dané mocniny int daného čísla double
         * 
         * @param baseNum Základ mocniny
         * @param exponent Exponent
         * @return Vrací baseNum umocněný na exponent.
         */
        public static double Power(double baseNum, int exponent)
        {
            if(baseNum == 0 && exponent == 0)
            {
                return double.NaN;
            }
            double result_Power = 1;
            for (int i = 0; i < exponent; i++)
            {
                result_Power *= baseNum;
            }
            for (int i = 0; i > exponent; i--)
            {
                result_Power /= baseNum;
            }
            return result_Power;          
        }

        /**
         * @brief Metoda pro danou odmocninu int daného čísla double
         * 
         * @param radicant Odmocněnec
         * @param index Odmocnitel
         * @return Vrací index-tou odmocninu z čísla radicant.
         */
        public static double Root(double radicant, int index)
        {
            double delta = 0.0000001;

            if( index < 0)
            {
                return double.NaN;
            }

            if ((index % 2 == 0 && radicant < 0) || index == 0) // Mimo definiční obor
            {
                return double.NaN;
            }
            else if(radicant == 0) // V definičním oboru, ale nelze vypočítat podle používaného algoritmu
            {
                return 0;
            }

            double result = radicant / index;
            double diff = double.MaxValue;
            while (diff > delta)
            {
                double nextResult = ((index - 1) * result + radicant / Power(result, index - 1)) / index; // Mathematic formula for Root

                if (result - nextResult >= 0) // ABS(result - nextResult)
                {
                    diff = result - nextResult;
                }
                else
                {
                    diff = -(result - nextResult);
                }

                result = nextResult;
            }

            return result;
        }

        /**
         * @brief Metoda pro výpočet logaritmu o základu int z čísla int nedefinované chování, pokud předpokládaný výsledek neleží na množině přirozených číslech
         * 
         * @param number Číslo ze kterého se počítá logaritmus
         * @param baseNum Základ logaritmu
         * @return Vrací logaritmus o základu baseNum z čísla number.
         */
        public static double Logarithm(int number, int baseNum)
        {
            if (number <= 0 || baseNum <= 0 || baseNum == 1)
            {
                return double.NaN;
            }

            double result = 0;
            double product = 1;
            while (product < number)
            {
                product *= baseNum;
                result++;
            }
            return result + ((number / product) - 1) / (baseNum - 1);
        }
    }
}
