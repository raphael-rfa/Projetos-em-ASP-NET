namespace ControleDeEstoque.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int QntProduzida { get; set; }
        public int QntVendida { get; set; }
        public int QntEstoque
        {
            get { return QntProduzida - QntVendida; }
            set { return; }
        }
    }
}
