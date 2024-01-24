int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

// Чтобы убедиться что все элемменты массива найдены выдем исходный на экран через функкцию
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} "); //интерполяция строк.
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4); // Точка входа в наш код
ShowMatrix(matrix); //вызов функции вывода массива на экран.

// Воспользуемся условной конструкцией if и в качестве условия проверим возвращенное значение функции IsInteresting на истинность. Если она вернет
// значение TRUE, то выведем проверяемый элемент массива на экран. Если вернет FALSE, то никаких дополнительных действий не делаем.

foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine($"{e}");
    }
}
// функция проверки на интересность принмает на вход целое число
// функцию суммирования четных чисел вынесем в отдельную функцию, а в текущей оставим задел для ее вызова.
bool IsInteresting(int value)
{
    int SumOfDigits = GetSumDigits(value);
    if (SumOfDigits % 2 == 0)
    {
        return true;
    }
        return false;
}

int GetSumDigits(int value)
{
    int sum = 0;
    while (value > 0) // делить value на 10 имеет смысл, если оно больше 0;
    {
        sum = sum + value % 10;
        value = value / 10; // Переменная value в цикле каждый раз уменьшается на 10, но бесконечно так продожаться не может и нужно задать огрничение в условии цикла While. 
    }
    return sum;
}