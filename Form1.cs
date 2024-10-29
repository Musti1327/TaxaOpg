using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using System.Globalization;
using Newtonsoft.Json.Linq;


namespace TaxaOpg
{
    public partial class Form1 : Form
    {

        private string distances { get; set; }

        private string apiKey = "AIzaSyAbPOEz-GSgEjGhEqU4KBxvY-VgbT6WfVs";

        private SetCar setCar = new SetCar();
        private PriceDto _priceDto;


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
            if (_priceDto == null)
            {
                MessageBox.Show("Vælg venligst en vogn type og tid først.");
                return;
            }

            string start = Start_Destination.Text;
            string slut = Slut_Destination.Text;

            if (string.IsNullOrEmpty(start) || string.IsNullOrEmpty(slut))
            {
                MessageBox.Show("Indtast begge destinationer");
                return;
            }

            try
            {
                string url = $"https://maps.googleapis.com/maps/api/directions/json?origin={start}&destination={slut}&mode=driving&key={apiKey}";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    JObject json = JObject.Parse(responseBody);

                    {
                        var distance = json["routes"][0]["legs"][0]["distance"]["text"];
                        distances = distance.ToString();

                        Antal_km.Text = distances;
                        distances = distances.Replace(",", ".");
                        double distanceValue = 0;

                        if (distances.EndsWith(" km"))
                        {
                            distanceValue = double.Parse(distances.Replace(" km", ""), CultureInfo.InvariantCulture);
                        }
                        else if (distances.EndsWith(" m"))
                        {
                            distanceValue = double.Parse(distances.Replace(" m", ""), CultureInfo.InvariantCulture) / 1000;
                        }

                        // Use StartPris and PrisPrKm in calculation
                        double totalpris = _priceDto.StartPris + (distanceValue * _priceDto.PrisPrKm);
                        _priceDto.pris = totalpris;
                        Pris.Text = _priceDto.pris.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Start_Destination_TextChanged(object sender, EventArgs e)
        {


        }
        private void Slut_Destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void VisKort_Click(object sender, EventArgs e)
        {
            string url = string.Format("http://maps.google.com/maps?t={0}&q=loc:{1}", "Satellite", Start_Destination.Text);
            webView21.Source = new Uri(url);
        }

        private void PrisUpdate()
        {
            if (VognTypeComboBox.SelectedItem == null || DagNatComboBox.SelectedItem == null)
                return;

            VehicleType selectedCarType = (VehicleType)VognTypeComboBox.SelectedItem;
            SetTillaeg selectedTime = (SetTillaeg)DagNatComboBox.SelectedItem;


            if (selectedTime == SetTillaeg.Dag)
            {
                if (selectedCarType == VehicleType.Normal)
                    _priceDto = setCar.GetNormalCarPriceDay();
                else if (selectedCarType == VehicleType.Big)
                    _priceDto = setCar.GetBigCarPriceDay();
            }
            else if (selectedTime == SetTillaeg.Nat)
            {
                if (selectedCarType == VehicleType.Normal)
                    _priceDto = setCar.GetNormalCarPriceNight();
                else if (selectedCarType == VehicleType.Big)
                    _priceDto = setCar.GetBigCarPriceNight();
            }


            if (_priceDto != null)
            {
                Pris.Text = _priceDto.StartPris.ToString();

            }

        }

        private void VognTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrisUpdate();
        }

        private void DagNatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrisUpdate();
        }
    }

}





