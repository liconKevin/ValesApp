using System.Text.RegularExpressions;

namespace ValesApp.Helpers
{
    public class validPhone
    {
        public string phoneNumber {  get; private set; }
        private Regex regex = new Regex("^\\d{10}$");

        public validPhone(string phoneNumber) => (this.phoneNumber) =
        (
           string.IsNullOrWhiteSpace(phoneNumber) || !regex.IsMatch(phoneNumber) ? throw new ArgumentException("Numero no valido") : this.phoneNumber = phoneNumber
        );
    }
}
