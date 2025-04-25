using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;

namespace Hattmakarens_system
{
    public partial class LoggaInGr�nsnittt : Form
    {
        public LoggaInGr�nsnittt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            string username = txtEpost.Text;
            string password = txtL�senord.Text;

            lblEpostError.Visible = false;
            lblLosenordError.Visible = false;

            bool hasError = false;

            if (string.IsNullOrEmpty(username))
            {
                lblEpostError.Text = "V�nligen fyll i e-postadress.";
                lblEpostError.Visible = true;
                hasError = true;
            }
            else if (!IsValidEmail(username))
            {
                lblEpostError.Text = "V�nligen ange en giltig e-postadress.";
                lblEpostError.Visible = true;
                hasError = true;
            }

            if (string.IsNullOrEmpty(password))
            {
                lblLosenordError.Text = "V�nligen fyll i l�senord.";
                lblLosenordError.Visible = true;
                hasError = true;
            }
            else if (password.Length < 4)
            {
                lblLosenordError.Text = "L�senordet m�ste vara minst 4 tecken l�ngt.";
                lblLosenordError.Visible = true;
                hasError = true;
            }

            if (hasError)
            {
                return;
            }

            var controller = new LoggaInController(new AppDbContext());

            var loggedInUser = controller.GetUser(username, password);

            if (loggedInUser != null)
            {
                Program.aktuellAnv�ndare = loggedInUser;                  
                Program.homepage = new Homepage(Program.aktuellAnv�ndare); 
                Program.homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fel anv�ndarnamn eller l�senord.");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtAnv�ndarnamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
