using ConAppCalc;

static void Main(string[] args)
{
    // Create a new instance of the Calculator class
    Calculator calculator = new Calculator();
    // Perform some calculations
    int sum = calculator.Add(5, 3);
    int difference = calculator.Subtract(10, 4);
    int product = calculator.Multiply(6, 7);
    double quotient = calculator.Divide(20, 4);
    // Display the results
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Difference: {difference}");
    Console.WriteLine($"Product: {product}");
    Console.WriteLine($"Quotient: {quotient}");
}