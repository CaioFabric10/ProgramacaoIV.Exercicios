using ProgramacaoIV.Exercicios.Enums;
using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioOito.xaml
    /// </summary>
    public partial class ExercicioOito : Window
    {
        public ExercicioOito()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            if (!dtpData.SelectedDate.HasValue)
            {
                MessageBox.Show("Por favor, selecione uma data.");
                return;
            }

            DateTime dataSelecionada = dtpData.SelectedDate.Value;

            // Cast explícito de DayOfWeek para nosso enum
            DiasSemana diaSemana = (DiasSemana)dataSelecionada.DayOfWeek;

            MessageBox.Show($"O dia da semana é: {diaSemana}");
        }
    }
}
