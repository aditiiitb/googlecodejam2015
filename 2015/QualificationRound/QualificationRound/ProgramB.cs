using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QualificationRound
{
    internal class ProgramB
    {
       
        private static void Main(string[] args)
        {
            var helper = new CodeJamHelper('B', ProblemType.Small, 0);
            var numTestCases = helper.ReadLineInt32();
            foreach (var caseNum in Enumerable.Range(1, numTestCases))
            {
                var numDiners = helper.ReadLineInt32();
                var pancakesConf = helper.ReadLine();
                var pancakesArray = pancakesConf.Split(' ');
                var P = new List<int>();
                foreach (var pancakeNumStr in pancakesArray)
                {
                    P.Add(Int32.Parse(pancakeNumStr));
                }
                P.Sort();
                helper.OutputCase(MinimumPossibleTime(P));
            }
        }

        private static int MinimumPossibleTime(List<int> pancakes)
        {
            int max = pancakes.Max();
            int currCost = max;

            if (max < 4)
            {
                return max;
            }
            int average = max/2;
            var newpans = new List<int>();
            for (int i = 0; i < pancakes.Count; i++)
            {
                newpans.Add(pancakes[i]);
            }
            newpans.Add(average);

            if (max%2 == 0)
            {
                newpans.Add(average);
            }
            else
            {
                newpans.Add(average + 1);
            }

            newpans.Remove(max);
            return Math.Min(1 + MinimumPossibleTime(newpans), max);
        }
    }
}
