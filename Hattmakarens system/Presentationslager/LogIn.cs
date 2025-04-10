using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;

namespace Hattmakarens_system
{
    public partial class LoggaInGränsnittt
        : Form
    {
        public LoggaInGränsnittt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            string username = txtEpost.Text;
            string password = txtLösenord.Text;

            // Nollställ felmeddelanden
            lblEpostError.Visible = false;
            lblLosenordError.Visible = false;

            bool hasError = false;

            // Validering av om e-postfältet är tomt eller ogiltigt
            if (string.IsNullOrEmpty(username))
            {
                lblEpostError.Text = "Vänligen fyll i e-postadress.";
                lblEpostError.Visible = true; // Visa felmeddelande för e-post
                hasError = true;
            }
            else if (!IsValidEmail(username))  // Kontrollera om e-posten är giltig
            {
                lblEpostError.Text = "Vänligen ange en giltig e-postadress.";
                lblEpostError.Visible = true;
                hasError = true;
            }

            // Validering av om lösenordsfältet är tomt eller för kort
            if (string.IsNullOrEmpty(password))
            {
                lblLosenordError.Text = "Vänligen fyll i lösenord.";
                lblLosenordError.Visible = true; // Visa felmeddelande för lösenord
                hasError = true;
            }
            else if (password.Length < 4) // Lösenord måste vara minst 4 tecken långt
            {
                lblLosenordError.Text = "Lösenordet måste vara minst 4 tecken långt.";
                lblLosenordError.Visible = true;
                hasError = true;
            }

            // Om det finns några fel, avsluta och visa alla meddelanden
            if (hasError)
            {
                return;
            }

            // Skapa en instans av din LoginController och skicka med dbContext
            var controller = new LoggaInController(new AppDbContext());

            // Anropa login-metoden och kolla om användarnamn och lösenord matchar
            if (controller.Login(username, password))
            {
                // Om inloggningen lyckas, öppna HomePage-formen
                Homepage homePage = new Homepage();
                homePage.Show();  // Öppna HomePage-formen

                // Dölja login-formen
                this.Hide();  // Dölja den aktuella login-formen
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord.");
            }
        }

        // En hjälpmetod för att validera e-postformatet
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

        private void txtAnvändarnamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
