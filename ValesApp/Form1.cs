using ValesApp.AppVal.Implementation;
using ValesApp.DB;

namespace ValesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            testData();
        }

        public void testData()
        {
            //DataAccess.InsertClient(new ImpCliente(6141968, "Kevin", "Licon"));

            List<ImpCliente> data = DataAccess.GetClients();

            List<string> dat = new List<string> { "Hell", "No"};

            var bs = new BindingSource();

            bs.DataSource = dat;

            dg_users.DataSource = bs;

            dg_users.Refresh();

        }


    }
}
