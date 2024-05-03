using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlReserva
    {
        DAOReserva reserv;//Conexão com Reserva
        DAOLivro li;
        Reserva model;//Conectar Com a Classe Pessoa
        private int opcao;
        public ControlReserva()
        {
            reserv = new DAOReserva();
            model = new Reserva();//Acesso a Todos os Métodos da Classe Pessoa
        }//Fim do Construtor

        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//Fim do Modificar Opcao

        public void Menu()
        {
            Console.WriteLine("Menu - Livro"                        +
                             "\nEscolha Uma das Opções Abaixo: "    +
                             "\n1. Reservar Livro"                  +
                             "\n2. Consultar Tudo"                  +
                             "\n3. Consultar Individual"            +
                             "\n4. Informar Dados do Usuário"       +
                             "\n5. Atualizar Quantidade"            +
                             "\n6. Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do Menu

        public void Operacao()
        {
            Menu();//Mostrar o Menu
            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Informe o Código do Livro: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o Livro:que Deseja Reservar ");
                    string livro = Console.ReadLine();

                    Console.WriteLine("Informe o CPF do Usuário: ");
                    string pessoa = Console.ReadLine();

                    Console.WriteLine("Informe a Quantidade que Deseja Reservar: ");
                    int quantidade = Convert.ToInt32(Console.ReadLine());

                    double preco = li.ConsultarPreco(codigo);

                    //Chamar o Método Consultar
                    reserv.Inserir(codigo, livro, pessoa, quantidade, preco, "Ativo");
                    break;

                case 2:
                    //Mostrar os Dados
                    Console.WriteLine(reserv.ConsultarTudo());
                    break;

                case 3:
                    Console.WriteLine("Informe o Codigo do Livro que Deseja Consultar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    //Mostrar os Dados
                    Console.WriteLine(reserv.ConsultarIndividual(codigo));
                    break;

                case 4:
                    Console.WriteLine("Informe o Codigo do Livro: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o CPF do Usuário: ");
                    pessoa = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(reserv.Atualizar(codigo, "Pessoa", pessoa));
                    break;

                case 5:
                    Console.WriteLine("Informe o Codigo do Livro: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o CPF do Usuário: ");
                    quantidade = Convert.ToInt32(Console.ReadLine());

                    //Atualizar
                    Console.WriteLine(reserv.Atualizar(codigo, "Quantidade", quantidade));
                    break;

                case 6:
                    Console.WriteLine("Informe o Codigo do Livro: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    //Excluir
                    reserv.Excluir(codigo);
                    break;

                default:
                    Console.WriteLine("Escolha uma Opção Válida!");
                    break;
            }//Fim do Switch

        }//Fim da Operação
    }//Fim da Classe
}//Fim do Método
