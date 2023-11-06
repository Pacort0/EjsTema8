using Ejercicio05_Tema8.Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05_Tema8.DAL
{
    public static class clsListadoPersonasDAL
    {
        /// <summary>
        /// Función que nos devuelve un listado completo de personas
        /// </summary>
        /// <returns>Listado de personas con id, nombre y apellidos</returns>
        public static ObservableCollection<clsPersona> getListadoCompletoPersonas()
        {
            ObservableCollection<clsPersona> listadoCompletoPersonas = new ObservableCollection<clsPersona>()
            {
                new clsPersona() {Id = 1, Nombre = "Paco", Apellidos = "Rodríguez"},
                new clsPersona() {Id = 2, Nombre = "Miguel", Apellidos = "Cabezón"},
                new clsPersona() {Id = 3, Nombre = "Luisa", Apellidos = "Gameplays"},
                new clsPersona() {Id = 4, Nombre = "Francisco Javier", Apellidos = "Octogenario"},
                new clsPersona() {Id = 5, Nombre = "Isa", Apellidos = "K"},
                new clsPersona() {Id = 6, Nombre = "Juan", Apellidos = "Martínez"},
                new clsPersona() {Id = 7, Nombre = "Pepe", Apellidos = "Correa"},
                new clsPersona() {Id = 8, Nombre = "María", Apellidos = "Ronaldo"},
                new clsPersona() {Id = 9, Nombre = "Amapola", Apellidos = "Rakitic"},
                new clsPersona() {Id = 10, Nombre = "Rocío", Apellidos = "Duncal"},
                new clsPersona() {Id = 11, Nombre = "Pedro", Apellidos = "Rodríguez"},
                new clsPersona() {Id = 12, Nombre = "Javier", Apellidos = "Martínez"},
                new clsPersona() {Id = 13, Nombre = "Víctor", Apellidos = "Velázquez"},
                new clsPersona() {Id = 14, Nombre = "Ignacio", Apellidos = "Ortiz"},
                new clsPersona() {Id = 15, Nombre = "Ignacio", Apellidos = "Llorente"},
                new clsPersona() {Id = 16, Nombre = "Lucía", Apellidos = "de Castro"},
                new clsPersona() {Id = 17, Nombre = "Granada", Apellidos = "Bombita"},
                new clsPersona() {Id = 18, Nombre = "Martita", Apellidos = "Flores"}
            };

            return listadoCompletoPersonas;
        }
    }
}
