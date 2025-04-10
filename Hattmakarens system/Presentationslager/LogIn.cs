using Hattmakarens_system.Controllers;
using Hattmakarens_system.Database;

namespace Hattmakarens_system
{
    public partial class LoggaInGr�nsnittt
        : Form
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

            // Nollst�ll felmeddelanden
            lblEpostError.Visible = false;
            lblLosenordError.Visible = false;

            bool hasError = false;

            // Validering av om e-postf�ltet �r tomt eller ogiltigt
            if (string.IsNullOrEmpty(username))
            {
                lblEpostError.Text = "V�nligen fyll i e-postadress.";
                lblEpostError.Visible = true; // Visa felmeddelande f�r e-post
                hasError = true;
            }
            else if (!IsValidEmail(username))  // Kontrollera om e-posten �r giltig
            {
                lblEpostError.Text = "V�nligen ange en giltig e-postadress.";
                lblEpostError.Visible = true;
                hasError = true;
            }

            // Validering av om l�senordsf�ltet �r tomt eller f�r kort
            if (string.IsNullOrEmpty(password))
            {
                lblLosenordError.Text = "V�nligen fyll i l�senord.";
                lblLosenordError.Visible = true; // Visa felmeddelande f�r l�senord
                hasError = true;
            }
            else if (password.Length < 4) // L�senord m�ste vara minst 4 tecken l�ngt
            {
                lblLosenordError.Text = "L�senordet m�ste vara minst 4 tecken l�ngt.";
                lblLosenordError.Visible = true;
                hasError = true;
            }

            // Om det finns n�gra fel, avsluta och visa alla meddelanden
            if (hasError)
            {
                return;
            }

            // Skapa en instans av din LoginController och skicka med dbContext
            var controller = new LoggaInController(new AppDbContext());

            // Anropa login-metoden och kolla om anv�ndarnamn och l�senord matchar
            if (controller.Login(username, password))
            {
                // Om inloggningen lyckas, �ppna HomePage-formen
                Homepage homePage = new Homepage();
                homePage.Show();  // �ppna HomePage-formen

                // D�lja login-formen
                this.Hide();  // D�lja den aktuella login-formen
            }
            else
            {
                MessageBox.Show("Fel anv�ndarnamn eller l�senord.");
            }
        }

        // En hj�lpmetod f�r att validera e-postformatet
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
