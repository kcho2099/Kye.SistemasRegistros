namespace Kye.SistemasRegistros.DTO.Usuarios
{
    public class UsuarioDTO
    {
        public int Idusuario { get; set; }

        public string NombreUsuario { get; set; }

        public string ContraseñaHash { get; set; }

        public string Rol { get; set; }

        public bool StatusActivo { get; set; }
    }
}
