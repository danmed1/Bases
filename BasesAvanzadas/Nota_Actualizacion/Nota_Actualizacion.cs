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

namespace Nota_Actualizacion
{
    public partial class Nota_Actualizacion
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
            this.lbCedMT.Entering += new Microsoft.Office.Tools.Word.ContentControlEnteringEventHandler(this.richTextContentControl2_Entering);
            this.Startup += new System.EventHandler(this.ThisDocument_Startup);
            this.Shutdown += new System.EventHandler(this.ThisDocument_Shutdown);

        }

        #endregion

        private void richTextContentControl2_Entering(object sender, ContentControlEnteringEventArgs e)
        {

        }
    }
}
