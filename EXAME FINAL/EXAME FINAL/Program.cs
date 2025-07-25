using EXAME_FINAL;

do
{
    Cliente c = new Cliente();
    Console.WriteLine("Informe o nome:");
    c._nome = Console.ReadLine();
    Console.WriteLine("Infomer o CPF:");
    c._cpf = Console.ReadLine();
    Console.WriteLine("informe o CNH:");
    c._cnh = Console.ReadLine();
    Console.WriteLine("Informe o telefone:");
    c._telefone = Console.ReadLine();
    Console.WriteLine("Informe o Email:");
    c._email = Console.ReadLine();



    Veiculo v = new Veiculo();
    Console.WriteLine("Informe a placa do Veículo passeio ou carga:");
    v._placa = Console.ReadLine();
    Console.WriteLine("Informe o modelo:");
    v._modelo = Console.ReadLine();
    Console.WriteLine("Informe a marca:");
    v._marca = Console.ReadLine();
    Console.WriteLine("Informe o ano:");
    v._ano = Console.ReadLine();

    




} while (true);
