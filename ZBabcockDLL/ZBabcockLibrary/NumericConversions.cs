using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBabcockLibrary
{
    public class NumericConversions
    {
        public static List<string> DecimalToBiOctHex(decimal number)
        {
            List<string> convertedNum = new List<string>();
            decimal numBase = 2m;
            for (int a = 0; a < 3; a++)
            {

                int remainder = 0;
                decimal cutNumber = number;
                List<string> newNumber = new List<string>();

                while (cutNumber > 0)
                {

                    if (cutNumber != number)
                    {
                        remainder = (int)(cutNumber % numBase);
                        cutNumber = (int)(cutNumber / numBase);
                        newNumber.Add(remainder.ToString());
                    }
                    else
                    {
                        remainder = (int)(number % numBase);
                        cutNumber = (int)(number / numBase);
                        newNumber.Add(remainder.ToString());
                    }
                }

                newNumber.Reverse();

                if (a == 0)
                {
                    numBase = 8m;
                    convertedNum.Add(string.Join("", newNumber.ToArray()));
                    newNumber.Clear();
                }
                else if (numBase == 8m)
                {
                    numBase = 16m;
                    convertedNum.Add(string.Join("", newNumber.ToArray()));
                    newNumber.Clear();
                }
                else
                {
                    for (int i = 0; i < newNumber.Count; i++)
                    {
                        if (newNumber[i] == "10")
                        {
                            newNumber[i] = "A";
                        }
                        else if (newNumber[i] == "11")
                        {
                            newNumber[i] = "B";
                        }
                        else if (newNumber[i] == "12")
                        {
                            newNumber[i] = "C";
                        }
                        else if (newNumber[i] == "13")
                        {
                            newNumber[i] = "D";
                        }
                        else if (newNumber[i] == "14")
                        {
                            newNumber[i] = "E";
                        }
                        else if (newNumber[i] == "15")
                        {
                            newNumber[i] = "F";
                        }
                    }

                    convertedNum.Add(string.Join("", newNumber.ToArray()));
                    newNumber.Clear();
                }
            }
            return convertedNum;
        }

        public static string DecimalToBinary(decimal number)
        {
            decimal numBase = 2m;

            string output = "";

            int remainder = 0;
            decimal cutNumber = number;
            List<string> newNumber = new List<string>();

            while (cutNumber > 0)
            {

                if (cutNumber != number)
                {
                    remainder = (int)(cutNumber % numBase);
                    cutNumber = (int)(cutNumber / numBase);
                    newNumber.Add(remainder.ToString());
                }
                else
                {
                    remainder = (int)(number % numBase);
                    cutNumber = (int)(number / numBase);
                    newNumber.Add(remainder.ToString());
                }
            }

            newNumber.Reverse();

            output = string.Join("", newNumber.ToArray());

            return output;
        }
    }
}
