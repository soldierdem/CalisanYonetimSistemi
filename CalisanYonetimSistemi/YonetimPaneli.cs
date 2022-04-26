using CalisanYonetimSistemi.Calisan;
using CalisanYonetimSistemi.Yonetici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalisanYonetimSistemi
{
    public partial class YonetimPaneli : Form
    {
        public YonetimPaneli()
        {
            InitializeComponent();
        }

        private void YonetimPaneli_Load(object sender, EventArgs e)
        {

            ekleCalisanbtn.Visible= false;
            guncelleCalisanbtn.Visible = false;
            silCalisanbtn.Visible = false;

            ekleYoneticibtn.Visible = false;
            guncelleYoneticibtn.Visible = false;
            silYoneticibtn.Visible=false;

        }

        private YoneticiListeForm yoneticiListeForm;
        private void button2_Click(object sender, EventArgs e)
        {
            if (ekleYoneticibtn.Visible == false)
            {
                ekleYoneticibtn.Visible = true;
                guncelleYoneticibtn.Visible = true;
                silYoneticibtn.Visible = true;
                yoneticiListeForm = new YoneticiListeForm();
                yoneticiListeForm.MdiParent = this;
                yoneticiListeForm.Show();
            }
            else
            {
                ekleYoneticibtn.Visible = false;
                guncelleYoneticibtn.Visible = false;
                silYoneticibtn.Visible = false;
                yoneticiListeForm.Close();
            }


        }
        private YoneticiEkleForm yoneticiEkleForm;
        private bool ekleYoneticiDurum = false;

        private void ekleYoneticibtn_Click(object sender, EventArgs e)
        {
            if (ekleYoneticiDurum == false)
            {
                yoneticiEkleForm = new YoneticiEkleForm();
                yoneticiEkleForm.MdiParent = this;
                yoneticiEkleForm.Show();
                ekleYoneticiDurum = true;
            }
            else
            {
                yoneticiEkleForm.Close();
                ekleYoneticiDurum = false;
            }
            
        }
        private YoneticiGuncelleForm yoneticiGuncelleForm;
        private bool guncelleYoneticiDurum = false;

        private void guncelleYoneticibtn_Click(object sender, EventArgs e)
        {
            if (guncelleYoneticiDurum == false)
            {
                yoneticiGuncelleForm = new YoneticiGuncelleForm();
                yoneticiGuncelleForm.MdiParent = this;
                yoneticiGuncelleForm.Show();
                guncelleYoneticiDurum=true;
            }
            else
            {
                yoneticiEkleForm.Close();
                guncelleYoneticiDurum = false;
            }
            
        }
        private YoneticiSilForm yoneticiSilForm;
        private bool silYoneticiDurum = false;
        private void silYoneticibtn_Click(object sender, EventArgs e)
        {
            if (silYoneticiDurum == false)
            {
                yoneticiSilForm = new YoneticiSilForm();
                yoneticiSilForm.MdiParent = this;
                yoneticiSilForm.Show();
                silYoneticiDurum = true;
            }
            else
            {
                yoneticiSilForm.Close();
                silYoneticiDurum = false;
            }
            
        }


        private CalisanListeForm calisanListeForm;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleCalisanbtn.Visible == false)
            {
                ekleCalisanbtn.Visible = true;
                guncelleCalisanbtn.Visible = true;
                silCalisanbtn.Visible = true;
                calisanListeForm = new CalisanListeForm();
                calisanListeForm.MdiParent = this;
                calisanListeForm.Show();
            }
            else
            {
                ekleCalisanbtn.Visible = false;
                guncelleCalisanbtn.Visible = false;
                silCalisanbtn.Visible = false;
                calisanListeForm.Close();
            }



        }

        private CalisanEkleForm calisanEkleForm;
        private bool ekleCalisanDurum = false;
        private void ekleCalisanbtn_Click(object sender, EventArgs e)
        {
            if (ekleCalisanDurum == false)
            {
                calisanEkleForm = new CalisanEkleForm();
                calisanEkleForm.MdiParent = this;
                calisanEkleForm.Show();
                ekleCalisanDurum = true;
            }
            else
            {
                calisanEkleForm.Close();
                ekleCalisanDurum = false;
            }


        }

        private CalisanGuncelleForm calisanGuncelleForm;
        private bool guncelleCalisanDurum = false;
        private void guncelleCalisanbtn_Click(object sender, EventArgs e)
        {
            if (guncelleCalisanDurum == false)
            {
                calisanGuncelleForm = new CalisanGuncelleForm();
                calisanGuncelleForm.MdiParent = this;
                calisanGuncelleForm.Show();
                guncelleCalisanDurum = true;
            }
            else
            {
                calisanGuncelleForm.Close();
                guncelleCalisanDurum = false;
            }

        }

        private CalisanSilForm calisanSilForm;
        private bool silCalisanDurum = false;
        private void silCalisanbtn_Click(object sender, EventArgs e)
        {
            if (silCalisanDurum == false)
            {
                calisanSilForm = new CalisanSilForm();
                calisanSilForm.MdiParent = this;
                calisanSilForm.Show();
                silCalisanDurum = true;
            }
            else
            {
                calisanSilForm.Close();
                silCalisanDurum = false;
            }


        }

        
    }
}
