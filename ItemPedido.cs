class ItemPedido
{
    private Produto produto;
    private int quantidade;


    public ItemPedido(Produto produto, int quantidade)
    {
        this.produto = produto;
        this.quantidade = quantidade;
    }

    public int Quantidade
    {
        get { return quantidade; }
        set { quantidade = value; }
    }

    public Produto Produto
    {
        get { return produto; }
        set { produto = value; }
    }

    public double CalcularTotal()
    {
        double result = quantidade * produto.Preco;
        return result;
    }

    public int CalcularPesoTotal()
    {
        int result = produto.Gramas * quantidade;
        return result;
    }
}    