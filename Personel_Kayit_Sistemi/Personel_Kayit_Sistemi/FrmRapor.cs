﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Kayit_Sistemi
{
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personel_OdeviDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personel_OdeviDataSet.Tbl_Personel);

            this.reportViewer1.RefreshReport();
        }
    }
}
