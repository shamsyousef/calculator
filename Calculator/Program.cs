Console.WriteLine("Simple Calculator");

Console.Write("Enter first number: ");
double firstNumber = double.Parse(Console.ReadLine()!);

Console.Write("Enter second number: ");
double secondNumber = double.Parse(Console.ReadLine()!);

Console.Write("Choose operation (+, -, *, /): ");
string operation = Console.ReadLine()!;

double result = 0;

switch (operation)
{
    case "+":
        result = firstNumber + secondNumber;
        break;

    case "-":
        result = firstNumber - secondNumber;
        break;

    case "*":
        result = firstNumber * secondNumber;
        break;

    case "/":
        result = firstNumber / secondNumber;
        break;
}

Console.WriteLine($"Result: {result}");