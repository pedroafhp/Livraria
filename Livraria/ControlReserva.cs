﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlReserva
    {
        Reserva model;//Conectar Com a Classe Pessoa
        private int opcao;
        public ControlReserva()
        {
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
                             "\n2. Atualizar Quantidade"            +
                             "\n3. Excluir");
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
                    string quantidade = Console.ReadLine();

                    //Chamar o Método Consultar
                    model.ConsultarReserva(codigo, livro, pessoa, quantidade);
                    break;

                case 2:
                    Console.WriteLine("Informe o Codigo do Livro que Deseja Consultar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    //Mostrar os Dados
                    Console.WriteLine(model.ConsultarReserva(codigo));
                    break;

                case 3:
                    Console.WriteLine("Informe o Codigo: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o Livro que Deseja Reservar: ");
                    livro = Console.ReadLine();

                    //Atualizar
                    livro = model.ConsultarLivro;
                    break;

                case 4:
                    Console.WriteLine("Informe o Codigo do Livro: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe a Nova Quantidade: ");
                    quantidade = Convert.ToDouble32(Console.ReadLine());

                    //Atualizar
                    quantidade = model.ConsultarQuantidade;
                    break;

                case 5:
                    Console.WriteLine("Informe o Codigo do Livro: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o Novo Preço: ");
                    preco = Convert.ToInt32(Console.ReadLine());

                    //Atualizar
                    preco = model.ConsultarPreço;
                    break;

                case 6:
                    Console.WriteLine("Informe o Codigo do Livro: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    //Excluir
                    model.Excluir(codigo);
                    Console.WriteLine("Livro Desativado");
                    break;

                default:
                    Console.WriteLine("Escolha uma Opção Válida!");
                    break;
            }//Fim do Switch

        }//Fim da Operação
    }//Fim da Classe
}//Fim do Método
