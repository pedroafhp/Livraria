using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlPessoa
    {
        Pessoa model;//Conectar Com a Classe Pessoa
        private int opcao;
        public ControlPessoa()
        {
            model = new Pessoa();//Acesso a Todos os Métodos da Classe Pessoa
        }//Fim do Construtor

        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//Fim do Modificar Opcao

        public void Menu()
        {
             Console.WriteLine("Menu - Pessoa"                    + 
                              "\nEscolha Uma das Opções Abaixo: " +
                              "\n1. Cadastrar Pessoa"             +
                              "\n2. Consultar Pessoa"             +
                              "\n3. Atualizar Nome"               +
                              "\n4. Atualizar Telefone"           +
                              "\n5. Atualizar Endereço"           +
                              "\n6. Atualizar Data de Nascimento" + 
                              "\n7. Atualizar Senha"              +
                              "\n8. Atualizar Situação"           +
                              "\n9. Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do Menu

        public void Operacao()
        {
            Menu();//Mostrar o Menu
            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Informe o CPF: ");
                    long CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o Seu Nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Informe o Seu Endereço: ");
                    string endereco = Console.ReadLine();

                    Console.WriteLine("Informe o Seu Telefone: ");
                    string telefone = Console.ReadLine();

                    Console.WriteLine("Informe Sua Data de Nascimento: ");
                    DateTime dtaNascimento = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Informe o Seu Login: ");
                    string login = Console.ReadLine();

                    Console.WriteLine("Informe a Sua Senha: ");
                    string senha = Console.ReadLine();

                    Console.WriteLine("Informe o Seu Cargo: ");
                    string cargo = Console.ReadLine();

                    //Chamar o Método Cadastrar
                    model.Cadastrar(CPF, nome, endereco, telefone, dtaNascimento, login, senha, cargo);
                    break;

                    case 2:
                    Console.WriteLine("Informe o CPF que Deseja Consultar: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    //Mostrar os Dados
                    Console.WriteLine(model.ConsultarIndividual(CPF));
                    break;

                    case 3:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o Novo Nome: ");
                    nome = Console.ReadLine();

                    //Atualizar
                    model.AtualizarNome(CPF, nome);
                    break;

                    case 4:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o Novo Endereço: ");
                    endereco = Console.ReadLine();

                    //Atualizar
                    model.AtualizarEndereco(CPF, endereco);
                    break;

                    case 5:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o Novo Telefone: ");
                    telefone = Console.ReadLine();

                    //Atualizar
                    model.AtualizarTelefone(CPF, telefone);
                    break;

                    case 6:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a Nova Data de Nascimento: ");
                    dtaNascimento = Convert.ToDateTime(Console.ReadLine());

                    //Atualizar
                    model.AtualizarDtaNascimento(CPF, dtaNascimento);
                    break;

                    case 7:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a Nova Senha: ");
                    senha = Console.ReadLine();

                    //Atualizar
                    model.AtualizarSenha(CPF, senha);
                    break;

                    case 8:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o Novo Cargo: ");
                    cargo = Console.ReadLine();

                    //Atualizar
                    model.AtualizarCargo(CPF, cargo);
                    break;

                    case 9:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    //Excluir
                    model.Excluir(CPF);
                    Console.WriteLine("Usuário Desativado" );
                    break;

                default:
                    Console.WriteLine("Escolha uma Opção Válida!");
                    break;
            }//Fim do Switch

            }//Fim da Operação

    }//Fim da Classe
}//Fim do Projeto
