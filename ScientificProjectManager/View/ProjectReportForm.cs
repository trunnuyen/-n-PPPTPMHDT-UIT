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
    public partial class ProjectReportForm : Form
    {

        public ProjectReportForm()
        {
            InitializeComponent();
            
            
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
            int Value = Convert.ToInt32(numericUpDown1.Value);
            for (int i = 0; i <= Value-(10 + i); i+=50)
            {

                progressHT.PerformStep();


            }
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {
            Refresh();
            
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
    }
}
