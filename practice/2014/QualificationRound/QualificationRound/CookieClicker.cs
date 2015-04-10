using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualificationRound
{
    class CookieClicker
    {
        static void Main(string[] args)
        {
            var helper = new CodeJamHelper('B', ProblemType.Large, 0);
            var numTestCases = helper.ReadLineInt32();
            foreach (var caseNum in Enumerable.Range(1, numTestCases))
            {
                var vals = helper.ReadDoubleArray();
                var C = vals[0];
                var F = vals[1];
                var X = vals[2];
                int n = 0;
                var expression = C * (1.0 + n + 2.0 / F) - X;
                while (expression < 0)
                {
                    n++;
                    expression = C * (1.0 + n + 2.0 / F) - X;
                }
                // expression has become more than 0 for the minimum n
                var time = X / (2.0 + n * F);
                while (n > 0)
                {
                    n--;
                    time += C / (2.0 + n * F);
                }
                helper.OutputCase(time);
            }
        }
    }
}
