// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Функция FillArray наполняет массив случайными целыми числами
int[,] FillArray(int[,] matr, int lBound, int hBound)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(lBound, hBound);
    return matr;
}

// Функция WorkArray ищет среднее арифметическое по столбцам
void AverageColumnArray(int[,] matr)
{
    Console.WriteLine("Среднее арифметическое:");
    for (int j = 0; j < matr.GetLength(1); j++)                         // цикл по столбцам
    {
        float sum = 0;                                                  // накопитель суммы
        for (int i = 0; i < matr.GetLength(0); i++)                     // цикл по строкам
            sum += matr[i, j];
        Console.Write($"\t{Math.Round(sum / matr.GetLength(0), 2)}");
    }
}

// Функция PrintArray выводит значения массива на консоль
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write("\t" + matr[i, j]);
        Console.WriteLine();
    }
}

const int m = 3;                                                          //  размерность массива по вертикали
const int n = 4;                                                          //  размерность массива по горизонтали
int[,] matrix = new int[m, n];
Console.Clear();                                                       //  очистка консоли
FillArray(matrix, 0, 10);                                                //  вызов функции по наполнению массива случайными целыми числами
PrintArray(matrix);                                                    //  вызов функции по выводу массива в консоль для контроля   
AverageColumnArray(matrix);                                            //  вызов функции расчету сред. арифм. по столбцам