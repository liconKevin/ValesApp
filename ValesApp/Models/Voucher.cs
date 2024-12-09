using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValesApp.Models
{
    public class Voucher
    {
        public int id_voucher {  get; private set; }
        public float amount { get; private set; }
        public float new_balance { get; private set; }
        public int id_loand { get; private set; }


        public Voucher(float amount, float new_balance, int id_loand, int id_voucher = 0) => (this.amount, this.new_balance, this.id_loand, this.id_voucher) =
            (
                !float.IsNegative(amount) ? amount : throw new ArgumentException(nameof(amount), "La cantidad no puede ser negativa"),
                !float.IsNormal(new_balance) ? new_balance : throw new ArgumentException(nameof(new_balance), "El nuevo balance no puede ser negativo"),
                !int.IsNegative(id_loand)? id_loand: throw new ArgumentException(nameof(id_loand), "Error en la carga de Id de prestamo"),
                !int.IsNegative(id_voucher)? id_voucher: throw new ArgumentException(nameof(id_voucher), "No puede existir un Id negativo")
            );


    }
}
