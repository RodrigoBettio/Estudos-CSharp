
//Criando função

List<string> listaBandas = new List<string>();

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine("Seja bem vindo ao meu Primeiro Programa\n"); //Sempre utilizar PascalCase para métodos e camelCase para variáveis
}

void ExibirMenu()
{
    Console.WriteLine("1- Registrar Banda");
    Console.WriteLine("2- Mostrar todas as Bandas");
    Console.WriteLine("3- Avalie uma Banda");
    Console.WriteLine("4- Mostre a média da banda");
    Console.WriteLine("5- Sair");

    Console.Write("\nDigite a sua opção: "); //Tirar o line ele só escreve e não pular a linha
    string opcao = Console.ReadLine()!; // o "!" serve para indicar que o valor não deverá ser nulo
    int opcaoEscolhida = int.Parse(opcao);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
            break;
        
        case 2:
            MostrarBandas();
            break;

        case 3:
            //AvaliarBanda();
            break;

        case 4:
           // MostrarMediaBanda();
            break;

        case 5:
            Console.WriteLine("Tchauzinho");
            break;
        
        default:
            Console.WriteLine("Opção Inválida");
            break;
    
    }

}

void RegistrarBanda (){
    Console.Clear(); //Limpa o console
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandaEscolhida = Console.ReadLine()!;
    listaBandas.Add(bandaEscolhida); //Adicionando a banda na lista

    Console.WriteLine($"A banda {bandaEscolhida} foi registrada com sucesso"); //Interpolação de String

    Thread.Sleep(1500); //Espera 1500 milisegundos para 

    Console.Clear();
    ExibirMenu();
}

void MostrarBandas(){
    Console.Clear();
    for (int i = 0; i < listaBandas.Count; i++){
        Console.WriteLine($"Banda {i+1}: {listaBandas[i]}");
    }

    Thread.Sleep(1500);
    Console.Clear();

    ExibirMenu();
}

ExibirMensagemDeBoasVindas();
ExibirMenu();
