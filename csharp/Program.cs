string mensagemDeBoasVindas = "Boas vindas ao Loud Sound";

// List<string> listaDasBandas1 = new List<string> { "Audioslave", "Pearl Jam"};

Dictionary<string, List<int>> listaDasBandas = new Dictionary<string, List<int>>();
listaDasBandas.Add("Arctic Monkeys", new List<int> { 10, 9 ,6 ,5 });
listaDasBandas.Add("Linkin Park", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
    
        ██╗░░░░░░█████╗░██╗░░░██╗██████╗░  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
        ██║░░░░░██╔══██╗██║░░░██║██╔══██╗  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
        ██║░░░░░██║░░██║██║░░░██║██║░░██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
        ██║░░░░░██║░░██║██║░░░██║██║░░██║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
        ███████╗╚█████╔╝╚██████╔╝██████╔╝  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
        ╚══════╝░╚════╝░░╚═════╝░╚═════╝░  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesdoMenu()
{
    ExibirLogo();
    Console.WriteLine("\n1 - Registrar uma banda");
    Console.WriteLine("2 - Listar bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir a média de uma banda");
    Console.WriteLine("0 - Sair");

    Console.Write("\nDigite a opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: ListarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: ExibirMedia();
            break;
        case 0: Console.WriteLine("Saindo...");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTitulo("Registro de Bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nBanda {nomeDaBanda} registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesdoMenu();
}

void ListarBandas()
{
    Console.Clear();
    ExibirTitulo("Lista de Bandas");
    foreach (string banda in listaDasBandas.Keys)
    {
        Console.WriteLine(banda);
    }
    Console.WriteLine("\nDigite uma tecla para voltar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesdoMenu();
}

void AvaliarBanda()
{ 
    Console.Clear();
    ExibirTitulo("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (listaDasBandas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Digite sua nota: ");
        int nota = int.Parse(Console.ReadLine()!);
        listaDasBandas[nomeDaBanda].Add(nota);
        Console.WriteLine("\nAvaliação da banda registrada com sucesso");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesdoMenu();
    } else
    {
        Console.WriteLine("\nBanda não localizada");
        Console.WriteLine("\nDigite uma tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesdoMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTitulo("Avaliação da Banda");
    Console.Write("Digite o nome da banda que deseja ver avaliação: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (listaDasBandas.ContainsKey(nomeDaBanda))
    {
        List<int> notas = listaDasBandas[nomeDaBanda];
        Console.WriteLine($"\nMédia: {notas.Average()}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesdoMenu();
    } else
    {
        Console.WriteLine("\nBanda não localizada");
        Console.WriteLine("\nDigite uma tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesdoMenu();
    }
}

void ExibirTitulo(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco + "\n");
}

ExibirOpcoesdoMenu();