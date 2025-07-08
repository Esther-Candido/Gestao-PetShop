using System.ComponentModel;
using Gestão_Petshop_C_.Dtos;
using Gestão_Petshop_C_.Models;
using Gestão_Petshop_C_.Repository;
using Gestão_Petshop_C_.Services;

ClienteRepository repo = new ClienteRepository();
ClienteService clienteService = new ClienteService(repo);


PetRepository repo2 = new PetRepository();
PetService petservice = new PetService(repo2);


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
            var runPet = true;
            while (runPet)
            {
                Console.Clear();
                Console.WriteLine("======PETS======");
                Console.WriteLine("1 - Cadastrar Pet -> Cliente");
                Console.WriteLine("2 - Lista de Pets");
                Console.WriteLine("3 - Listar Pet -> Cliente");
                Console.WriteLine("4 - Remover");
                Console.WriteLine("0 - Menu Principal");
                Console.Write("Opção: ");
                string opcPet = Console.ReadLine();
                switch (opcPet)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Nome Pet: ");
                        string nome = Console.ReadLine();
                        Console.Write("Raça: ");
                        string raca = Console.ReadLine();
                        Console.Write("Tipo Animal (Cachorro, Gato, Pássaro, Galinha): ");
                        string tipo = Console.ReadLine();
                        Console.Write("Idade: ");
                        int idade = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Dono (nome do cliente já cadastrado): ");
                        string dono = Console.ReadLine();

                        // Converter string para enum Tipo
                        if (!Enum.TryParse<Tipo>(tipo, true, out Tipo tipoConvertido))
                        {
                            Console.WriteLine("Tipo inválido! Tente novamente.");
                            break;
                        }

                        // Buscar cliente 
                        var buscarCliente = repo.ListaClientes();
                        Cliente clienteEncontrado = buscarCliente.FirstOrDefault(a => a.Nome == dono);
                    

                        PetDTO novoPet = new PetDTO()
                        {
                            Nome = nome,
                            Raca = raca,
                            TipoAtual = tipoConvertido,
                            Idade = idade,
                            Dono = clienteEncontrado
                        };

                        petservice.CadastrarPetCliente(novoPet);
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("\n===== Lista de Pets =====");
                        petservice.SoPet();
                        Console.WriteLine("Pressione uma tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("\n===== Pets & Donos =====");
                        petservice.ListaPet();
                        Console.WriteLine("Pressione uma tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.Write("Nome do Pet: ");
                        string petRemover = Console.ReadLine();
                        PetDTO Petremove = new PetDTO() { Nome = petRemover };
                        petservice.Remover(Petremove);
                        break;
                    case "0":
                        runPet = false;
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
            break;
        case "0":
            seguir = false;
            Console.Clear();
            break;
        default:
            break;
    }
}