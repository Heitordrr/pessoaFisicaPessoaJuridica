using Interface;

namespace Classes {
    
    public class PessoaJuridica : Pessoa, pessoaJuridica {

        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }
        
        public override float calcularImporsto(float rendimento) {
            throw new NotImplementedException();
        }

        public override float pagarImposto(float rendimento) {
            throw new NotImplementedException();
        }

        public bool validarCnpj (string cnpj) {
            throw new NotImplementedException();
         }
    }
}