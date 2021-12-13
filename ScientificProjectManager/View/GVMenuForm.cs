using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificProjectManager.View
{
    public partial class GVMenuForm : Form
    {
        public GVMenuForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new GVProjectForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new GVLecturerForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new GVStudentForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void GVMenuForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
