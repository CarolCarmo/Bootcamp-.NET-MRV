using System;
using System.Collections.Generic;
using Dio.series.Interfaces;

namespace Dio.series.Classes
{
    public class SerieRepositorio : iRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade){
            listaSerie[id] = entidade;
        }
        public void Exclui(int id){
            listaSerie[id].excluir();
        }
        public void Insere(Serie objeto){
            listaSerie.Add(objeto);
        }
        public List<Serie> Lista(){
            return listaSerie;
        }
        public int ProximoId(){
            return listaSerie.Count;
        }
        public Serie RetornoPorId(int id)
        {
            return listaSerie[id];
        }
    }
}