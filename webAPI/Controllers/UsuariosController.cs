namespace webAPI.Controllers;
using Models;

public class UsuariosController
    {
    Models.Model_Usuarios usuario;
        public UsuariosController()
        {
            usuario = new Model_Usuarios();
        }

    public async Task  Carga(int idusuario, string nombre, int estado, int idperfil)
    {
        List<usuario> _usuarios = new List<usuario>();
        _usuario.idusuario = idusuario;
        _usuario.nombre = nombre;
        _usuario.estado = estado;
        _usuario.idperfil = idperfil;
        await "";
    }

    public async Task IniciaSesion(string nombreUsuario, string password)
    {
        await "";
    }

    public async Task VerificaPerfil(string nombreUsuario)
    {
          await "";
    }


}
