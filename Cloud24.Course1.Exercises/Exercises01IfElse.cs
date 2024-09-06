namespace Cloud24.Course1.Exercises;

public static class Exercises01IfElse
{
    // 1. Even or Odd:
    // Ask the user to input a number.
    // Check if the number is even or odd.
    // Print out "The number is even" or "The number is odd" accordingly.
    public static void Exercise01()
    {
        // Ask the user to input a number.
        Console.WriteLine("Enter an integer");
        int number = Convert.ToInt32(Console.ReadLine());

        // Check if the number is even or odd.
        // // Print out "The number is even" or "The number is odd" accordingly.
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }


    // 2. Age Bracket:
    // Ask the user to input their age.
    // If the age is less than 13, print "You are a child".
    // If the age is between 13 and 19, print "You are a teenager".
    // Otherwise, print "You are an adult".
    public static void Exercise02()
    {
        Console.WriteLine("Enter your age as an integer:");
        int age;

        while (true)
        {
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("Please enter a valid integer");
            }
        }

        // if (age < 13)
        // {
        //     Console.WriteLine("You are a child");
        // }
        // // else if (age > 13 && age < 18)
        // else if (age is > 13 and < 18)
        // {
        //     Console.WriteLine("You are a teenager");
        // }
        // else
        // {
        //     Console.WriteLine("You are an adult");
        // }

        switch (age)
        {
            case < 0:
                Console.WriteLine("You have not been born yet");
                break;
            case < 13:
                Console.WriteLine("You are a child");
                break;
            case > 13 and < 18:
                Console.WriteLine("You are a teenager");
                break;
            default:
                Console.WriteLine("You are an adult");
                break;
        }
    }

    // 3. Ask the user to input their test score (0-100).
    // Assign grades as follows:
    // 90-100: A
    // 80-89: B
    // 70-79: C
    // 60-69: D
    // < 60: F
    // Print out the grade.
    public static void Exercise03()
    {
        Console.WriteLine("Enter your test score as an integer in the range 0 to 100:");
        int score;

        while (true)
        {
            try
            {
                score = Convert.ToInt32(Console.ReadLine());
                if (score is < 0 or > 100)
                {
                    Console.WriteLine("Please enter a valid test score.");
                    continue;
                }

                break;
            }
            catch
            {
                Console.WriteLine("Please enter a valid integer");
            }
        }


        char grade = score switch
        {
            < 60 => 'F',
            <= 69 => 'D',
            < 79 => 'C',
            < 89 => 'B',
            _ => 'A'
        };
        Console.WriteLine($"Your grade is {grade}.");
    }

    // 4. Leap Year Checker:
    // Ask the user to input a year.
    // Check if the year is a leap year or not (Hint: a leap year is divisible by 4 and not
    // divisible by 100, unless it is also divisible by 400).
    // Print the result.
    public static void Exercise04()
    {
    }

    // 5. Maximum of Three:
    // Input three numbers from the user.
    // Find and print the maximum of the three numbers using if-else.
    public static void Exercise05()
    {
        List<int> numbers = [];

        while (numbers.Count < 3)
        {
            try
            {
                Console.WriteLine($"Input integer {numbers.Count + 1}:");
                var integer = Convert.ToInt32(Console.ReadLine());
                numbers.Add(integer);
            }
            catch
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }

        // int max = numbers.Max();
        int max = numbers.First();
        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
        }

        Console.WriteLine($"Max number is {max}.");
    }

    // 6. Positive, Negative, or Zero:
    // Input a number.
    // Check whether it's positive, negative, or zero.
    // Print the result.
    public static void Exercise06()
    {
        int number;
        while (true)
        {
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }

        if (number.Equals(0))
            Console.WriteLine("Zero");
        else if (number < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Positive");
    }

    // 7. Discount System:
    // Input the total amount of a purchase.
    // If the amount is above $1000, give a discount of 10%.
    // Print the final amount after the discount.
    public static void Exercise07()
    {
    }

    // 8. Weekdays:
    // Input a number between 1 and 7.
    // Print the corresponding day of the week (e.g., 1 for Monday, 2 for Tuesday, etc.).
    // If the number is outside the 1-7 range, print an error message.
    public static void Exercise08()
    {
    }

    // 9. Password Checker:
    // Have a predefined password (e.g., "CSharp123").
    // Ask the user to input a password.
    // If the input matches the predefined password, print "Access granted".
    // Otherwise, print "Access denied".
    public static void Exercise09()
    {
    }

    // 10. Temperature Converter:
    // Ask the user if they want to convert from Fahrenheit to Celsius or vice versa.
    // Take the temperature input.
    // Perform the conversion using if-else.
    // Print the converted temperature.
    public static void Exercise10()
    {
    }
}