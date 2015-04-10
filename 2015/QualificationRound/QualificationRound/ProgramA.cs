using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualificationRound
{
    class ProblemA
    {
        static void Main(string[] args)
        {
            var helper = new CodeJamHelper('A', ProblemType.Large, 0);
            var numTestCases = helper.ReadLineInt32();
            foreach (var caseNum in Enumerable.Range(1, numTestCases))
            {
                var line = helper.ReadLine();
                var items = line.Split(' ');
                var maxShyness = items[0];
                var shynessCount = items[1];
                var currShynessLevel = 0;
                var friendCount = 0;
                var numPplStanding = 0;
                for(int i = 0; i < shynessCount.Length; i++)
                {
                    currShynessLevel = i;
                    var numPplAtThisLevel = Int32.Parse(shynessCount[i].ToString());
                    if (numPplAtThisLevel != 0)
                    {
                        if (numPplStanding >= currShynessLevel)
                        {
                            // all ppl at this level will stand anyway
                        }
                        else
                        {
                            // we need more ppl to stand .. increment friends
                            friendCount += (currShynessLevel - numPplStanding);
                            // add the additional friends to num ppl standing
                            numPplStanding += (currShynessLevel - numPplStanding);
                            // now these ppl will stand ..increment standing count
                        }
                        numPplStanding += numPplAtThisLevel;
                    }
                }
                helper.OutputCase(friendCount);
            }
        }
    }
}
