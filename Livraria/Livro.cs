using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Livro
    {
        private int codigo;
        private string titulo;
        private string autor;
        private string editora;
        private string genero;
        private string ISBN;
        private int quantidade;
        private int preco;
        private string situacao;

        //Método Construtor
        public Livro()
        {
            ConsultarCodigo = 0;
            ConsultarTitulo = "";
            ConsultarAutor = "";
            ConsultarEditora = "";
            ConsultarGenero = "";
            ConsultarISBN = "";
            ConsultarQuantidade = 0;
            ConsultarPreco = 0;
        }//Fim do Construtor

        //Método Modificadores = Gets e Sets
        public int ConsultarCodigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }//Fim do Modificar

        public string ConsultarTitulo
        {
            get { return titulo; }
            set { this.titulo = value; }
        }//Fim do Modificar

        public string ConsultarAutor
        {
            get { return autor; }
            set { this.autor = value; }
        }//Fim do Modificar

        public string ConsultarEditora
        {
            get { return editora; }
            set { this.editora = value; }
        }//Fim do Modificar

        public string ConsultarGenero
        {
            get { return genero; }
            set { this.genero = value; }
        }//Fim do Modificar

        public string ConsultarISBN
        {
            get { return ISBN; }
            set { this.ISBN = value; }
        }//Fim do Modificar

        public int ConsultarQuantidade
        {
            get { return quantidade; }
            set { this.quantidade = value; }
        }//Fim do Modificar

        public int ConsultarPreco
        {
            get { return preco; }
            set { this.preco = value; }
        }//Fim do Modificar

        public string ConsultarSituacao
        {
            get { return situacao; }
            set { this.situacao = value; }
        }//Fim do Modificar

        //Métodos - CRUD
        public void CadastrarLivro(int codigo, string titulo, string autor, string editora,
            string genero, string ISBN, int quantidade, int preco, string situacao)
        {
            ConsultarCodigo = 0;
            ConsultarTitulo = "";
            ConsultarAutor = "";
            ConsultarEditora = "";
            ConsultarGenero = "";
            ConsultarISBN = "";
            ConsultarQuantidade = 0;
            ConsultarPreco = 0;
            ConsultarSituacao = "Ativo";
        }//Fim do Método

        public string ConsultarIndividual(int codigo)
        {
            string consulta = "";
            if (ConsultarCodigo == codigo)
            {
                consulta =        "\nCodigo: "      + ConsultarCodigo +
                                  "\nTitulo: "      + ConsultarTitulo +
                                  "\nAutor: "       + ConsultarAutor +
                                  "\nEditora: "     + ConsultarEditora +
                                  "\nGenero: "      + ConsultarGenero +
                                  "\nIBSN: "        + ConsultarISBN +
                                  "\nQuantidade: "  + ConsultarQuantidade +
                                  "\nPreço: "       + ConsultarPreco;
            }
            else
            {
                consulta = "Número de ISBN não é valido!";
            }
            return consulta;
        }//Fim do Método

        public double ConsultarPrecoIndividual(int codigo)
        {
            double consulta = 0;
            if (ConsultarCodigo == codigo)
            {
                consulta = ConsultarPreco;
            }
            return consulta;
        }//Fim do Método

        public void AtualizarVersao(string titulo)
        {
            if (ConsultarTitulo != titulo)
            {
                ConsultarTitulo = titulo;
            }
        }//Fim do Método

        public void AtualizarEstoque(int quantidade)
        {
            if (ConsultarQuantidade == 0)
            {
                ConsultarQuantidade = quantidade;
            }
        }//Fim do Método

        public void AtualizarValor(int preco)
        {
            if (ConsultarPreco != preco)
            {
                ConsultarPreco = preco;
            }//Fim do If
        }//Fim do Método

        public void AtualizarSituacao(int codigo, string situacao)
        {
            if (ConsultarCodigo == codigo)
            {
                ConsultarSituacao = situacao;
            }//Fim do If
        }//Fim do Método

        public void Excluir(int codigo)
        {
            if (ConsultarCodigo == codigo)
            {
                ConsultarSituacao = "Inativo";

            }//Fim do If
        }//Fim do Excluir

    }//Fim da Classe
}//Fim do Projeto
