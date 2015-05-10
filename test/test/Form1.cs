using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Tools.Word;

namespace test
{
    public partial class Form1 : Form
    {
        private static Object oMissing = System.Reflection.Missing.Value;
        private static Object oTemplatePath = "E:\\Users\\Alejandro\\Documents\\Bases\\BasesAvanzadas\\Nota_Ingreso\\Nota_Ingreso.dotx";
        private const String fechaElab="1001166377"  ;
        private const String comboMtrat ="975728911" ;
        private const String comboCedula="2053575138";
        private const String txtEspe="485905416";
        private const String txtNSS="575868325";
        private const String txtApPat="3027040718";
        private const String txtApPatP="2411188545";
        private const String txtNomP="1701207138";
        private const String txtGenP="1462076139";
        private const String txtFNacP="2985573284";
        private const String txtDomP="2559662763";
        private const String txtEscP="3347958648";
        private const String txtEtnP="825245716";
        private const String txtRelP="251392476";
        private const String txtMotIngre="2318756361";
        private const String txtMedElab="1129599720";
        private const String txtCedElab="1935319829";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document wordDoc = new Microsoft.Office.Interop.Word.Document();
            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);


            foreach (Microsoft.Office.Interop.Word.ContentControl test in wordDoc.ContentControls)
            {

                switch (test.ID)
                {
                    case fechaElab:
                        test.Range.Text = DateTime.Now.ToString("M/d/yyyy");
                        ComboBoxContentControl a;
                        
                        break;
                    case comboMtrat:
                        
                        break;
                    case comboCedula:
                        break;
                    case txtEspe:
                        break;
                    case txtNSS:
                        break;
                    case txtApPat:
                        break;
                    case txtApPatP:
                        break;
                    case txtNomP:
                        break;
                    case txtGenP:
                        break;
                    case txtFNacP:
                        break;
                    case txtDomP:
                        break;
                    case txtEscP:
                        break;
                    case txtEtnP:
                        break;
                    case txtRelP:
                        break;
                    case txtMotIngre:
                        break;
                    case txtMedElab:
                        break;
                    case txtCedElab:
                        break;
                }
                

            }

  
           
            wordApp.Visible = true;
            //wordApp.Application.Quit();
            
        }
    }
}
