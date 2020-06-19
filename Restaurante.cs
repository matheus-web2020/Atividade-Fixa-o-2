namespace AtividadeFixação2
{
    public class Restaurante
    {
        public string NomeRestaurante { get; set; }

        public string Endereço { get; set; }

        public Restaurante(string _nome, string _endereço){
            
            this.NomeRestaurante = _nome;
            this.Endereço = _endereço;
        }

        public string MostrarDados(){
            return $"Bem Vindo ao Restaurante: {NomeRestaurante}";
        
        }
        public string MostrarDados1(){
            return $"Estamos localizados na {Endereço}";
        
        }
    }
}