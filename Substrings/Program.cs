using Substrings.Helpers;
using Substrings.Interfaces;

IInputHelper inputHelper = new ConsoleInputHelper();

string[] strArray = inputHelper.GetStringsArray();
List<string> sameStrings = new List<string>();
List<string> concatStrings = new List<string>();
 
// Check for strings which consist the only character
for (int i = 0; i < strArray.Length; i++)
{
    if (StringsHelper.AllCharactersSame(strArray[i]))
    {
        sameStrings.Add(strArray[i]);
    }
}

// Concatenate strings which consist the only character
for (int i = 0; i < sameStrings.Count; i++)
{
    // Check for string with certain character exists in same strings array
    if (concatStrings.Any(str => str[0] == sameStrings[i][0]))
    {
        continue;
    }

    string tempConcat = sameStrings[i];

    for (int j = 1; j < sameStrings.Count; j++)
    {
        if (sameStrings[i][0] == sameStrings[j][0])
        {
            tempConcat += sameStrings[j];
        }
    }

    concatStrings.Add(tempConcat);
}

string maxLengthStr = concatStrings.OrderByDescending(str => str.Length).First();

Console.WriteLine($"Max length string is {maxLengthStr}, it's length is {maxLengthStr.Length}");