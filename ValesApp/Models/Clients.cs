using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValesApp.Models
{
    public class Clients
    {

        public string phoneNumber {  get; private set; }

        public string name { get; private set; }

        public string lastName { get; private set; }

        private Regex regex = new Regex("^[0-9]+$");

        public Clients(string phoneNumber, string name, string lastName) => (this.phoneNumber, this.name, this.lastName) = 
            (
                validNumber(phoneNumber)? phoneNumber: throw new ArgumentException("Se ingreso un numero invalido"),
                string.IsNullOrWhiteSpace(name.Trim())? throw new ArgumentException("No se ingreso un nombre"): name,
                string.IsNullOrWhiteSpace(lastName.Trim())? throw new ArgumentException("No se ingreso un apellido"):lastName
            );


        private bool validNumber(string number)
        {

            return string.IsNullOrWhiteSpace(number) ? throw new ArgumentException("No se ingreso un numero")
                : regex.IsMatch(number); 

        }

    }
}
