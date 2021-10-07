using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprimible
{
    class Impresora
    {

        List<Imprimible> ColaDeImpresion = new List<Imprimible>();

        public void AgregarImprimible(Imprimible unImprimible)
        {
            
            ColaDeImpresion.Add(unImprimible);
            
        }
        public void ImprimirTodo()
        {
            foreach (Imprimible c in ColaDeImpresion)
            {
                c.Imprimir();
            }
        }

    }

  

}
