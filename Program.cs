using System.Text.RegularExpressions;
using BackEndProj.Classes;

Console.Clear();

Console.WriteLine(@$"
===========================================
|    bem vindo ao sistema de cadastro de  |
|         Pessoa Físicas e Juridicas      | 
===========================================   
");

Utils.barraCarregamento("Carregando");

string opcao;

//começo doWhile

do
{

    Console.Clear();
    Console.WriteLine(@$"
==========================================
|        Escolha uma das opções abaixo:  |   
|----------------------------------------|
|            1 - Pessoa Física           | 
|            2 - Pessoa Jurídica         |   
|                                        |   
|            0 - Sair                    |   
==========================================
");

    opcao = Console.ReadLine();


    // if (opcao == "1")
    // {

    // }else if (opcao == "2")
    // {

    // }else if (opcao == "0")
    // {

    // }else

    // {

    // }
    switch (opcao)
    {
        case "1":
            //métodos dos objetos --Genericos
            PessoaFisica metodosPf = new PessoaFisica();

            // *************************** Cadastro ******************************

            //endereço de pessoa física
            Endereco endPf = new Endereco();
            endPf.logradouro = "Rua Bacaba";
            endPf.numero = 328;
            endPf.comercial = false;

            //pessoa física
            PessoaFisica novaPessoaFisica = new PessoaFisica();

            Console.WriteLine($"Digite o Nome:");

            novaPessoaFisica.nome = Console.ReadLine();
            novaPessoaFisica.dataNascimento = "29/01/1968";
            novaPessoaFisica.endereco = endPf;
            novaPessoaFisica.rendimento = 1600;
            novaPessoaFisica.cpf = "12345678-00";

            // *************************** Exibição ******************************

            Console.Clear();
            //Exibindo os dados da pessoa física
            Console.WriteLine();
            Console.WriteLine($"**************PESSOA FÍSICA*************");
            Console.WriteLine();
            Console.WriteLine(@$"
            
Nome {novaPessoaFisica.nome}
Endereço: {novaPessoaFisica.endereco.logradouro}
Número: {novaPessoaFisica.endereco.numero}
Endereço Comercial: {novaPessoaFisica.endereco.comercial}
CPF: {novaPessoaFisica.cpf}
Data Nascimento: {novaPessoaFisica.dataNascimento}
Maior de Idade: {metodosPf.ValidarDataNascimento(novaPessoaFisica.dataNascimento)}
Rendimento: R$ {novaPessoaFisica.rendimento}
Rendimento Líquido: R$ {metodosPf.PagarImposto(novaPessoaFisica.rendimento)}
");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();
            Console.ResetColor();


            break;

        case "2":
            //métodos dos objetos --Genericos
            PessoaJuridica metodosPj = new PessoaJuridica();

            // *************************** Cadastro ******************************

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
            novaPessoaJuridica.rendimento = 6000;

            // *************************** Exibição ******************************

            Console.WriteLine();
            Console.WriteLine($"**************PESSOA JURÍDICA*************");
            Console.WriteLine();

            Console.WriteLine(@$"
Razão Social: {novaPessoaJuridica.nome}
CNPJ: {novaPessoaJuridica.cnpj}
Representante: {novaPessoaJuridica.nome}
Endereço: {novaPessoaJuridica.endereco.logradouro}
Número: {novaPessoaJuridica.endereco.numero}
Endereço Comercial: {novaPessoaJuridica.endereco.comercial}
CNPJ Válido? {metodosPj.ValidarCnpj(novaPessoaJuridica.cnpj)}
Rendimento: R$ {novaPessoaJuridica.rendimento}
Rendimento Líquido: R$ {metodosPj.PagarImposto(novaPessoaJuridica.rendimento)}
");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();
            Console.ResetColor();

            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");

            Utils.barraCarregamento("Finalizando");

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção Invalida, digite outra opção!");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }

    // fim do doWhile

} while (opcao != "0");


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

//métodos dos objetos


// *************************** Exibição ******************************

// Console.WriteLine($"Nome: {novaPessoaFisica.nome}");
// Console.WriteLine($"Endereço: {novaPessoaFisica.endereco.logradouro}");
// Console.WriteLine($"Número: {novaPessoaFisica.endereco.numero}");
// Console.WriteLine($"Endereço Comercial: {novaPessoaFisica.endereco.comercial}");
// Console.WriteLine($"CPF: {novaPessoaFisica.cpf}");

// Console.WriteLine($"Data Nascimento: " + novaPessoaFisica.dataNascimento);
// Console.WriteLine("Maior de Idade: "+ metodosPf.ValidarDataNascimento(novaPessoaFisica.dataNascimento));
// Console.WriteLine($"Rendimento: R$ {novaPessoaFisica.rendimento}");
// Console.WriteLine($"Rendimento Líquido: R$ {metodosPf.PagarImposto(novaPessoaFisica.rendimento)}"); //cáuculo do desconto


//Exibir os dados da pessoa jurídica


// Console.WriteLine($"Razão Social: {novaPessoaJuridica.nome}");
// Console.WriteLine($"CNPJ: {novaPessoaJuridica.cnpj}");
// Console.WriteLine($"Representante: {novaPessoaJuridica.nome}");
// Console.WriteLine($"Endereço: {novaPessoaJuridica.endereco.logradouro}");
// Console.WriteLine($"Número: {novaPessoaJuridica.endereco.numero}");
// Console.WriteLine($"Endereço Comercial: {novaPessoaJuridica.endereco.comercial}");
// Console.WriteLine($"CNPJ Válido? {metodosPj.ValidarCnpj(novaPessoaJuridica.cnpj)}");
// Console.WriteLine($"Rendimento: R$ {novaPessoaJuridica.rendimento}");
// Console.WriteLine($"Rendimento Líquido: R$ {metodosPj.PagarImposto(novaPessoaJuridica.rendimento)}"); //cáuculo do desconto
