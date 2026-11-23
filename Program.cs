using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            CatalogoProdutos catalogo = new CatalogoProdutos();
            catalogo.CarregarArq(@"C:\Users\vitor.fortunato\Desktop\TP-VITORFORTUNATO\bin\Debug\net10.0\produtos_catalogo.csv");

            int opcao = 1000;

            while (opcao != 0)
            {
                Console.WriteLine("BEM VINDO AO TP SINISTRO, ESCOLHA AS OPCOES");
                Console.WriteLine("0- SAIR");
                Console.WriteLine("1- BUSCAR PRODUTO POR ID SKU");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        break;

                    case 1:
                        Console.WriteLine("DIGITE O ID:");
                        string resp = Console.ReadLine();
                        Produto result = catalogo.BuscarPorId(resp);
                        if(result != null)
                        {
                            Console.WriteLine($"NOME: {result.Nome}, CATEGORIA: {result.Categoria}, PRECO: {result.Preco}, PESO:{result.Gramas}");
                            Console.WriteLine("Produto não econtrado");
                        }
                        Console.WriteLine("Produto não econtrado");
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