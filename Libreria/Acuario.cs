using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Acuario
    {
        public string Direccion { get; set; }
        public Delfin delfin { get;set;}
        public Delfin delfin1 { get;set;}
        public Orca orca { get;set;}

        

        public void ListaDeNombres()
        {
            Console.WriteLine("Delfin 1 : " + delfin.nombre);
            Console.WriteLine("Delfin 2 : " + delfin1.nombre);
            Console.WriteLine("orca : " + orca.nombre);
            Console.WriteLine("direccion : " + Direccion);
            
        }





    }
}
