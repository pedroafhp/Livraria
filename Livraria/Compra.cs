using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Compra
    {
        Pessoa modelPessoa;
        Livro modelLivro;
        private double precoTotal;

        //Método Construtor
        public Compra()
        {
            modelPessoa = new Pessoa();
            modelLivro = new Livro();

        }//Fim do Construtor

        //Método Modificadores = Gets e Sets
        public double ConsultarPrecoTotal
        {
            get { return precoTotal; }
            set { this.precoTotal = value; }
        }//Fim do Modificar

        //Métodos - CRUD
        public void EfeturarCompra(int codigo, int CPF, string pessoa, string telefone, int codigoLivro, int quantidade, double preco, double precoTotal) 
        {
            ConsultarCPF = modelPessoa.ConsultarIndividual(CPF);
            ConsultarPessoa = modelPessoa.ConsultarIndividual(pessoa);
            ConsultarTelefone = modelPessoa.AtualizarTelefone(telefone);
            ConsultarCodigo = modelLivro.ConsultarPrecoIndividual(codigo);
            ConsultarQuantidade = modelLivro.AtualizarEstoque(quantidade);
            ConsultarPreco = modelLivro.ConsultarPrecoIndividual(codigoLivro);
            ConsultarPrecoTotal = ConsultarPreco * ConsultarQuantidade(preco, quantidade);
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
