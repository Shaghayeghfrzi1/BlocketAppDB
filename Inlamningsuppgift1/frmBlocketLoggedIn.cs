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
    public partial class frmBlocketLoggedIn : Form
    {
        string thisUser;
        int thisUserNumber;
        int sortType = 0;
        int idNumber;
        Advert advert;
        AdvertCRUD advertCRUD;
        public frmBlocketLoggedIn(string registerUser, int registerUserNumber)
        {
            InitializeComponent();

            thisUser = registerUser;
            thisUserNumber = registerUserNumber;
            advert = new Advert();

            cmbSort.Items.Add("Senaste");
            cmbSort.Items.Add("Billigaste");

        }

        public frmBlocketLoggedIn()
        {
            InitializeComponent();            
        }
        private void SearchAdverts(int sort)
        {
            lstShowAdvert.DataSource = null;


            lstShowAdvert.DisplayMember = "Title";
            lstShowAdvert.DataSource = advert.GetAdverts(thisUser, sortType);

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

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            frmBlocket fBloket = new frmBlocket();
            fBloket.Show();
            this.Hide();
        }

        private void lstShowAdvert_Click(object sender, EventArgs e)
        {
            cmdUpdateAdvert.Enabled = true;
            cmdDeleteAdvert.Enabled = true;
        }

        private void frmBlocketLoggedIn_Load(object sender, EventArgs e)
        {
            lstShowAdvert.DataSource = null;
            lstShowAdvert.DisplayMember = "Title";
            lstShowAdvert.DataSource = advert.GetAdverts(thisUser,sortType);
           
        }

        private void cmdCreateAdvert_Click(object sender, EventArgs e)
        {
            frmSaveAdvert fSave = new frmSaveAdvert(thisUserNumber);
            fSave.Show();
        }

        private void cmdUpdateAdvert_Click(object sender, EventArgs e)
        {
            advert = new Advert(lstShowAdvert.SelectedItem.ToString());
            int idNumberr= advert.GetSelectedAdvertID();

            frmUpdateAdvert fUpdate = new frmUpdateAdvert(idNumberr);
            fUpdate.Show();
        }

        private void cmdDeleteAdvert_Click(object sender, EventArgs e)
        {
            
            advertCRUD = new AdvertCRUD(idNumber);

            bool isdelete= advertCRUD.DeleteAdvert();
            if (isdelete)
                MessageBox.Show("Du har tagit bort din annons: " + lstShowAdvert.SelectedItem.ToString());

        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            lstShowAdvert.DataSource = null;
            lstShowAdvert.DisplayMember = "Title";
            lstShowAdvert.DataSource = advert.GetAdverts(thisUser,sortType);
            txtSelectedAdvert.Text = "";
            lblAllInfoAdvert.Text = "Annons: \n\nKategori: \n\nBeskrivning: \n\nDatum: \n\nPris: ";
        }
        
        private void lstShowAdvert_DoubleClick(object sender, EventArgs e)
        {
            advert = new Advert(lstShowAdvert.SelectedItem.ToString());
            int advertID = advert.GetSelectedAdvertID();
             idNumber = advert.GetSelectedAdvertID();

            string advertINFO = advert.GetSelectedAdvertAllInfo(advertID);
            string[] allinfoArray = advertINFO.Split('*');
            string category = getCategory(int.Parse(allinfoArray[4]));

            lblAllInfoAdvert.Text = "Annons: " + allinfoArray[0] + "\n\nKategori: " + category +
                "\n\nBeskrivning: " + allinfoArray[1] + "\n\nDatum: " + allinfoArray[2] +
                "\n\nPris: " + allinfoArray[3];


        }
      
        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.SelectedItem.ToString() == "Senaste")
                sortType = 1;
            else if (cmbSort.SelectedItem.ToString() == "Billigaste")
                sortType = 2;

            SearchAdverts(sortType);
        }
    }
}
