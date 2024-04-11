using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Reserva
    {
        private int codigo;
        private string livro;
        private string pessoa;
        private int quantidade;
        private string ISBN;
 
        //Método Construtor
        public Reserva()
        {
            ConsultarCodigo = 0;
            ConsultarLivro = "";
            ConsultarPessoa = "";
            ConsultarQuantidade = 0;
            ConsultarISBN = "";

        }//Fim do Construtor

        //Método Modificadores = Gets e Sets
        public int ConsultarCodigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }//Fim do Modificar

        public string ConsultarLivro
        {
            get { return livro; }
            set { this.livro = value; }
        }//Fim do Modificar

        public string ConsultarPessoa
        {
            get { return pessoa; }
            set { this.pessoa = value; }
        }//Fim do Modificar

        public int ConsultarQuantidade
        {
            get { return quantidade; }
            set { this.quantidade = value; }
        }//Fim do Modificar

        public string ConsultarISBN
        {
            get { return ISBN; }
            set { this.ISBN = value; }
        }//Fim do Modificar

        //Métodos - CRUD
        public void CadastrarLivro(int codigo, string livro, string pessoa, int quantidade)
        {
            ConsultarCodigo = 0;
            ConsultarLivro = "";
            ConsultarPessoa = "";
            ConsultarQuantidade = 0;
        }//Fim do Método

        public string ConsultarIndividual(string ISBN)
        {
            string consulta = "";
            if (ConsultarISBN == ISBN)
            {
                consulta =        "\nCodigo: "     + ConsultarCodigo +
                                  "\nLivro: "      + ConsultarLivro +
                                  "\nPessoa: "     + ConsultarPessoa +
                                  "\nQuantidade: " + ConsultarQuantidade;
            }
            else
            {
                consulta = "Número de ISBN não é valido!";
            }
            return consulta;
        }//Fim do Método

        public void Excluir(string ISBN)
        {
            if (ConsultarISBN == ISBN)
            {
                ConsultarISBN = "Inativo";

            }//Fim do If
        }//Fim do Excluir

    }//Fim do Método
}//Fim do Projeto
