using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Word;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Office = Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;

namespace Nota_Ingreso
{
    public  partial class ThisDocument
    {
        private void ThisDocument_Startup(object sender, System.EventArgs e)
        {

        }

        private void ThisDocument_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Código generado por el Diseñador de VSTO

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InternalStartup()
        {
            this.fechaElabNI.Entering += new Microsoft.Office.Tools.Word.ContentControlEnteringEventHandler(this.fechaElab_Entering);
            this.txtDomPNI.Entering += new Microsoft.Office.Tools.Word.ContentControlEnteringEventHandler(this.txtDomPNI_Entering);
            this.Startup += new System.EventHandler(this.ThisDocument_Startup);
            this.Shutdown += new System.EventHandler(this.ThisDocument_Shutdown);

        }

        #endregion

        public void lbNomMT_Entering(object sender, System.EventArgs e) { }

        private void ComboBoxContentControl_Entering(object sender, ContentControlEnteringEventArgs e)
        {
            MessageBox.Show(sender.GetType().ToString());   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fechaElab_Entering(object sender, ContentControlEnteringEventArgs e)
        {

        }

        private void txtDomPNI_Entering(object sender, ContentControlEnteringEventArgs e)
        {

        }
       
    }
}
