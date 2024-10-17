using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaxaOpg
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.VognTypeComboBox = new System.Windows.Forms.ComboBox();
            this.Antal_km = new System.Windows.Forms.Label();
            this.Pris = new System.Windows.Forms.Label();
            this.VisKort = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DagNatComboBox = new System.Windows.Forms.ComboBox();
            this.Slut_Destination = new System.Windows.Forms.TextBox();
            this.Start_Destination = new System.Windows.Forms.TextBox();
            this.Beregn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.VognTypeComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.Antal_km);
            this.splitContainer1.Panel1.Controls.Add(this.Pris);
            this.splitContainer1.Panel1.Controls.Add(this.VisKort);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.DagNatComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.Slut_Destination);
            this.splitContainer1.Panel1.Controls.Add(this.Start_Destination);
            this.splitContainer1.Panel1.Controls.Add(this.Beregn);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webView21);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 0;
            // 
            // VognTypeComboBox
            // 
            this.VognTypeComboBox.DataSource = new TaxaOpg.VehicleType[] {
        TaxaOpg.VehicleType.Unknown,
        TaxaOpg.VehicleType.Normal,
        TaxaOpg.VehicleType.Big};
            this.VognTypeComboBox.Items.AddRange(new object[] {
            TaxaOpg.VehicleType.Unknown,
            TaxaOpg.VehicleType.Normal,
            TaxaOpg.VehicleType.Big});
            this.VognTypeComboBox.Location = new System.Drawing.Point(12, 167);
            this.VognTypeComboBox.Name = "VognTypeComboBox";
            this.VognTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.VognTypeComboBox.TabIndex = 14;
            // 
            // Antal_km
            // 
            this.Antal_km.AutoSize = true;
            this.Antal_km.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antal_km.Location = new System.Drawing.Point(155, 167);
            this.Antal_km.Name = "Antal_km";
            this.Antal_km.Size = new System.Drawing.Size(21, 23);
            this.Antal_km.TabIndex = 13;
            this.Antal_km.Text = "0";
            // 
            // Pris
            // 
            this.Pris.AutoSize = true;
            this.Pris.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pris.Location = new System.Drawing.Point(155, 194);
            this.Pris.Name = "Pris";
            this.Pris.Size = new System.Drawing.Size(21, 23);
            this.Pris.TabIndex = 12;
            this.Pris.Text = "0";
            this.Pris.Click += new System.EventHandler(this.Pris_Click_1);
            // 
            // VisKort
            // 
            this.VisKort.Location = new System.Drawing.Point(275, 3);
            this.VisKort.Name = "VisKort";
            this.VisKort.Size = new System.Drawing.Size(75, 63);
            this.VisKort.TabIndex = 11;
            this.VisKort.Text = "Vis Kort";
            this.VisKort.UseVisualStyleBackColor = true;
            this.VisKort.Click += new System.EventHandler(this.VisKort_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // DagNatComboBox
            // 
            this.DagNatComboBox.DataSource = new TaxaOpg.SetTillaeg[] {
        TaxaOpg.SetTillaeg.Dag,
        TaxaOpg.SetTillaeg.Nat};
            this.DagNatComboBox.Items.AddRange(new object[] {
            TaxaOpg.SetTillaeg.Dag,
            TaxaOpg.SetTillaeg.Nat});
            this.DagNatComboBox.Location = new System.Drawing.Point(12, 194);
            this.DagNatComboBox.Name = "DagNatComboBox";
            this.DagNatComboBox.Size = new System.Drawing.Size(121, 21);
            this.DagNatComboBox.TabIndex = 9;
            // 
            // Slut_Destination
            // 
            this.Slut_Destination.Location = new System.Drawing.Point(176, 115);
            this.Slut_Destination.Name = "Slut_Destination";
            this.Slut_Destination.Size = new System.Drawing.Size(132, 20);
            this.Slut_Destination.TabIndex = 4;
            this.Slut_Destination.TextChanged += new System.EventHandler(this.Slut_Destination_TextChanged);
            // 
            // Start_Destination
            // 
            this.Start_Destination.Location = new System.Drawing.Point(12, 115);
            this.Start_Destination.Name = "Start_Destination";
            this.Start_Destination.Size = new System.Drawing.Size(132, 20);
            this.Start_Destination.TabIndex = 0;
            this.Start_Destination.TextChanged += new System.EventHandler(this.Start_Destination_TextChanged);
            // 
            // Beregn
            // 
            this.Beregn.Location = new System.Drawing.Point(12, 252);
            this.Beregn.Name = "Beregn";
            this.Beregn.Size = new System.Drawing.Size(75, 23);
            this.Beregn.TabIndex = 3;
            this.Beregn.Text = "Beregn Pris";
            this.Beregn.UseVisualStyleBackColor = true;
            this.Beregn.Click += new System.EventHandler(this.Beregn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slut Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Destination";
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(3, 3);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(437, 444);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox Slut_Destination;
        private System.Windows.Forms.TextBox Start_Destination;
        private System.Windows.Forms.Button Beregn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DagNatComboBox;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button VisKort;
        private System.Windows.Forms.Label Antal_km;
        private System.Windows.Forms.Label Pris;
        private System.Windows.Forms.ComboBox VognTypeComboBox;
    }
}

