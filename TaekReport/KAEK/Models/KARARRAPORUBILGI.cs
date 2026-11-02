using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaekReport.KAEK.Models
{
    public class KARARRAPORUBILGI
    {


        public bool PLASEBOVARMI { get; set; }
        public bool PLASEBOUYGUN { get; set; }
        public bool PLASEBOUYGUNDEGIL
        {
            get
            {
                return !PLASEBOUYGUN;
            }
            set
            {
                PLASEBOUYGUN = !value;
            }
        }
        public string PLASEBOUYGUNTEXT
        {
            get
            {
                if (PLASEBOUYGUN)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                PLASEBOUYGUN = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }

        public string PLASEBOACIKLAMA { get; set; }


        public bool DNAANALIZIVARMI { get; set; }

        public string DNAANALIZIVARMITEXT
        {
            get
            {
                if (DNAANALIZIVARMI)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                DNAANALIZIVARMI = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }
        public bool ANALIZIUYGUN { get; set; }
        public bool ANALIZIUYGUNDEGIL
        {
            get
            {
                return !ANALIZIUYGUN;
            }
            set
            {
                ANALIZIUYGUN = !value;
            }
        }

        public string ANALIZIACIKLAMA { get; set; }


        public bool ARASTIRMAKISITLILARVARMI { get; set; }
        public string ARASTIRMAKISITLILARVARMITEXT
        {
            get
            {
                if (ARASTIRMAKISITLILARVARMI)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                ARASTIRMAKISITLILARVARMI = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }
        public bool KISITLILARIUYGUN { get; set; }
        public bool KISITLILARIUYGUNDEGIL
        {
            get
            {
                return !KISITLILARIUYGUN;
            }
            set
            {
                KISITLILARIUYGUN = !value;
            }
        }

        public string KISITLILARACIKLAMA { get; set; }


        public bool ARASTIRMAPEDIATRIKVARMI { get; set; }
        public string ARASTIRMAPEDIATRIKVARMITEXT
        {
            get
            {
                if (ARASTIRMAPEDIATRIKVARMI)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                ARASTIRMAPEDIATRIKVARMI = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }
        public bool PEDIATRIKCOCUK { get; set; }
        public string PEDIATRIKCOCUKTEXT
        {
            get
            {
                if (PEDIATRIKCOCUK)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                PEDIATRIKCOCUK = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }

        public string PEDIATRIKCOCUKTIPI { get; set; }

        public bool COCUKSAGLIGIETIKMI { get; set; }
        public string COCUKSAGLIGIETIKMITEXT
        {
            get
            {
                if (COCUKSAGLIGIETIKMI)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                COCUKSAGLIGIETIKMI = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }
        public string COCUKSAGLIGIETIKMIACIKLAMA { get; set; }

        public bool YENIDOGANKILINIK { get; set; }
        public string YENIDOGANKILINIKTEXT
        {
            get
            {
                if (YENIDOGANKILINIK)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                YENIDOGANKILINIK = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }

        public bool YENIDOGANUZMANGORUSU { get; set; }
        public string YENIDOGANUZMANGORUSUTEXT
        {
            get
            {
                if (YENIDOGANUZMANGORUSU)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                YENIDOGANUZMANGORUSU = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }

        public string YENIDOGANUZMANTIPI { get; set; }
        public string YENIDOGANETIKMI { get; set; }
        public string YENIDOGANETIKMIACK { get; set; }



        public bool DISHEKIMI { get; set; }
        public string DISHEKIMITEXT
        {
            get
            {
                if (DISHEKIMI)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                DISHEKIMI = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }
        public bool DISHEKIMIUZMAN { get; set; }
        public string DISHEKIMIUZMANTEXT
        {
            get
            {
                if (DISHEKIMIUZMAN)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                DISHEKIMIUZMAN = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }
        public string DISHEKIMIUZMANTIPI { get; set; }
        public bool DISHEKIMIETIK { get; set; }
        public string DISHEKIMIETIKTEXT
        {
            get
            {
                if (DISHEKIMIETIK)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                DISHEKIMIETIK = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }
        public string DISHEKIMIETIKACK { get; set; }

        ///İlk Uygunluk Başvurusu:

        public bool UYGUN { get; set; }
        public bool UYGUNDEGIL { get; set; }
        public string ILKUYGUNLUKACIKLAMA { get; set; }
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }
        public bool D { get; set; }
        public bool E { get; set; }
        public bool F { get; set; }
        public bool G { get; set; }
        public bool H { get; set; }
        public bool I { get; set; }
        public bool J { get; set; }
        public bool K { get; set; }
        public bool L { get; set; }
        public bool M { get; set; }
        public bool N { get; set; }
        public bool O { get; set; }
        public bool P { get; set; }
        public bool R { get; set; }
        public bool S { get; set; }



        public bool DANISMANVARMI { get; set; }

        public string DANISMANVARMITEXT
        {
            get
            {
                if (DANISMANVARMI)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                DANISMANVARMI = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }

        public string DANISMANUZMANLIKALANI { get; set; }
        public bool DANISMANCIKARCATISMASI { get; set; }

        public string DANISMANCIKARCATISMASITEXT
        {
            get
            {
                if (DANISMANCIKARCATISMASI)
                    return "Evet";
                else
                    return "Hayır";
            }
            set
            {
                DANISMANCIKARCATISMASI = string.Equals(value?.Trim(), "Evet", StringComparison.OrdinalIgnoreCase);
            }
        }

        public string DANISMANGORUSTIPI { get; set; }
        public string DANISMANACIKLAMASI { get; set; }







    }
}
