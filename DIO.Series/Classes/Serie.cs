using System;

namespace Dio.series
{
    public class Serie : EntidadeBase
    {
        //Atributos da classe
        private Genero genero {get; set;}
        private string titulo {get; set;}
        private string descricao {get; set;}
        private int ano {get; set;}
        private bool excluido {get; set;}
        private bool Excluido {get; set;}

        //Metodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano){
            this.id = id;
            this.genero = genero;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
            this.excluido = excluido;
        }

        public override string ToString(){
            string retorno = "";
            retorno += "Gênero: " + this.genero + Environment.NewLine;
            retorno += "Título: " + this.titulo + Environment.NewLine;
            retorno += "Descrição: " + this.descricao + Environment.NewLine;
            retorno += "Ano de ínicio: " + this.ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo(){
            return this.titulo;
        }

        public int retornaId(){
            return this.id;
        }

        public bool retornaExcluido()
		{
			return this.Excluido;
		}

        public void excluir(){
            this.excluido = true;
        }
    }
}