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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Button1ClickExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            album.Source = new BitmapImage(new Uri("Data/_1.jpg", UriKind.Relative));
        }

        private void Button2ClickExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            album.Source = new BitmapImage(new Uri("Data/_2.jpg", UriKind.Relative));
        }

        private void Button3ClickExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            album.Source = new BitmapImage(new Uri("Data/_3.jpg", UriKind.Relative));
        }

        private void Button4ClickExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            album.Source = new BitmapImage(new Uri("Data/_4.jpg", UriKind.Relative));
        }

        private void Button5ClickExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            album.Source = new BitmapImage(new Uri("Data/_5.jpg", UriKind.Relative));
        }

        private void Button6ClickExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            album.Source = new BitmapImage(new Uri("Data/_6.jpg", UriKind.Relative));
        }

        private void Button7ClickExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            album.Source = new BitmapImage(new Uri("Data/_7.jpg", UriKind.Relative));
        }

        private void Button8ClickExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            album.Source = new BitmapImage(new Uri("Data/_8.jpg", UriKind.Relative));
        }

        private void Button9ClickExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            album.Source = new BitmapImage(new Uri("Data/_9.jpg", UriKind.Relative));        }

        private void Button10ClickExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            album.Source = new BitmapImage(new Uri("Data/_10.jpg", UriKind.Relative));
        }
    }
}
