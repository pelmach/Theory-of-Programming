using System;
class Program
{
    public static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine()); //Размер одномерного массива
        int m = Convert.ToInt32(Console.ReadLine()); //Размер матрицы
        int num = Convert.ToInt32(Console.ReadLine()); //n ряда в задаче про сумму ряда
        int[] mas = new int[n]; 
        int[,] matrix = new int[m, m];
        double num1 = Sum(num);
        int num2 = change(num);
        Console.WriteLine("Сумма ряда " + num1);
        Console.WriteLine("Колво перестановок " + num2);
       
        
    }
    static void InputMatr(int[,] matrix, int m) // Ввод матрицы
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine()); 
            }
        }
    }
    static void OutputMatr(int[,] matrix, int m) // Вывод матрицы
    {
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
    }

    static void InputMas(int[] mas) //Ввод одномерного массива
    {
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    static void OutputMas(int[] mas) //Вывод одномерного массива
    {

        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write(mas[i] + " ");
        }
    }
    static void Sort(int[] mas) //Реализация сортировки выбором для одномерного массива
    {
        for (int i = 0; i < mas.Length - 1; i++)
        {
            int max = i;
            for (int j = i + 1; j < mas.Length; j++)
            {
                if(mas[j] > mas[max]){
                    max = j;
                }
            }
            Swap(ref mas[max],ref mas[i]);
        }
    }
    static void MatrixSort(int[,] matrix, int m)
    {
        // Сортировка выборкой для матрицы
        // Отсортировать все диагонали (вдоль побочной) квадратной матрицы по возрастанию
        int[,] NewMatrix = new int[m, m];
        for (int k = 0; k < m; k++)
        {
            int num = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i+j == k)
                    {
                        NewMatrix[i, num] = matrix[i, j];
                        num++;
                    }
                    if (i+j == k + 1)
                    {
                        NewMatrix[i, num] = matrix[i, j];
                        num++;
                    }
                }
            }
        }
        OutputMatr(NewMatrix, m);
    }
    static void Swap(ref int a,ref int b)
    {
        int num = a;
        a = b;
        b = num;
    }
    static double  Sum(int n)
        // сумма ряда
    {
        double result = 0;
        result += Math.Pow(-1, n - 1) * 1 / Math.Pow(2, n - 1);
        if (n == 1) {
            return result;
        }
        return Sum(n - 1);
           
    }
    static int change(int n)
        // колво переставновок 
    {
        if(n == 1)
        {
            return 1;
        }
        return n * change(n - 1);
    }
    
}
