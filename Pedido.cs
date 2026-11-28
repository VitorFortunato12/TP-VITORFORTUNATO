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
        if(itemPedido != null && itemPedido.Quantidade > 0)
        {
            for(int i=0; i < itens.Count(); i++)
            {
                if(itens[i].Produto.Id == itemPedido.Produto.Id)
                {
                    itens[i].Quantidade = itens[i].Quantidade + itemPedido.Quantidade;
                    return;
                }
            }
            itens.Add(itemPedido);
        }
    }
}