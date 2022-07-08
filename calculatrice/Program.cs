// See https://aka.ms/new-console-template for more information

double calculate(double a, double b, char operation)
{
    switch (operation)
    {
        case '+':
            return a + b;
        case '-':   
            return a - b;
        case '*':
            return a * b;
        case '/':
            return a / b;
        default:
            Console.WriteLine("The operation entred is not correcte");
            return 0;
    }
}
double a;
double b;
char operation;

Console.Write("Enter the fisrt number a = ");
a = double.Parse(Console.ReadLine());

Console.Write("Enter the second number b = ");
b = double.Parse(Console.ReadLine());

Console.Write("Enter the operation symbole : ");
operation = Char.Parse(Console.ReadLine());



Console.WriteLine($"The result of {a} {operation} {b} = {calculate(a, b, operation)}");

