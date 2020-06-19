using System;
namespace AtividadeFixação2
{
    public class Pedido
    {
        public string[] Itens { get; set; }

        public Cliente Cliente { get; set; }

        public Restaurante Restaurante { get; set; }

        public string FormaPGTO { get; set; }

        public string Pagamento { get; set; }

        public DateTime DataEntrega { get; set; }

        public bool PedidoPago(){
            if(Pagamento != null){
                return true;
            }
                return false;   
        }

        public string EntregarPedido(){

             string retorno = "Pedido Entregue! \n";
             retorno += Cliente.MostrarDados1();
             retorno += Cliente.MostrarDados2();
             retorno += DataEntrega;


            return retorno;
        }
    }
}