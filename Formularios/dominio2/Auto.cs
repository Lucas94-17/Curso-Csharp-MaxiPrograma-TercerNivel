using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio2
{
    public class Auto
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public DateTime Fecha { get; set; }
        public bool Usado { get; set; }
        public bool Importado { get; set; }
        //public bool Nacional { get; set; }
    }
    public class AutoNegocio
    {
        public List<Auto> Listar()
        {
            List<Auto> ListaAutos = new List<Auto>();

            ListaAutos.Add(new Auto());

            ListaAutos[0].Id = 1;
            ListaAutos[0].Modelo = "Golf";
            ListaAutos[0].Descripcion = "Alto auto  y linda marca";
            ListaAutos[0].Color = "Rojo";
            ListaAutos[0].Fecha = DateTime.Now;
            ListaAutos[0].Usado = true;
            ListaAutos[0].Importado = true;

            return ListaAutos;
        }
    }
}

