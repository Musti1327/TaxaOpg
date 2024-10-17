using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TaxaOpg
{
    public partial class Form1 : Form
    {
        private string apiKey = "AIzaSyDAo5Cokd4acdyTCMgtY1DXBUTPToyE--I";

        private SetCar setCar = new SetCar();


        public Form1()
        {
            InitializeComponent();
            InitWebView();


        }

        private async void InitWebView()
        {
            this.Controls.Add(webView21);
            await webView21.EnsureCoreWebView2Async(null);
        }


        private async void Beregn_Click(object sender, EventArgs e)
        {


        }



        private void Start_Destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void Slut_Destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {


        }

        private void VisKort_Click(object sender, EventArgs e)
        {
            
        }

        private void DagNatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pris_Click_1(sender, e);
        }

        private void VognTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pris_Click_1(sender, e);
        }


        private void Pris_Click_1(object sender, EventArgs e)
        {
            if (VognTypeComboBox.SelectedItem == null || DagNatComboBox.SelectedItem == null)
                return;

            VehicleType selectedCarType = (VehicleType)VognTypeComboBox.SelectedItem;
            SetTillaeg selectedTime = (SetTillaeg)DagNatComboBox.SelectedItem;
            PriceDto priceDto = null;

          
            if (selectedTime == SetTillaeg.Dag)
            {
                if (selectedCarType == VehicleType.Normal)
                    priceDto = setCar.GetNormalCarPriceDay();
                else if (selectedCarType == VehicleType.Big)
                    priceDto = setCar.GetBigCarPriceDay();
            }
            else if (selectedTime == SetTillaeg.Nat)
            {
                if (selectedCarType == VehicleType.Normal)
                    priceDto = setCar.GetNormalCarPriceNight();
                else if (selectedCarType == VehicleType.Big)
                    priceDto = setCar.GetBigCarPriceNight();
            }

            
            if (priceDto != null)
            {
                Pris.Text = $"Start Pris: {priceDto.StartPris}, \nPris pr km: {priceDto.PrisPrKm}";
            }
            
            
        }
    }
}



