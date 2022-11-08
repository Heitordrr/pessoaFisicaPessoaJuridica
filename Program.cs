using Backend;
using Classes;

{
    
}

List<PessoaFisica> listaPf = new List<PessoaFisica>();

Console.Clear();
string? opcao;

Utils.BarraCarregamento("Carregando");
do {
Console.WriteLine(@$"
    =================================================
    |      Bem vindo ao Sistema de Cadastro         |
    |           Pessoa Fisica Juridica              |
    =================================================
    |           1 - Pessoa Física                   |
    |                                               |
    |           2 - Pessoa Jurídica                 |
    |                                               |
    |           0 - Sair                            |
    =================================================
");
 Console.WriteLine("INFORME A OPÇÃO: ");
opcao = Console.ReadLine();
PessoaFisica metodosPf = new PessoaFisica();

switch (opcao) {
    case "1":
        

            string? opcaoPf;
        do {
            Console.Clear();
            Console.WriteLine(@$"
    =================================================
    |      Bem vindo ao Sistema de Cadastro         |
    |           Pessoa Fisica Juridica              |
    =================================================
    |         1 - Cadastrar Pessoa Física           |
    |                                               |
    |         2 - Lista Pessoa Física               |
    |                                               |
    |       0 - Voltar ao menu anterior             |
    =================================================
    ");

        opcaoPf = Console.ReadLine();
        Thread.Sleep(2000);

        switch (opcaoPf) {
            case "1":
            Console.Clear();
                PessoaFisica novapf = new PessoaFisica ();
                EnderecoFinal novoEndPf = new EnderecoFinal();


                Console.WriteLine("Digite o nome da pessoa física: ");
                novapf.nome = Console.ReadLine();

            //     bool dataValida;
            // do {
            //     Console.WriteLine("Digite a data de nascimento Ex: xx/xx/xxxx ");
            //     string? dataNascimento = Console.ReadLine();
            //     dataValida = novapf.validarDataNascimento(dataNascimento);
            //     if (dataValida) {
            //         DateTime.TryParse(dataNascimento, out DateTime dataConvertida);
            //         novapf.dataNascimento = dataConvertida;
            //     } else {
            //         Console.ForegroundColor = ConsoleColor.DarkRed;
            //         System.Console.WriteLine("Data inválida");
            //         Console.ResetColor();
            //         Thread.Sleep(3000);
            //     }
            // } while (!dataValida);

            // System.Console.WriteLine($"Digite o número do CPF: ");
            // novapf.cpf = Console.ReadLine();

            // System.Console.WriteLine($"Digite o rendimento mensal: (apenas números)");
            // novapf.rendimento = float.Parse(Console.ReadLine());

            // System.Console.WriteLine($"Digite o Logradouro: ");
            // novoEndPf.logradouro = Console.ReadLine();

            // System.Console.WriteLine($"Digite o Número: ");
            // novoEndPf.numero = int.Parse(Console.ReadLine());

            // System.Console.WriteLine($"Digite o Complemento: ");
            // novoEndPf.complemento = Console.ReadLine();

            // System.Console.WriteLine($"Este endereço é comercial? S/N ");
            // string endCom = Console.ReadLine().ToUpper();
            
            //     if (endCom == "S") {
            //         novoEndPf.endComercial = true;
            //     } else {
            //         novoEndPf.endComercial = false;
            //     }


            // novapf.endereco = novoEndPf;
            // listaPf.Add(novapf);

            //exemplo 1
            // StreamWriter sw = new StreamWriter($"{novapf.nome}.txt");
            // sw.WriteLine(novapf.nome);
            // sw.Close();

            using (StreamWriter sw = new StreamWriter($"{novapf.nome}.txt")) {
                sw.WriteLine(novapf.nome);
            }


            Console.Clear();
            Console.WriteLine($"Cadastro Gravado");
            Thread.Sleep(3000);
            break; 

            case "2": 
                Console.Clear();
                // foreach (PessoaFisica cadaPessoa in listaPf) {
               
                // Console.WriteLine(@$" 
                // Nome: {cadaPessoa.nome}
                // CPF: {cadaPessoa.cpf}
                // Maior de Idade: {(metodosPf.validarDataNascimento(cadaPessoa.dataNascimento) ? "Sim" : "Não")}
                // Imposto a ser pago: {metodosPf.pagarImposto(cadaPessoa.rendimento).ToString("C")}
                // ");  

                // Console.WriteLine($"Pressione ENTER para continuar");
                // Console.ReadLine();
                // }
                using (StreamReader sr = new StreamReader("heitor.txt")) {
                    string linha; 

                    while ((linha = sr.ReadLine()) != null){
                        Console.WriteLine(linha);
                    }
                    System.Console.WriteLine($"Tecle Enter");
                    Console.ReadLine();
                }


            break;

            case "0": 
                Utils.BarraCarregamento("Encerrando");
                Console.WriteLine("PROGRAMA ENCERRADO");
            break;

            default:
                Console.Clear();
                Console.WriteLine("COMANDO NÃO RECONHECIDO ----------> DIGITE UM COMANDO DO MENU");
                break;
            
        }

        } while (opcaoPf != "0");

        Console.WriteLine("PESSOA FÍSICA");

        



        // novapf.nome = "Heitor";
        // novapf.cpf = "12345678910";
        // novapf.rendimento = 6600.5f;
        // novapf.dataNascimento = new DateTime(2000, 10, 01);

        // novoEndPf.logradouro = "Rua da Mata";
        // novoEndPf.numero = 179;
        // novoEndPf.complemento = "Esquina da rua";
        // novoEndPf.endComercial = true;

        // novapf.endereco = novoEndPf;

        // Console.WriteLine(@$" 
        // Nome: {novapf.nome}, 
        // CPF: {novapf.cpf},
        // Logadrouro: {novapf.endereco.logradouro},
        // Numero: {novapf.endereco.numero}
        // ");

        // Thread.Sleep(5000);
        // Console.Clear();
    break;

    case "2":
        Console.Clear();
        Console.WriteLine("PESSOA JURÍDICA");
        PessoaJuridica novapj = new PessoaJuridica ();
        PessoaJuridica metodosPj = new PessoaJuridica();
        EnderecoFinal novoEndPj = new EnderecoFinal();

        novapj.nome = "So Agredece";
        novapj.razaoSocial = "HOMEM LTDA";
        novapj.cnpj = "02.464.694/0001-43";
        novoEndPj.logradouro = "Rua Belém";
        novoEndPj.numero = 177;

        novapj.endereco = novoEndPj;
        
        metodosPj.Inserir(novapj);

        // Console.WriteLine(@$"
        // Nome: {novapj.nome}
        // Razão Social: {novapj.razaoSocial}
        // CNPJ: {novapj.cnpj} - valido: {novapj.validarCnpj(novapj.cnpj)}
        // ");
        // Thread.Sleep(5000);
        // Console.Clear();

        List<PessoaJuridica> listaExibicaoPj = metodosPj.LerArquivo();

        foreach (PessoaJuridica cadaItem in listaExibicaoPj)
        {
            Console.Clear();
            Console.WriteLine(@$"
            Nome: {cadaItem.nome}
            Razão Social: {cadaItem.razaoSocial}

            
            ");
            Console.WriteLine($"Presione Enter");
            Console.ReadLine();
        }

    break;
    case "0":
    Utils.BarraCarregamento("Encerrando");
    Console.WriteLine("PROGRAMA ENCERRADO");
    break;

    default:
    Console.Clear();
    Console.WriteLine("COMANDO NÃO RECONHECIDO ----------> DIGITE UM COMANDO DO MENU");
    break;
}
} while (opcao != "0");     




// Thread.Sleep(4000);
// Console.Clear();

//novapf.endereco = "Belém, Pará, Brasil";
//Console.WriteLine(novapf.nome);
//Console.WriteLine(novapf.cpf);
//Console.WriteLine("Bem vindo " + novapf.nome + ", seu cpf é: " + novapf.cpf + " e seu endereço é " + novapf.endereco);

//Console.WriteLine("--------------------------------------------------------------------------------------------");

//PessoaJuridica novapj = new PessoaJuridica ();


// Console.WriteLine(novapj.validarCnpj("55523209000121"));
//Console.WriteLine("Nome da empresa é " + novapj.razaoSocial + ", seu CNPJ é: " + novapj.cnpj + " e seu endereço é " + novapj.endereco);
//Pessoa Física=========================================================================
//float ImpostoPagar = novapf.calcularImposto (novapf.rendimento);
//Console.WriteLine($"{calcularImposto:0.00}");
//Console.WriteLine(calcularImposto.ToString("C"));

//Pessoa Jurídica=========================================================================
//Console.Write(novapj.calcularImposto(6600.5f));

//var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
//Console.WriteLine(date1);

//DateTime temp = new DateTime(2000, 01, 01);
//Console.WriteLine(novapf.validarDataNascimento("01/01/2000"));

//========================================================
//ENCONTRO REMOTO 5

//===========================================================

//==========================================
//Encontro remoto 6