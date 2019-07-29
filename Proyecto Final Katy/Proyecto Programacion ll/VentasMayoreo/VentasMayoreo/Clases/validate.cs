using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VentasMayoreo
{
    class validate
    {
                  
        public static bool nameFormat(string nombre)
        {
            bool respuesta = false;
            Regex regex = new Regex("^[A-Z]{4,35}");
            if(regex.IsMatch(nombre))
            {
                respuesta = true;
            }
            return respuesta;
        }
      public static bool numberFormat(string telefono)
        {
            bool respuesta = false;
            Regex regex = new Regex("667[0-9]{7}");
            if(regex.IsMatch(telefono))
            {
                respuesta = true;
            }
            return respuesta;
        }
        public static bool curpFormat(string curp)
        {
            bool respuesta = false;
            Regex regex = new Regex("^[A-Z]{4}[0-9]{6}[A-Z]{6}[0-9]{2}$");
            if(regex.IsMatch(curp))
            {
                respuesta = true;
            }
            return respuesta;
        }
        public static bool selectedSexo(GroupBox g)
        {
            bool respuesta = false;
            foreach (Control c in g.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton r = c as RadioButton;
                    if (r.Checked)
                    {
                        respuesta = true;
                        break;
                    }
                }
            }
            return respuesta;
        }
        public static bool fechaCorrecta(DateTimePicker f)
        {
            bool respuesta = false;
            if (DateTime.Today.Year - f.Value.Year >= 18)
            {
                respuesta = true;
            }
            return respuesta;
        }
        public static bool selectedCombo(ComboBox c)
        {
            bool respuesta = false;
            if(c.SelectedIndex!=-1)
            {
                respuesta = true;
            }
            return respuesta;
        }
   
    }
}
