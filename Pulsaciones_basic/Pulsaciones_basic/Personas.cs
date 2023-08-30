using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pulsaciones_basic
{
    internal class Personas
    {
        private String Identificacion;
        private String Nombre;
        private char Sexo;
        private int Edad;
        private float Pulsaciones;

        public Personas() { 
        }

        public Personas(String Identificacion, String Nombre, char Sexo, int Edad, float Pulsaciones)
        {
            this.Identificacion = Identificacion;
            this.Nombre = Nombre;
            this.Sexo = Sexo;
            this.Edad = Edad;
            this.Pulsaciones = Pulsaciones;
        }

        public String getIdentificacion() 
        {
            return Identificacion; 
        }

        public void setIdentificacion(String Identificacion)
        {
            this.Identificacion = Identificacion;
        }

        public String getNombre()
        {
            return Nombre;
        }

        public void setNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }

        public char getSexo()
        {
            return Sexo;
        }

        public void setSexo(char Sexo)
        {
            this.Sexo = Sexo;
        }

        public int getEdad()
        {
            return Edad;
        }

        public void setEdad(int Edad)
        {
            this.Edad = Edad;
        }

        public float getPulsaciones()
        {
            return Pulsaciones;
        }

        public void setPulsaciones(float Pulsaciones)
        {
            this.Pulsaciones = Pulsaciones;
        }

        public override string ToString()
        {
            return "\n"
                    + "\nIdentificacion: " + Identificacion
                    + "\nNombre:" + Nombre
                    + "\nSexo:  " + Sexo
                    + "\nEdad:  " + Edad
                    + "\nPulsaciones: " + Pulsaciones//.ToString("F2")
                    + "\n____________________________________________";

        }
        /*public override String ToString()
        {
            return $"Identificacion{Identificacion} Nombre:{Nombre} Sexo: {Sexo} Edad{Edad} Pulsacion {Pulsaciones}";
        }*/
    }
        
}
