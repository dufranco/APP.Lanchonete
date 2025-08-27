namespace APP.Lanchonete.Models
{
    public class ControleAcesso
    {
        public int IdControle { get; set; }

        public int IdPerfil { get; set; }

        public string NomePerfil { get; set; }

        public string NomeTela { get; set; }

        public bool Permitido { get; set; }
    }
}
