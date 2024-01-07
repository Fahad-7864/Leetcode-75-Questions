string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));


// Function to reverse each word in a sentence.
string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");
    // Loop through each word in the array.
    foreach (string word in words)
    {
        // Call the ReverseWord function for each word, add it to the result,
        // and append a space.
        result += ReverseWord(word) + " ";
    }
    // Trim any trailing spaces from the result and return it.
    return result.Trim();
}

// Function to reverse the characters in a word.
string ReverseWord(string word)
{
    string result = "";
    // Loop through the characters of the word in reverse order.
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}