namespace AtividadeFixação2
{
    public class Cliente
    {
        public string NomeCliente { get; set; }

        public string EndereçoAtual { get; set; }

        public Cliente(string _nome, string _endereçoAtual){
            this.NomeCliente = _nome;
            this.EndereçoAtual = _endereçoAtual;
        }

        public string MostrarDados1(){
            return $"Seu Nome Cadastrado está como: {NomeCliente}";
        }
        public string MostrarDados2(){
            return $"Você está localizado na: {EndereçoAtual}";
        }
    }
}