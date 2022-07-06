using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.DegerlendirmeFormu
{
    public partial class rprDegerlendirmeFormu : DevExpress.XtraReports.UI.XtraReport
    {
        public rprDegerlendirmeFormu(Degerlendirme form)
        {
            InitializeComponent();
            txtAmac.Text = form.Amac;
            txtArastirmaAdi.Text = form.ArastirmaAdi;
            txtButce.Text = form.Butce;
            txtDestekleyici.Text = form.Destekleyici;
            txtDosyaNo.Text = "Dosya No : " + form.DosyaNo;
            txtGonullu.Text = form.GonulluSayisi;
            txtNitelik.Text = form.Nitelik;
            txtSorumlu.Text = form.SorumluArastirmaci;
            txtSure.Text = form.Sure;
            txtToplantiTarihi.Text = "Toplantı Tarihi : " + form.ToplantiTarihi;
            txtYardımcı.Text = form.YardimciArastirmacilar;
        }

    }
}
