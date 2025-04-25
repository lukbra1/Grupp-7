using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;
using Hattmakarens_system.ModelsNy;
using Microsoft.EntityFrameworkCore;

namespace Hattmakarens_system
{
    public partial class LoggaInGränsnittt : Form
    {
        AppDbContext _context;
        LoggaInController _loggaInController;

        public LoggaInGränsnittt()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _loggaInController = new LoggaInController(_context);
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            string username = txtEpost.Text;
            string password = txtLösenord.Text;

            lblEpostError.Visible = false;
            lblLosenordError.Visible = false;

            bool hasError = false;

            if (string.IsNullOrEmpty(username))
            {
                lblEpostError.Text = "Vänligen fyll i e-postadress.";
                lblEpostError.Visible = true;
                hasError = true;
            }
            else if (!IsValidEmail(username))
            {
                lblEpostError.Text = "Vänligen ange en giltig e-postadress.";
                lblEpostError.Visible = true;
                hasError = true;
            }

            if (string.IsNullOrEmpty(password))
            {
                lblLosenordError.Text = "Vänligen fyll i lösenord.";
                lblLosenordError.Visible = true;
                hasError = true;
            }
            else if (password.Length < 4)
            {
                lblLosenordError.Text = "Lösenordet måste vara minst 4 tecken långt.";
                lblLosenordError.Visible = true;
                hasError = true;
            }

            if (hasError)
            {
                return;
            }

            User loggedInUser = _loggaInController.HämtaUser(username, password);

            if (loggedInUser != null)
            {
                MessageBox.Show(username);
                Program.aktuellAnvändare = loggedInUser;
                Program.homepage = new Homepage(Program.aktuellAnvändare);
                Program.homepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord.");
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
    }
}
