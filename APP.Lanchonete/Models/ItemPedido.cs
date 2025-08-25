namespace APP.Lanchonete.Models
{
    public class ItemPedido
    {
        public int IdItem { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
        public string DescricaoProduto { get; set; }
        public string Status { get; set; }
    }
}
