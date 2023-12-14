using System;
using System.IO;
namespace LibMatr
{
    public class Class_Сохранить
    {
        public static void Save(int[,] matr)
        {
            StreamWriter stream = new StreamWriter("массив.txt");
            stream.WriteLine(matr.GetLength(0));
            stream.WriteLine(matr.GetLength(1));
            for (int i = 0; i < matr.GetLength(0); i++)
                for (int j = 0; j < matr.GetLength(1);j++)
            {
                stream.WriteLine(matr[i,j]);
            }
            stream.Close();
        }
        public static void Insert(out int[,] matr)
        {
            StreamReader stream = new StreamReader("массив.txt");
            int len = Convert.ToInt32(stream.ReadLine());
            int men = Convert.ToInt32(stream.ReadLine());
            matr = new Int32[len,men];
            for (int i = 0; i < matr.GetLength(0); i++)
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i,j] = Convert.ToInt32(stream.ReadLine());
            }
            stream.Close();
        }
        
        
    }
}
