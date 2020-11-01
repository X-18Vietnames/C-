using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.CLASS;

namespace WindowsFormsApp1.GUI
{
    public partial class admin : Form
    {
        List<FOOD> lfood = new List<FOOD>();
        FOODBUS fbus = new FOODBUS();

        List<DESK> ldesk = new List<DESK>();
        DESKBUS desbus = new DESKBUS();

        List<BILL> lbill = new List<BILL>();
        BILLBUS fbill = new BILLBUS();

        List<employer> lemployer = new List<employer>();
        EMPLOYERBUS femployer = new EMPLOYERBUS();

        List<SPECIES> lspecies = new List<SPECIES>();
        SPECIESBUS fspecies = new SPECIESBUS();


        List<DETAILBILL> ldtbill = new List<DETAILBILL>();
        DETAILBILLBUS fdtbill = new DETAILBILLBUS();




        public admin()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            dataFood.DataSource = FOODBUS.GETFOOD();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabBILL_Selected(object sender, TabControlEventArgs e)
        {
          
        }
  private void admin_Load(object sender, EventArgs e)
        {
            dataBill.DataSource = BILLBUS.GETBILL();
            dataFood.DataSource = FOODBUS.GETFOOD();
            dataDesk.DataSource = DESKBUS.GETDESK();
            dataEmployer.DataSource = EMPLOYERBUS.GETEMPLOYER();
            dataSpecies.DataSource = SPECIESBUS.GETSPECIES();

            desk_cbo.DataSource = DESKBUS.GETDESK();
            desk_cbo.ValueMember = "IDDESK";
            desk_cbo.DisplayMember = "NAMEDESK";

            speciescbo.DataSource = SPECIESBUS.GETSPECIES();
            speciescbo.ValueMember = "IDSPECIES";
            speciescbo.DisplayMember = "NAMESPECIES";
        }
      
    }
}
