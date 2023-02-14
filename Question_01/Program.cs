// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] FillTable(double[,] table)
{
    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.NextDouble() + rnd.Next(0, 10);
        }
    }
    return table;
}
void PrintTable(double[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(" " + table[i,j]);
        }
        Console.WriteLine();
    }
}
double[,] table = new double[5, 5];
FillTable(table);
PrintTable(table);