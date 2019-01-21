using System;
using System.Collections.Generic;
using System.Text;
using Examen_GCA.Models;

namespace Examen_GCA.DataSource
{
    public class Datos
    {
        public List<Persona> Poblacion = new List<Persona>()
        {
            new Persona()
            {
                PersonaId=1,
                Nombre="Luis Angel",
                Apellidos="Ayala Osorio",
                Edad = 25,
                Genero = "Masculino"
            },
            new Persona()
            {
                PersonaId=2,
                Nombre="Javier",
                Apellidos="Gil Avila",
                Edad = 35,
                Genero = "Masculino"
            },
            new Persona()
            {
                PersonaId=3,
                Nombre="Enrique",
                Apellidos="Esquivel Cortes",
                Edad = 26,
                Genero = "Masculino"
            },
            new Persona()
            {
                PersonaId=4,
                Nombre="Joshua Amauri",
                Apellidos="Rodriguez Perez",
                Edad = 24,
                Genero = "Masculino"
            },
            new Persona()
            {
                PersonaId=5,
                Nombre="Luis Enrique",
                Apellidos="Jimenez Perez",
                Edad = 22,
                Genero = "Masculino"
            },
        };
    }
}