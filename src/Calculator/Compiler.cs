/**
* @file Compiler.cs
* @author Lucia Cengelová
* @author Ondřej Broža
* 
* @brief Implemetnace Compiler
*/
using System.Runtime.ExceptionServices;
/**
* @brief Namespace, který implementuje třídu Compiler.
*/
namespace Compiler
{
    /**
     * @brief Statická třída, která se stará o komunikaci mezi Calculator a MathLib.
     */
    public static class Compiler
    {
        /**
         * @brief Statická metoda, která přečte zpracuje vstup v daném formátu a pomocí metody Calculate ho vyhodnotí.
         * 
         * @param input Vstup kalkulačky
         * @return Vrátí výsledek výrazu který dostane, nebo "Syntax Error" v připadě špatného formátu vstupu.
         */
        public static string Compile(string input)
        {           
            const string error = "Syntax Error";

            List<double> numbersList = new List<double>();
            List<int> indexOfNum = new List<int>();
            List<int> arrOfNum = new List<int>();
            List<char> symbolsList = new List<char>();
            List<int> indexOfSym = new List<int>();
            List<int> arrOfSym = new List<int>();

            int i = 0;
            while (i < input.Length)
            {
                char currentChar = input[i];
                //  Vklad zapornych cisel
                if (currentChar == '-')
                {
                    if (i == 0 || symbolsList.Count > 0 && (symbolsList[symbolsList.Count - 1] == '(' || symbolsList[symbolsList.Count - 1] == '+' || symbolsList[symbolsList.Count - 1] == '-' || symbolsList[symbolsList.Count - 1] == '*' || symbolsList[symbolsList.Count - 1] == '/' || symbolsList[symbolsList.Count - 1] == '^'))
                    {
                        int j = i + 1;
                        double number = 0.0;
                        while (j < input.Length && (char.IsDigit(input[j]) || input[j] == ','))
                        {
                            number = number * 10 + (input[j] - '0');
                            j++;
                        }
                        numbersList.Add(-number);
                        indexOfNum.Add(numbersList.Count-1); // index v listu
                        arrOfNum.Add(i-1); // index v inputu
                        i = j;
                        continue;
                    }
                }
                //  Vklad cisel 
                if (char.IsDigit(currentChar) || currentChar == ',')
                {
                    int j = i;
                    double number = 0;
                    bool sep_in = false;
                    double after_decimal = 1;

                    while (j < input.Length && (char.IsDigit(input[j]) || input[j] == ','))
                    {
                        if (char.IsDigit(input[j]))
                        {
                            if (sep_in == true)
                            {
                                number = number + (Convert.ToUInt32(Convert.ToString(input[j])) * (0.1 * after_decimal));
                                after_decimal *= 0.1;
                            }
                            if (number == 0.0)
                            {
                                number = Convert.ToUInt32(Convert.ToString(input[j]));
                            }
                            else if (sep_in == false)
                            {
                                number = number * 10;
                                number = number + Convert.ToUInt32(Convert.ToString(input[j]));
                            }
                            j++;
                        }
                        else if (input[j] == ',')
                        {
                            sep_in = true;
                            j++;
                        }
                    }
                    
                    numbersList.Add((double)number);
                    indexOfNum.Add(numbersList.Count-1);
                    arrOfNum.Add(j-1);
                    i = j;
                    continue;
                }
                // Pridani charakteru do symbollistu
                else if (currentChar == '+' || currentChar == '-' || currentChar == '*' || currentChar == '/' || currentChar == '|' || currentChar == '!' || currentChar == '(' || currentChar == ')' || currentChar == '^' || currentChar == 'l' || currentChar == 'r')
                {
                    symbolsList.Add(currentChar);
                    indexOfSym.Add(symbolsList.Count-1);
                    arrOfSym.Add(i);
                    i++;
                }
                else
                {
                    return error;
                }

            }
            List<double> result = Calculate(numbersList, symbolsList, input, indexOfNum, indexOfSym, arrOfNum, arrOfSym);
            if (result == null || result.Count != 1)
            {
                return error;
            }
            result[0] = Math.Round(result[0], 5);

            return result[0].ToString();
           
        }
          /**
          * @brief Vypočítá výraz zadaný seznamem double čísel a seznamem znaků. V případě netriviálního výrazu je funkce rekurzivní.
          * 
          * @param numbersList Seznam všech čísel výrazu zleva do prava
          * @param symbolsList Seznam všech řídících znaků výrazu zleva do prava
          * @return Vrátí výsledek zadaného výrazu.
          */
        static List<double> Calculate(List<double> numbersList, List<char> symbolsList, string inputCalc, List<int> IndexOfNum, List<int> IndexOfSym, List<int> ArrOfNum, List<int> ArrOfSym)
        {
            int symbols_length = symbolsList.Count;
            int bracket_cnt = 0;
            int bracketsdone = 0;
            if (bracketsdone == 1) { bracketsdone = 2; }           
            List<int> index_open_bracket = new List<int>();
            List<int> index_closed_bracket = new List<int>();
            if(bracketsdone != 2)
            {
                for (int y = 0; y < inputCalc.Length; y++)
                {
                    if (inputCalc[y] == '(')
                    {
                        bracket_cnt++;
                        index_open_bracket.Add(y);
                    }
                    if (inputCalc[y] == ')')
                    {
                        bracket_cnt--;
                        index_closed_bracket.Add(y);
                    }
                }
            }

            if (bracket_cnt != 0)
            {
                return null;
            }

            // Bubblesort to switch brackets
            var n = index_open_bracket.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (index_open_bracket[j] < index_open_bracket[j + 1])
                    {
                        var tempVar = index_open_bracket[j];
                        index_open_bracket[j] = index_open_bracket[j + 1];
                        index_open_bracket[j + 1] = tempVar;
                    }
                }
            }  

            int open_brackets_length = index_open_bracket.Count;
            int closed_brackets_length = index_closed_bracket.Count;

            if (open_brackets_length != closed_brackets_length)
            {
                return null;
            }
            else if (open_brackets_length == closed_brackets_length && bracketsdone == 0)
            {   
                if(closed_brackets_length == 0)
                {
                    Operations(symbolsList, numbersList);
                }
                bracketsdone = 1;
                // Cyklus podle poctu dvojic zavorek
                for (int z = 0; z < open_brackets_length; z++) 
                {
                    // Cyklus v oblastni nejvnitrnejsi zavorky v prikladu
                    for (int l = index_open_bracket[z]; l != index_closed_bracket[z]; l++) 
                    {
                        // Pokud se provadi specialni operace s cislem v zavorce
                        if (inputCalc[index_open_bracket[z] - 1] == '^' || inputCalc[index_open_bracket[z] - 1] == 'r' || inputCalc[index_open_bracket[z] - 1] == 'l')
                        {
                            break;
                        } 
                             List<char> subSymbolsList = new List<char>();
                             List<double> subNumbersList = new List<double>();

                        bool sep_in = false;
                        // Ukladani do sublistu
                        for (int i = 0; i < (index_closed_bracket[z] - index_open_bracket[z]) + 1; i++) 
                        {

                            if (inputCalc[index_open_bracket[z] + i] == '+' || inputCalc[index_open_bracket[z] + i] == '-' || inputCalc[index_open_bracket[z] + i] == '*' || inputCalc[index_open_bracket[z] + i] == '/' || inputCalc[index_open_bracket[z] + i] == '|' || inputCalc[index_open_bracket[z] + i] == '!' || inputCalc[index_open_bracket[z] + i] == '(' || inputCalc[index_open_bracket[z] + i] == ')' || inputCalc[index_open_bracket[z] + i] == '^' || inputCalc[index_open_bracket[z] + i] == 'l' || inputCalc[index_open_bracket[z] + i] == 'r')
                            {                              
                                subSymbolsList.Add(inputCalc[index_open_bracket[z] + i]);
                            }
                            else
                            {
                                int j = index_open_bracket[z] + i;
                                double number = 0;

                                double after_decimal = 1;

                                if (char.IsDigit(inputCalc[j]))
                                {
                                    if (sep_in == true)
                                    {

                                        number = number + (Convert.ToUInt32(Convert.ToString(inputCalc[j])) * (0.1 * after_decimal));

                                        after_decimal *= 0.1;
                                    }
                                    if (number == 0.0)
                                    {
                                        number = Convert.ToUInt32(Convert.ToString(inputCalc[j]));
                                    }
                                    else if (sep_in == false)
                                    {
                                        number = number * 10;
                                        number = number + Convert.ToUInt32(Convert.ToString(inputCalc[j]));
                                    }

                                }
                                else if (inputCalc[j] == ',')
                                {
                                    sep_in = true;

                                }

                                subNumbersList.Add((double)number);

                            }

                        }

                        int pocetsymboluSubSym = subSymbolsList.Count;
                        int pocetciselSubNum = subNumbersList.Count;

                        double subResult = Operations(subSymbolsList, subNumbersList);
                        //mazani pouzitych symbolu v symbollistu
                        for (int a = 0; a < ArrOfSym.Count; a++)
                        {
                            if (index_open_bracket[z] == ArrOfSym[a])
                            {
                                symbolsList.RemoveRange(a, pocetsymboluSubSym);
                            }
                        }
                        //mazani pouzitych cisel a vlozeni vysledku ze zavorky
                        for (int a = index_open_bracket[z]; a < index_closed_bracket[z]; a++)
                        {
                            for (int b = 0; b < ArrOfNum.Count; b++)
                            {
                                if (a == ArrOfNum[b])
                                {
                                    numbersList.RemoveRange(IndexOfNum[b], pocetciselSubNum-1);
                                    numbersList[IndexOfNum[b]] = subResult;
                                    b = ArrOfNum.Count;
                                    a = index_closed_bracket[z];
                                    
                                }
                            }                                                        
                        }

                        inputCalc.Remove(index_open_bracket[z], (index_closed_bracket[z] - index_open_bracket[z]) + 1);
                        l = index_closed_bracket[z]-1;                       
                    }                  
                }

                Operations(symbolsList, numbersList);

            }

            // Vykonat mazani ohranicujicich zavorek jako 1.
            double Operations(List<char> OperationsSymbolsList, List<double> OperationsNumbersList)
            {
                for (int i = 0; i < OperationsSymbolsList.Count; i++)
                {
                    if (OperationsSymbolsList[i] == '(' || OperationsSymbolsList[i] == ')')
                    {
                        OperationsSymbolsList.RemoveAt(i);
                        i = 0;
                    }
                }

                // Vykonat faktorial, power, root a logaritmus jako 2.
                for (int i = 0; i < OperationsSymbolsList.Count; i++)
                {
                    char currentSymbol = OperationsSymbolsList[i];
                    // factorial
                    if (currentSymbol == '!')
                    {
                        int factorial_num = (int)OperationsNumbersList[i];
                        double factorial_result = MathLib.MathLib.Factorial(factorial_num);
                        OperationsNumbersList[i] = factorial_result;
                        OperationsSymbolsList.RemoveAt(i);
                        i--;
                    }
                    // power
                    else if (currentSymbol == '^')
                    {
                        double baseNum = OperationsNumbersList[i];
                        double exponent = OperationsNumbersList[i + 1];
                        double power_result = MathLib.MathLib.Power(baseNum, (int)exponent);
                        OperationsNumbersList[i] = power_result;
                        OperationsNumbersList.RemoveAt(i + 1);
                        OperationsSymbolsList.RemoveAt(i);
                        i--;
                    }
                    // root
                    else if (currentSymbol == 'r')
                    {
                        double index = OperationsNumbersList[i];
                        double radicant = OperationsNumbersList[i + 1];
                        double root_result = MathLib.MathLib.Root(radicant, (int)index);
                        OperationsNumbersList[i] = root_result;
                        OperationsNumbersList.RemoveAt(i + 1);
                        OperationsSymbolsList.RemoveAt(i);
                        i--;
                    }
                    // logarithm
                    else if (currentSymbol == 'l')
                    {
                        double baseNum = OperationsNumbersList[i];
                        double number = OperationsNumbersList[i + 1];
                        double log_result = MathLib.MathLib.Logarithm((int)number, (int)baseNum);
                        OperationsNumbersList[i] = log_result;
                        OperationsNumbersList.RemoveAt(i + 1);
                        OperationsSymbolsList.RemoveAt(i);
                        i--;
                    }
                }

                // Vykonat nasobeni a deleni jako 3.
                for (int i = 0; i < OperationsSymbolsList.Count; i++)
                {
                    char currentSymbol = OperationsSymbolsList[i];
                    double result = 0;
                    if (currentSymbol == '*' || currentSymbol == '/')
                    {
                        double leftNumber = OperationsNumbersList[i];
                        double rightNumber = OperationsNumbersList[i + 1];
                        if (currentSymbol == '*')
                        {
                            result = MathLib.MathLib.Multiplication(leftNumber, rightNumber);
                        }
                        else if (currentSymbol == '/')
                        {
                            result = MathLib.MathLib.Division(leftNumber, rightNumber);
                        }
                        OperationsNumbersList[i] = result;
                        OperationsNumbersList.RemoveAt(i + 1);
                        OperationsSymbolsList.RemoveAt(i);
                        i--;
                    }
                }

                // Vykonat scitani a odcitani jako 4.
                for (int i = 0; i < OperationsSymbolsList.Count; i++)
                {
                    char currentSymbol = OperationsSymbolsList[i];
                    double leftNumber = OperationsNumbersList[i];
                    double rightNumber = OperationsNumbersList[i + 1];
                    double result = 0;
                    if (currentSymbol == '+')
                    {
                        result = MathLib.MathLib.Addition(leftNumber, rightNumber);
                        OperationsNumbersList[i] = result;
                        OperationsNumbersList.RemoveAt(i + 1);
                        OperationsSymbolsList.RemoveAt(i);
                        i--;
                    }
                    else if (currentSymbol == '-')
                    {
                        result = MathLib.MathLib.Subtraction(leftNumber, rightNumber);
                        OperationsNumbersList[i] = result;
                        OperationsNumbersList.RemoveAt(i + 1);
                        OperationsSymbolsList.RemoveAt(i);
                        i--;
                    }
                }     

                return OperationsNumbersList[0];
            }

            return numbersList;

        }
    }
}