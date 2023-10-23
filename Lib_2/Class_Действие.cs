using System;

namespace Lib_2
{
    public class Class_Действие
    {
        public static int Getnomb(int[,] matr, out int x)
        {   

              int n = 0;
              int m = 0;
              x = 0;
              

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                n = 0;
                m = 0;
                
                 

                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] < 0) n++;

                    if (matr[i, j] > 0) m++;

                }
                if (n == m) x = i+1;
            }
            
                    return x;
        }
    }
}
