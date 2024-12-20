using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FootballClubSystem.Models;


namespace FootballClubSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var email = txtEmail.Text;
                var password = txtPassword.Text;
                var user = authService.Login(email, password);

                // Если роль болельщика, перенаправляем в личный кабинет болельщика
                if (user.Role == "Admin")
                {
                    var MatchAdminForm = new MatchAdminForm();
                    MatchAdminForm.Show();
                    this.Hide(); // Закрыть форму входа
                }
                else
                {
                    var fanForm = new MatchForm();
                    fanForm.Show();
                    this.Hide(); // Закрыть форму входа
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
