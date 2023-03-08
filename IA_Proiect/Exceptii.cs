using System;
using System.Collections.Generic;
using System.Text;


namespace IA_Proiect
{
    internal class Exceptii
    {
        public static void ExceptionNumberPopulation(int populatie)
        {
            if (populatie <= 2)
            {
                throw new SolutieInvalida("E necesar ca Populația>2");
            }
        }

        public static void ExceptionNumberGeneration(int nrGeneratie)
        {
            if (nrGeneratie <= 0)
            {
                throw new SolutieInvalida("E necesar ca Numarul Generatiilor>0");
            }
        }

        public static int parseIntoIntegerFromTextbox(string textboxValue)
        {
            try
            {
                return Int32.Parse(textboxValue);
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Variabila este nula");
            }
            catch (FormatException)
            {
                throw new FormatException("Text invalid");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Numarul " + textboxValue + " este invalid");
            }
        }
    }
}

