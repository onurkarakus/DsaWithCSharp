namespace ArraysCode.MultiDimensional;

public static class MultiplicationTable
{
    public static void RunSample()
    {
        int[,] multiplicationTable = new int[10, 10];

        for (int row = 0; row < multiplicationTable.GetLength(0); row++)
        {
            for (int column = 0; column < multiplicationTable.GetLength(1); column++)
            {
                multiplicationTable[row, column] = (row + 1) * (column + 1);
            }
        }

        for (int row = 0; row < multiplicationTable.GetLength(0); row++)
        {
            for (int column = 0; column < multiplicationTable.GetLength(1); column++)
            {
                Console.Write("{0,4}", multiplicationTable[row, column]);
            }

            Console.WriteLine();
        }
    }
}
