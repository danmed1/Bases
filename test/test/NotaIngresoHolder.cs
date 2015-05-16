using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class NotaIngresoHolder
    {
        private int Id_Nota_Gen;
        private String NumSeguroSocial;
        private int Id_Profesional_Salud_MT;
        private int Id_Hospital;
        private String Clave_Diagnostico;
        private int Id_Profesional_Salud_Elab;
        private int Id_Tiempo;
        private const String TIPO = "Ingreso";
        private String Motivo_NG;
        private int Id_Hospital_Origen;
        public NotaIngresoHolder() { }

        public int getId_Nota_Gen()
        {
            return Id_Nota_Gen;
        }
        public String getNumSeguroSocial()
        {
            return NumSeguroSocial;
        }
        public int getId_Profesional_Salud_MT()
        {
            return Id_Profesional_Salud_MT;
        }
        public int getId_Hospital()
        {
            return Id_Hospital;
        }
        public String getClave_Diagnostico()
        {
            return Clave_Diagnostico;
        }
        public int getId_Profesional_Salud_Elab()
        {
            return Id_Profesional_Salud_Elab;
        }
        public int getId_Tiempo()
        {
            return Id_Tiempo;
        }
        public String getTipo()
        {
            return TIPO;
        }
        public String getMotivo_NG()
        {
            return Motivo_NG;
        }
        public int getId_Hospital_Origen()
        {
            return Id_Hospital_Origen;
        }

        public void setId_Nota_Gen(int Id_Nota_Gen)
        {
            this.Id_Nota_Gen = Id_Nota_Gen;
        }
        public void setNumSeguroSocial(String NumSeguroSocial)
        {
            this.NumSeguroSocial = NumSeguroSocial;
        }
        public void setId_Profesional_Salud_MT(int Id_Profesional_Salud_MT)
        {
            this.Id_Profesional_Salud_MT = Id_Profesional_Salud_MT;

        }
        public void setId_Hospital(int Id_Hospital)
        {
            this.Id_Hospital = Id_Hospital;
        }
        public void setClave_Diagnostico(String Clave_Diagnostico)
        {
            this.Clave_Diagnostico = Clave_Diagnostico;
        }
        public void setId_Profesional_Salud_Elab(int Id_Profesional_Salud_Elab)
        {
            this.Id_Profesional_Salud_Elab = Id_Profesional_Salud_Elab;
        }
        public void setId_Tiempo(int Id_Tiempo)
        {
            this.Id_Tiempo = Id_Tiempo;
        }
        public void setMotivo_NG(String Motivo_NG)
        {
            this.Motivo_NG = Motivo_NG;
        }
        public void setId_Hospital_Origen(int Id_Hospital_Origen)
        {
            this.Id_Hospital_Origen = Id_Hospital_Origen;
        }

    }
}
