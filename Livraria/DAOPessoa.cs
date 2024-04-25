using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Livraria
{
    class DAOPessoa
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public long[] CPF;
        public string[] nome;
        public string[] endereco;
        public string[] telefone;
        public DateTime[] dtaNascimento;
        public string[] login;
        public string[] senha;
        public string[] situacao;
        public string[] posicao;
        public int i;
        public int contador;
        public string msg;
        //Construtor
        public DAOPessoa() 
        {
            conexao = new MySqlConnection("server=localhost;DataBase=livrariaTI20N;Uid=root;Password=;Convert Zero DateTime=True");
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

        public void Inserir(long CPF, string nome, string endereco, string telefone, DateTime dtaNascimento, 
                            string login, string senha, string situacao, string posicao)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter();
                parameter.ParameterName = "@Date";
                parameter.MySqlDbType = MySqlDbType.Date;
                parameter.Value = dtaNascimento.Year + "-" + dtaNascimento.Month + "-" + dtaNascimento.Day;

                //Declarei as Variáveis e Preparei o Comando
                dados = $"('{CPF}','{nome}','{endereco}','{telefone}','{parameter.Value}','{login}','{senha}','{situacao}','{posicao}')";
                comando = $"Insert into pessoa values {dados}";

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
            string query = "select * from pessoa";//Coletar os Dados do Banco

            //Instanciar
            CPF = new long[100];
            nome = new string[100];
            endereco = new string[100];
            telefone = new string[100];
            dtaNascimento = new DateTime[100];
            login = new string[100];
            senha = new string[100];
            situacao = new string[100];
            posicao = new string[100];

            //Preencher
            for (i=0; i < 100; i++)
            {
                CPF[i] = 0;
                nome[i] = "";
                endereco[i] = "";
                telefone[i] = "";
                dtaNascimento[i] = new DateTime();
                login[i] = "";
                senha[i] = "";
                situacao[i] = "";
                posicao[i] = "";
            }//Fim do For

            //Preparar o Comando do Select
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura do Banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            while(leitura.Read())
            {
                CPF[i] = Convert.ToInt64(leitura["CPF"]);
                nome[i] = leitura["Nome"] + "";
                endereco[i] = leitura["Endereco"] + "";
                telefone[i] = leitura["Telefone"] + "";

                //Convertendo para o Padrão de Dia/Mês/Ano
                MySqlParameter parameter = new MySqlParameter();
                parameter.ParameterName = "@Date";
                parameter.MySqlDbType = MySqlDbType.Date;
                parameter.Value =  Convert.ToDateTime(leitura["dtNascimento"]).Day + "/"   +
                                   Convert.ToDateTime(leitura["dtNascimento"]).Month + "/" + 
                                   Convert.ToDateTime(leitura["dtNascimento"]).Year;
                dtaNascimento[i] = Convert.ToDateTime(parameter.Value);

                login[i] = leitura["Login"] + "";
                senha[i] = leitura["Senha"] + "";
                situacao[i] = leitura["Situacao"] + "";
                posicao[i] = leitura["Posicao"] + "";
                i++;
                contador++;
            }//Fim do While
            leitura.Close();//Fecha a Conexão com o Banco
        }//Fim do Método

        public string ConsultarTudo()
        {
            PreencherVetor();//Preencher os Vetores
            msg = "";
            for(i = 0; i < contador; i++) 
            {
                msg += "\nCPF: "                    + CPF[i] +
                       ", Nome: "                   + nome[i] +
                       ", Endereço: "               + endereco[i] +
                       ", Telefone: "               + telefone[i] +
                       ", Data de Nascimento: "     + dtaNascimento[i] +
                       ", Login: "                  + login[i] +
                       ", Senha: "                  + senha[i] +
                       ", Situação: "               + situacao[i] +
                       ", Posição: "                + posicao[i];
            }//Fim do For

            return msg;
        }//Fim do Método

        public string ConsultarIndividual(long codCPF)
        {
            PreencherVetor();
            for(i = 0; i < contador; i++)
            {
                if (CPF[i] == codCPF)
                {
                    msg = "CPF: "                    + CPF[i] +
                          ", Nome: "                 + nome[i] +
                          ", Endereco: "             + endereco[i] +
                          ", Telefone: "             + telefone[i] +
                          ", Data de Nascimento: "   + dtaNascimento[i] +
                          ", Login: "                + login[i] +
                          ", Senha: "                + senha[i] +
                          ", Situacao: "             + situacao[i] +
                          ", Cargo: "                + posicao[i];
                    return msg;
                }//Fim do If
            }//Fim do For

            return "Código Informado Não é Válido!";
        }//Fim do Consultar Individual

        public string Atualizar(long codCPF, string campo, string novoDado)
        {
            try
            {
                string query = "Update Pessoa Set " + campo + " = '" + novoDado + "' Where CPF = '" + codCPF + "'";
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

        public string Atualizar(long codCPF, string campo, DateTime novoDado)
        {
            try
            {
                string query = "Update Pessoa Set " + campo + " = '" + novoDado + "' Where CPF = '" + codCPF + "'";
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

        public string Excluir(long codCPF)
        {
            try
            {
                string query = "Update Pessoa Set Situacao = 'Inativo' Where CPF = '" + codCPF + "'";   
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
