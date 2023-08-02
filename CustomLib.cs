public static class CustomLibClass
{

    public static void Break()
    {
        Console.WriteLine();
        Console.WriteLine(new string('*', 50));
        Console.WriteLine();
    }

    public static int Input(string inputmessage)
    {
        Console.Write(inputmessage);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
    }

    public static int[] GenerateArray(int arraysize, int from, int to)
    {
        Random rand = new Random();

        int[] newarray = new int[arraysize];
        for (int i = 0; i < arraysize; i++)
        {
            newarray[i] = rand.Next(from, to);
        }
        return newarray;
    }

    public static double[] GenerateDoubleArray(int arraysize, int from, int to)
    {
        Random rand = new Random();

        double[] newarray = new double[arraysize];
        for (int i = 0; i < arraysize; i++)
        {
            newarray[i] = Math.Round(rand.Next(from, to) + rand.NextDouble(), 2);
        }
        return newarray;
    }

    public static void PrintArray(int[] arr)
    {
        int arrsize = arr.Length;
        Console.Write("[");
        for (int i = 0; i < arrsize; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        Console.Write("\b]\n");
    }
    
    public static void PrintDoubleArray(double[] arr)
    {
        int arrsize = arr.Length;
        Console.Write("[");
        for (int i = 0; i < arrsize; i++)
        {
            Console.Write($"{arr[i].ToString("0.00")}  ");
        }
        Console.Write("\b\b]\n");
    }

    public static int[,] Generate2DArray(int rows, int columns, int from = 10, int to = 100)
    {
        Random rand = new Random();
        int[,] newarray = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {   
            for (int j = 0; j < columns; j++)
            {
                newarray[i,j] = rand.Next(from, to);
            }
        }

        return newarray;
    }

    public static void Print2DArray(int[,] arrayToPrint)
    {
        for (int i = 0; i < arrayToPrint.GetLength(0); i++)
        {   
            for (int j = 0; j < arrayToPrint.GetLength(1); j++)
            {
                Console.Write($"{arrayToPrint[i,j]}\t");
            }
            Console.WriteLine();
        }
    }

    public static double[,] Generate2DArrayDouble(int rows, int columns, int from = 10, int to = 100, int round = 2)
    {
        Random rand = new Random();
        double[,] newarray = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {   
            for (int j = 0; j < columns; j++)
            {
                newarray[i,j] =  Math.Round(rand.Next(from, to)+ rand.NextDouble(), round);
            }
        }
        return newarray;
    }

    public static void Print2DArrayDouble(double[,] arrayToPrint)
    {
        for (int i = 0; i < arrayToPrint.GetLength(0); i++)
        {   
            for (int j = 0; j < arrayToPrint.GetLength(1); j++)
            {
                Console.Write($"{arrayToPrint[i,j]}\t");
            }
            Console.WriteLine();
        }
    }

    public static void Anykey()
    {
        Console.Write("\npress any key to continue...");
        Console.ReadKey();
        Console.Write("\b"+ " ");

    }

}