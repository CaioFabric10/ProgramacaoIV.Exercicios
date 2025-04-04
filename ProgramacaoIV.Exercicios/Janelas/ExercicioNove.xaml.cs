using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioNove.xaml
    /// </summary>
    public partial class ExercicioNove : Window
    {
        private bool ligado = false;
        public ExercicioNove()
        {
            InitializeComponent();
        }

        private void btnInterruptor_Click( object sender, EventArgs e)
        {
            ligado = !ligado;

            String estado = ligado ? "ligado" : "Desligado";

            MessageBox.Show($"Estado atual: {estado}");
        }
    }
}
