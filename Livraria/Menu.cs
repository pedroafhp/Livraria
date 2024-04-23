using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Menu
    {
        ControlPessoa controlePessoa;
        ControlLivro controleLivro;
        ControlReserva controleReserva;
        public int opcao;

        public Menu()
        {
            controlePessoa = new ControlPessoa();
            controleLivro = new ControlLivro();
            controleReserva = new ControlReserva();
            opcao = 0;
        }//Fim do Menu

            public void EscolherControl()
            {
                   Console.WriteLine("\n\nMenu - Geral"               +
                                    "\n0. Sair "                      +
                                    "\n1. Pessoa "                    +
                                    "\n2. Livro"                      +
                                    "\n3. Reserva "                   +
                                    "\n4. Compra "                    +
                                    "\nEscolha Uma das Opções Acima: ");
                opcao = Convert.ToInt32(Console.ReadLine());
            }//Fim do Escolher

            public void OperacaoMenu()
            {
                do 
                { 
                    EscolherControl();//Chamar o Texto do Menu
                    switch (opcao)
                    {
                        case 0:
                            Console.WriteLine("Obrigado!");
                            break;

                        case 1:
                            controlePessoa.Operacao();
                            break;

                        case 2:
                            controleLivro.Operacao();
                        break;

                        case 3:
                            controleReserva.Operacao();
                            break;

                        case 4:
                            
                            break;

                    default:
                        break;
                    }//Fim do Switch
                } while (opcao != 0);
             }//Fim da Operação Menu

    }//Fim da Classe
}//Fim do Projeto
