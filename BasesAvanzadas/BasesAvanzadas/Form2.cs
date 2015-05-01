using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace BasesAvanzadas
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void altas_Click(object sender, EventArgs e)
        {
            Word.Document doc;
            object index = 1;
            var archivoWord = new Word.Application();
            archivoWord.Documents.Add();
            archivoWord.Visible = true;
            Object xmlFormat = Word.WdSaveFormat.wdFormatXML;
            Object f = "prueba1";

            doc = archivoWord.ActiveDocument;
            
            doc.SaveAs2(f,xmlFormat);
            doc.Close();
        }

        private void guardar() { 
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
