using ConsoleApp1;
using Projeto_RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PROJETO_Conce_POO
{
    internal class Clientes : Pessoas
    {



        public double Renda { get; set; }
        public string Profissao { get; set; }



        public int ID { get; set; }



        public List<string> HistoricoCompras { get; set; }











        public void PopularCliente()
        {



            Console.WriteLine("Insira o nome do cliente");
            nome = Console.ReadLine();



            Console.WriteLine("Informe o ID do cliente");
            ID = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Insira a idade do cliente");
            idade = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Insira o cpf do cliente");
            cpf = Console.ReadLine();



            Console.WriteLine("Insira o nascimento do cliente");
            data_nascimento = Console.ReadLine();



            Console.WriteLine("Insira a origem do cliente");
            origem = Console.ReadLine();



            Console.WriteLine("Insira renda cliente");
            Renda = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Insira a profissão do cliente");
            Profissao = Console.ReadLine();
            ID++;




        }



        public void AdicionarCompra(string compra)
        {
            if (HistoricoCompras == null)
            {
                HistoricoCompras = new List<string>();
            }



            HistoricoCompras.Add(compra);

        }



        public void MostrarHistoricoCompras()
        {
            if (HistoricoCompras == null || HistoricoCompras.Count == 0)
            {
                Console.WriteLine("Nenhuma compra registrada.");
            }
            else
            {
                Console.WriteLine("Histórico de Compras:");
                foreach (string compra in HistoricoCompras)
                {
                    Console.WriteLine(compra);
                }
            }
        }





        public static void ExcluirClientePorID(List<Clientes> listaClientes, int id)
        {
            var clienteParaExcluir = listaClientes.FirstOrDefault(cliente => cliente.ID == id);
            if (clienteParaExcluir != null)
            {
                listaClientes.Remove(clienteParaExcluir);
                Console.WriteLine("Cliente excluído com sucesso.");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }





    }
}