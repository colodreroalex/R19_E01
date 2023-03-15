using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R19_E01
{
    internal class ProgramadorJunior : Programador  //Hereda de la clase BASE/PADRE "Programador" --> Copiar/Pegar de la clase base a la hija 
    {
        //Modificar esta clase Junior a nuestro gusto

        //CONSTANTES

        const float BONUS_MIN = 100F;
        const float BONUS_MAX = 1000f;

        //MIEMBROS 
        private float _bonus; 

        #region CONSTRUCTORES
        public ProgramadorJunior() : base()     //--> Constructor por defecto cogido de la clase BASE
        {
            _bonus = BONUS_MIN;        //--> Por defecto
        }

        //v.-1
        //public ProgramadorJunior(string nombre, string apellidos) : this()
        //{
        //    Nombre = nombre;
        //    Apellidos = apellidos;
        //}

        //v.-2
        public ProgramadorJunior(string nombre, string apellidos) : base(nombre, apellidos) 
        {
            _bonus = BONUS_MIN;
        }

        public ProgramadorJunior(string nombre, string apellidos, float paga) : base(nombre, apellidos, paga)
        {
            _bonus = BONUS_MIN;
        }

        public ProgramadorJunior(string nombre, string apellidos, float paga, float extra) : this(nombre, apellidos, paga)  //Hago ref al de arriba con 3 parametros directamente
                                                                                                                                //Para así asignarle por Propiedad el Bonus
        {
            Bonus = BONUS_MIN;
        }

        #endregion

        #region PROPIEDADES
        public float Bonus
        {
            get { return _bonus; }
            set 
            {
                ComprobarBonus(value); 
                _bonus = value; 
            }
        }

        public override float Salario
        {
            get { return SalarioModificado(base.Salario); }
            
        }

        

        #endregion

        #region METODOS
        //PRIVADOS
        private void ComprobarBonus(float valor)
        {
            if (valor < BONUS_MIN)
                throw new Exception($"ERROR: El valor es inferior al {BONUS_MIN}");
            if (valor > BONUS_MAX)
                throw new Exception($"ERROR: El valor es superior al {BONUS_MAX}"); 
        }


        private float SalarioModificado(float basee)
        {
            float salar = 0f;

            salar = basee * 0.1f;

            if (basee != 0) salar = salar + basee;

            return salar;
        }

        //PUBLICOS
        #endregion

    }
}
