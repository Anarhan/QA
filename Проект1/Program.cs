namespace Проект1;
class Program 
{
    static void Main(string[] args)
    {
        try
        {
            // Получаем первое число от пользователя
            Console.Write("Введите первое число: ");
            string? num1Str = Console.ReadLine();
            BigInteger num1 = new BigInteger(System.Numerics.BigInteger.Parse(num1Str));

            // Получаем второе число от пользователя
            Console.Write("Введите второе число: ");
            string? num2Str = Console.ReadLine();
            BigInteger num2 = new BigInteger(System.Numerics.BigInteger.Parse(num2Str));

            // Пользователь выбирает операцию
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Выберите операцию +, -, *, / : \t ");
            char operation = Console.ReadKey().KeyChar;
            Console.ResetColor();

            //создаем экземпляр класса
            Program program = new Program();
            BigInteger result;

            // Выполняем выбранную операцию с помощью switch case
            switch (operation)
            {
                case '+':
                    result = program.Add(num1, num2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n\nСумма: " + result);
                    Console.ResetColor();
                    break;
                case '-':
                    result = program.Subtract(num1, num2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n\nРезультат вычитания: " + result);
                    Console.ResetColor();
                    break;
                case '*':
                    result = program.Multiply(num1, num2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n\n\nРезультат умножения: " + result);
                    Console.ResetColor();
                    break;
                case '/':
                    try   // Этот блок кода может вызвать исключение
                    {
                        result = program.Divide(num1, num2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\n\nРезультат деления: " + result);
                        Console.ResetColor();
                    }

                    // Этот блок выполняется, если в блоке try произошло исключение
                    catch (ArgumentException ex) 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n\nОшибка при делении: " + ex.Message);
                        Console.ResetColor();
                    }
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\nНедопустимая операция!!!");
                    Console.ResetColor();
                    break;
            }
        }
        // catch выполниться если в блоке try некорректный ввод
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\nНеверный ввод. Пожалуйста, введите допустимые целые числа.");
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nПроизошла ошибка: " + ex.Message);
            Console.ResetColor();
        }

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("\n\nДля выхода нажмите на Enter");
        Console.ResetColor();
        Console.ReadLine();
    }


    // Методы для выполнения арифметических операций с использованием класса BigInteger
    public BigInteger Add(BigInteger a, BigInteger b)
    {
        return a.Add(a, b);
    }

    public BigInteger Subtract(BigInteger a, BigInteger b)
    {
        return a.Subtract(a, b);
    }

    public BigInteger Multiply(BigInteger a, BigInteger b)
    {
        return a.Multiply(a, b);
    }

    public BigInteger Divide(BigInteger a, BigInteger b)
    {
        return a.Divide(a, b);
    }

}


