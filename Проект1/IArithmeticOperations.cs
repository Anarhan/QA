using System;
namespace Проект1
{
    // Интерфейс для арифметических операций, параметризованный типом T
    public interface IArithmeticOperations<T>
	{
        T Add(T a, T b);
        T Subtract(T a, T b);
        T Multiply(T a, T b);
        T Divide(T a, T b);
    }
}

