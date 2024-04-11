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
            ConsultarPreço = 0;
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

        public int ConsultarPreço
        {
            get { return preco; }
            set { this.preco = value; }
        }//Fim do Modificar

        //Métodos - CRUD
        public void CadastrarLivro(int codigo, string titulo, string autor, string editora,
            string genero, string ISBN, int quantidade, int preco)
        {
            ConsultarCodigo = 0;
            ConsultarTitulo = "";
            ConsultarAutor = "";
            ConsultarEditora = "";
            ConsultarGenero = "";
            ConsultarISBN = "";
            ConsultarQuantidade = 0;
            ConsultarPreço = 0;
        }//Fim do Método

        public string ConsultarIndividual(string ISBN)
        {
            string consulta = "";
            if (ConsultarISBN == ISBN)
            {
                consulta =        "\nCodigo: "      + ConsultarCodigo +
                                  "\nTitulo: "      + ConsultarTitulo +
                                  "\nAutor: "       + ConsultarAutor +
                                  "\nEditora: "     + ConsultarEditora +
                                  "\nGenero: "      + ConsultarGenero +
                                  "\nIBSN: "        + ConsultarISBN +
                                  "\nQuantidade: "  + ConsultarQuantidade +
                                  "\nPreço: "       + ConsultarPreço;
            }
            else
            {
                consulta = "Número de ISBN não é valido!";
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
            if (ConsultarPreço != preco)
            {
                ConsultarPreço = preco;
            }//Fim do If
        }//Fim do Método

        public void Excluir(string ISBN)
        {
            if (ConsultarISBN == ISBN)
            {
                ConsultarISBN = "Inativo";

            }//Fim do If
        }//Fim do Excluir

    }//Fim da Classe
}//Fim do Projeto
