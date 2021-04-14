using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inlamningsuppgift1
{
    public partial class frmBlocket : Form
    {
        Advert advert;
        string thisUser=" ";


        public frmBlocket()
        {
            InitializeComponent();
            cmbCategory.Items.Add("Möbler");
            cmbCategory.Items.Add("Mobiltelefoner");
            cmbCategory.Items.Add("Cyklar");
            cmbCategory.Items.Add("Datorer");

            cmbSort.Items.Add("Senaste");
            cmbSort.Items.Add("Billigaste");

        }
        private void SearchAdverts(int sort)
        {
            lstShowAdvert.DataSource = null;

            lstShowAdvert.DisplayMember = "Title";

            advert = new Advert(txtSearch.Text, cmbCategory.SelectedItem.ToString());
            lstShowAdvert.DataSource = advert.GetAdverts(thisUser,sort);

        }
        private string getCategory(int categorynumber)
        {
            string result = "";
            if (categorynumber == 1) result = "Möbler";
            if (categorynumber == 2) result = "Mobiltelefoner";
            if (categorynumber == 3) result = "Cyklar";
            if (categorynumber == 4) result = "Datorer";

            return result;

        }

        //********************************KNAPPAR*********************
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            frmLogin fLogin = new frmLogin();
            fLogin.Show();
            this.Hide();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sort = 0;
            if (cmbSort.SelectedItem.ToString() == "Senaste")
                sort = 1;
            else if (cmbSort.SelectedItem.ToString() == "Billigaste")
                sort = 2;

            SearchAdverts(sort);
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            SearchAdverts(1);
        }

        private void lstShowAdvert_DoubleClick(object sender, EventArgs e)
        {
            advert = new Advert(lstShowAdvert.SelectedItem.ToString());
            int advertID = advert.GetSelectedAdvertID();

            string advertINFO = advert.GetSelectedAdvertAllInfo(advertID);
            string[] allinfoArray = advertINFO.Split('*');
            string category = getCategory(int.Parse(allinfoArray[4]));

            lblAllInfoAdvert.Text = "Annons: " + allinfoArray[0] + "\n\nKategori: "+category +
                "\n\nBeskrivning: " + allinfoArray[1] + "\n\nDatum: " + allinfoArray[2] +
                "\n\nPris: " + allinfoArray[3];
           
        }
    }
}
