Console.WriteLine("Calculator");

Console.Write("Enter first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choose an operation:");
Console.WriteLine("+ Addition");
Console.WriteLine("- Subtraction");
Console.WriteLine("* Multiplication");
Console.WriteLine("/ Division");

Console.Write("Operation: ");
string operation = Console.ReadLine();

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

    default:
        Console.WriteLine("Invalid operation.");
        return;
}

Console.WriteLine("Result: " + result);