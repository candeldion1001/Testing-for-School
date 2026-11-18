using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candel
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbFullname.Text) ||
                string.IsNullOrWhiteSpace(txtbUsername.Text) ||
                string.IsNullOrWhiteSpace(txtbEmail.Text) ||
                string.IsNullOrWhiteSpace(txtbPassword.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

               } 
        }
    }

