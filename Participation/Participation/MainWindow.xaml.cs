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

namespace Participation
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Toy> ToyBox = new List<Toy>();
            Toy t1 = new Toy();
            t1.Manufacturer = ManInput.Text;
            t1.Name = ToyInput.Text;
            double priceFin = 0;
            if (double.TryParse(PriceInput.Text, out priceFin) == false)
            {
                MessageBox.Show("Hello user, please input a number.");
                PriceInput.Text = PriceInput.Text;
            }
            else
            {
                t1.Price = priceFin;
            }
            t1.Image = urlInput.Text;

            ToyBox.Add(t1);
            foreach (var item in ToyBox)
            {
                ListOfToys.Items.Add(item);
            }
            ManInput.Clear();
            ToyInput.Clear();
            PriceInput.Clear();
            urlInput.Clear();
        }

        private void ListOfToys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Toy selectedToy = (Toy)ListOfToys.SelectedItem;
            MessageBox.Show($"{selectedToy.GetAisle()}");


        }
    }
}
