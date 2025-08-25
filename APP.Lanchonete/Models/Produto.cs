namespace APP.Lanchonete.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public decimal Preco { get; set; }

        public string Tipo { get; set; } = string.Empty;

        public bool Ativo { get; set; }

        public DateTime? DataCadastro { get; set; }

        public DateTime? DataAtualizacao { get; set; }
    }
}