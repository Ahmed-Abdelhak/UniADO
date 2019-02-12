using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DAL;
using Project.DBL;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ddUni.DataSource = UniDal.GetAll();
            ddUni.DisplayMember = "name";
            ddUni.ValueMember = "id";

        }

        private void NewMethod(int num)
        {
            ddlFac.DataSource = FacDal.GetFacultyByUniId(num);
            ddlFac.DisplayMember = "name";
            ddlFac.ValueMember = "id";
        }

        private void ddUni_SelectedIndexChanged(object sender, EventArgs e)
        {

             NewMethod(ddUni.SelectedIndex+1);
        }
    }
}
