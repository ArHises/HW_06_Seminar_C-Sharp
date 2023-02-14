// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] FillTable(int[,] table)
{
    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(0, 9);
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
int[,] ChangeFirstLastLines(int[,] table){
    int[] save = new int[table.GetLength(1)];

    for (int i = 0; i < table.GetLength(1); i++)// save first line to "save"
    {
        save[i] = table[0,i];
    }
    for (int i = 0; i < table.GetLength(1); i++)// change 1st line by last
    {
        table[0,i] = table[table.GetLength(0) - 1,i];
    }
    for (int i = 0; i < table.GetLength(1); i++)// change last line by "save"
    {
        table[table.GetLength(0) - 1,i] = save[i];
    }
    return table;
}
int[,] table = new int[4, 6];
FillTable(table);
PrintTable(table);

Console.WriteLine();

table = ChangeFirstLastLines(table);
PrintTable(table);