using System;

namespace AtividadeFixação2
{
    class Program
    {
        static void Main(string[] args)
        {
           Restaurante restaurante = new Restaurante("SenaiFood", "Barão de Limeira");
           Console.WriteLine(restaurante.MostrarDados());
           Console.WriteLine("");
           Console.WriteLine(restaurante.MostrarDados1());
           Console.WriteLine("");

           Cliente matheus = new Cliente("Matheus", "Avenida Brasil");
           Console.WriteLine(matheus.MostrarDados1());
           Console.WriteLine("");
           Console.WriteLine(matheus.MostrarDados2());
           Console.WriteLine("");
           Console.WriteLine("Seu Pedido saiu para entrega");
           Console.WriteLine("");

           Pedido pedido1 = new Pedido();
           pedido1.Cliente = matheus;
           pedido1.Restaurante = restaurante;
           

           Console.WriteLine(pedido1.EntregarPedido());
          




        }
    }
}
