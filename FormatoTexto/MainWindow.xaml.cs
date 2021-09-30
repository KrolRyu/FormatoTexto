using System.Windows;
using System.Windows.Controls;

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextoFinalTextBlock.Text = TextoTextBox.Text;
        }

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {          
                TextoFinalTextBlock.FontWeight = FontWeights.Bold;
        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBlock.FontStyle = FontStyles.Italic;
        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBlock.FontWeight = FontWeights.Normal;
        }
        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBlock.FontStyle = FontStyles.Normal;
        }

        private void AzulRadio_Checked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBlock.Foreground = System.Windows.Media.Brushes.Blue;
        }

        private void RojoRadio_Checked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBlock.Foreground = System.Windows.Media.Brushes.Red;
        }

        private void VerdeRadio_Checked(object sender, RoutedEventArgs e)
        {
            TextoFinalTextBlock.Foreground = System.Windows.Media.Brushes.Green;
        }
    }
}
