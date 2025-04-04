using System.ComponentModel;

namespace ProgramacaoIV.Exercicios.Enums
{
    public enum TipoUsuario 
    {
        [Description("Usuário com todos os privilégios")] Administrador,

        [Description("Usuário comum do sistema")] UsuarioComum,

        [Description("Apenas visitante, acesso restrito")] Visitante
    }
}