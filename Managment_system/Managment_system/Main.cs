using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Managment_system
{
    public partial class Managment_System : Form
    {
        public Managment_System()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            
         
        }
     
     
  
        

        private void Form1_Load(object sender, EventArgs e)
        {
        
            
        }

    
      

        private void btn_add_Click(object sender, EventArgs e)
        {
            ListViewItem item1;
            item1 = listView1.Items.Add(tb_studentid.Text);
            item1.SubItems.Add(tb_name.Text);
            item1.SubItems.Add(tb_surname.Text);
            item1.SubItems.Add(tb_class.Text); 
            item1.SubItems.Add(tb_c.Text);
            item1.SubItems.Add(tb_java.Text);
            item1.SubItems.Add(tb_math.Text);
            item1.SubItems.Add(tb_autocad.Text);
            item1.SubItems.Add(tb_physics.Text);
            item1.SubItems.Add(tb_average.Text);

            tb_studentid.Text = "";
            tb_name.Text = "";
            tb_surname.Text = "";
            tb_class.Text = "";
            tb_c.Text = "";
            tb_java.Text = "";
            tb_math.Text = "";
            tb_autocad.Text = "";
            tb_physics.Text = "";
            tb_average.Text = "";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult answer = new DialogResult();
            answer = MessageBox.Show("Are you sure you want to delete?", "Deletion Process", MessageBoxButtons.YesNoCancel);
            if (answer == DialogResult.Yes)
            {
                listView1.SelectedItems[0].Remove();
            }
            
            

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Managment System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            float r1, r2, r3, r4, r5, avg, total;
            r1 = float.Parse(tb_c.Text);
            r2 = float.Parse(tb_java.Text);
            r3 = float.Parse(tb_math.Text);
            r4 = float.Parse(tb_autocad.Text);
            r5 = float.Parse(tb_physics.Text);
            total = r1 + r2 + r3 + r4 + r5;
            avg = total / 5;
            tb_average.Text = "" + avg;
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

