using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using Hattmakarens_system.Database;
using Hattmakarens_system.Models;
using Hattmakarens_system.Presentationslager;

namespace Hattmakarens_system
{
    public partial class RegistreraKund : Form
    {
        public RegistreraKund()
        {
            InitializeComponent();
        }



        private void ClearErrorMessages()
        {
            lblFel1.Text = string.Empty;
            lblFel2.Text = string.Empty;
            lblFel3.Text = string.Empty;
            lblFel4.Text = string.Empty;
            lblFel6.Text = string.Empty;
        }

        // (Valfritt) Event-handlers om du vill lägga till något:
        private void RegistreraKund_Load(object sender, EventArgs e) { }
        private void txtForNamn_TextChanged(object sender, EventArgs e) { }
        private void txtEfterName_TextChanged(object sender, EventArgs e) { }

        private void btnRegistrera_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                string epost = txtEmail.Text.Trim();

                bool epostFinns = context.Kunder.Any(k => k.Epost == epost);
                if (epostFinns)
                {
                    lblFel4.Text = "E-postadressen är redan registrerad, ange en annan E-postadress.";
                    return; // Stoppa registreringen
                }
            }


            if (!ValidateFields())
                return;

            Kund nyKund = new Kund
            {
                ForNamn = txtForNamn.Text,
                EfterNamn = txtEfterName.Text,
                Telefon = txtTel.Text,
                Epost = txtEmail.Text,
                Adress = txtAddress.Text,
            };

            try
            {
                using (var context = new AppDbContext())
                {
                    context.Kunder.Add(nyKund);
                    context.SaveChanges();
                }

                var LaggTillHattar = new LaggTillLagerhattar();
                LaggTillHattar.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel inträffade: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            bool harFel = false;

            // Förnamn
            if (string.IsNullOrWhiteSpace(txtForNamn.Text))
            {
                lblFel1.Text = "Förnamn måste fyllas i.";
                harFel = true;
            }
            else
            {
                if (txtForNamn.Text.Length < 2)
                {
                    lblFel1.Text = "Förnamnet måste innehålla minst 2 bokstäver.";
                    harFel = true;
                }
                else if (txtForNamn.Text.Length > 50)
                {
                    lblFel1.Text = "Förnamnet får inte vara längre än 50 tecken.";
                    harFel = true;
                }
                else if (!txtForNamn.Text.All(char.IsLetter))
                {
                    lblFel1.Text = "Förnamnet får endast innehålla bokstäver.";
                    harFel = true;
                }
            }

            // Efternamn
            if (string.IsNullOrWhiteSpace(txtEfterName.Text))
            {
                lblFel2.Text = "Efternamn måste fyllas i.";
                harFel = true;
            }
            else
            {
                if (txtEfterName.Text.Length < 2)
                {
                    lblFel2.Text = "Efternamnet måste innehålla minst 2 bokstäver.";
                    harFel = true;
                }
                else if (txtEfterName.Text.Length > 50)
                {
                    lblFel2.Text = "Efternamnet får inte vara längre än 50 tecken.";
                    harFel = true;
                }
                else if (!txtEfterName.Text.All(char.IsLetter))
                {
                    lblFel2.Text = "Efternamnet får endast innehålla bokstäver.";
                    harFel = true;
                }
            }

            // Telefon
            if (string.IsNullOrWhiteSpace(txtTel.Text))
            {
                lblFel3.Text = "Telefonnummer måste fyllas i.";
                harFel = true;
            }
            else
            {
                if (txtTel.Text.Length > 50)
                {
                    lblFel3.Text = "Telefonnummer får inte vara längre än 50 tecken.";
                    harFel = true;
                }
                else if (!IsValidPhoneNumber(txtTel.Text))
                {
                    lblFel3.Text = "Telefonnumret är inte giltigt.";
                    harFel = true;
                }
            }

            // E-post
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblFel4.Text = "E-postadress måste fyllas i.";
                harFel = true;
            }
            else
            {
                if (txtEmail.Text.Length > 200)
                {
                    lblFel4.Text = "E-postadressen får inte vara längre än 200 tecken.";
                    harFel = true;
                }
                else if (!IsValidEmail(txtEmail.Text))
                {
                    lblFel4.Text = "E-postadressen är inte giltig.";
                    harFel = true;
                }
            }

            // Adress
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                lblFel6.Text = "Adress måste fyllas i.";
                harFel = true;
            }
            else
            {
                if (txtAddress.Text.Length < 10)
                {
                    lblFel6.Text = "Adressen måste innehålla minst 10 tecken.";
                    harFel = true;
                }
                else if (!txtAddress.Text.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
                {
                    lblFel6.Text = "Adressen får endast innehålla bokstäver, siffror och mellanslag.";
                    harFel = true;
                }
            }


            return !harFel;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            try
            {
                string cleaned = phoneNumber.Replace(" ", "").Replace("-", "");
                if (cleaned.StartsWith("+"))
                    cleaned = cleaned.Substring(1);

                return cleaned.All(char.IsDigit) && cleaned.Length >= 7 && cleaned.Length <= 15;
            }
            catch
            {
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

