using System;
using Пример_таблицы_WPF;
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
        int[,] matr;
        int n = 0;
        int i, j, x;

        private void MenuItem_Click_О_программе(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Автор: Соколов Даниил  Практическая работа №2 \n Цель:Дана целочисленная матрица размера M × N.\n Найти номер последнего из ее столбцов, содержащих равное количество положительных и отрицательных элементов (нулевые элементы матрицы не учитываются).\n Если таких столбцов нет, то вывести 0.. ");

        }

        private void MenuItem_Click_Выход(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_Сохранить(object sender, RoutedEventArgs e)
        {
            LibMatr.Class_Сохранить.Save(matr);
        }

        private void MenuItem_Click_Вставить(object sender, RoutedEventArgs e)
        {
            LibMatr.Class_Сохранить.Insert(out matr);
            dg_matr.ItemsSource = VisualArray.ToDataTable(matr).DefaultView;
            
        }

        private void Cl_Выявить(object sender, RoutedEventArgs e)
        {
             x= Lib_2.Class_Действие.Getnomb(matr, out x);
            TextBox_Rez.Text = Convert.ToString(x);
        }

        private void Click_Размер(object sender, RoutedEventArgs e)
        {
            MenuItem_Сохранить.IsEnabled = true;
            if (int.TryParse(tb_strock.Text, out int n)) // проверка является ли значение числом
            {
                if (int.TryParse(tb_stolb.Text, out int m))
                    
                {
                    matr = new Int32[n, m];
                    if (n > 0 && m > 0)
                    {
                        Random rnd = new Random();
                        for (i = 0; i < n; i++)
                        for (j = 0; j < m; j++) matr[i, j] = rnd.Next(-100, 100);
                        
                            dg_matr.ItemsSource = VisualArray.ToDataTable(matr).DefaultView;
                    }
                    else
                        MessageBox.Show("Введите размер матрицы правильно");
                }
                else
                    MessageBox.Show("Введите размер матрицы правильно");

            }

        }
    } 
}