namespace Kye.SistemasRegistros.DTO
{
    public class UpdateMiembroDTO
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public string Fotografia { get; set; }

        public string Celular { get; set; }

        public string WhatsApp { get; set; }

        public string CorreoElectronico { get; set; }
        
        public byte[] Idhuella { get; set; }

    }
}