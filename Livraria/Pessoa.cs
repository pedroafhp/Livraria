using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Pessoa
    {
        private long CPF;
        private string nome;
        private string endereco;
        private string telefone;
        private DateTime dtaNascimento;
        private string login;
        private string senha;
        private string situacao;//Ativo ou Inativo
        private string posicao;//Atendente ou Administrador ou Cliente

        //Método Construtor
        public Pessoa()
        {
            ModificarCPF = 0;
            ModificarNome = "";
            ModificarEndereco = "";
            ModificarTelefone = "";
            ModificarDtaNascimento = new DateTime();//"00/00/0000 00:00:00"
            ModificarLogin = "";
            ModificarSenha = "";
            ModificarSituacao = "";
            ModificarPosicao = "";
        }//Fim do Construtor

        //Método Modificadores = Gets e Sets
        public long ModificarCPF
        {
            get { return CPF; }
            set { this.CPF = value; }
        }//Fim do Modificar

        public string ModificarNome
        {
            get { return nome; }
            set { this.nome = value; }
        }//Fim do Modificar

        public string ModificarEndereco
        {
            get { return endereco; }
            set { this.endereco = value; }
        }//Fim do Modificar

        public string ModificarTelefone
        {
            get { return telefone; }
            set { this.telefone = value; }
        }//Fim do Modificar

        public DateTime ModificarDtaNascimento
        {
            get { return dtaNascimento; }
            set { this.dtaNascimento = value; }
        }//Fim do Modificar

        public string ModificarLogin
        {
            get { return login; }
            set { this.login = value; }
        }//Fim do Modificar

        public string ModificarSenha
        {
            get { return senha; }
            set { this.senha = value; }
        }//Fim do Modificar

        public string ModificarSituacao
        {
            get { return situacao; }
            set { this.situacao = value; }
        }//Fim do Modificar

        public string ModificarPosicao
        {
            get { return posicao; }
            set { this.posicao = value; }
        }//Fim do Modificar

        //Métodos - CRUD
        public void Cadastrar(long CPF, string nome, string endereco, string telefone,
            DateTime dtaNascimento, string login, string senha, string posicao)
        {
            ModificarCPF = CPF;
            ModificarNome = nome;
            ModificarEndereco = endereco;
            ModificarTelefone = telefone;
            ModificarDtaNascimento = dtaNascimento;
            ModificarLogin = login;
            ModificarSenha = senha;
            ModificarSituacao = "Ativo";
            ModificarPosicao = posicao;
        }//Fim do Método

        public string ConsultarIndividual(long CPF)
        {
            string consulta = "";
            if (ModificarCPF == CPF)
            {
                consulta =        "\nNome: "                + ModificarNome          +
                                  "\nEndereço: "            + ModificarEndereco      +
                                  "\nTelefone: "            + ModificarTelefone      +
                                  "\nData de Nascimento: "  + ModificarDtaNascimento +
                                  "\nLogin: "               + ModificarLogin         +
                                  "\nSenha: "               + ModificarSenha         +
                                  "\nSituação: "            + ModificarSituacao      +
                                  "\nPosição: "             + ModificarPosicao;
            }
            else
            {
                consulta = "Número de CPF não é valido!";
            }
            return consulta;
        }//Fim do Método

        public void AtualizarNome(long CPF, string nome)
        {
            if(ModificarCPF == CPF)
            {
                ModificarNome = nome;
            }
        }//Fim do Método

        public void AtualizarEndereco(long CPF, string endereco)
        {
            if (ModificarCPF == CPF)
            {
                ModificarEndereco = endereco;
            }
        }//Fim do Método

        public void AtualizarTelefone(long CPF, string telefone)
        {
            if (ModificarCPF == CPF)
            {
                ModificarTelefone = telefone;
            }
        }//Fim do Método

        public void AtualizarDtaNascimento(long CPF, DateTime dtaNascimento)
        {
            if (ModificarCPF == CPF)
            {
                ModificarDtaNascimento = dtaNascimento;
            }
        }//Fim do Método

        public void AtualizarSenha(long CPF, string senha)
        {
            if (ModificarCPF == CPF)
            {
                ModificarSenha = senha;
            }
        }//Fim do Método

        public void AtualizarSituacao(long CPF, string situacao)
        {
            if (ModificarCPF == CPF)
            {
                ModificarSituacao = situacao;
            }
        }//Fim do Método

        public void AtualizarCargo(long CPF, string cargo)
        {
            if (ModificarCPF == CPF)
            {
                ModificarPosicao = cargo;
            }
        }//Fim do Método

        public void Excluir(long CPF)
        {
            if (ModificarCPF == CPF)
            {
                ModificarSituacao = "Inativo";

            }//Fim do If
        }//Fim do Excluir

    }//Fim da Classe
}//Fim do Projeto
