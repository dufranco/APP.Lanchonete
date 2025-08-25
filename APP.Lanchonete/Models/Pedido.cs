namespace APP.Lanchonete.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<ItemPedido> ItensPedido { get; set; }
    }
}
