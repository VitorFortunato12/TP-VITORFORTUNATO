using System.Globalization;

class CatalogoProdutos
{

    private Dictionary<string, Produto> catalogo;

    private LogLogistica log = new LogLogistica();

    private string caminho;

    public CatalogoProdutos()
    {
        this.catalogo = new Dictionary<string, Produto>();
        this.caminho = null;
    }

    public void CarregarArq(string arq)
    {
        this.caminho = arq;
        string[] linhas = File.ReadAllLines(arq);
        catalogo = new Dictionary<string, Produto>();

        for (int i = 1; i < linhas.Length; i++)
        {
            string[] campos = linhas[i].Split(';');

            double preco = double.Parse(campos[3], CultureInfo.InvariantCulture);
            int peso = int.Parse(campos[4], CultureInfo.InvariantCulture);

            Produto produto = new Produto(campos[0], campos[1], campos[2], preco, peso);
            catalogo.Add(produto.Id, produto);
        }
    }

    public Produto BuscarPorId(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            return null;
        }

        catalogo.TryGetValue(id, out Produto result);
        return result;
    }


    public bool ExisteSKU(string id)
    {
        if (catalogo.ContainsKey(id))
        {
            return true;
        }
        return false;
    }

    public void CadastrarProduto(Produto produto)
    {
        string linha = $"{produto.Id};{produto.Nome};{produto.Categoria};{produto.Preco.ToString(CultureInfo.InvariantCulture)};{produto.Gramas.ToString(CultureInfo.InvariantCulture)}";
        File.AppendAllText(caminho, linha + Environment.NewLine);
        catalogo.Add(produto.Id, produto);
        log.Registrar($"PRODUTO CADASTRADA COM SUCESSO | {produto.Id} | {produto.Nome}");
    }
}