using System;

namespace Imprimible
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora imprimir = new Impresora();
            Contrato contrato = new Contrato();
            Foto foto = new Foto();
            Documento documento = new Documento();

            imprimir.AgregarImprimible(contrato);
            imprimir.AgregarImprimible(foto);
            imprimir.AgregarImprimible(documento);

            imprimir.ImprimirTodo();
            Console.ReadKey();


        }




    }
}
