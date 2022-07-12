using System;
namespace Substrings.Helpers
{
    public static class StringsHelper
    {
        public static bool AllCharactersSame(string str)
        {
            char[] charArr = str.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] != charArr[0])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

