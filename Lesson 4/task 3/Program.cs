string GetLetters(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters += e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLetters(str);
Console.WriteLine(result);


//

string GetDigits (string s)
{
    string digits = "";
    foreach (char e in s)
    {
        if (char.IsDigit(e))
        {
            digits += e;
        }
    }
    return digits;
}

string str = Console.ReadLine();
string result = GetDigits(str);
Console.WriteLine(result);