using Interface;

namespace Classes {
    
    public class PessoaFisica : Pessoa, pessoaFisica {

        public string? cpf { get; set; }

        public DateTime dataNascimento { get; set; }

        

        public override float calcularImporsto(float rendimento) {
            throw new NotImplementedException();
        }

        public override float pagarImposto(float rendimento) {
            throw new NotImplementedException();
        }

        public bool validarDataNascimento(DateTime dataNascimento) {
            throw new NotImplementedException();
        }
    }

}
