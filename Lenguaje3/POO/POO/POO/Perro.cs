using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Perro
    {
        //Atributos
        private string nombre;
        private string raza;
        private decimal altura;


        //Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Raza
        {
            get { return raza; }
            set { raza= value; }
        }

        public decimal Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        //Otra manera de crear propiedades
        //public string Nombre1 { get; set; }
        //public string Raza1 { get; set; } 
        //public decimal Altura1 { get; set; }

        //Como declarar un constructor
        public Perro()
        {

        }
        //Otra manera
        public Perro(string _nombre, string _raza, decimal _altura)
        {
            nombre = _nombre;
            raza = _raza;
            altura = _altura;
        }

        public Perro(string nombre)
        {
            Nombre=nombre;
        }

        //Metodos
        public decimal DevuelveAltura()
        {
            return Altura;
        }
        public string comer(string comida)
        {
            return nombre + " comera " + comida;
        }
    }
}
