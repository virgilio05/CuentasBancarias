using System;
using System.Collections.Generic;

namespace CuentasBancarias
{
    /// <summary>
    /// Clase que registra y gestiona el historial de transacciones de una cuenta bancaria.
    /// </summary>
    internal class Historial
    {
        // Clase interna para representar una transacción
        public class Transaccion
        {
            public string TipoTransaccion { get; set; }
            public decimal Monto { get; set; }
            public DateTime Fecha { get; set; }
            public decimal SaldoAnterior { get; set; }
            public decimal SaldoPosterior { get; set; }

            public override string ToString()
            {
                return string.Format("{0,-12} | ${1,10:F2} | {2} | Saldo: ${3:F2}",
                    TipoTransaccion, Monto, Fecha.ToString("dd/MM/yyyy HH:mm:ss"), SaldoPosterior);
            }
        }

        // Atributos privados
        private List<Transaccion> transacciones;
        private string numeroCuenta;

        /// <summary>
        /// Constructor que inicializa el historial vinculado a una cuenta.
        /// </summary>
        /// <param name="numeroCuenta">Número de la cuenta asociada</param>
        public Historial(string numeroCuenta)
        {
            this.numeroCuenta = numeroCuenta;
            this.transacciones = new List<Transaccion>();
        }

        /// <summary>
        /// Registra una transacción en el historial.
        /// </summary>
        /// <param name="tipoTransaccion">Tipo de transacción (Depósito, Retiro, Transferencia)</param>
        /// <param name="monto">Monto de la transacción</param>
        /// <param name="saldoAnterior">Saldo antes de la transacción</param>
        /// <param name="saldoPosterior">Saldo después de la transacción</param>
        public void RegistrarTransaccion(string tipoTransaccion, decimal monto, decimal saldoAnterior, decimal saldoPosterior)
        {
            Transaccion transaccion = new Transaccion
            {
                TipoTransaccion = tipoTransaccion,
                Monto = monto,
                Fecha = DateTime.Now,
                SaldoAnterior = saldoAnterior,
                SaldoPosterior = saldoPosterior
            };

            transacciones.Add(transaccion);
        }

        /// <summary>
        /// Obtiene la cantidad total de transacciones registradas.
        /// </summary>
        /// <returns>Número de transacciones</returns>
        public int ObtenerCantidadTransacciones()
        {
            return transacciones.Count;
        }

        /// <summary>
        /// Muestra todas las transacciones del historial en la consola.
        /// </summary>
        public void MostrarHistorial()
        {
            Console.WriteLine("\n╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           HISTORIAL DE TRANSACCIONES - CUENTA: " + numeroCuenta.PadRight(17) + "║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════════════╣");

            if (transacciones.Count == 0)
            {
                Console.WriteLine("║ No hay transacciones registradas.                                  ║");
            }
            else
            {
                Console.WriteLine("║ Tipo         |    Monto    | Fecha                | Saldo        ║");
                Console.WriteLine("╠════════════════════════════════════════════════════════════════════╣");

                foreach (Transaccion transaccion in transacciones)
                {
                    string linea = transaccion.ToString();
                    Console.WriteLine("║ " + linea.PadRight(66) + " ║");
                }
            }

            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");
        }

        /// <summary>
        /// Obtiene el historial de transacciones como una lista.
        /// </summary>
        /// <returns>Lista de transacciones registradas</returns>
        public List<Transaccion> ObtenerTransacciones()
        {
            return new List<Transaccion>(transacciones);
        }

        /// <summary>
        /// Calcula el monto total de depósitos.
        /// </summary>
        /// <returns>Suma de todos los depósitos</returns>
        public decimal CalcularTotalDepositos()
        {
            decimal total = 0;
            foreach (Transaccion t in transacciones)
            {
                if (t.TipoTransaccion.Equals("Depósito", StringComparison.OrdinalIgnoreCase))
                {
                    total += t.Monto;
                }
            }
            return total;
        }

        /// <summary>
        /// Calcula el monto total de retiros.
        /// </summary>
        /// <returns>Suma de todos los retiros</returns>
        public decimal CalcularTotalRetiros()
        {
            decimal total = 0;
            foreach (Transaccion t in transacciones)
            {
                if (t.TipoTransaccion.Equals("Retiro", StringComparison.OrdinalIgnoreCase))
                {
                    total += t.Monto;
                }
            }
            return total;
        }

        /// <summary>
        /// Limpia el historial de transacciones.
        /// </summary>
        public void LimpiarHistorial()
        {
            transacciones.Clear();
            Console.WriteLine("✓ El historial ha sido limpiado.");
        }
    }
}
