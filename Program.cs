using System.Globalization;

class Program
{

    static void CadastrarProduto(CatalogoProdutos catalogo)
    {

        Console.WriteLine("DIGITE O SKU DO PRODUTO:");
        string sku = Console.ReadLine();

        if (catalogo.ExisteSKU(sku) == true)
        {
            Console.WriteLine("SKU JA CADASTRADA!");
        }
        else
        {
            Console.WriteLine("DIGITE O NOME DO PRODUTO:");
            string nome = Console.ReadLine();
            Console.WriteLine("DIGITE A CATEGORIA");
            string categoria = Console.ReadLine();
            Console.WriteLine("DIGITE O PREÇO");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE O PESO");
            int peso = int.Parse(Console.ReadLine());

            Produto produto = new Produto(sku, nome, categoria, preco, peso);
            catalogo.CadastrarProduto(produto);
            Console.WriteLine("PRODUTO CADASTRADO COM SUCESSO!");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            CatalogoProdutos catalogo = new CatalogoProdutos();
            catalogo.CarregarArq(@"C:\Users\vitor.fortunato\Desktop\TP-VITORFORTUNATO\bin\Debug\net10.0\produtos_catalogo.csv");

            int opcao = 1000;
            Console.WriteLine("BEM VINDO AO TP SINISTRO, ESCOLHA AS OPCOES");
            while (opcao != 0)
            {
                Console.WriteLine();
                Console.WriteLine("==================================");
                Console.WriteLine("0- SAIR");
                Console.WriteLine("1- BUSCAR PRODUTO POR ID SKU");
                Console.WriteLine("2- CADASTRAR PRODUTO");
                Console.WriteLine("==================================");
                Console.WriteLine();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        break;

                    case 1:
                        Console.WriteLine("DIGITE O ID:");
                        string resp = Console.ReadLine()?.Trim(); // Remove espaços extras nas pontas
                        Produto result = catalogo.BuscarPorId(resp);

                        if (result != null)
                        {
                            Console.WriteLine($"NOME: {result.Nome}, CATEGORIA: {result.Categoria}, PREÇO: {result.Preco:C}, PESO: {result.Gramas}g");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado!");
                        }
                        break;


                    case 2:
                        CadastrarProduto(catalogo);
                        break;

                    default:
                        Console.WriteLine("Opcao Invalida");
                        break;
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}