using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioUm.xaml
    /// </summary>
    public partial class ExercicioUm : Window
    {
        public ExercicioUm()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var valorUmConvertido = Convert.ToInt32(txtValorUm.Text);
                var valorDoisConvertido = Convert.ToInt32(txtValorDois.Text);

                MessageBox.Show($"Resultado = {valorUmConvertido + valorDoisConvertido}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
    }
}
