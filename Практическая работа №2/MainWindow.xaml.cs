using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практическая_работа__2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[] mas;
        int n = 0;
        private void Click_Добавить_число(object sender, RoutedEventArgs e)
        {
             if (mas == null)
             {
                MessageBox.Show("Создайте массив");
                return;
             }

            if (int.TryParse(TextBox_K.Text, out int K)) // проверка является ли значение числом
            {
                if (K != 0)
                {

                    TextBox_K.Clear();
                    mas[n++] = K;
                }
                    else
                    MessageBox.Show("Введите число отличное от нуля");
                if (n == mas.Length)
                {
                    Button_Добавить.IsEnabled = false;
                    MenuItem_Сохранить.IsEnabled = true;
                    
                 
                }
                

            
            }
            else
                MessageBox.Show("Введите число отличное от нуля");
        }





        private void Click_Помножить(object sender, RoutedEventArgs e)
        {
            TextBox_Rez.Text = Lib_2.Class_Действие.GetProiz(mas).ToString();
        }

        private void MenuItem_Click_О_программе(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Автор: Соколов Даниил  Практическая работа №2 \n Цель:Ввести n целых чисел(>0 или <0). Найти произведение чисел. Результат вывести на экран. ");
            
        }

        private void MenuItem_Click_Выход(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_Сохранить(object sender, RoutedEventArgs e)
        {
            LibMas.Class_Сохранить.Save(mas);
        }

        private void MenuItem_Click_Вставить(object sender, RoutedEventArgs e)
        {
            LibMas.Class_Сохранить.Insert(out mas);
        }

        private void Click_Размер(object sender, RoutedEventArgs e)
        {
            
            if (int.TryParse(TextBox_Razm.Text, out int i)) // проверка является ли значение числом
            {
                if (i > 0)
                {
                    mas = new int[i];
                    n = 0 ;
                    Button_Добавить.IsEnabled = true;

                    MenuItem_Сохранить.IsEnabled = false;
                   
                    TextBox_Rez.Clear();

                }
                else
                MessageBox.Show("Введите размер массива правильно");
            }
            else
            MessageBox.Show("Введите размер массива правильно");
        }

    }
}
    

