namespace Cloud24.Course1.Theory;

public class Car
{
    public string Make { get; set; }
    public string Color { get; set; }

    public override string ToString()
    {
        return $"Car: {Make} - {Color}";
    }
}