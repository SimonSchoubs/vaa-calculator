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

namespace VAACalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WagenStore Store { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Store = new WagenStore();
            updateScreen();
        }

        private void AddBenzineWagen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var wagen = new BenzineWagen(
                    TextBoxPrijs.Text,
                    TextBoxBouwjaar.Text,
                    TextBoxNummerplaat.Text,
                    TextBoxCO2.Text);
                Store.WagenToevoegen(wagen);
                updateScreen();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void AddDieselWagen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var wagen = new DieselWagen(
                    TextBoxPrijs.Text,
                    TextBoxBouwjaar.Text,
                    TextBoxNummerplaat.Text,
                    TextBoxNOx.Text);
                Store.WagenToevoegen(wagen);
                updateScreen();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void BerekenTotaal_Click(object sender, RoutedEventArgs e)
        {
            vaaTotaal.Content = "€" + Store.VAATotaal();
        }

        private void updateScreen()
        {
            TextBoxBouwjaar.Text = "";
            TextBoxCO2.Text = "";
            TextBoxNOx.Text = "";
            TextBoxNummerplaat.Text = "";
            TextBoxOutput.Text = "";
            TextBoxPrijs.Text = "";

            foreach (var wagen in Store.Lijst())
            {
                TextBoxOutput.AppendText(wagen.ToString() + "\n");
            }
        }
    }
}
