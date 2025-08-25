namespace APP.Lanchonete.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string SenhaSemBase64 { get; set; }
        public string ConfirmarSenhaSemBase64 { get; set; }
        public int IdPerfil { get; set; }
        public string NomePerfil { get; set; }
    }
}
