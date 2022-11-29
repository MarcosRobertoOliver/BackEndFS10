using System.Text.RegularExpressions;
using BackEndProj.Classes;


//Métodos genéricos
PessoaFisica metodosPf = new PessoaFisica();
PessoaJuridica metodosPj = new PessoaJuridica();
//cabeçalho de boas vindas

Console.WriteLine(@$"
===========================================
|    bem vindo ao sistema de cadastro de  |
|         Pessoa Físicas e Juridicas      | 
===========================================   
");

Utils.barraCarregamento("Iniciando o sistema");

string opcao;


// ************************** MENU PRINCIPAL *******************
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
    Console.Write("Opção:");
    opcao = Console.ReadLine(); // esperando o usuario digitar
    Console.Clear();


    switch (opcao)
    {
        case "1": // Pessoa Fisica
            List<PessoaFisica> cadastroPf = new List<PessoaFisica>(); //Lista (Array) de PessoaFísica

            //*********** SUB-MENU PESSOA FíSICA ************
            string opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
==========================================
|     Escolha uma das seguintes opções:  |   
|----------------------------------------|
|         1 - Cadastrar Pessoa Física    | 
|         2 - Listar Pessoa Fisica       |   
|                                        |   
|         0 - Voltar ao menu anterior    |   
==========================================
");
                Console.Write("Escolha uma opção:");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1": // Cadastrar pessoa Física

                        //endereço de pessoa física
                        Endereco endPf = new Endereco();
                        endPf.logradouro = "Rua Bacaba";
                        endPf.numero = 328;
                        endPf.comercial = false;

                        //pessoa física
                        PessoaFisica novaPessoaFisica = new PessoaFisica();

                        // Console.WriteLine($"Digite o Nome:");

                        novaPessoaFisica.nome = "Marcos";
                        novaPessoaFisica.dataNascimento = "29/01/1968";
                        novaPessoaFisica.endereco = endPf;
                        novaPessoaFisica.rendimento = 1600;
                        novaPessoaFisica.cpf = "12345678-00";

                        cadastroPf.Add(novaPessoaFisica); //cadastra na lista
                        Utils.barraCarregamento("Cadastro Pessoa Física Efetuado com sucesso");
                        break;

                    case "2": // Listar pessoa Física

                        Console.WriteLine($"************** Listagem Pessoas Física *************");
                        Console.WriteLine();
                        //ler cada pessoa da lista 
                        foreach (var pf in cadastroPf)
                        {

                            Console.WriteLine(@$"
Nome {pf.nome}
Endereço: {pf.endereco.logradouro}1
Número: {pf.endereco.numero}
Endereço Comercial: {pf.endereco.comercial}
CPF: {pf.cpf}
Data Nascimento: {pf.dataNascimento}
Maior de Idade: {metodosPf.ValidarDataNascimento(pf.dataNascimento)}
Rendimento: R$ {pf.rendimento}
Rendimento Líquido: R$ {metodosPf.PagarImposto(pf.rendimento)}
");
                        }

                        Utils.barraCarregamento("Fim da Listagem");
                        break;

                    case "0": // Voltar ao menu principal
                        Utils.barraCarregamento("Opção escolhida é voltar ao menu anterior");
                        break;

                    default:
                        Utils.barraCarregamento("Opção Invalida pressione 'ENTER' para continuar");
                        break;
                }

            } while (opcaoPf != "0");



            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();
            Console.ResetColor();
            Utils.barraCarregamento("pressione 'ENTER' para continuar");
            break;




        case "2": //Cadastra uma Pessoa Juridica
            List<PessoaJuridica> cadastroPj = new List<PessoaJuridica>(); //Lista (Array) de PessoaJuridica
            string opcaoPj;



            do
            {
                Console.Clear();
                Console.WriteLine(@$"
==========================================
|     Escolha uma das seguintes opções:  |   
|----------------------------------------|
|         1 - Cadastrar Pessoa Jurídica  | 
|         2 - Listar Pessoa Jurídica     |   
|                                        |   
|         0 - Voltar ao menu anterior    |   
==========================================
");
                Console.Write("Escolha uma opção:");
                opcaoPj = Console.ReadLine();
                switch (opcaoPj)
                {
                    case "1": //Cadastrar Pessoa Juridica



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

                        //Cadastrar uma pessoa na lista
                        cadastroPj.Add(novaPessoaJuridica);

                        Utils.barraCarregamento("Pessoa Juridica cadastrada com sucesso!!!");
                        break;

                    case "2": //Listar Pessoa Juridica
                        Console.Clear();
                        Console.WriteLine($"************** Listagem Pessoas Jurídica *************");
                        Console.WriteLine();
                        //ler cada pessoa da lista
                        foreach (var pj in cadastroPj)
                        {
                           
Console.WriteLine();
Console.WriteLine(@$"
Razão Social: {pj.nome}
CNPJ: {pj.cnpj}
Representante: {pj.nome}
Endereço: {pj.endereco.logradouro}
Número: {pj.endereco.numero}
Endereço Comercial: {pj.endereco.comercial}
CNPJ Válido? {metodosPj.ValidarCnpj(pj.cnpj)}
Rendimento: R$ {pj.rendimento}
Rendimento Líquido: R$ {metodosPj.PagarImposto(pj.rendimento)}
");
}
Utils.barraCarregamento("Fim da Listagem");
                        break;

                    case "0": // Voltar ao menu principal
                        Utils.barraCarregamento("Opção escolhida é voltar ao menu anterior");
                        break;

                    default:
                        Utils.barraCarregamento("Opção Invalida, pressione");
                        break;
                }

            } while (opcaoPj != "0");





            // *************************** Exibição ******************************


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



// // *************************** Exibição ******************************

//             Console.Clear();
//             //Exibindo os dados da pessoa física
//             






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
