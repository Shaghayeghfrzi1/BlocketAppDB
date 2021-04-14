using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlamningsuppgift1
{
    public partial class frmUpdateAdvert : Form
    {
        Advert advert;
        AdvertCRUD advertCRUD;
        int selectedAdvertID;
        public frmUpdateAdvert(int infoAdvertID)
        {
            selectedAdvertID = infoAdvertID;
            InitializeComponent();
            cmbCategory.Items.Add("Möbler");
            cmbCategory.Items.Add("Mobiltelefoner");
            cmbCategory.Items.Add("Cyklar");
            cmbCategory.Items.Add("Datorer");
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //advert = new Advert(txtTitle.Text, txtDescription.Text,dateTimePicker.Value, int.Parse(txtPrice.Text), selectedAdvertID);
            advertCRUD = new AdvertCRUD(txtTitle.Text, txtDescription.Text, dateTimePicker.Value, int.Parse(txtPrice.Text), selectedAdvertID);
            bool isUpdate = advertCRUD.UpdateAdvert();

            if (isUpdate)
                MessageBox.Show("Du har uppdaterad din annons.");
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            frmBlocketLoggedIn fStart = new frmBlocketLoggedIn();
            fStart.Show();
            this.Hide();
        }

        private void frmUpdateAdvert_Load(object sender, EventArgs e)
        {
            advert = new Advert();
            string advertValues = advert.GetSelectedAdvertAllInfo(selectedAdvertID);

            string[] advertValue = advertValues.Split('*');

            txtTitle.Text = advertValue[0];
            txtDescription.Text = advertValue[1];
            dateTimePicker.Value = DateTime.Parse(advertValue[2]);
            txtPrice.Text = advertValue[3];

            if (int.Parse(advertValue[4]) == 1)
                cmbCategory.Text = "Möbler";
            else if (int.Parse(advertValue[4]) == 2)
                cmbCategory.Text = "Mobiltelefoner";
            else if (int.Parse(advertValue[4]) == 3)
                cmbCategory.Text = "Cyklar";
            else if (int.Parse(advertValue[4]) == 4)
                cmbCategory.Text = "Datorer";

        }
    }
}
