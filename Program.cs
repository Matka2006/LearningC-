class Program
{
    static void Main(string[] args)
    {

        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Not a number!");
            Console.Read();
            return;
        }
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Not a number!");
            Console.Read();
            return;
        }

        var s = Console.ReadLine();
        var boolVar = true;
        if (s.Length == 0 || s.Length > 1 && !boolVar)
        {
            Console.WriteLine("Wrong sign");
            Console.Read();
            return;
        }

        switch (s[0])
        {
            case '+':
                Console.WriteLine("Result of {0} + {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a + b, Convert.ToString(a + b, 2), Convert.ToString(a + b, 16));
                break;
            case '-':
                Console.WriteLine("Result of {0} - {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a - b, Convert.ToString(a - b, 2), Convert.ToString(a - b, 16));
                break;
            case '/':
                Console.WriteLine("Result of {0} / {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a / b, Convert.ToString(a / b, 2), Convert.ToString(a / b, 16));
                break;
            case '*':
                Console.WriteLine("Result of {0} * {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a * b, Convert.ToString(a * b, 2), Convert.ToString(a * b, 16));
                break;
            case '%':
                Console.WriteLine("Result of {0} % {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a % b, Convert.ToString(a % b, 2), Convert.ToString(a % b, 16));
                break;

        }

        Console.WriteLine("Also suggest using the following functions: &, |, ^");
        var c = Console.ReadLine();
        //var boolC = true;
        if (c[0] != '&' && c[0] != '|' && c[0] != '^' && c[0] != 'N')
        {
            Console.WriteLine("Wrong sign");
            Console.Read();
            return;
        }

        switch (c[0])
        {
            case '&':
                Console.WriteLine("Result of {0} & {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a & b, Convert.ToString(a & b, 2), Convert.ToString(a & b, 16));
                break;
            case '|':
                Console.WriteLine("Result of {0} | {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a | b, Convert.ToString(a | b, 2), Convert.ToString(a | b, 16));
                break;
            case '^':
                Console.WriteLine("Result of {0} ^ {1} = {2}, 0b: {3}, 0x: {4} ", a, b, a ^ b, Convert.ToString(a ^ b, 2), Convert.ToString(a ^ b, 16));
                break;
            case 'N':
                break;

        }

        Console.WriteLine("Thank you for using my calculator!!!");
        Console.Read();

    }
}

