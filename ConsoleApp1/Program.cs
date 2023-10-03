using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using PROJETO_Conce_POO;
using System.ComponentModel;



namespace Projeto_RH
{
    internal class Program
    {
        public static List<Clientes> lista_Cliente = new List<Clientes>();



        public static void CadastrarCliente(List<Clientes> lista_Cliente)
        {

            Clientes objCliente = new Clientes()
            objCliente.PopularCliente();







            lista_Cliente.Add(objCliente);

        }

        public static void VizualizarCliente()
        {





            for (int i = 0; i < lista_Cliente.Count; i++)
            {
                Console.WriteLine($"{i + 1}. ID: {lista_Cliente[i].ID}, Nome: {lista_Cliente[i].nome}, Idade: {lista_Cliente[i].ID}, Profissão: {lista_Cliente[i].Profissao}," +
                    $"CPF: {lista_Cliente[i].cpf}, Nascimento: {lista_Cliente[i].data_nascimento}, Origem: {lista_Cliente[i].origem} ");

            }





        }



        public static void MostrarHistoricoDeCompras(List<Clientes> listaClientes)
        {
            Console.WriteLine("Informe o ID do cliente para exibir o histórico de compras:");
            if (int.TryParse(Console.ReadLine(), out int idClienteHistorico))
            {
                Clientes clienteHistorico = listaClientes.FirstOrDefault(cliente => cliente.ID == idClienteHistorico);
                if (clienteHistorico != null)
                {
                    clienteHistorico.MostrarHistoricoCompras();
                }
                else
                {
                    Console.WriteLine("Cliente não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
        }



        public static void ExcluirClientePorID(List<Clientes> listaClientes)
        {
            Console.WriteLine("Informe o ID do cliente para excluir:");
            if (int.TryParse(Console.ReadLine(), out int idClienteExcluir))
            {
                Clientes.ExcluirClientePorID(listaClientes, idClienteExcluir);
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
        }





        static void ChamarMenu()
        {
            Console.WriteLine("--------MENU GERENCIADOR DE CONSSESIONARIA-----------");
            Console.WriteLine("1 : Clientes");
            Console.WriteLine("2 : Funcionários");
            Console.WriteLine("3 : Relógio Ponto");
            Console.WriteLine("4 : Sair");
        }



        static void ChamarSubMenuCliente()
        {
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 : Cadastrar");
            Console.WriteLine("2 : Vizualizar");
            Console.WriteLine("3 : Histórico de compras");
            Console.WriteLine("4 : Excluir");
            Console.WriteLine("5 : Sair");
        }



        static void ExecutarMenuCliente()
        {
            while (true)
            {
                ChamarSubMenuCliente();
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        CadastrarCliente(lista_Cliente);
                        break;
                    case "2":
                        VizualizarCliente();
                        break;
                    case "3":

                        MostrarHistoricoDeCompras(lista_Cliente);
                        break;
                    case "4":
                        ExcluirClientePorID(lista_Cliente);
                        break;



                    default:





                        return;
                }
            }
        }



        static void ExecutarMenu()
        {
            while (true)
            {
                ChamarMenu();
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        ExecutarMenuCliente();
                        break;
                    case "2":



                        break;
                    case "3":



                        break;
                    default:
                        Console.WriteLine("Até Mais!");
                        return;
                }
            }
        }



        static void Main(string[] args)
        {
            ExecutarMenu();
        }
    }
}