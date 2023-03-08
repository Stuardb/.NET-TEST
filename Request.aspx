<%@ Page Language="C#" %>

<!DOCTYPE html>

<html>
<head>
    <title>Validación de formulario en ASP.NET</title>
</head>
<body>
    <h1>Inicio de sesión</h1>
    <form runat="server">
        <div>
            <label for="username">Usuario:</label>
            <input type="text" id="username" name="username" required />
        </div>
        <div>
            <label for="password">Contraseña:</label>
            <input type="password" id="password" name="password" required />
        </div>
        <div>
            <button type="submit" runat="server" onserverclick="ValidateForm_Click">Enviar</button>
        </div>
    </form>
</body>
</html>

<script runat="server">
    protected void ValidateForm_Click(object sender, EventArgs e)
    {
        string username = Request.Form["username"];
        string password = Request.Form["password"];

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            // Los campos de nombre de usuario y contraseña son obligatorios
            Response.Write("<p>Ingrese su nombre de usuario y contraseña.</p>");
        }
        else
        {
            // Insertar código para validar credenciales.
            Response.Write("<p>Bienvenido, " + username + ".</p>");
        }
    }
</script>