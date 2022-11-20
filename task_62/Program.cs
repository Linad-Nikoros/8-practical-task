// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] array1 = new int[4, 4];

int num_boster = 1;

for (int reducer = 0; reducer < array1.GetLength(0) - 2; reducer++)
{
    for (int i = 0 + reducer; i < array1.GetLength(0) - reducer; i++)
    {
        array1[0 + reducer, i] = num_boster;
     num_boster++;
    }
 num_boster--;

    for (int i = 0 + reducer; i < array1.GetLength(0) - reducer; i++)
    {
        array1[i, 3 - reducer] = num_boster;
     num_boster++;
    }
 num_boster--;

    for (int i = array1.GetLength(0) - 1 - reducer; i >= 0 + reducer; i--)
    {
        array1[3 - reducer, i] = num_boster;
     num_boster++;
    }
 num_boster--;

    for (int i = array1.GetLength(0) - 1 - reducer; i > 0 + reducer; i--)
    {
        array1[i, 0 + reducer] = num_boster;
     num_boster++;
    }
 num_boster--;
 num_boster++;
}

print_array(array1);
void print_array(int[,] array001)
{
    for (int i = 0; i < array001.GetLength(0); i++)
    {
        for (int j = 0; j < array001.GetLength(1); j++)
        {
            Console.Write(array001[i, j] +"\t");
        }
        Console.WriteLine();
    }
}