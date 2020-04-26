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
using Bmi_Calculator.BL;

namespace PTO_10_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BmiModel NieuweBerekening = new BmiModel();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnResultaat_Click(object sender, RoutedEventArgs e)
        {
            NieuweBerekening.BerekenBmi(txtGewicht.Text, txtLengte.Text);
            lblUitkomst.Content = NieuweBerekening.Feedback;
        }
    }
}
