using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventD2_22
{
    internal class Result
    {
        public static string getResult(string dName)
        {
            int result = 0;
            string resultS="";
            if (dName[0].Equals('A') & dName[1].Equals('Y') | dName[0].Equals('B') & dName[1].Equals('Z') | dName[0].Equals('C') & dName[1].Equals('X'))
            {
                result = result + 6;
            }
            else if (dName[0].Equals('A') & dName[1].Equals('X') | dName[0].Equals('B') & dName[1].Equals('Y') | dName[0].Equals('C') & dName[1].Equals('Z'))
            {
                result = result + 3;
            }

            if (dName[1].Equals('X'))
            {
                result = result + 1;
            }
            else if (dName[1].Equals('Y'))
            {
                result = result + 2;
            }
            else if (dName[1].Equals('Z'))
            {
                result = result + 3;
            }

            resultS = result.ToString();
            return resultS;
        }

        public static string getCalculatedResult(string dName)
        {
            int result = 0;
            string resultS = "";
            if (dName[0].Equals('A') & dName[1].Equals('Y') | dName[0].Equals('B') & dName[1].Equals('X') | dName[0].Equals('C') & dName[1].Equals('Z'))
            {
                result = result + 1;
            }
            else if (dName[0].Equals('A') & dName[1].Equals('Z') | dName[0].Equals('B') & dName[1].Equals('Y') | dName[0].Equals('C') & dName[1].Equals('X'))
            {
                result = result + 2;
            }
            else if (dName[0].Equals('A') & dName[1].Equals('X') | dName[0].Equals('B') & dName[1].Equals('Z') | dName[0].Equals('C') & dName[1].Equals('Y'))
            {
                result = result + 3;
            }

            if (dName[1].Equals('X'))
            {
                result = result + 0;
            }
            else if (dName[1].Equals('Y'))
            {
                result = result + 3;
            }
            else if (dName[1].Equals('Z'))
            {
                result = result + 6;
            }

            resultS = result.ToString();
            return resultS;
        }
    }
}
//rock=1
//paper=2
//scissors=3
//loose = 0
//draw = 3
//win = 6