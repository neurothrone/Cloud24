namespace Cloud24.Course1.Lab1;

public static class SubstringPatternFinder
{
    public static void Run()
    {
        Console.WriteLine("Input a string:");
        // var userInput = Console.ReadLine() ?? string.Empty; 
        var userInput = "29535123p48723487597645723645";

        Console.WriteLine("--------------------------");
        Console.WriteLine("\nResult:");
        Console.WriteLine("--------------------------");

        // Use 'ulong' to handle large sums and prevent overflow
        // // source: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
        ulong sum = 0;

        ProcessString(userInput, ref sum);

        Console.WriteLine("\nSum:");
        Console.WriteLine(sum);
        // INPUT: 29535123p48723487597645723645
        // OUTPUT: 5836428677242
    }

    private static void ProcessString(string input, ref ulong sum)
    {
        for (int i = 0; i < input.Length; i++)
        {
            // Skip non-digit characters
            if (!char.IsDigit(input[i]))
                continue;

            char startDigit = input[i];
            int j = i + 1;

            // Iterate until a substring is found that starts and ends with the same digit
            while (j < input.Length && char.IsDigit(input[j]))
            {
                // EXAMPLE:
                // If for example the startDigit is 2, we continue iterating until we find a digit that equals 2, the
                // so-called end number (terminates the substring) and execute the code block inside the if statement.

                // Check if the current digit matches the start digit
                if (input[j].Equals(startDigit))
                {
                    PrintValidSubstringWithColor(input, i, j);
                    sum += ParseValidSubstring(input, i, j);

                    // Stop searching after finding a valid number
                    break;
                }

                j++;
            }
        }
    }

    // Print out and highlight each valid substring
    private static void PrintValidSubstringWithColor(string input, int start, int end)
    {
        // Print the part of the string before the valid number
        Console.Write(input.Substring(0, start));

        // Highlight the valid number in green
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(input.Substring(start, end - start + 1));
        Console.ResetColor();

        // Print the rest of the string after the valid number
        Console.WriteLine(input.Substring(end + 1));
    }

    // Parse a valid substring to a numeric (ulong) value
    private static ulong ParseValidSubstring(string input, int start, int end)
    {
        string validSubstring = input.Substring(start, end - start + 1);
        return ulong.Parse(validSubstring);
    }
}