using LocadoraCarros.Abstract;
using LocadoraCarros.Entities;
using LocadoraCarros.Models;
using System.Net.Sockets;

var rentalCompany = new RentalCompany();

List<string> mainOptions = [
    "Menu Clientes",
    "Menu Veiculos",
    "Menu Locações",
    "Sair"
    ];

List<string> customerOptions = [
    "Cadastrar Cliente",
    "Listar Clientes",
    "Atualizar Cliente",
    "Remover Cliente",
    "Voltar ao Menu Principal"
    ];

List<string> vehicleOptions = [
    "Cadastrar Veículo",
    "Listar Veículos",
    "Atualizar Veículos",
    "Remover Veículos",
    "Voltar ao Menu Principal"
    ];

List<string> rentalsOptions = [
    "Cadastrar Locação",
    "Listar Locações",
    "Finalizar Locação",
    "Remover Locação",
    "Voltar ao Menu Principal"
    ];



do
{
    int mainChoice = Menu.Display("=== Menu Principal ===", mainOptions);

    switch (mainChoice)
    {
        case 1:
            int customerChoice = Menu.Display("=== Menu Clientes ===", customerOptions);
            break;
        case 2:
            int vehicleChoice = Menu.Display("=== Menu Veículo ===", vehicleOptions);
            break;
        case 3:
            int rentalChoice = Menu.Display("=== Menu Locações ===", rentalsOptions);
            break;
        case 4:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opcao invalida");
            break;
    }

} while (true);

void CustomerMenu(int option)
{
    switch (option)
    {
        case 1:
            CreateCustomer();
            break;
        case 2:
            ListCustomers();
            break;
        case 3:
            Console.WriteLine(UpdatePhone());
            break;
        case 4:
            DeleteCustomer();
            break;
        default:
            break;
    }
}
,  
AbstractPerson? UpdatePhone()
{
    Console.WriteLine("Informe o nome do cliente a ser atualizado: ");
    string name = Console.ReadLine() ?? "";

    var customer = FindCustomerByName(name);

    if(customer is not null)
    {
        Console.WriteLine("Ínforme o telefone do cliente: ");
        var phone = Console.ReadLine();

        customer.SetContactPhone(phone);
        Console.WriteLine("Telefone atualizado com sucesso");
    }
    else
    {
        Console.WriteLine("Cliente não encontrado.");
    }

    return customer;
}

AbstractPerson FindCustomerByName(string name)
{
    return rentalCompany.Customer.Find(c => c.GetName().Contains(name));
    
}

void DeleteCustomer()
{
    Console.WriteLine("Informe o nome do cliente a ser removido: ");
    var name = Console.ReadLine();

    var customer = FindCustomerByName(name);

    if(customer is not null)
    {
        rentalCompany.Customer.Remove(customer);
        Console.WriteLine("Cliente removido com sucesso");
    }
    else
    {
        Console.WriteLine("Cliente não encontrado.");
    }

}

void ListCustomers()
{
    Console.WriteLine("=== Lista de Clientes ===");
    foreach(var customer in rentalCompany.Customer.Order())
    {
        Console.WriteLine(customer);
    }
}

void CreateCustomer()
{
    Console.WriteLine("Informe o nome do cliente:");
    var name = Console.ReadLine() ?? "";

    Console.WriteLine("Informe a data de nascimento do cliente:");
    var birthDate = DateOnly.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Informe o email do cliente:");
    var email = Console.ReadLine() ?? "";

    Console.WriteLine("Informe o logradouro do cliente: ");
    var street = Console.ReadLine() ?? "";

    Console.WriteLine("Informe o número do endereço do cliente: ");
    var number = Console.ReadLine() ?? "";

    Console.WriteLine("Informe o complemento do endereço do cliente: ");
    var complement = Console.ReadLine() ?? "";

    Console.WriteLine("Informe o bairro do cliente: ");
    var neighborhood = Console.ReadLine() ?? "";

    Console.WriteLine("Informe a cidade do cliente: ");
    var city = Console.ReadLine() ?? "";

    Console.WriteLine("Informe o estado do cliente: ");
    var state = Console.ReadLine() ?? "";

    Console.WriteLine("Informe o CEP do cliente: ");
    var zipCode = Console.ReadLine() ?? "";

    var contact = new Contact(email, null);
    var address = new Address(street, int.Parse(number), neighborhood, zipCode, complement, city, state, null);

    Console.WriteLine("Qual tipo de cliente está cadastrando? (1 - PF | 2 - PJ) ");
    int customerType = int.Parse(Console.ReadLine() ?? "1");

    if (customerType == 1)
    {
        Console.Write("Informe o número da CNH: ");
        var cnh = Console.ReadLine() ?? "";

        Console.WriteLine("Informe o número do CPF: ");
        var cpf = Console.ReadLine() ?? "";

        var customer = new CustomerPF(name, birthDate, contact, address, cnh, cpf);

        rentalCompany.Customer.Add(customer);
    }
    else
    {
        Console.WriteLine("Informe o CNPJ da empresa: ");
        var cnpj = Console.ReadLine() ?? "";

        var customer = new CustomerPJ(name, birthDate, contact, address, cnpj);
        rentalCompany.Customer.Add(customer);
    }
}