using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Compra
    {
        Livro modelLivro;
        private int codigo;
        private string pessoa;
        private int codigoLivro;
        private int quantidade;
        private double preco;
        private double total;
        private string situacao;

        //Método Construtor
        public Compra()
        {
            ConsultarCodigo = 0;
            ConsultarPessoa = "";
            ConsultarLivro = 0;
            ConsultarQuantidade = 0;
            ConsultarPreco = 0;
            ConsultarTotal = 0;
            ConsultarSituacao = "";
        }//Fim do Construtor

        //Método Modificadores = Gets e Sets
        public int ConsultarCodigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }//Fim do Modificar

        public string ConsultarPessoa
        {
            get { return pessoa; }
            set { this.pessoa = value; }
        }//Fim do Modificar

        public int ConsultarLivro
        {
            get { return codigoLivro; }
            set { this.codigoLivro = value; }
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

        public double ConsultarTotal
        {
            get { return total; }
            set { this.total = value; }
        }//Fim do Modificar

        public string ConsultarSituacao
        {
            get { return situacao; }
            set { this.situacao = value; }
        }//Fim do Modificar

        //Métodos - CRUD
        public void EfeturarCompra(int codigo, string pessoa, int codigoLivro, int quantidade, int preco) 
        {
            ConsultarCodigo = 0;
            ConsultarPessoa = "";
            ConsultarQuantidade = 0;
            ConsultarPreco = modelLivro.ConsultarPrecoIndividual(codigoLivro);
            ConsultarTotal = ConsultarQuantidade * ConsultarPreco;
        }//Fim do Método

        public string ConsultarIndividual(int codigo)
        {
            string consulta = "";
            if (ConsultarCodigo == codigo)
            {
                consulta = "\nCodigo: "                 + ConsultarCodigo +
                                  "\nPessoa: "          + ConsultarPessoa +
                                  "\nLivro: "           + ConsultarLivro +
                                  "\nEditora: "         + ConsultarQuantidade +
                                  "\nValor Unitário: "  + ConsultarPreco +
                                  "\nTotal: "           + ConsultarTotal;
            }
            else
            {
                consulta = "Número de ISBN não é valido!";
            }
            return consulta;
        }//Fim do Método

        public void RealizarCompra(int codigoLivro)
        {
            if (ConsultarLivro != codigoLivro)
            {
                ConsultarLivro = codigoLivro;
            }
        }//Fim do Método

        public void AtualizarEstoque(int quantidade)
        {
            if (ConsultarQuantidade == 0)
            {
                ConsultarQuantidade = quantidade;
            }
        }//Fim do Método

        public void ConsultarValor(int preco)
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
