using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebiWI.ServiceReference1;

namespace WebiWI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCiudades();
            }
        }

        protected void CargarCiudades()
        {
            Service1Client client = new Service1Client();
            var ciudades = client.GetCiudades();
            foreach (var ciudad in ciudades)
            {
                this.ciudad.Items.Add(new ListItem(ciudad, ciudad));
            }
        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            string nombre = Request.Form["nombre"];
            string apellidos = Request.Form["apellidos"];
            string correo = Request.Form["correo"];
            string genero = Request.Form["generoM"] == "on" ? "Masculino" : "Femenino";
            int ciudadId = ciudad.SelectedIndex + 1; // asumiendo que la id de la ciudad es igual a su posición en la lista + 1
            string requerimientos = Request.Form["requerimientos"];
            string direccion = Request.Form["direccion"];

            Service1Client client = new Service1Client();
            client.GuardarDatosEnArchivo(nombre, apellidos, correo, genero, ciudadId, requerimientos);

            txtResultado.TextMode = TextBoxMode.MultiLine;
            txtResultado.Rows = 10;
            txtResultado.Columns = 30;
            string mensaje = $"Nombre: {nombre}\n" +
                            $"Apellidos: {apellidos}\n" +
                            $"Correo: {correo}\n" +
                            $"Género: {genero}\n" +
                            $"Ciudad: {ciudadId}\n" +
                            $"Requerimientos: {requerimientos}\n" +
                            $"Dirección: {direccion}";

            txtResultado.Text = mensaje;
        }
    }
}
