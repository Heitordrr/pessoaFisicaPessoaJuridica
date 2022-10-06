using Classes;
// See https://aka.ms/new-console-template for more information
PessoaFisica novapf = new PessoaFisica ();

novapf.nome = "Heitor";
novapf.cpf = "12345678910";


//Console.WriteLine(novapf.nome);
//Console.WriteLine(novapf.cpf);

Console.WriteLine("Bem vindo " + novapf.nome + ", seu cpf é: " + novapf.cpf);