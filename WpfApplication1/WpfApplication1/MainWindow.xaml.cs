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

namespace WpfApplication1
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

        private void cmdEnviar_Click(object sender, RoutedEventArgs e)
        {
            mostraMensagem(txtNome.Text, txtIdade.Text);
        }

        private void mostraMensagem(string nome, string idade)
        {
            MessageBox.Show("Nome: " + nome + " Idade: " + idade, "Erro - Aplicativo de teste", 
                MessageBoxButton.OKCancel, MessageBoxImage.Error);
        }

        private void chkChecado_Click(object sender, RoutedEventArgs e)
        {
            if (chkChecado.IsChecked  == true)
            {
                cmdEnviar.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                cmdEnviar.Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
