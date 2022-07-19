using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class Producto
    {
      public  String Apio        { get; set; }
      public  String Porotov     { get; set; } 
      public  String Lechuga     { get; set; }
      public  String Acelga      { get; set; }
      public  String Ajo         { get; set; }
      public  String Berenjena   { get; set; }
      public  String Betarraga   { get; set; }
      public  String Cebollin    { get; set; }
      public  String Cebolla     { get; set; }
      public  String Choclo      { get; set; }
      public  String Frutilla    { get; set; }
      public  String Papa        { get; set; }
      public  String Poroto      { get; set; }
      public  String Repollo     { get; set; }
      public  String Tomate      { get; set; }
      public  String Zanahoria   { get; set; }
      public  String Habas       { get; set; }
      public  String Arvejas     { get; set; }
      public  String Pimenton  { get; set; }

        public Producto()
        {
        }

        public Producto(string apio, string porotov, string lechuga, string acelga, string ajo, string berenjena, string betarraga, string cebollin, string cebolla, string choclo, string frutilla, string papa, string poroto, string repollo, string tomate, string zanahoria, string habas, string arvejas, string pimenton)
        {
            Apio = apio;
            Porotov = porotov;
            Lechuga = lechuga;
            Acelga = acelga;
            Ajo = ajo;
            Berenjena = berenjena;
            Betarraga = betarraga;
            Cebollin = cebollin;
            Cebolla = cebolla;
            Choclo = choclo;
            Frutilla = frutilla;
            Papa = papa;
            Poroto = poroto;
            Repollo = repollo;
            Tomate = tomate;
            Zanahoria = zanahoria;
            Habas = habas;
            Arvejas = arvejas;
            Pimenton = pimenton;
        }


    }
}
