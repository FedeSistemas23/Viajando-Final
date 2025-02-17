using CapaDatos;
using System;
using System.IO;

namespace CapaNegocio
{
    public class CN_BackUp
    {

        CD_BackUp backup = new CD_BackUp();

        public void RealizarBackup(string rutaDestino)
        {
            if (string.IsNullOrWhiteSpace(rutaDestino))
            {
                throw new ArgumentException("La ruta de destino no puede estar vacía.");
            }

            if (!Directory.Exists(Path.GetDirectoryName(rutaDestino)))
            {
                throw new DirectoryNotFoundException("El directorio de destino no existe.");
            }
            backup.RealizarBackup(rutaDestino);
        }   
    }
}
