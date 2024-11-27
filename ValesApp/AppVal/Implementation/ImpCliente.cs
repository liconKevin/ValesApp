using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ValesApp.Domain.Entity;
using Windows.Networking;

namespace ValesApp.AppVal.Implementation
{
    public class ImpCliente: Cliente
    {
        public ImpCliente(int phoneNumber, string name, string lastName)
        {
            this.phoneNumber = phoneNumber;
            this.name = name;
            this.lastName = lastName;
        }

        public int getNumber()
        {
            return phoneNumber;
        }

        public string getName()
        {
            return name;
        }

        public string getLastName()
        {
            return lastName;
        }
    }
}
