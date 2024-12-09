using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValesApp.Models
{
    public class Loans
    {
        public int? id_loan { get; private set; }
        public string description { get; private set; }
        public float total_loan { get; private set; }
        public int total_months { get; private set; }
        public string? id_client { get; private set; }


        public Loans(string description, float total_loan, int total_months, string id_client, int id_loan = 0) => (this.description, this.total_loan, this.total_months, this.id_client, this.id_loan) =
            (
                !string.IsNullOrWhiteSpace(description)? description: throw new ArgumentNullException(nameof(description), "No se ingreso una descripcion"),
                !float.IsNegative(total_loan)? total_loan: throw new ArgumentException(nameof(total_loan),"No se puede ingresar una cantidad negativa"),
                !int.IsNegative(total_months)? total_months: throw new ArgumentException(nameof(total_months),"No se puede ingesar un mes negativo"),
                !string.IsNullOrWhiteSpace(id_client) ? id_client : throw new ArgumentNullException(nameof(id_client), "No se ingreso una descripcion"),
                !int.IsNegative(id_loan) ? id_loan : throw new ArgumentException(nameof(id_loan), "No existen ID's negativos")
            );
        

    }
}
