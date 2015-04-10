using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualificationRound
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new CodeJamHelper('A', ProblemType.Small, 0);
            var numTestCases = helper.ReadLineInt32();
            foreach (var caseNum in Enumerable.Range(1, numTestCases))
            {
                var answer1 = helper.ReadLineInt32();
                var rows = new List<int[]>();
                rows.Add(helper.ReadInt32Array());
                rows.Add(helper.ReadInt32Array());
                rows.Add(helper.ReadInt32Array());
                rows.Add(helper.ReadInt32Array());
                var answer2 = helper.ReadLineInt32();
                var rowsB = new List<int[]>();
                rowsB.Add(helper.ReadInt32Array());
                rowsB.Add(helper.ReadInt32Array());
                rowsB.Add(helper.ReadInt32Array());
                rowsB.Add(helper.ReadInt32Array());
                var possibilities1 = rows[answer1 - 1];
                var possibilities2 = rowsB[answer2 - 1];
                var answer = possibilities1.Intersect(possibilities2).ToList();
                if (answer != null && answer.Count == 1)
                {
                    helper.OutputCase(answer[0]);
                }
                else if (answer.Count > 1)
                {
                    helper.OutputCase("Bad magician!");
                }
                else if (answer.Count == 0)
                {
                    helper.OutputCase("Volunteer cheated!");
                }
            }
        }
    }
}
