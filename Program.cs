using Backend;
using Classes;

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
switch (opcao) {
    case "1":
        Console.Clear();
        Console.WriteLine("PESSOA FÍSICA");

        PessoaFisica novapf = new PessoaFisica ();
        EnderecoFinal novoEndPf = new EnderecoFinal();

        novapf.nome = "Heitor";
        novapf.cpf = "12345678910";
        novapf.rendimento = 6600.5f;
        novapf.dataNascimento = new DateTime(2000, 10, 01);

        novoEndPf.logradouro = "Rua da Mata";
        novoEndPf.numero = 179;
        novoEndPf.complemento = "Esquina da rua";
        novoEndPf.endComercial = true;

        novapf.endereco = novoEndPf;

        Console.WriteLine(@$" 
        Nome: {novapf.nome}, 
        CPF: {novapf.cpf},
        Logadrouro: {novapf.endereco.logradouro},
        Numero: {novapf.endereco.numero}
        ");

        Thread.Sleep(5000);
        Console.Clear();
    break;

    case "2":
        Console.Clear();
        Console.WriteLine("PESSOA JURÍDICA");
        PessoaJuridica novapj = new PessoaJuridica ();
        EnderecoFinal novoEndPj = new EnderecoFinal();

        novapj.nome = "So Agredece";
        novapj.razaoSocial = "HOMEM LTDA";
        novapj.cnpj = "02.464.694/0001-43";
        novoEndPj.logradouro = "Rua Belém";
        novoEndPj.numero = 177;

        novapj.endereco = novoEndPj;

        Console.WriteLine(@$"
        Nome: {novapj.nome}
        Razão Social: {novapj.razaoSocial}
        CNPJ: {novapj.cnpj} - valido: {novapj.validarCnpj(novapj.cnpj)}

        ");
        Thread.Sleep(5000);
        Console.Clear();
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