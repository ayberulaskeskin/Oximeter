using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRandSpO2Reader
{
    
    public partial class Login : Form
    {

        


        public Login()
        {
            InitializeComponent();
        }
        
       

        int k = 1;
    
     

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Equals("admin") && textBox2.Text.Equals("12345678"))
            {
                MessageBox.Show("Your are success!");
               
              (this.Owner as Form1).resultToolStripMenuItem.Enabled = true;
               (this.Owner as Form1).serialPortsToolStripMenuItem.Enabled = true;
                (this.Owner as Form1).loginToolStripMenuItem.Text = "Logout";
                (this.Owner as Form1).loginToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
                this.Close();
                


               
            }
            else 
            {
                MessageBox.Show("Your pasword or name are wrong");

                k++;
                if (3 < k)
                {
                    MessageBox.Show("You have tried three times!\nYou can't access the program.");
                    Application.Exit();

                }


            }
          

        }
    }
}
