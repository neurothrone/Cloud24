using Cloud24.Course1.Theory;

void TestCars()
{
    var c1 = new Car { Make = "Toyota", Color = "Silver" };
    var c2 = new Car { Make = "Ford", Color = "White" };

    var cars = new List<Car> { c1, c2 };

    foreach (var car in cars)
    {
        Console.WriteLine(car);
    }
}

void TestInputWithException()
{
    var input = Console.ReadLine() ?? string.Empty;

    try
    {
        var integer = int.Parse(input);
        Console.WriteLine($"Result: {integer}");
    }
    catch (FormatException _)
    {
        Console.WriteLine("Invalid input, that is not an integer.");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
}

void TestWithResultPattern(int balance, int amountToWithdraw)
{
    Result result;
    if (balance < amountToWithdraw)
    {
        result = Result.Failure("Insufficient balance.");
    }
    else
    {
        balance -= amountToWithdraw;
        result = Result.Success();
    }

    Console.WriteLine(result.IsSuccess ? $"{amountToWithdraw} withdrawn." : result.ErrorMessage);
}

TestCars();
// TestInputWithException();
// TestWithResultPattern(200, 300);
// TestWithResultPattern(200, 100);