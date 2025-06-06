﻿var sentence = "This is going to be a really really really really really long text!";
const int maxLength = 20;

Console.WriteLine("Original: " + sentence);
Console.WriteLine("Truncated: " + TruncateText(sentence, maxLength));

static string TruncateText(string text, int maxLength = 20)
{
    if (text.Length < maxLength)
    {
        return text;
    }

    var words = text.Split(' ');
    var totalCharacters = 0;
    var summaryWords = new List<string>();

    foreach (var word in words)
    {
        summaryWords.Add(word);

        totalCharacters += word.Length + 1;

        if (totalCharacters > maxLength)
        {
            break;
        }
    }

    return String.Join(" ", summaryWords.ToArray()) + " ...";
}
