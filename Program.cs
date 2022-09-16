using Funcionário;

Funcionario funcionario = new Funcionario();
Console.WriteLine("Digite o nome do funcionário: ");
funcionario.nome = Console.ReadLine();
Console.WriteLine("Digite o valor por hora do funcionário: "); 
funcionario.valorPorHora = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite quantas horas o funcionário trabalhou no mês: ");
funcionario.horas = Convert.ToInt16(Console.ReadLine());

double total = funcionario.total();
Console.WriteLine($"O funcionário {funcionario.nome}, que trabalhou {funcionario.horas} horas no mês deve receber " + total);
