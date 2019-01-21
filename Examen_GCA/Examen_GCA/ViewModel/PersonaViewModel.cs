using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text;
using Examen_GCA.Models;
using Examen_GCA.DataSource;
using System.Collections.ObjectModel;

namespace Examen_GCA.ViewModels
{
    public class PersonaViewModel
    {
        private ObservableCollection<Persona> Persona;

        public ObservableCollection<Persona> persona
        {
            get { return Persona; }
            set { Persona = value; }
        }
        public PersonaViewModel()
        {
            persona = new ObservableCollection<Persona>();
            Datos _context = new Datos();

            foreach (var gente in _context.Poblacion)
            {
                persona.Add(gente);
            }
        }
    }
}