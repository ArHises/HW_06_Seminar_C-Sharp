// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] FillTable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = i + j;
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
            Console.Write(" " + table[i,j]);
        }
        Console.WriteLine();
    }
}
int[,] table = new int[4,6];
FillTable(table);
PrintTable(table);