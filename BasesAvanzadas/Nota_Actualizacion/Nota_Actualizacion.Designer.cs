﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 414
namespace Nota_Actualizacion {
    
    
    /// 
    [Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(0)]
    [global::System.Security.Permissions.PermissionSetAttribute(global::System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public sealed partial class Nota_Actualizacion : Microsoft.Office.Tools.Word.DocumentBase {
        
        internal Microsoft.Office.Tools.ActionsPane ActionsPane;
        
        private Microsoft.Office.Tools.Word.RichTextContentControl lbTitle;
        
        private Microsoft.Office.Tools.Word.RichTextContentControl lbHosp;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbFecha;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbFolio;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbDatMTrat;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbDirH;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbNMT;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbEspe;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbCedMT;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbDatP;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbNomP;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbApPPac;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbApMatP;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbGenP;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbFNac;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbDomP;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbEscP;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbEtP;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbRelP;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbDEst;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbMotIn;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbObs;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbElabor;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbCedElab;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl lbNSS;
        
        internal Microsoft.Office.Tools.Word.RichTextContentControl txt_NHNA;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        private global::System.Object missing = global::System.Type.Missing;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        internal Microsoft.Office.Interop.Word.Application ThisApplication;
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Nota_Actualizacion(global::Microsoft.Office.Tools.Word.Factory factory, global::System.IServiceProvider serviceProvider) : 
                base(factory, serviceProvider, "ThisDocument", "ThisDocument") {
            Globals.Factory = factory;
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void Initialize() {
            base.Initialize();
            this.ThisApplication = this.GetHostItem<Microsoft.Office.Interop.Word.Application>(typeof(Microsoft.Office.Interop.Word.Application), "Application");
            Globals.Nota_Actualizacion = this;
            global::System.Windows.Forms.Application.EnableVisualStyles();
            this.InitializeCachedData();
            this.InitializeControls();
            this.InitializeComponents();
            this.InitializeData();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void FinishInitialization() {
            this.InternalStartup();
            this.OnStartup();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void InitializeDataBindings() {
            this.BeginInitialization();
            this.BindToData();
            this.EndInitialization();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeCachedData() {
            if ((this.DataHost == null)) {
                return;
            }
            if (this.DataHost.IsCacheInitialized) {
                this.DataHost.FillCachedData(this);
            }
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BindToData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StartCaching(string MemberName) {
            this.DataHost.StartCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StopCaching(string MemberName) {
            this.DataHost.StopCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool IsCached(string MemberName) {
            return this.DataHost.IsCached(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BeginInitialization() {
            this.BeginInit();
            this.ActionsPane.BeginInit();
            this.lbTitle.BeginInit();
            this.lbHosp.BeginInit();
            this.lbFecha.BeginInit();
            this.lbFolio.BeginInit();
            this.lbDatMTrat.BeginInit();
            this.lbDirH.BeginInit();
            this.lbNMT.BeginInit();
            this.lbEspe.BeginInit();
            this.lbCedMT.BeginInit();
            this.lbDatP.BeginInit();
            this.lbNomP.BeginInit();
            this.lbApPPac.BeginInit();
            this.lbApMatP.BeginInit();
            this.lbGenP.BeginInit();
            this.lbFNac.BeginInit();
            this.lbDomP.BeginInit();
            this.lbEscP.BeginInit();
            this.lbEtP.BeginInit();
            this.lbRelP.BeginInit();
            this.lbDEst.BeginInit();
            this.lbMotIn.BeginInit();
            this.lbObs.BeginInit();
            this.lbElabor.BeginInit();
            this.lbCedElab.BeginInit();
            this.lbNSS.BeginInit();
            this.txt_NHNA.BeginInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void EndInitialization() {
            this.txt_NHNA.EndInit();
            this.lbNSS.EndInit();
            this.lbCedElab.EndInit();
            this.lbElabor.EndInit();
            this.lbObs.EndInit();
            this.lbMotIn.EndInit();
            this.lbDEst.EndInit();
            this.lbRelP.EndInit();
            this.lbEtP.EndInit();
            this.lbEscP.EndInit();
            this.lbDomP.EndInit();
            this.lbFNac.EndInit();
            this.lbGenP.EndInit();
            this.lbApMatP.EndInit();
            this.lbApPPac.EndInit();
            this.lbNomP.EndInit();
            this.lbDatP.EndInit();
            this.lbCedMT.EndInit();
            this.lbEspe.EndInit();
            this.lbNMT.EndInit();
            this.lbDirH.EndInit();
            this.lbDatMTrat.EndInit();
            this.lbFolio.EndInit();
            this.lbFecha.EndInit();
            this.lbHosp.EndInit();
            this.lbTitle.EndInit();
            this.ActionsPane.EndInit();
            this.EndInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeControls() {
            this.ActionsPane = Globals.Factory.CreateActionsPane(null, null, "ActionsPane", "ActionsPane", this);
            this.lbTitle = Globals.Factory.CreateRichTextContentControl(null, null, "2336095911", "lbTitle", this);
            this.lbHosp = Globals.Factory.CreateRichTextContentControl(null, null, "1112870767", "lbHosp", this);
            this.lbFecha = Globals.Factory.CreateRichTextContentControl(null, null, "1007090284", "lbFecha", this);
            this.lbFolio = Globals.Factory.CreateRichTextContentControl(null, null, "1670899283", "lbFolio", this);
            this.lbDatMTrat = Globals.Factory.CreateRichTextContentControl(null, null, "3966988095", "lbDatMTrat", this);
            this.lbDirH = Globals.Factory.CreateRichTextContentControl(null, null, "1900930751", "lbDirH", this);
            this.lbNMT = Globals.Factory.CreateRichTextContentControl(null, null, "3769097416", "lbNMT", this);
            this.lbEspe = Globals.Factory.CreateRichTextContentControl(null, null, "1134914462", "lbEspe", this);
            this.lbCedMT = Globals.Factory.CreateRichTextContentControl(null, null, "2679757862", "lbCedMT", this);
            this.lbDatP = Globals.Factory.CreateRichTextContentControl(null, null, "2859147885", "lbDatP", this);
            this.lbNomP = Globals.Factory.CreateRichTextContentControl(null, null, "2587797773", "lbNomP", this);
            this.lbApPPac = Globals.Factory.CreateRichTextContentControl(null, null, "3886047910", "lbApPPac", this);
            this.lbApMatP = Globals.Factory.CreateRichTextContentControl(null, null, "4201709322", "lbApMatP", this);
            this.lbGenP = Globals.Factory.CreateRichTextContentControl(null, null, "768122029", "lbGenP", this);
            this.lbFNac = Globals.Factory.CreateRichTextContentControl(null, null, "1377426226", "lbFNac", this);
            this.lbDomP = Globals.Factory.CreateRichTextContentControl(null, null, "1915732615", "lbDomP", this);
            this.lbEscP = Globals.Factory.CreateRichTextContentControl(null, null, "2416111015", "lbEscP", this);
            this.lbEtP = Globals.Factory.CreateRichTextContentControl(null, null, "3050172707", "lbEtP", this);
            this.lbRelP = Globals.Factory.CreateRichTextContentControl(null, null, "2850130251", "lbRelP", this);
            this.lbDEst = Globals.Factory.CreateRichTextContentControl(null, null, "998078696", "lbDEst", this);
            this.lbMotIn = Globals.Factory.CreateRichTextContentControl(null, null, "2570295120", "lbMotIn", this);
            this.lbObs = Globals.Factory.CreateRichTextContentControl(null, null, "3298618429", "lbObs", this);
            this.lbElabor = Globals.Factory.CreateRichTextContentControl(null, null, "1189869004", "lbElabor", this);
            this.lbCedElab = Globals.Factory.CreateRichTextContentControl(null, null, "2977167431", "lbCedElab", this);
            this.lbNSS = Globals.Factory.CreateRichTextContentControl(null, null, "3093418573", "lbNSS", this);
            this.txt_NHNA = Globals.Factory.CreateRichTextContentControl(null, null, "3816815050", "txt_NHNA", this);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeComponents() {
            // 
            // ActionsPane
            // 
            this.ActionsPane.AutoSize = false;
            this.ActionsPane.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            // 
            // lbTitle
            // 
            this.lbTitle.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbHosp
            // 
            this.lbHosp.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbFecha
            // 
            this.lbFecha.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbFolio
            // 
            this.lbFolio.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbDatMTrat
            // 
            this.lbDatMTrat.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbDirH
            // 
            this.lbDirH.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbNMT
            // 
            this.lbNMT.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbEspe
            // 
            this.lbEspe.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbCedMT
            // 
            this.lbCedMT.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbDatP
            // 
            this.lbDatP.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbNomP
            // 
            this.lbNomP.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbApPPac
            // 
            this.lbApPPac.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbApMatP
            // 
            this.lbApMatP.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbGenP
            // 
            this.lbGenP.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbFNac
            // 
            this.lbFNac.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbDomP
            // 
            this.lbDomP.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbEscP
            // 
            this.lbEscP.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbEtP
            // 
            this.lbEtP.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbRelP
            // 
            this.lbRelP.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbDEst
            // 
            this.lbDEst.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbMotIn
            // 
            this.lbMotIn.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbObs
            // 
            this.lbObs.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbElabor
            // 
            this.lbElabor.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbCedElab
            // 
            this.lbCedElab.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // lbNSS
            // 
            this.lbNSS.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // txt_NHNA
            // 
            this.txt_NHNA.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            // 
            // Nota_Actualizacion
            // 
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool NeedsFill(string MemberName) {
            return this.DataHost.NeedsFill(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void OnShutdown() {
            this.txt_NHNA.Dispose();
            this.lbNSS.Dispose();
            this.lbCedElab.Dispose();
            this.lbElabor.Dispose();
            this.lbObs.Dispose();
            this.lbMotIn.Dispose();
            this.lbDEst.Dispose();
            this.lbRelP.Dispose();
            this.lbEtP.Dispose();
            this.lbEscP.Dispose();
            this.lbDomP.Dispose();
            this.lbFNac.Dispose();
            this.lbGenP.Dispose();
            this.lbApMatP.Dispose();
            this.lbApPPac.Dispose();
            this.lbNomP.Dispose();
            this.lbDatP.Dispose();
            this.lbCedMT.Dispose();
            this.lbEspe.Dispose();
            this.lbNMT.Dispose();
            this.lbDirH.Dispose();
            this.lbDatMTrat.Dispose();
            this.lbFolio.Dispose();
            this.lbFecha.Dispose();
            this.lbHosp.Dispose();
            this.lbTitle.Dispose();
            this.ActionsPane.Dispose();
            base.OnShutdown();
        }
    }
    
    /// 
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
    internal sealed partial class Globals {
        
        /// 
        private Globals() {
        }
        
        private static Nota_Actualizacion _Nota_Actualizacion;
        
        private static global::Microsoft.Office.Tools.Word.Factory _factory;
        
        private static ThisRibbonCollection _ThisRibbonCollection;
        
        internal static Nota_Actualizacion Nota_Actualizacion {
            get {
                return _Nota_Actualizacion;
            }
            set {
                if ((_Nota_Actualizacion == null)) {
                    _Nota_Actualizacion = value;
                }
                else {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        internal static global::Microsoft.Office.Tools.Word.Factory Factory {
            get {
                return _factory;
            }
            set {
                if ((_factory == null)) {
                    _factory = value;
                }
                else {
                    throw new System.NotSupportedException();
                }
            }
        }
        
        internal static ThisRibbonCollection Ribbons {
            get {
                if ((_ThisRibbonCollection == null)) {
                    _ThisRibbonCollection = new ThisRibbonCollection(_factory.GetRibbonFactory());
                }
                return _ThisRibbonCollection;
            }
        }
    }
    
    /// 
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "12.0.0.0")]
    internal sealed partial class ThisRibbonCollection : Microsoft.Office.Tools.Ribbon.RibbonCollectionBase {
        
        /// 
        internal ThisRibbonCollection(global::Microsoft.Office.Tools.Ribbon.RibbonFactory factory) : 
                base(factory) {
        }
    }
}
