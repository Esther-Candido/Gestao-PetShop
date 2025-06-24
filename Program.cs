using Gestão_Petshop_C_.Dtos;
using Gestão_Petshop_C_.Models;
using Gestão_Petshop_C_.Repository;
using Gestão_Petshop_C_.Services;

ClienteRepository repo = new ClienteRepository();
ClienteService clienteService = new ClienteService(repo);


bool seguir = true;

while (seguir)
{
    Console.WriteLine("Bem vindo - Gestão PetShop");
    Console.WriteLine("1 - Clientes");
    Console.WriteLine("2 - Pets");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");
    string opc = Console.ReadLine();

    switch (opc)
    {
        case "1":
            var runCliente = true;
            while (runCliente)
            {
                Console.Clear();
                Console.WriteLine("====CLIENTES====");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Remover");
                Console.WriteLine("0 - Menu Principal");
                Console.Write("Opção: ");
                string opcCliente = Console.ReadLine();
                switch (opcCliente)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        string tel = Console.ReadLine();
                        Console.Write("Endereço: ");
                        string endereco = Console.ReadLine();

                        ClienteDTO novoCliente = new ClienteDTO()
                        {
                            Nome = nome,
                            Telefone = tel,
                            Endereco = endereco
                        };

                        clienteService.CadastrarCliente(novoCliente);
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n===== Ficha de Clientes =====");
                        clienteService.ListaClientes();
                        Console.WriteLine("Pressione uma tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("Nome do cliente: ");
                        string nomeRemover = Console.ReadLine();
                        ClienteDTO clienteRemover = new ClienteDTO() { Nome = nomeRemover };
                        clienteService.Remover(clienteRemover);
                        break;
                    case "0":
                        runCliente = false;
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
            break;
        case "2":
            Console.Clear();
            break;
        case "0":
            seguir = false;
            Console.Clear();
            break;
        default:
            break;
    }
}

