using System.Windows;


namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioSeis.xaml
    /// </summary>
    public partial class ExercicioSeis : Window
    {
        private int contador = 0;
        public ExercicioSeis()
        { 
            InitializeComponent();
        }

        private void btnContar_Click(object sender, RoutedEventArgs e)
        {
            contador++;
            MessageBox.Show($"Número de cliques: {contador}");
        }
    }
}
