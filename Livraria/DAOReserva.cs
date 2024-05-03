using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace Livraria
{
    class DAOReserva
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public int[] codigo;
        public string[] livro;
        public string[] pessoa;
        public int[] quantidade;
        public double[] preco;
        public string[] situacao;
        public int i;
        public int contador;
        public string msg;
        //Construtor
        public DAOReserva()
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

        public void Inserir(int codigo, string livro, string pessoa,int quantidade, double preco, string situacao)
        {
            try
            {
                //Declarei as Variáveis e Preparei o Comando
                dados = $"('{codigo}','{livro}','{pessoa}','{quantidade}','{preco}','{situacao}')";
                comando = $"Insert into reserva(codigo, livro, pessoa, quantidade, preco, situacao) values {dados}";

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
            string query = "select * from reserva";//Coletar os Dados do Banco

            //Instanciar
            codigo = new int[100];
            livro = new string[100];
            pessoa = new string[100];
            quantidade = new int[100];
            preco = new double[100];
            situacao = new string[100];

            //Preencher
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                livro[i] = "";
                pessoa[i] = "";
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
                livro[i] = leitura["livro"] + "";
                pessoa[i] = leitura["pessoa"] + "";
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
                       ", Livro: "      + livro[i] +
                       ", Pessoa: "     + pessoa[i] +
                       ", Quantidade: " + quantidade[i] +
                       ", Preco: "      + preco[i] +
                       ", Situação: "   + situacao[i];
            }//Fim do For

            return msg;
        }//Fim do Método

        public string ConsultarIndividual(int codReserva)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (codigo[i] == codReserva)
                {
                    msg = "\nCodigo: "      + codigo[i] +
                          ", Livro: "       + livro[i] +
                          ", Pessoa: "      + pessoa[i] +
                          ", Quantidade: "  + quantidade[i] +
                          ", Preco: "       + preco[i] +
                          ", Situação: "    + situacao[i];
                    return msg;
                }//Fim do If
            }//Fim do For

            return "Código Informado Não é Válido!";
        }//Fim do Consultar Individual

        public string Atualizar(int codReserva, string campo, string novoDado)
        {
            try
            {
                string query = "Update Reserva Set " + campo + " = '" + novoDado + "' Where Codigo = '" + codReserva + "'";
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

        public string Atualizar(int codReserva, string campo, int novoDado)
        {
            try
            {
                string query = "Update Reserva Set " + campo + " = '" + novoDado + "' Where Codigo = '" + codReserva + "'";
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

        public string Excluir(int codReserva)
        {
            try
            {
                string query = "Update Reserva Set Situacao = 'Inativo' Where Codigo = '" + codReserva + "'";
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
