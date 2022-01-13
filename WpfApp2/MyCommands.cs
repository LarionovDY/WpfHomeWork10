using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp2
{
    class MyCommands
    {
        public static RoutedCommand Button1Click { get; set; }
        public static RoutedCommand Button2Click { get; set; }
        public static RoutedCommand Button3Click { get; set; }
        public static RoutedCommand Button4Click { get; set; }
        public static RoutedCommand Button5Click { get; set; }
        public static RoutedCommand Button6Click { get; set; }
        public static RoutedCommand Button7Click { get; set; }
        public static RoutedCommand Button8Click { get; set; }
        public static RoutedCommand Button9Click { get; set; }
        public static RoutedCommand Button10Click { get; set; }
        static MyCommands()
        {
            Button1Click = new RoutedCommand();
            Button2Click = new RoutedCommand();
            Button3Click = new RoutedCommand();
            Button4Click = new RoutedCommand();
            Button5Click = new RoutedCommand();
            Button6Click = new RoutedCommand();
            Button7Click = new RoutedCommand();
            Button8Click = new RoutedCommand();
            Button9Click = new RoutedCommand();
            Button10Click = new RoutedCommand();
        }
    }
}
