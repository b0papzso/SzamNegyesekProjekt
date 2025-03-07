using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SzamNegyesekProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[,] table = new int[3, 3];

        public MainWindow()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void IncreaseTableSection(int row, int col)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    table[row + i, col + j]++;
                }
            }
            UpdateUI();
        }

        private void UpdateUI()
        {
            TableDisplay.Text = $"{table[0, 0]} {table[0, 1]} {table[0, 2]}\n" +
                                $"{table[1, 0]} {table[1, 1]} {table[1, 2]}\n" +
                                $"{table[2, 0]} {table[2, 1]} {table[2, 2]}";
        }

        private void ButtonA_Click(object sender, RoutedEventArgs e)
        {
            IncreaseTableSection(0, 0);
        }

        private void ButtonB_Click(object sender, RoutedEventArgs e)
        {
            IncreaseTableSection(0, 1);
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            IncreaseTableSection(1, 0);
        }

        private void ButtonD_Click(object sender, RoutedEventArgs e)
        {
            IncreaseTableSection(1, 1);
        }
        private void ButtonNull_Click(object sender, RoutedEventArgs e)
        {
            table[0, 0] = 0;
            table[0, 2] = 0;
            table[2, 0] = 0;
            table[2, 1] = 0;
            table[0, 1] = 0;
            table[2, 2] = 0;
            table[1, 0] = 0;
            table[1, 1] = 0;
            table[1, 2] = 0;
            UpdateUI();
        }
    }
}