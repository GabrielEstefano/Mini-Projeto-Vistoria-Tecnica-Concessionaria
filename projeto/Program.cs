using projeto;

Console.WriteLine("=======================================");
Console.WriteLine("AUTOCHECK.NET - VISTORIA TECNICA");
Console.WriteLine("=======================================");

List<Veiculo> ListaDeVistorias = new List<Veiculo>();
int Opcao = 0;

do
{
    Console.WriteLine("\nSELECIONE UMA DAS OPÇÕES:");
    Console.WriteLine("1 - Realizar Vistoria.");
    Console.WriteLine("2 - Exibir Vistorias Anteriores.");
    Console.WriteLine("3 - Sair.");

    Console.WriteLine("Opção: ");
    Opcao = int.Parse(Console.ReadLine());

    switch (Opcao)
    {
        case 1:
        Console.WriteLine("Qual o tipo do veículo:");
        Console.WriteLine("1 - Carro");
        Console.WriteLine("2 - Moto");
        Console.WriteLine("3 - Caminhão");
        Console.WriteLine("Opção: ");
        int tipoVeiculo = int.Parse(Console.ReadLine());

        Console.WriteLine("Marca: ");
        string marca = Console.ReadLine();
        Console.WriteLine("Modelo: ");
        string modelo = Console.ReadLine();
        Console.WriteLine("Ano: ");
        int ano = int.Parse(Console.ReadLine());
        Console.WriteLine("Quilometragem: ");
        double quilometragem = double.Parse(Console.ReadLine());

        Veiculo veiculoNovo = null;
        if(tipoVeiculo == 1)
            {
                Console.WriteLine("Quantidade de Portas: ");
                int portas = int.Parse(Console.ReadLine());
                veiculoNovo = new Carro(marca, modelo, ano, quilometragem, portas);
            }
        else if(tipoVeiculo == 2)
            {
                Console.WriteLine("Cilindradas: ");
                int cilindradas = int.Parse(Console.ReadLine());
                veiculoNovo = new Moto(marca, modelo, ano, quilometragem, cilindradas);
            }
        else if(tipoVeiculo == 3)
            {
                Console.WriteLine("Quantidade de Eixos: ");
                int eixos = int.Parse(Console.ReadLine());
                Console.WriteLine("Capacidade de Carga (Toneladas): ");
                double capacidadeCarga = double.Parse(Console.ReadLine());
                veiculoNovo = new Caminhao(marca, modelo, ano, quilometragem, eixos, capacidadeCarga);
            }

        List<string> checkList = veiculoNovo.ObterCheckListObrigatorio();
        foreach(string nomeItem in checkList)
            {
                Console.Write($"Status de {nomeItem} (Bom/Regular/Ruim)");
                string statusCliente = Console.ReadLine();
                veiculoNovo.AdicionarItemVistoriado(nomeItem, statusCliente);
            }

        ListaDeVistorias.Add(veiculoNovo);
        Console.WriteLine("Vistoria feita com sucesso!");
        break;

        case 2:
            if(ListaDeVistorias.Count == 0){Console.WriteLine("Nenhuma vistoria realizada até o momento.");}
            else{ foreach(Veiculo veiculo in ListaDeVistorias){veiculo.ExibirRelatorio();} }
        break;

        case 3:Console.WriteLine("Encerrando o Programa...");
        break;

        default:Console.WriteLine("Opção inválida.");
        break;
    }
}
while(Opcao != 3);
