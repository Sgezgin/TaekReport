using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using TaekReport.Models;

namespace TaekReport.OnayFormuEng
{
    public partial class rprOnayFormuEng : DevExpress.XtraReports.UI.XtraReport
    {
        public rprOnayFormuEng(OnayFormuEngModel model)
        {
            InitializeComponent();

            lblustYazi.Text = model.ReviewDate + "  , Medical Research Ethics Committee, Ege University, Bornova 35100 Izmir, TURKEY reviewed the study given below:";
            lblProtocolTitle.Text = model.ProtocolTitle;
            lblProtocolType.Text = model.ProtocolType;
            lblProtocolNumber.Text = model.ProtocolNumber;
            lblInvestigator.Text = model.Investigator;
            lblInstitution.Text = model.Institution;
            lblChairman.Text = model.Chairman;
            lblChairmanTitle.Text = model.ChairmanTitle;
            lblApprovalDate.Text = model.ApprovalDate;

            lblChairmanTckn.Text = model.ChairmanTckn;

        }

    }
}
