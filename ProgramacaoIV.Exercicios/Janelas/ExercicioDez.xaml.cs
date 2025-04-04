using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioDez.xaml
    /// </summary>
    public partial class ExercicioDez : Window
    {
        private Random random = new Random();
        public ExercicioDez()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            int numeroSorteado = random.Next(1, 7);

            string mensagem = numeroSorteado == 6
                ? $"Você tirou {numeroSorteado}! Você Ganhou!"
                : $"Você tirou {numeroSorteado}. Tente Novamente!";

            MessageBox.Show(mensagem);
        }
    }
}
