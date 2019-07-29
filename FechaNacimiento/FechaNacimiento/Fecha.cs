using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaNacimiento
{
    class Fecha
    {
        int dia;
        int mes;
        int año;

        public Fecha(int dia, int mes, int año)
        {

            this.dia = dia;
            this.mes = mes;
            this.año = año;
        }

        public int getDia()
        {
            return dia;
        }
        public void setDia(int dia)
        {
            this.dia = dia;
        }
        public int getMes()
        {
            return mes;
        }
        public void setMes(int mes)
        {
            this.mes = mes;
        }
        public int getAño()
        {
            return año;
        }
        public void setAño(int año)
        {
            this.año = año;
        }

        public Boolean fechaCorrecta()
        {
            Boolean diaCorrecta, mesCorrecto, añoCorrecto;
            añoCorrecto = año > 0;
            mesCorrecto = mes >= 1 && mes <= 12;
            switch (mes)
            {
                case 2:
                    if (esBisiesto())
                    {
                        diaCorrecta = dia >= 1 && dia <= 29;
                    }
                    else
                    {
                        diaCorrecta = dia >= 1 && dia <= 28;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    diaCorrecta = dia >= 1 && dia <= 30;
                    break;
                default:
                    diaCorrecta = dia >= 1 && dia <= 31;
                    break;
            }
            return diaCorrecta && mesCorrecto && añoCorrecto;

        }

        private Boolean esBisiesto()
        {
            Boolean bisiesto;
            if ((año % 4 == 0) && ((año % 100 != 0) || (año % 400 == 0)))
                bisiesto = true;
            else
                bisiesto = false;

            return bisiesto;
        }
    }
}
