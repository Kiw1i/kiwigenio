<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebiWI.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
    <title>Segundo Laboratorio </title>
    <script type="text/javascript">
        function limpiar_contenido() {
            var vacio = "";
            document.getElementById("nombre").value = vacio;
            document.getElementById("apellidos").value = vacio;
            document.getElementById("generoM").checked = false;
            document.getElementById("generoF").checked = false;
            document.getElementById("correo").value = vacio;
            document.getElementById("direccion").value = vacio;
            document.getElementById("ciudad").value = 0;
            document.getElementById("requerimientos").value = vacio;
            return false;
        }
    </script>
    <script type="text/javascript">
        function enviar_contenido() {
            var vacio = "";
            var fecha = new Date();
            var validar = /^[a-zA-Z\s]+$/;
            var validarE = /^[A-Za-z0-9._%+-]+@unsa\.edu\.pe$/;
            var nombre = document.getElementById("nombre").value;
            var apellidos = document.getElementById("apellidos").value;
            var generoM = document.getElementById("generoM").checked;
            var generoF = document.getElementById("generoF").checked;
            var correo = document.getElementById("correo").value;
            var direccion = document.getElementById("direccion").value;
            var ciudad = document.getElementById("ciudad").value;
            var requerimientos = document.getElementById("requerimientos").value.trim();
            if (nombre == vacio || !validar.test(nombre)) {
                alert("ingrese el nombre por favor");
                return false;
            }
            if (apellidos == vacio || !validar.test(apellidos)) {
                alert("ingrese sus apellidos por favor ");
                return false;
            }
            if (generoM == false && generoF == false) {
                alert("ingrese su genero por favor ");
                return false;
            }
            if (correo == vacio || !validarE.test(correo)) {
                alert("ingrese su correo por favor");
                return false;
            }
            if (ciudad == vacio) {
                alert("seleccione el nombre de su ciudad de la lista ");
                return false;
            }
            alert("Registrado a las " + fecha);
        }
    </script>
    <style>
 body {
  background-image: url('imagen/michi-uwu.png');
  background-repeat: no-repeat;
  background-size: cover;
  background-position: center center;
}


        h1 {
        font-family: 'Trebuchet MS', sans-serif;
        font-size: 36px;
        color: #000000;
        position:relative;
        left:440px;
        }
        label[for="nombre"] {
            /* Estilos para el label de nombre */
        font-family: 'Trebuchet MS', sans-serif;
        font-size: 18px;
        color: #656565;
        position:absolute;
        left:450px;
        }

        label[for="apellidos"] {
            /* Estilos para el label de apellidos */
             font-family: 'Trebuchet MS', sans-serif;
        font-size: 18px;
        color: #656565;
        position:absolute;
        left:450px;
        }

        label[for="generoM"] {
            /* Estilos para el label de género masculino */
             font-family: 'Trebuchet MS', sans-serif;
        font-size: 18px;
        color: #656565;
        position:absolute;
        left:570px;
        }

        label[for="generoF"] {
            /* Estilos para el label de género femenino */
             font-family: 'Trebuchet MS', sans-serif;
        font-size: 18px;
        color: #656565;
        position:absolute;
        left:670px;
        }

        label[for="correo"] {
            /* Estilos para el label de correo */
             font-family: 'Trebuchet MS', sans-serif;
        font-size: 18px;
        color: #656565;
        position:absolute;
        left:450px;
        }

        label[for="direccion"] {
            /* Estilos para el label de dirección */
             font-family: 'Trebuchet MS', sans-serif;
        font-size: 18px;
        color: #656565;
        position:absolute;
        left:800px;
        }

        label[for="ciudad"] {
            /* Estilos para el label de ciudad */
        font-family: 'Trebuchet MS', sans-serif;
        font-size: 18px;
        color: #656565;
        height:23px;
        position:absolute;
        left:450px;
        }

        label[for="requerimientos"] {
            /* Estilos para el label de requerimientos */
        font-family: 'Trebuchet MS', sans-serif;
        font-size: 18px;
        color: #656565;
        position:absolute;
        left:450px;
        }
        .texto-genero {
        font-family: 'Trebuchet MS', sans-serif;
        font-size: 18px;
        color: #656565;
        position:absolute;
        left:450px;
        }
        .arroba{
        text-align:center;
        color: black;
        background-color: #c6c6c6;
        border:1px solid #cecece;
        border-radius:5px;
        height:25px;
        width:30px;
        position:absolute;
        left:100px;
        border-top-left-radius: 5px;
        border-bottom-left-radius: 5px;
        border-top-right-radius: 0;
        border-bottom-right-radius: 0;
        border-style: solid;
        border-width: 1px;
        }
        #nombre {
        color: black;
        background-color: white;
        border:1px solid #cecece;
        border-radius:5px;
        height:23px;
        width:300px;
        position:absolute;
        left:550px;

        }
        #apellidos {
        color: black;
        background-color: white;
        border:1px solid #cecece;
        border-radius:5px;
        height:23px;
        width:300px;
        position:absolute;
        left:550px;
        }
        #correo {
        color: black;
        background-color: white;
        border:1px solid #cecece;
        border-radius:5px;
        height:23px;
        width:300px;
        position:absolute;
        left:100px;
        padding-left:35px;
        }
        #direccion {
        color: black;
        background-color: white;
        border:1px solid #cecece;
        border-radius:5px;
        height:23px;
        width:300px;
        position:absolute;
        left:100px;
        }
        #requerimientos {
        color: black;
        background-color: white;
        border:1px solid #cecece;
        border-radius:5px;
        height:80px;
        width:800px;
        position:absolute;
        left:450px;
        font-family: 'Trebuchet MS', sans-serif;
        font-size: 18px;
        }
        #generoM {
        position:absolute;
        left:550px;
        }
        #generoF {
        position:absolute;
        left:650px;
        }
        #ciudad{
        color: black;
        text-align:center;
        background-color: white;
        border:1px solid #cecece;
        border-radius:5px;
        height:23px;
        width:150px;
        position:absolute;
        left:550px;
        }
        #enviar{
        color:black;
        position:absolute;
        top:450px;
        left:750px;
        border-radius:5px;
        border:1px solid #ffd800;
        background-color:#ffd800;
        border-top-left-radius: 5px;
        border-bottom-left-radius: 5px;
        border-top-right-radius: 0;
        border-bottom-right-radius: 0;
        border-style: solid;
        border-width: 1px;
        height:30px;
        width:70px;
        }
        #limpiar{
        color:white;
        position:absolute;
        top:450px;
        left:820px;
        border-radius:5px;
        border:1px solid #00ff21;
        background-color:#00ff21;
        border-top-left-radius: 0px;
        border-bottom-left-radius: 0px;
        border-top-right-radius: 5px;
        border-bottom-right-radius: 5px;
        border-style: solid;
        border-width: 1px;
        height:30px;
        width:70px;
        }
        .datos-recolectados {
        color: black;
        background-color: white;
        border: 1px solid #cecece;
        border-radius: 5px;
        height: 80px;
        width: 800px;
        position: absolute;
        top:500px;
        left: 450px;
        font-family: 'Trebuchet MS', sans-serif;
        font-size: 18px;
        color: #656565;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            Registro de Alumnos: 
        </h1>
        <label for="nombre" id="labelNombre">
            Nombre
        </label>
        <input type="text" id="nombre" name="nombre" /> 
        <br />
        <br />
        <label for="apellidos" id="labelApellidos">
            Apellidos
        </label>
        <input type="text" id="apellidos" name="apellidos" />
        <br />
        <br />
        <br />
        <div class="contenedor-genero">
          <span class="texto-genero">Género</span>
          <div class="botones-genero">
            <input type="radio" id="generoM" name="sexo" value="masculino"/>
            <label for="generoM"><span>Masculino</span></label>
            <input type="radio" id="generoF" name="sexo" value="femenino"/>
            <label for="generoF"><span>Femenino</span></label>
          </div>
        </div>
        <br />
        <br />
        <label for="correo" id="labelCorreo">
            Correo
                <input type="text" id="correo" name="correo" />
                <span class="arroba">@</span>
        </label>

        <br />
        <br />
        <label for="direccion" id="labelDireccion">
            Dirección
            <input type="text" id="direccion" name="direccion" />
        </label>
        <label for="ciudad" id="labelCiudad">
            Ciudad
        </label>
        <asp:DropDownList ID="ciudad" runat="server">
            <asp:ListItem Value="">Seleccione</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <label for="requerimientos" id="labelRequerimientos">
            Requerimientos:
        </label>
        <br />
        <br />
        <textarea id="requerimientos" name="requerimientos" rows="5" cols="30"></textarea>
        <br />
        <asp:Button ID="limpiar" runat="server" Text="Limpiar" OnClientClick="return limpiar_contenido();"/>
        <asp:Button ID="enviar" runat="server" Text="Enviar" OnClientClick="return enviar_contenido();" OnClick="Enviar_Click" />
        <div>
        </div>
        <asp:TextBox ID="txtResultado" runat="server" CssClass="datos-recolectados"></asp:TextBox>
    </form>
</body>
</html>