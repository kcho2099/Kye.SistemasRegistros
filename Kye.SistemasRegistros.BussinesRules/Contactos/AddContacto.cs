using Kye.SistemasRegistros.DTO.Contactos;
using Kye.SistemasRegistros.Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kye.SistemasRegistros.CasosUso.Contactos
{
    public class AddContacto
    {
        DBSistemasRegistrosContext _context;

        public AddContacto(DBSistemasRegistrosContext context)
        {
            _context = context;
        }

        public async Task<(string Mensaje, bool Accion)> Add(AgregarContactosDTO contacto)
        {
            try
            {
                _context.ContactosEmergencias.Add(new ContactosEmergencia
                {
                    Idmiembro = contacto.Idmiembro,
                    NombreContacto = contacto.NombreContacto,
                    Parentesco = contacto.Parentesco,
                    TelefonoContacto = contacto.TelefonoContacto,
                    StatusActivo = true,
                });
                await _context.SaveChangesAsync();
                return ("Contacto agregado", true);
            }
            catch (Exception ex)
            {
                return ($"Error al agregar el contacto : {ex.Message ?? ex.ToString()}", false);
            }
        }
    }
}
