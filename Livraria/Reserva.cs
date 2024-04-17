using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private double preco;
        private string situacao;
 
        //Método Construtor
        public Reserva()
        {
            ConsultarCodigo = 0;
            ConsultarLivro = "";
            ConsultarPessoa = "";
            ConsultarQuantidade = 0;
            ConsultarPreco = 0;
            ConsultarSituacao = "";

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

        public double ConsultarPreco
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
        public void ConsultarReserva(int codigo, string livro, string pessoa, int quantidade, double preco)
        {
            ConsultarCodigo = 0;
            ConsultarLivro = "";
            ConsultarPessoa = "";
            ConsultarQuantidade = 0;
            ConsultarPreco = 0;
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

    }//Fim do Método
}//Fim do Projeto
