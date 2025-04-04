using ProgramacaoIV.Exercicios.Enums;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioCinco.xaml
    /// </summary>
    public partial class ExercicioCinco : Window
    {
        public ExercicioCinco()
        {
            InitializeComponent();
            cmbTipos.ItemsSource = Enum.GetValues(typeof(TipoUsuario)).Cast<TipoUsuario>();
        }

        private void btnMostrarDescricao_Click(object sender, RoutedEventArgs e)
        {
            if (cmbTipos.SelectedItem is TipoUsuario tipoSelecionado)
            {
                string descricao = ObterDescricao(tipoSelecionado);
                MessageBox.Show(descricao);
            }
            else
            {
                MessageBox.Show("Selecione um tipo de usuário.");
            }
        }

        private string ObterDescricao(Enum valor)
        {
            FieldInfo campo = valor.GetType().GetField(valor.ToString());
            DescriptionAttribute atributo = campo.GetCustomAttribute<DescriptionAttribute>();
            return atributo?.Description ?? valor.ToString();
        }
    }
}
