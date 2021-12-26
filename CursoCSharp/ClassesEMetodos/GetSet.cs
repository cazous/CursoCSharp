using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada)
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            setMarca(marca);
            setModelo(modelo);
            setCilindrada(cilindrada); //Assim, a construção do objeto já passa pelas validações dentro dos Setters
        }

        public Moto()
        {

        }

        public string getMarca()
        {
            return Marca;
        }
        public void setMarca(string marca)
        {
            Marca = marca;
        }

        public string getModelo()
        {
            return Modelo;
        }

        public void setModelo(string modelo)
        {
            Modelo = modelo;
        }

        public int getCilindrada()
        {
            return Cilindrada;
        }

        public void setCilindrada(int cilindrada)
        {
            //if(cilindrada > 0)
            //{
            //Cilindrada= cilindrada;
            //}
            Cilindrada = Math.Abs(cilindrada);
        }

    }
    internal class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.getMarca());
            Console.WriteLine(moto1.getModelo());
            Console.WriteLine(moto1.getCilindrada());

            var moto2 = new Moto();

            moto2.setMarca("Honda");
            moto2.setModelo("CG Titan");
            moto2.setCilindrada(-150);
            Console.WriteLine(moto2.getMarca() + " " + moto2.getModelo());
        }
    }
}
