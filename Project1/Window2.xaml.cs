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
using System.Windows.Shapes;

namespace Project1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public int Stackcost = 0;
        public int Topping = 0;
        public int counter = 0;

        public Window2()
        {
            InitializeComponent();
        }

        public void addTopping() {
            Console.WriteLine("checked");


            counter++;


            if (counter > 3)
            {
                int extras = counter - 3;

                Topping = extras * 1;
            }
            else
            {
                Topping = 0;
            }

            Totalbl.Content = (Stackcost + Topping).ToString();
        }

        public void removeTopping()  {

            Console.WriteLine("unchecked");

            Console.WriteLine("before removing" + counter);
            counter--;

            Console.WriteLine("after removing" + counter);


            if(counter > 3)
            {
                int extras = counter - 3;

                Topping = extras * 1;
            }
            else
            {
                Topping = 0;
            }


            Totalbl.Content = (Stackcost + Topping).ToString();

        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            Stackcost = 8;
            Totalbl.Content = Stackcost.ToString();
        }

        private void RadioButton2_Checked(object sender, RoutedEventArgs e)
        {
            Stackcost = 14;
            Totalbl.Content = Stackcost.ToString();
        }

        private void RadioButton3_Checked(object sender, RoutedEventArgs e)
        {
            Stackcost = 26;
            Totalbl.Content = Stackcost.ToString();
        }

        private void Topping1_Checked(object sender, RoutedEventArgs e)
        {
            if (Topping1.IsChecked == true)
            {
                addTopping();
            }
            else
            {
                removeTopping();
            }
        }

        private void Topping2_Checked(object sender, RoutedEventArgs e)
        {
            if (Topping2.IsChecked == true)
            {
                addTopping();
            }
            else
            {
                removeTopping();
            }
        }

        private void Topping3_Checked(object sender, RoutedEventArgs e)
        {
            if (Topping3.IsChecked == true)
            {
                addTopping();
            }
            else
            {
                removeTopping();
            }
        }

        private void Topping4_Checked(object sender, RoutedEventArgs e)
        {
            if (Topping4.IsChecked == true)
            {
                addTopping();
            }
            else
            {
                removeTopping();
            }
        }

        private void Topping5_Checked(object sender, RoutedEventArgs e)
        {
            if (Topping5.IsChecked == true)
            {
                addTopping();
            }
            else
            {
                removeTopping();
            }
        }

        private void Topping6_Checked(object sender, RoutedEventArgs e)
        {
            if (Topping6.IsChecked == true)
            {
                addTopping();
            }
            else
            {
                removeTopping();
            }
        }

        private void Side1_Checked(object sender, RoutedEventArgs e)
        {
            if (Side1.IsChecked == true)
            {
                addTopping();
            }
            else
            {
                removeTopping();
            }
        }

        private void Side2_Checked(object sender, RoutedEventArgs e)
        {

       


            if (Side2.IsChecked == true)
            {
                addTopping();
            }
            else
            {
                removeTopping();
            }
        }

    }
}
