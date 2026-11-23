using System.Globalization;

class CatalogoProdutos
{

    private Dictionary<string, Produto> catalogo;

    public CatalogoProdutos()
    {
        this.catalogo = new Dictionary<string, Produto>();
    }

    public void CarregarArq(string arq)
    {
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
        if (catalogo.TryGetValue(id, out Produto result))
        {
            return result;
        }
        Console.WriteLine("Produto não encontrado!");
        return null;
    }

    public void CadastrarProduto(string )
}