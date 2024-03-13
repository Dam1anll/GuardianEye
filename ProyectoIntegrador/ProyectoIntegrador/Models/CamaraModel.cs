using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoIntegrador.Models
{
    public class CamaraModel
    {
        public string Id = string.Empty;
        public string Ubicacion { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty; 
        public string Modelo { get; set;} = string.Empty;
    }
}
