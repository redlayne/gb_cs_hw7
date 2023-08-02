internal class Program
{
    private static void Main(string[] args)
    {   
        Console.Clear();

        void DoubleArrayTask47()
        {   
            int rowsInArray = CustomLibClass.Input("How many rows? ");
            int columnsInArray = CustomLibClass.Input("How many columns? ");

            double[,] justarray = CustomLibClass.Generate2DArrayDouble(rowsInArray, columnsInArray, -5, 5, 1); // rows, columns, from, to, round
            CustomLibClass.Print2DArrayDouble(justarray);
        }

        void ElementSearchTask50()
        {   
            int[,] myarray = CustomLibClass.Generate2DArray(4, 6, 10, 100); // rows, columns, from, to
            Console.WriteLine("Here is your table.\n");
            CustomLibClass.Print2DArray(myarray);

            Console.WriteLine();
            int rowCheck = CustomLibClass.Input("Row index? ");
            int columnCheck = CustomLibClass.Input("Column index? ");

            if (rowCheck >= myarray.GetLength(0) || columnCheck >= myarray.GetLength(1) || rowCheck <0 || columnCheck <0) Console.WriteLine("No such index!");
            else Console.WriteLine($"Your element is {myarray[rowCheck, columnCheck]}");
        }

        void ColumnAverageTask52()
        {   
            int[,] somearray = CustomLibClass.Generate2DArray(3, 5, 10, 100); // rows, columns, from, to
            Console.WriteLine("Here is your table.\n");
            CustomLibClass.Print2DArray(somearray);

            double[] averagearray = new double[somearray.GetLength(1)];

            for (int i = 0; i < somearray.GetLength(1); i++)
            {
                double columnSum = 0;
                for (int j = 0; j < somearray.GetLength(0); j++)
                {
                    columnSum += somearray[j,i];
                }
                averagearray [i] = columnSum / somearray.GetLength(0);
            }

            Console.WriteLine();
            Console.WriteLine("Columns averages:");
            CustomLibClass.PrintDoubleArray(averagearray);
        }    

        DoubleArrayTask47();

        CustomLibClass.Anykey();
        CustomLibClass.Break();
        
        ElementSearchTask50();

        CustomLibClass.Anykey();
        CustomLibClass.Break();

        ColumnAverageTask52();
        CustomLibClass.Break();
        
    }
}