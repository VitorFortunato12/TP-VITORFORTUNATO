class Produto
{
    private string id;
    private string nome;
    private string categoria;
    private double preco;
    private int gramas;

    public Produto()
    {
        this.id = "";
        this.nome = "";
        this.preco = 0.0;
        this.categoria = "";
        this.gramas = 0;
    }

    public Produto(string id, string nome, string categoria, double preco, int gramas)
    {
        this.id = id;
        this.nome = nome;
        this.preco = preco;
        this.categoria = categoria;
        this.gramas = gramas;
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double Preco
    {
        get { return preco; }
        set { preco = value; }
    }

    public string Categoria
    {
        get { return categoria; }
        set { categoria = value; }
    }

    public int Gramas
    {
        get { return gramas; }
        set { gramas = value; }
    }
}