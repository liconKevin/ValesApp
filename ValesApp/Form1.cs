
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
                Clients client = new Clients("asdasd", "Kevin", "Licon");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


    }
}
