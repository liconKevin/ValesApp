
using ValesApp.Models;

namespace ValesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitObj();

        }

        public void InitObj()
        {

            try
            {
                Loans loan = new Loans("Prestamo Maria Guadalupe", 500, 7, "6141242112");

                Clients clients = new Clients("6141967125", "Kevin", "Licon");

                MessageBox.Show(clients.lastName);

                MessageBox.Show(loan.description);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


    }
}
