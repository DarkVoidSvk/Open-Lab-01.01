using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {

            int intStr; bool intResultTryParse = int.TryParse(input, out intStr);
            if (intResultTryParse == true && intStr < 10)
            {

                return true;

            }
            else 
            {

                return false;

            }
        }
    }
}
