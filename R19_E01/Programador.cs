using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19_E01
{
    internal class Programador
    {
        //Todas las constantes privadas ya que no se me pide que se puedan usar desde otro sitio, entonces serian publicas.
        private const string INI_CADENAS = "DESCONOCIDO";
        private const float INI_SALARIO = 1000F;

        const float SALARIO_MIN = 500F;     //No viene en el enunciado , lo establecemos nosotros como programadores
        const float SALARIO_MAX = 10000F;

        const int CADENA_MAX = 40;      //No viene en el enunciado , lo establecemos nosotros como programadores

        //Variables
        private string _nombre = "";
        private string _apellidos = "";
        private float _salario;

        #region Constructores
        public Programador()    //En el constructor por defecto , si se los valores que me dan en el enunciado y que deben de tener por defecto
                                       //Se le asigna al miembro y no a la propiedad, ya que si valida estos parametros pueden no ser validos y por
                                       //lo tanto dar error al generar el objeto
        {
            _nombre = INI_CADENAS;
            _apellidos = INI_CADENAS;
            _salario = INI_SALARIO; 
        }


        public Programador(string name, string surname) : this()        //Llamar al propio constructor de la clase -->"Programador()"
        {
            Nombre = name; 
            Apellidos = surname;
        }

        public Programador(string name, string surname, float salar) : this(name, surname)        //Inicializa , llamando al constructor correspondiente de 2 parametros
                                                                                                  //Y luego se establece el unico que queda
        {
            Salario = salar; 
        }
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return _nombre; }
            set 
            { 
                value = value.Trim().ToUpper(); //Comprobar que no tenga espacios en blancos y que se haga la transformacion a MAYUS
                ComprobarCadena(value);     //Despues se comprueban otros factores

                //Asignacion
                _nombre = value; 
            }

        }

        public string Apellidos
        {
            get { return _apellidos; }
            set
            {
                value = value.Trim().ToUpper();
                ComprobarCadena(value); 

                //Asignacion
                _apellidos = value; 
            }
        }

        public virtual float Salario
        {
            //Modificar el GET para que devuelva el salario incrementado en un 10%
                //Virtual --> Se puede sobreescribir
            get { return _salario;  }
            set 
            {
                ComprobarSalario(value); 

                //Asignacion
                _salario = value;
            }


        }


        #endregion

        #region Metodos
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <exception cref="ArgumentException">Cadena Vacia</exception>
        /// <exception cref="FormatException">Longitud de cadena incorrecta</exception>
        private void ComprobarCadena(string valor)
        {
            //1.-Cadena Vacia
            if (String.IsNullOrEmpty(valor)) 
                throw new ArgumentException("ERROR: La cadena esta vacia...");  

            //2.-Longitud de la cadena
            if (valor.Length > CADENA_MAX) 
                throw new FormatException($"ERROR: La cadena supera el limite de {CADENA_MAX} caracteres...");

            //3.-Comprobar los caracteres permitidos
            ComprobarCaracteres(valor); 
        }

        private void ComprobarCaracteres(string cadena)
        {
            const char CAR_A = 'A';
            const char CAR_Z = 'Z';
            const int ESPACIO = 32;

            int i = 0;
            bool noValido = false;  //Deteccion de caracteres no validos AVANZADO


            //MAS COMPLICADO PARA MI
            //for( i = 0 ; i < cadena.Length && !noValido; i++)
            //{
            //    noValido = !(((cadena[i] >= CAR_A) && (cadena[i] <= CAR_Z)) || (cadena[i] == ESPACIO));
            //}

            for (i = 0; i < cadena.Length && !noValido; i++)
            {
                noValido = (((cadena[i] < CAR_A) || (cadena[i] > CAR_Z)) && (cadena[i] != ESPACIO));
            }

            if (noValido) 
                throw new Exception($"ERROR: La cadena '{cadena}' contiene caracteres no validos");
        }

        private void ComprobarSalario(float paga)
        {
            if (paga < SALARIO_MIN)
                throw new Exception($"ERROR: El salario es inferior a {SALARIO_MIN}");
            if (paga > SALARIO_MAX)
                throw new Exception($"ERROR: El salario es superior a {SALARIO_MAX}");
        }

        public override string ToString()
        {

            string cadena;

            cadena = "DATOS PROGRAMADOR\n";
            cadena += $"Nombre: {Nombre}\n";
            cadena += $"Apellidos: {Apellidos}\n";
            cadena += $"Salario: {Salario}\n";

            return cadena; 
        }

        #endregion

    }
}
