using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualificationRound
{
    public class ProblemD
    {
        private static void Main()
        {
            var helper = new CodeJamHelper('D', ProblemType.Small, 0);
            var numTestCases = helper.ReadLineInt32();
            foreach (var caseNum in Enumerable.Range(1, numTestCases))
            {
                var line = helper.ReadLine();
                var items = line.Split(' ');
                var X = Int32.Parse(items[0]);
                var R = Int32.Parse(items[1]);
                var C = Int32.Parse(items[2]);
                if (X >= 7)
                {
                    helper.OutputCase("RICHARD");
                }
                else if ((R*C)%X != 0)
                {
                    helper.OutputCase("RICHARD");
                }
                else 
                {
                    switch (X)
                    {
                        case 1:
                            helper.OutputCase("GABRIEL");
                            break;
                        case 2:
                            helper.OutputCase("GABRIEL");
                            break;
                        case 3:
                            if (R < 2 || C < 2 || (R*C)%(3*2) != 0)
                            {
                                helper.OutputCase("RICHARD");
                            }
                            else
                            {
                                helper.OutputCase("GABRIEL");
                            }
                            break;
                        case 4:
                            if (R < 2 || C < 2 || (R*C)%(4*3) != 0)
                             {
                                helper.OutputCase("RICHARD");
                            }
                            else
                            {
                                helper.OutputCase("GABRIEL");
                            }
                            break;
                        case 5:
                             if (R < 3 || C < 3 || (R*C)%(5*4) != 0)
                             {
                                helper.OutputCase("RICHARD");
                            }
                            else
                            {
                                helper.OutputCase("GABRIEL");
                            }
                            break;
                        case 6:
                             if (R < 4 || C < 4 || (R*C)%(6*5) != 0)
                             {
                                helper.OutputCase("RICHARD");
                            }
                            else
                            {
                                helper.OutputCase("GABRIEL");
                            }
                            break;
                    }
                }
            }
        }
    }
}
