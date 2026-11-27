class Pedido
{
    private int id_pedido;
    private string nomeCliente;
    private string endereco;
    private List<ItemPedido> itens;

     public Pedido(int id_pedido, string nomeCliente, string endereco)
    {
        this.endereco = endereco;
        this.id_pedido = id_pedido;
        this.nomeCliente = nomeCliente;
        this.itens = new List<ItemPedido>();
    }

    public int Id_Pedido
    {
        get { return id_pedido; }
        set { id_pedido = value; }
    }

    public string NomeCliente
    {
        get { return nomeCliente; }
        set { nomeCliente = value; }
    }

    public string Endereco
    {
        get { return endereco;}
        set { endereco = value;}
    }

    public void AdicionarItemPedido(ItemPedido itemPedido)
    {
        itens.Add(itemPedido);
    }
}