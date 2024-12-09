using System.Text.RegularExpressions;

namespace ValesApp.Models
{
    public class Clients
    {

        public string phoneNumber {  get; private set; }

        public string name { get; private set; }

        public string lastName { get; private set; }

        private Regex regex = new Regex("^\\d{10}$");

        public Clients(string phoneNumber, string name, string lastName) => (this.phoneNumber, this.name, this.lastName) =
            (
                string.IsNullOrWhiteSpace(phoneNumber) || !regex.IsMatch(phoneNumber) ? throw new ArgumentException("Numero no valido"): phoneNumber,
                string.IsNullOrWhiteSpace(name.Trim())? throw new ArgumentException("No se ingreso un nombre"): name,
                string.IsNullOrWhiteSpace(lastName.Trim())? throw new ArgumentException("No se ingreso un apellido"):lastName
            );

    }
}
