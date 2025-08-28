using System.Text.Json.Serialization;

namespace APP.Lanchonete.Models
{
    public class ItemPedido
    {
        [JsonPropertyName("idItem")]
        public int IdItem { get; set; }

        [JsonPropertyName("idProduto")]
        public int IdProduto { get; set; }

        [JsonPropertyName("quantidade")]
        public int Quantidade { get; set; }

        [JsonPropertyName("descricaoProduto")]
        public string DescricaoProduto { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
