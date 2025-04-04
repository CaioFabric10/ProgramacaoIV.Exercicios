using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioSete.xaml
    /// </summary>
    public partial class ExercicioSete : Window
    {
        public ExercicioSete()
        {
            InitializeComponent();

            cmbParcelas.ItemsSource = new int[] { 1, 2, 3, 4, 5, 6, 10, 12 };
        }
        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(txtValorTotal.Text, out double valorTotal) || valorTotal <= 0)
            {
                MessageBox.Show("Digite um valor total válido!");
                return;
            }

            if(cmbParcelas.SelectedItem == null)
            {
                MessageBox.Show("Selecione a quantidade de parcelas.");
                return;
            }

            int parcelas = (int)cmbParcelas.SelectedItem;
            double valorParcela = valorTotal / parcelas;

            MessageBox.Show($"Cada Parcela será de R$ {valorParcela:F2}");
        }
    }
}
