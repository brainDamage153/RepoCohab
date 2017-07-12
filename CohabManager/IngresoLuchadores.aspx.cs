using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CohabManager
{
    public partial class IngresoLuchadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtRut.Attributes.Add("placeHolder", "Rut");
            txtNombre.Attributes.Add("placeHolder", "Nombre");
            txtApellido.Attributes.Add("placeholder","Apellido");
            txtFechaNac.Attributes.Add("placeholder", "Fecha de Nacimiento");
            txtCinturon.Attributes.Add("placeholder", "Cinturon");//cambiar por combobox

        }
    }
}