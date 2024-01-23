using System;
namespace Проект1
{
    // Создаем класс BigInteger, который реализует интерфейс IArithmeticOperations
	public class BigInteger : IArithmeticOperations<BigInteger>
    {
        private System.Numerics.BigInteger value;

        // Конструктор класса, принимающий значение типа System.Numerics.BigInteger
        public BigInteger(System.Numerics.BigInteger value)
        {
            this.value = value;
        }

        // Метод для получения значения BigInteger
        public System.Numerics.BigInteger GetValue()
        {
            return value;
        }

        // Переопределяем метод ToString для получения строкового представления BigInteger
        public override string ToString()
        {
            return value.ToString();
        }
        
        // Реализация метода сложения
        public BigInteger Add(BigInteger a, BigInteger b)
        {
            return new BigInteger(a.value + b.value);
        }

        // Реализация метода вычитания
        public BigInteger Subtract(BigInteger a, BigInteger b)
        {
            return new BigInteger(a.value - b.value);
        }

        // Реализация метода умножения
        public BigInteger Multiply(BigInteger a, BigInteger b)
        {
            return new BigInteger(a.value * b.value); 
        }

        // Реализация метода деления
        public BigInteger Divide(BigInteger a, BigInteger b)
        {
            if (b.value == 0)
            {
                // Дает цвет тексту
                Console.ForegroundColor = ConsoleColor.DarkRed;             
                throw new ArgumentException("Невозможно делить на 0!");
                // Возвращает на первоначальный вид
                Console.ResetColor();                                       
            }

            return new BigInteger(a.value / b.value);
        }
    }
}

