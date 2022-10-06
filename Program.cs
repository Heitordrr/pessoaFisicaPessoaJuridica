using Classes;
// See https://aka.ms/new-console-template for more information
PessoaFisica novapf = new PessoaFisica ();

novapf.nome = "Heitor";
novapf.cpf = "12345678910";
novapf.endereco = "Belém, Pará, Brasil";
//Console.WriteLine(novapf.nome);
//Console.WriteLine(novapf.cpf);
Console.WriteLine("Bem vindo " + novapf.nome + ", seu cpf é: " + novapf.cpf + " e seu endereço é " + novapf.endereco);

Console.WriteLine("--------------------------------------------------------------------------------------------");

PessoaJuridica novapj = new PessoaJuridica ();

novapj.razaoSocial = "HOMEM LTDA";
novapj.cnpj = "02.464.694/0001-43";
novapj.endereco = "São Paulo/sn";

Console.WriteLine("Nome da empresa é " + novapj.razaoSocial + ", seu CNPJ é: " + novapj.cnpj + " e seu endereço é " + novapj.endereco);


