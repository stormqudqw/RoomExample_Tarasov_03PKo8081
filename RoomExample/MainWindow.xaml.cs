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
using RoomLibrary;

namespace RoomExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room1 = new Room();
        Room room2 = new Room();
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpen2.IsEnabled = true;
            room1.RoomLenght = rnd.Next(2, 11);
            room1.RoomWidht = rnd.Next(2, 11);
            int numP = rnd.Next(1, 9);

            LableLenght1.Content = room1.RoomLenght;
            LableWight1.Content = room1.RoomWidht;
            LableNumPerson1.Content = numP;

            LablePerimeter1.Content = room1.RoomPerimeter();
            LableArea1.Content = room1.RoomArea();
            LablePersonArea1.Content = Math.Round( room1.PersonArea(numP),3);
        }

        private void TBLenght2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonOpen2_Click(object sender, RoutedEventArgs e)
        {
            ButtonAll.IsEnabled = true; 
            room2.RoomLenght = Convert. ToDouble(TBLenght2.Text);
            room2.RoomWidht = Convert.ToDouble(TBWidth2.Text);
            int nump = Convert.ToInt32(TBNumPerson2.Text);
            //вычисление периметра, площади, метража и вывод в метки
            LablePerimeter2.Content = room2.RoomPerimeter();
            LableArea2.Content = room2.RoomArea();
            LabelPersonArea2.Content = Math.Round(room2.PersonArea(nump), 3);
        }

        private void ButtonAll_Click(object sender, RoutedEventArgs e)
        {
            LableAllArea.Content = room1.RoomArea()+room2.RoomArea();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
