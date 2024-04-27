using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace Livraria
{
    class DAOLivro
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public int[] codigo;
        public string[] titulo;
        public string[] autor;
        public string[] editora;
        public string[] genero;
        public string[] ISBN;
        public int[] quantidade;
        public double[] preco;
        public string[] situacao;
        public int i;
        public int contador;
        public string msg;
        //Construtor
        public DAOLivro()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=livrariaTI20N;Uid=root;Password=");
            try
            {
                conexao.Open();//Abrir a Conexão
                Console.WriteLine("Conectado!");//Teste
            }
            catch (Exception erro)
            {
                Console.WriteLine("Algo Deu Errado!\n\n" + erro);
                conexao.Close();//Fechar a Conexão com o Banco
            }
        }//Fim do Construtor

        public void Inserir(int codigo, string titulo, string autor, string editora,
                            string genero, string ISBN, int quantidade, double preco, string situacao)
        {
            try
            {
                //Declarei as Variáveis e Preparei o Comando
                dados = $"('{codigo}','{titulo}','{autor}','{editora}','{genero}','{ISBN}','{quantidade}','{preco}','{situacao}')";
                comando = $"Insert into livro(codigo, titulo, autor, editora, genero, ISBN, quantidade, preco, situacao) values {dados}";

                //Engatilhar a Inserção do Banco
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Ctrl + Enter
                                                              //Mostrar na Tela
                Console.WriteLine(resultado + "Linha Afetada");
            }
            catch (Exception erro)
            {
                Console.WriteLine("Algo Deu Errado!\n\n" + erro);
            }

        }//Fim do Método

        public void PreencherVetor()
        {
            string query = "select * from livro";//Coletar os Dados do Banco

            //Instanciar
            codigo = new int[100];
            titulo = new string[100];
            autor = new string[100];
            editora = new string[100];
            genero = new string[100];
            ISBN = new string[100];
            quantidade = new int[100];
            preco = new double[100];
            situacao = new string[100];

            //Preencher
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                titulo[i] = "";
                autor[i] = "";
                editora[i] = "";
                genero[i] = "";
                ISBN[i] = "";
                quantidade[i] = 0;
                preco[i] = 0;
                situacao[i] = "";
            }//Fim do For

            //Preparar o Comando do Select
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura do Banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                titulo[i] = leitura["titulo"] + "";
                autor[i] = leitura["autor"] + "";
                editora[i] = leitura["editora"] + "";
                genero[i] = leitura["genero"] + "";
                ISBN[i] = leitura["ISBN"] + "";
                quantidade[i] = Convert.ToInt32(leitura["quantidade"]);
                preco[i] = Convert.ToDouble(leitura["preco"]);
                situacao[i] = leitura["situacao"] + "";
                i++;
                contador++;
            }//Fim do While
            leitura.Close();//Fecha a Conexão com o Banco
        }//Fim do Método

        public string ConsultarTudo()
        {
            PreencherVetor();//Preencher os Vetores
            msg = "";
            for (i = 0; i < contador; i++)
            {
                msg += "\nCodigo: "     + codigo[i] +
                       ", Titulo: "     + titulo[i] +
                       ", Autor: "      + autor[i] +
                       ", Editora: "    + editora[i] +
                       ", Genero: "     + genero[i] +
                       ", Quantidade: " + quantidade[i] +
                       ", Preco: "      + preco[i] +
                       ", Situação: "   + situacao[i];
            }//Fim do For

            return msg;
        }//Fim do Método

        public string ConsultarIndividual(int cod)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (codigo[i] == cod)
                {
                    msg = "\nCodigo: "      + codigo[i] +
                          ", Titulo: "      + titulo[i] +
                          ", Autor: "       + autor[i] +
                          ", Editora: "     + editora[i] +
                          ", Genero: "      + genero[i] +
                          ", Quantidade: "  + quantidade[i] +
                          ", Preco: "       + preco[i] +
                          ", Situação: "    + situacao[i];
                    return msg;
                }//Fim do If
            }//Fim do For

            return "Código Informado Não é Válido!";
        }//Fim do Consultar Individual

        public string Atualizar(int cod, string campo, string novoDado)
        {
            try
            {
                string query = "Update Livro Set " + campo + " = '" + novoDado + "' Where Codigo = '" + cod + "'";
                //Executar o Comando
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " Linha Afetada!";
            }
            catch (Exception ex)
            {
                return "Algo Deu Errado!\n\n\n" + ex;
            }
        }//Fim do Método

        public string Atualizar(int cod, string campo, int novoDado)
        {
            try
            {
                string query = "Update Livro Set " + campo + " = '" + novoDado + "' Where Codigo = '" + cod + "'";
                //Executar o Comando
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " Linha Afetada!";
            }
            catch (Exception ex)
            {
                return "Algo Deu Errado!\n\n\n" + ex;
            }
        }//Fim do Método

        public string Excluir(int cod)
        {
            try
            {
                string query = "Update Livro Set Situacao = 'Inativo' Where Codigo = '" + cod + "'";
                //Executar o Comando
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " Linha Afetada!";
            }
            catch (Exception ex)
            {
                return "Algo Deu Errado!\n\n\n" + ex;
            }
        }//Fim do Método

    }//Fim da Classe
}//Fim do Projeto
