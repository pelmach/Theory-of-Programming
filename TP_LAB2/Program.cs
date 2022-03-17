using System;
class Program
{
    public static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine()); //Размер одномерного массива
        int m = Convert.ToInt32(Console.ReadLine()); //Размер матрицы
        int[] mas = new int[n]; 
        int[,] matrix = new int[m, m]; 
         
        Console.WriteLine();
        InputMatr(matrix, m);
        MatrixSort(matrix, m);
        OutputMatr(matrix, m);
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
        for (int i = 0; i < m; i++)
        {
            int max = i;
            for (int j = 0; j < m; j++)
            {
                if(i > 0 && j > 0 && i < m && j < m)
                {
                    if(matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                    if (i + j % 2 == 0)
                    {
                        if (matrix[i, i] > max)
                        {
                            max = matrix[i, i];

                        }
                        else
                        {
                            Swap(ref matrix[i, j], ref matrix[i, i]);
                        }
                        if (matrix[j, i] > max)
                        {
                            max = matrix[j, i];
                        }
                        else
                        {
                            Swap(ref max, ref matrix[j, i]);
                        }
                    }
                    else
                    {
                        if (matrix[j, i] > max)
                        {
                            max = matrix[j, i];
                        }
                        else
                        {
                            Swap(ref max, ref matrix[j, i]);
                        }
                    }
                } 
            }
        }

    }
    static void Swap(ref int a,ref int b)
    {
        int num = a;
        a = b;
        b = num;
    }

}
