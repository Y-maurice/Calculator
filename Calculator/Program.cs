Console.WriteLine("Calculator");

while (true)
{

    double firstNumber;

    while (true)
    {
        Console.Write("Enter first number: ");

        if (double.TryParse(Console.ReadLine(), out firstNumber))
        {
            break;
        }

        Console.WriteLine("Invalid input. Please enter a number.");
    }


    double secondNumber;

    while (true)
    {
        Console.Write("Enter second number: ");

        if (double.TryParse(Console.ReadLine(), out secondNumber))
        {
            break;
        }

        Console.WriteLine("Invalid input. Please enter a number.");
    }

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
            if (secondNumber == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return;
            }

            result = firstNumber / secondNumber;
            break;

        default:
            Console.WriteLine("Invalid operation.");
            return;
    }

    Console.WriteLine("Result: " + result);


    Console.Write("Do you want another calculation? (y/n): ");
    string answer = Console.ReadLine();

    if (answer.ToLower() != "y")
    {
        break;
    }

    Console.WriteLine();
}

