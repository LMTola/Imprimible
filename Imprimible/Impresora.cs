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
            //Contrato contrato = new Contrato();
            ColaDeImpresion.Add(unImprimible);

          // Foto foto = new Foto();
           // ColaDeImpresion.Add(foto);

           //Documento documento = new Documento();
           // ColaDeImpresion.Add(documento);

           
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
