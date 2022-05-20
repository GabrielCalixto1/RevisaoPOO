namespace RevisaoPOO.lib.Models
{
    public class Pedido
    {
        public Usuario usuario { get; set; }
        public List<Produto> produtos { get; set; }
        public double ValorTotal { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }
    }
}