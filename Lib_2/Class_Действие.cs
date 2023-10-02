using System;

namespace Lib_2
{
    public class Class_Действие
    {
        public static int GetProiz(int[] mas )
        {
            int rez = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                rez *= mas[i];
                
            }
            return rez;
        }
    }
}
