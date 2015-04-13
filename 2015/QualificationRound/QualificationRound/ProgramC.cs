using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QualificationRound
{
    public class ProgramC
    {
       // public static Dictionary<string, string> stringToReducedStringMap = new Dictionary<string, string>();
        private static void Main(string[] args)
        {
            var helper = new CodeJamHelper('C', ProblemType.Small, 2);
            var numTestCases = helper.ReadLineInt32();
           
            foreach (var caseNum in Enumerable.Range(1, numTestCases))
            {
                var line = helper.ReadLine();
                var stringToRepeat = helper.ReadLine();
                var items = line.Split(' ');
                var L = Int32.Parse(items[0]);
                var X = Int32.Parse(items[1]);
                var stringToExamine = string.Empty;
                foreach (int k in Enumerable.Range(1, X))
                {
                    stringToExamine += stringToRepeat;
                }
                if (stringToExamine.Length < 3)
                {
                    helper.OutputCase("NO");
                    continue;
                }
              
                var done = false;

                if (GetReducedString(stringToExamine) != "-1")
                {
                    helper.OutputCase("NO");
                }
                else
                {
                   // Console.WriteLine("Found -1 ");
                    string firstSubString = "1";
                    for (int n = 0; n < stringToExamine.Length - 2; n++)
                    {
                        firstSubString = Multiply(firstSubString, stringToExamine[n].ToString());
                        if (firstSubString == "i")
                        {
                            string secondSubString = "1";
                            for (int x = n + 1; x < stringToExamine.Length - 1; x++)
                            {
                                secondSubString = Multiply(secondSubString, stringToExamine[x].ToString());
                                if (secondSubString == "j" && GetReducedString(stringToExamine.Substring(x + 1)) == "k")
                                {
                                    done = true;
                                    break;
                                }
                            }
                        }
                    }
                    helper.OutputCase((done) ? "YES" : "NO");
                }
            }
        }

        public static string GetReducedString(string text)
        {
            string reducedStr = "1";
            for (int n = 0; n < text.Length; n++)
            {
                reducedStr = Multiply(reducedStr, text[n].ToString());
            }
            return reducedStr;
        }

        public static string Multiply(string a, string b)
        {
            int finalSign = 1;
            if (a.Length == 2)
            {
                finalSign = -1;
                a = a[1].ToString();
            }
            if (b.Length == 2)
            {
                finalSign = finalSign*(-1);
                b = b[1].ToString();
            }
            string posMult = string.Empty;
            if (a == "i")
            {
                if (b == "i")
                {
                    posMult= "-1";
                }
                else if (b == "j")
                {
                    posMult= "k";
                }
                else if (b == "k")
                {
                    posMult= "-j";
                }
            }
            else if (a == "j")
            {
                if (b == "i")
                {
                    posMult = "-k";
                }
                else if (b == "j")
                {
                    posMult = "-1";
                }
                else if (b == "k")
                {
                    posMult = "i";
                }
            }
            else if (a == "k")
            {
                if (b == "i")
                {
                    posMult = "j";
                }
                else if (b == "j")
                {
                    posMult = "-i";
                }
                else if (b == "k")
                {
                    posMult = "-1";
                }
            }
            if (b == "1")
            {
                posMult = a;
            }
            if (a == "1")
            {
                posMult = b;
            }
            if (posMult.Length == 2)
            {
                finalSign = finalSign*(-1);
                posMult = posMult[1].ToString();
            }
            
            var result = finalSign > 0 ? posMult : "-" + posMult;
            return result;
        }

    }
}
