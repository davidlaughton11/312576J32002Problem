//David Laughton
//April 11th 2019
//To see combos of tickets

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

namespace _312576j3Problems2002
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input;
        string[] inputlines = new string[10];
        int countlines = 0;
        int[] ticketcost = new int[4];
        int moneytoraise;

        public MainWindow()
        {
            InitializeComponent();
            numInput.Text += "\n";
            numInput.SelectionStart = numInput.Text.Length;
            numInput.Focus();
        }       

        int counter = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Take input
            ReadInput();
            

            
        }

        private void ReadInput()
        {
            //input
            input = numInput.Text;
            int index;

            while (input.Contains('\r'))
            {
                index = input.IndexOf('\r');
                input = input.Remove(index, 1);
            }

            inputlines = input.Split('\n');

            for (int i = 0; i < 4; i ++)
            {
                int.TryParse(inputlines[i * 2 + 1], out ticketcost[i]);
            }
            int.TryParse(inputlines[9], out moneytoraise);

        }
        private void numInput_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return && countlines == 0)
            {
                numInput.Text += "Cost of green tickets: \n";
                numInput.SelectionStart = numInput.Text.Length; countlines++;
            }
            else if (e.Key == Key.Return && countlines == 1)
            {
                numInput.Text += "Cost of red tickets: \n";
                numInput.SelectionStart = numInput.Text.Length; countlines++;
            }
            else if (e.Key == Key.Return && countlines == 2)
            {
                numInput.Text += "Cost of orange tickets: \n";
                numInput.SelectionStart = numInput.Text.Length; countlines++;
            }
            else if (e.Key == Key.Return && countlines == 3)
            {
                numInput.Text += "Money to raise: \n";
                numInput.SelectionStart = numInput.Text.Length; countlines++;
            }
        }    
    }
}
