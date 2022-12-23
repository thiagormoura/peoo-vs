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

namespace EscolaApp
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
        private void Turma_Click(object sender, RoutedEventArgs e)
        {
            janelaturma w = new janelaturma();
            w.ShowDialog();
        }

        private void Aluno_Click(object sender, RoutedEventArgs e)
        {
            janelaaluno w = new janelaaluno();
            w.ShowDialog();
        }

        private void Matricula_Click(object sender, RoutedEventArgs e)
        {
            janelamatricula w = new janelamatricula();
            w.ShowDialog();
        }

        private void Diario_Click(object sender, RoutedEventArgs e)
        {
            janeladiario w = new janeladiario();
            w.ShowDialog();
        }
    }
}
