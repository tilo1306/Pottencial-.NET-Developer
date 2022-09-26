
string? option;
bool displaymenu = true;

while(displaymenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    option = Console.ReadLine();

    switch(option)
    {
        case "1":
        Console.WriteLine("Cadastro de cliente");
        break;
        case "2":
        Console.WriteLine("Busca de cliente");
        break;
        case "3":
        Console.WriteLine("Apagar cliente");
        break;
        case "4":
        Console.WriteLine("Encerrar");
        displaymenu = false;
        break;
        default:
        Console.WriteLine("Opção invalida");
        break;
    }
}

Console.WriteLine("O programa se encerrou");