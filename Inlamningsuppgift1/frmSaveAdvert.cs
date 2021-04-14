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
    public partial class frmSaveAdvert : Form
    {
        int myUserNumber;
        Advert advert;
        AdvertCRUD advertCRUD;
        public frmSaveAdvert(int thisUserNumber)
        {
            myUserNumber = thisUserNumber;
            InitializeComponent();

            cmbCategory.Items.Add("Möbler");
            cmbCategory.Items.Add("Mobiltelefoner");
            cmbCategory.Items.Add("Cyklar");
            cmbCategory.Items.Add("Datorer");
        }
        public int GetCategory(string categoryName)
        {
            int categoryNumber = 0;
            if (categoryName == "Möbler") categoryNumber = 1;
            else if (categoryName == "Mobiltelefoner") categoryNumber = 2;
            else if (categoryName == "Cyklar") categoryNumber = 3;
            else if (categoryName == "Datorer") categoryNumber = 4;

            return categoryNumber;
        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            advertCRUD = new AdvertCRUD(txtTitle.Text, GetCategory(cmbCategory.SelectedItem.ToString()).ToString(), txtDescription.Text,
                                dateTimePicker.Value, int.Parse(txtPrice.Text), myUserNumber);
           
            bool isSave=advertCRUD.SaveAdvert();

            if(isSave)
            MessageBox.Show("Din annons:  "+ txtTitle.Text +"  sparades");

            
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            frmBlocketLoggedIn fStart = new frmBlocketLoggedIn();
            fStart.Show();
            this.Hide();
        }
    }
}
