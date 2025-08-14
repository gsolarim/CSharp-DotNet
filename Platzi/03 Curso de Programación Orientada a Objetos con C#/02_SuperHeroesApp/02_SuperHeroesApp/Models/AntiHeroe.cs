using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SuperHeroesApp.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionDeAntiHeroe(string accion)
        {
            return $"El Antiheroe {NombreEIdentidadSecreta} ha realizado: {accion}.";
        }
    }
}