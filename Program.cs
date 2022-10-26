using BackEndProj.Classes;

//endereço de pessoa física

Endereco endPf = new Endereco();
    endPf.logradouro = "Rua Bacaba, 328";
    endPf.numero = 328;
    endPf.comercial = false;

    //pessoa física
PessoaFisica novaPessoaFisica = new PessoaFisica();

    novaPessoaFisica.nome = "Marcos";
    novaPessoaFisica.endereco = endPf;
    novaPessoaFisica.rendimento = 1000f;
    novaPessoaFisica.cpf = "12345678-00";

//endereço de pessoa juridica

Endereco endPj = new Endereco();
    endPj.logradouro = "Rua Rua Niterói";
    endPj.numero = 280;
    endPj.comercial = true;


    PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

    novaPessoaJuridica.nome = "Paulo Skaf";
    novaPessoaJuridica.endereco = endPj;
    novaPessoaJuridica.razaoSocial = "Serviço Nacional de Aprendizagem Social";
    novaPessoaJuridica.cnpj = "42.368.224/0001-09";
    novaPessoaJuridica.rendimento = 100000f;

    
    

//Exibindo os dados da pessoa física
Console.WriteLine($"**************PESSOA FÍSICA*************");
Console.WriteLine();

Console.WriteLine($"Nome: {novaPessoaFisica.nome}");
Console.WriteLine($"Endereço: {novaPessoaFisica.endereco.logradouro}");
Console.WriteLine($"Número: {novaPessoaFisica.endereco.numero}");
Console.WriteLine($"Endereço Comercial: {novaPessoaFisica.endereco.comercial}");
Console.WriteLine($"CPF: {novaPessoaFisica.cpf}");
Console.WriteLine($"Rendimento: R$ {novaPessoaFisica.rendimento}");
Console.WriteLine("Maior de Idade: "+ novaPessoaFisica.ValidarDataNascimento("29/01/1968"));

//Exibir os dados da pessoa jurídica

Console.WriteLine($"**************PESSOA JURÍDICA*************");
Console.WriteLine();

Console.WriteLine($"Razão Social: {novaPessoaJuridica.nome}");
Console.WriteLine($"CNPJ: {novaPessoaJuridica.cnpj}");
Console.WriteLine($"Representante: {novaPessoaJuridica.nome}");
Console.WriteLine($"Endereço: {novaPessoaJuridica.endereco.logradouro}");
Console.WriteLine($"Número: {novaPessoaJuridica.endereco.numero}");
Console.WriteLine($"Endereço Comercial: {novaPessoaJuridica.endereco.comercial}");
Console.WriteLine($"Rendimento: R$ {novaPessoaJuridica.rendimento}");

