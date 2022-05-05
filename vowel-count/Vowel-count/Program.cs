
/**
    Return the number (count) of vowels in the given string.
    We will consider a, e, i, o, u as vowels for this Kata (but not y).
    The input string will only consist of lower case letters and/or spaces.

 */


Console.WriteLine("Hey type a text \n");

void Main()
{
    string? text = Console.ReadLine();

    if (string.IsNullOrEmpty(text))
    {
        Console.WriteLine("Constains a 0 vowels");
        return;
    }

    int count = 0;
    char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
    var list = text.ToLower().ToArray();


    foreach (var item in list)
    {
        foreach (var vowel in vowels)
        {
            if (item.Equals(vowel))
                count++;
        }
    }

    Console.WriteLine($"Counstains a {count} vowels");
}

Main();

Console.ReadKey();