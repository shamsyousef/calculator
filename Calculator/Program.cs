bool continueCalculation = true;

while (continueCalculation)
{
    Console.WriteLine("Simple Calculator");

    double firstNumber;
    double secondNumber;

    Console.Write("Enter first number: ");
    while (!double.TryParse(Console.ReadLine(), out firstNumber))
    {
        Console.Write("Invalid input. Please enter a valid number: ");
    }

    Console.Write("Enter second number: ");
    while (!double.TryParse(Console.ReadLine(), out secondNumber))
    {
        Console.Write("Invalid input. Please enter a valid number: ");
    }

    Console.Write("Choose operation (+, -, *, /): ");
    string? operation = Console.ReadLine();

    double result;

    switch (operation)
    {
        case "+":
            result = firstNumber + secondNumber;
            Console.WriteLine($"Result: {result}");
            break;

        case "-":
            result = firstNumber - secondNumber;
            Console.WriteLine($"Result: {result}");
            break;

        case "*":
            result = firstNumber * secondNumber;
            Console.WriteLine($"Result: {result}");
            break;

        case "/":
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            else
            {
                result = firstNumber / secondNumber;
                Console.WriteLine($"Result: {result}");
            }
            break;

        default:
            Console.WriteLine("Invalid operation.");
            break;
    }

    Console.Write("Do you want to perform another calculation? (y/n): ");
    string? choice = Console.ReadLine();

    continueCalculation = choice?.ToLower() == "y";

    Console.WriteLine();
}