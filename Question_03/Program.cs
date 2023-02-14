// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] FillTable(int[,] table)
{
    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(0, 10);
        }
    }
    return table;
}
void PrintTable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(" " + table[i, j]);
        }
        Console.WriteLine();
    }
}
int[,] MakeOddIndexSquer(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0) table[i,j] = table[i,j] * table[i,j];
        }
    }
    return table;
}
int[,] table = new int[4, 6];
FillTable(table);
PrintTable(table);

Console.WriteLine();

MakeOddIndexSquer(table);
PrintTable(table);