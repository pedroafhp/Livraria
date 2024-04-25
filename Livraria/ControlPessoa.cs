using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlPessoa
    {
        DAOPessoa person;//Conexão com Pessoa
        Pessoa model;//Conectar Com a Classe Pessoa
        private int opcao;
        public ControlPessoa()
        {
            person = new DAOPessoa();
            model = new Pessoa();//Acesso a Todos os Métodos da Classe Pessoa
            ModificarOpcao = 0;
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
                              "\n2. Consultar Tudo"               +
                              "\n3. Consultar Individual"         +
                              "\n4. Atualizar Nome"               +
                              "\n5. Atualizar Telefone"           +
                              "\n6. Atualizar Endereço"           +
                              "\n7. Atualizar Data de Nascimento" + 
                              "\n8. Atualizar Senha"              +
                              "\n9. Atualizar Situação"           +
                              "\n10.Excluir");
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
                    person.Inserir(CPF, nome, endereco, telefone, dtaNascimento, login, senha, "Ativo", cargo);
                    break;

                    case 2:
                    //Mostrar os Dados
                    Console.WriteLine(person.ConsultarTudo());
                    break;

                    case 3:
                    Console.WriteLine("Informe o CPF que Deseja Consultar: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine(person.ConsultarIndividual(CPF));
                    break;

                    case 4:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o Novo Nome: ");
                    nome = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(CPF, "Nome", nome));
                    break;

                    case 5:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o Novo Endereço: ");
                    endereco = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(CPF, "Endereco", endereco));
                    break;

                    case 6:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o Novo Telefone: ");
                    telefone = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(CPF, "Telefone", telefone));
                    break;

                    case 7:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a Nova Data de Nascimento: ");
                    dtaNascimento = Convert.ToDateTime(Console.ReadLine());

                    //Atualizar
                    Console.WriteLine(person.Atualizar(CPF, "Data de Nascimento", dtaNascimento));
                    break;

                    case 8:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe a Nova Senha: ");
                    senha = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(CPF, "Senha", senha));
                    break;

                    case 9:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Informe o Novo Cargo: ");
                    cargo = Console.ReadLine();

                    //Atualizar
                    Console.WriteLine(person.Atualizar(CPF, "Cargo", cargo));
                    break;

                    case 10:
                    Console.WriteLine("Informe o CPF: ");
                    CPF = Convert.ToInt64(Console.ReadLine());

                    //Excluir
                    person.Excluir(CPF);
                    break;

                default:
                    Console.WriteLine("Escolha uma Opção Válida!");
                    break;
            }//Fim do Switch

            }//Fim da Operação

    }//Fim da Classe
}//Fim do Projeto
