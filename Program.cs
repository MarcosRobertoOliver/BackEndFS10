using System.Text.RegularExpressions;
using BackEndProj.Classes;

// ********************* SUBSTRING ********************
//             // 0123456789...
// string nome = "Marcos Roberto de Oliveira";
// Console.WriteLine(nome.Length);
// Console.WriteLine(nome.Substring(7));
// Console.WriteLine(nome.Substring(0, 6));

// Console.WriteLine(nome.IndexOf("Roberto"));

// Console.WriteLine(@$"

//     Nome Completo: {nome}
//     Sobrenome: {nome.Substring(nome.IndexOf("Roberto"))}
// ");

//***************************** REGEX ***************************

// string data = "02/11/2022";
// bool dataValida = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");
// bool dataValida2 = Regex.IsMatch(data, @"^\d{2}-\d{2}-\d{4}$");

// Console.WriteLine(dataValida);
// Console.WriteLine(dataValida2);

// //endereço de pessoa física

// Endereco endPf = new Endereco();
//     endPf.logradouro = "Rua Bacaba, 328";
//     endPf.numero = 328;
//     endPf.comercial = false;

//     //pessoa física
// PessoaFisica novaPessoaFisica = new PessoaFisica();

//     novaPessoaFisica.nome = "Marcos";
//     novaPessoaFisica.endereco = endPf;
//     novaPessoaFisica.rendimento = 1000f;
//     novaPessoaFisica.cpf = "12345678-00";

//endereço de pessoa juridica

Endereco endPj = new Endereco();
    endPj.logradouro = "Rua Rua Niterói";
    endPj.numero = 280;
    endPj.comercial = true;


    PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

    novaPessoaJuridica.nome = "Paulo Skaf";
    novaPessoaJuridica.endereco = endPj;
    novaPessoaJuridica.razaoSocial = "Serviço Nacional de Aprendizagem Social";
    // novaPessoaJuridica.cnpj = "42.368.224/0001-09";
    novaPessoaJuridica.cnpj = "42368224000109";
    novaPessoaJuridica.rendimento = 100000f;
    Console.WriteLine($"CNPJ VÁLIDO? {novaPessoaJuridica.ValidarCnpj(novaPessoaJuridica.cnpj)}");

    
    

// //Exibindo os dados da pessoa física
// Console.WriteLine($"**************PESSOA FÍSICA*************");
// Console.WriteLine();

// Console.WriteLine($"Nome: {novaPessoaFisica.nome}");
// Console.WriteLine($"Endereço: {novaPessoaFisica.endereco.logradouro}");
// Console.WriteLine($"Número: {novaPessoaFisica.endereco.numero}");
// Console.WriteLine($"Endereço Comercial: {novaPessoaFisica.endereco.comercial}");
// Console.WriteLine($"CPF: {novaPessoaFisica.cpf}");
// Console.WriteLine($"Rendimento: R$ {novaPessoaFisica.rendimento}");
// Console.WriteLine("Maior de Idade: "+ novaPessoaFisica.ValidarDataNascimento("29/01/1968"));

// //Exibir os dados da pessoa jurídica

// Console.WriteLine($"**************PESSOA JURÍDICA*************");
// Console.WriteLine();

// Console.WriteLine($"Razão Social: {novaPessoaJuridica.nome}");
// Console.WriteLine($"CNPJ: {novaPessoaJuridica.cnpj}");
// Console.WriteLine($"Representante: {novaPessoaJuridica.nome}");
// Console.WriteLine($"Endereço: {novaPessoaJuridica.endereco.logradouro}");
// Console.WriteLine($"Número: {novaPessoaJuridica.endereco.numero}");
// Console.WriteLine($"Endereço Comercial: {novaPessoaJuridica.endereco.comercial}");
// Console.WriteLine($"Rendimento: R$ {novaPessoaJuridica.rendimento}");
