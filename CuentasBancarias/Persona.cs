using System;

namespace CuentasBancarias
{
    /// <summary>
    /// Clase que representa a una persona con información personal básica.
    /// </summary>
    internal class Persona
    {
        // Atributos privados
        private string nombre;
        private string apellido;
        private string cedula;
        private string email;

        /// <summary>
        /// Constructor que inicializa todos los atributos de la persona.
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="cedula">Número de cédula</param>
        /// <param name="email">Correo electrónico</param>
        public Persona(string nombre, string apellido, string cedula, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.email = email;
        }

        /// <summary>
        /// Obtiene el nombre completo de la persona.
        /// </summary>
        /// <returns>Nombre completo (Nombre Apellido)</returns>
        public string ObtenerNombreCompleto()
        {
            return $"{nombre} {apellido}";
        }

        /// <summary>
        /// Obtiene la cédula de la persona.
        /// </summary>
        /// <returns>Número de cédula</returns>
        public string ObtenerCedula()
        {
            return cedula;
        }

        /// <summary>
        /// Obtiene el email de la persona.
        /// </summary>
        /// <returns>Correo electrónico</returns>
        public string ObtenerEmail()
        {
            return email;
        }

        /// <summary>
        /// Actualiza el email de la persona.
        /// </summary>
        /// <param name="nuevoEmail">Nuevo correo electrónico</param>
        public void ActualizarEmail(string nuevoEmail)
        {
            if (string.IsNullOrWhiteSpace(nuevoEmail))
            {
                Console.WriteLine("Error: El email no puede estar vacío.");
                return;
            }

            email = nuevoEmail;
            Console.WriteLine($"✓ Email actualizado a: {email}");
        }

        /// <summary>
        /// Muestra la información de la persona.
        /// </summary>
        public void MostrarInformacion()
        {
            Console.WriteLine("=== Información Personal ===");
            Console.WriteLine($"Nombre: {ObtenerNombreCompleto()}");
            Console.WriteLine($"Cédula: {cedula}");
            Console.WriteLine($"Email: {email}");
        }
    }
}
