using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class ScoreUtility
    {
        public static IScored BestOfTwo(IScored assignmentOne, IScored assignmentTwo)
        {
            var scoreOne = assignmentOne.Score / assignmentOne.MaximumScore;
            var scoreTwo = assignmentOne.Score / assignmentOne.MaximumScore;

            if(scoreOne > scoreTwo)
            {
                return assignmentOne;
            } else
            {
                return assignmentTwo;
            }
        }
    }
}
