using System;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Interação lógica para ExercicioQuatro.xam
    /// </summary>
    public partial class ExercicioQuatro : Window
    {
        public ExercicioQuatro()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(Object sender, RoutedEventArgs e)
        {
            try
            {
                var idade = Convert.ToInt32(txtIdade.Text);

                if (idade < 0)
                {
                    MessageBox.Show("Idade inválida! Por favor, insira um valor positivo.");
                    return;
                }

                string mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";

                MessageBox.Show(mensagem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
