using BackEndProj.Classes;


PessoaFisica novaPessoaFisica = new PessoaFisica();

novaPessoaFisica.nome = "Marcos";
novaPessoaFisica.endereco = "Rua bacaba, 328";
novaPessoaFisica.rendimento = 1000f;
novaPessoaFisica.cpf = "12345678-00";

Console.WriteLine($"Nome: {novaPessoaFisica.nome}");
Console.WriteLine($"Endereco: {novaPessoaFisica.endereco}");
Console.WriteLine($"CPF: {novaPessoaFisica.cpf}");
Console.WriteLine($"Rendimento: {novaPessoaFisica.rendimento}");

