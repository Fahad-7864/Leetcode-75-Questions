// Function to check if a given string 'word' is a palindrome.
bool IsPalindrome(string word)
{
    // Initialize start,end to their character index.
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        // Check if characters at 'start' and 'end' are different.
        if (word[start] != word[end])
        {
            // If they are different, it's not a palindrome, return false.
            return false;
        }
        start++; // Move 'start' to the next character.
        end--;   // Move 'end' to the previous character.
    }

    // If the loop completes without finding mismatched characters, return true.
    // It means the word is a palindrome.
    return true;
}

string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}