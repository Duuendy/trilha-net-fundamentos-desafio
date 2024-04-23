using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;


int carro = 1;
int moto = 2;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Informe o tipo de veículo: [1 - Carro / 2 - Moto]");
string tipoVeiculo = Convert.ToString(Console.ReadLine());

decimal precoInicial;
decimal precoPorHora;

if (tipoVeiculo == "1")
{
    tipoVeiculo = "Carro";
    precoInicial = 10;
    precoPorHora = 5;
}
else
{
    tipoVeiculo = "Moto";
    precoInicial = 5;
    precoPorHora = 5;
}

Console.WriteLine($"Opção escolhida foi: {tipoVeiculo} e os valores são: Valor Inicial R${precoInicial} e Valor Por Hora R${precoPorHora}");


// decimal precoInicial = 0;
// decimal precoPorHora = 0;

// Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
//                   "Digite o preço inicial:");
// precoInicial = Convert.ToDecimal(Console.ReadLine());

// Console.WriteLine("Agora digite o preço por hora:");
// precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
