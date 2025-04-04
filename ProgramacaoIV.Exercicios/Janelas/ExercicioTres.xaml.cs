using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioTres.xaml
    /// </summary>
    public partial class ExercicioTres : Window
    {
        public ExercicioTres()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (!dpNascimento.SelectedDate.HasValue)
            {
                MessageBox.Show("Por favor, selecione sua data de nascimento.");
                return;
            }

            var nascimento = dpNascimento.SelectedDate.Value;
            var hoje = DateTime.Today;

            var proximoAniversario = new DateTime(hoje.Year, nascimento.Month, nascimento.Day);

            if (proximoAniversario < hoje)
                proximoAniversario = proximoAniversario.AddYears(1);

            var diasFaltando = (proximoAniversario - hoje).Days;

            MessageBox.Show($"Faltam {diasFaltando} dia(s) para seu próximo aniversário.");
        }
    }
}
