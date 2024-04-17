using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlLivro
    {
        Livro model;//Conectar Com a Classe Pessoa
        private int opcao;
        public ControlLivro()
        {
            model = new Livro();//Acesso a Todos os Métodos da Classe Pessoa
        }//Fim do Construtor

        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//Fim do Modificar Opcao

        public void Menu()
        {
            Console.WriteLine("Menu - Livro" +
                             "\nEscolha Uma das Opções Abaixo: "   +
                             "\n1. Cadastrar Livro" +
                             "\n2. Consultar Livro" +
                             "\n3. Atualizar Livro"              +
                             "\n4. Atualizar Quantidade"            +
                             "\n5. Atualizar Preço"                 +
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

                    Console.WriteLine("Informe o Título do Livro: ");
                    string titulo = Console.ReadLine();

                    Console.WriteLine("Informe o Autor do Livro: ");
                    string autor = Console.ReadLine();

                    Console.WriteLine("Informe a Editora do Livro: ");
                    string editora = Console.ReadLine();

                    Console.WriteLine("Informe o Genero do Livro: ");
                    string genero = Console.ReadLine();

                    Console.WriteLine("Informe o ISBN do Livro: ");
                    string ISBN = Console.ReadLine();

                    Console.WriteLine("Informe a Quantidade de Livros: ");
                    int quantidade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o Valor do Livro: ");
                    int preco = Convert.ToInt32(Console.ReadLine());

                    //Chamar o Método Cadastrar
                    model.CadastrarLivro(codigo, titulo, autor, editora, genero, ISBN, quantidade, preco, "Ativo");
                    break;

                case 2:
                    Console.WriteLine("Informe o Codigo do Livro que Deseja Consultar: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    //Mostrar os Dados
                    Console.WriteLine(model.ConsultarIndividual(codigo));
                    break;

                case 3:
                    Console.WriteLine("Informe o Codigo do Livro: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe a Nova Versão: ");
                    titulo = Console.ReadLine();

                    //Atualizar
                    titulo = model.ConsultarTitulo;
                    break;

                case 4:
                    Console.WriteLine("Informe o Codigo do Livro: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe a Nova Quantidade: ");
                    quantidade = Convert.ToInt32(Console.ReadLine());

                    //Atualizar
                    quantidade = model.ConsultarQuantidade;
                    break;

                case 5:
                    Console.WriteLine("Informe o Codigo do Livro: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o Novo Preço: ");
                    preco = Convert.ToInt32(Console.ReadLine());

                    //Atualizar
                    preco = model.ConsultarPreco;
                    break;

                case 6:
                    Console.WriteLine("Informe o Codigo do Livro: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                    //Excluir
                    model.Excluir(codigo);
                    codigo = Convert.ToInt32(Console.ReadLine());
                    break;

                default:
                    Console.WriteLine("Escolha uma Opção Válida!");
                    break;
            }//Fim do Switch

        }//Fim da Operação
    }//Fim do Método
}//Fim do Projeto
