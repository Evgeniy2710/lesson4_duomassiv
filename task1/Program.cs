// Задача №1
// • Создать двумерный массив с размерами 3 x 5, состоящий из целых чисел
// • Вывести его элементы на экран
// int[,] matrix = new int[4, 5];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 11);
//         }
//     }
    

// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} "); //интерполяция строк.
//         }
//         Console.WriteLine();
//     }


int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

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

// Для вызова функции создания массива создадим переменную и передадим в нее параметры кол-ва строк и столбцов(нужные нам)
int[,] matrix = CreateMatrix(4, 5);
//затем выведем содержимое массива на экран. Укажем функцию и передадим соответсвующую переменную: matrix занчение которой было присвоено по результату выполненя функции CreateMatrix
ShowMatrix(matrix);

