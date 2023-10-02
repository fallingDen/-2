using System;
using System.IO;
namespace LibMas
{
    public class Class_Сохранить
    {
        public static void Save(int[] mas)
        {
            StreamWriter stream = new StreamWriter("массив.txt");
            stream.WriteLine(mas.Length);
            for (int i = 0; i < mas.Length; i++)
            {
                stream.WriteLine(mas[i]);
            }
            stream.Close();
        }
        public static void Insert(out int[] mas)
        {
            StreamReader stream = new StreamReader("массив.txt");
            int len = Convert.ToInt32(stream.ReadLine());
            mas = new Int32[len];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(stream.ReadLine());
            }
            stream.Close();
        }
        
        
    }
}
