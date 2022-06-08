using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace TaekReport.Models
{
    public class OLURFORMU
    {

        public string ID { get; set; } = "";
        public string BASVURUGUID { get; set; } = "";
        public string CALISMANINADI { get; set; } = "";
        public string CALISMANINAMACI { get; set; } = "";
        public string UYGULAMA { get; set; } = "";
        public string FTAOLASILIK { get; set; } = "";
        public string ZAMAN { get; set; } 
        public int TAHMINIGONULLUSAYI { get; set; } = 0;
        public string MATERYALANALIZ { get; set; } = "";
        public string BEKLENENLER { get; set; } = "";
        public string YARARLAR { get; set; } = "";
        public string SONAERDIRMEDURUMLARI { get; set; } = "";
        public string ZARARLAR { get; set; } = "";
        public string KATILMAZISE { get; set; } = "";
        public string ALTERNATIFYONTEMLER { get; set; } = "";
        public string UCRETODENECEKMI { get; set; } = "";
        public string SORUMLUGUID { get; set; } = "";
        public string KISIUCRETODEYECEKMI { get; set; } = "";
        public string BILGILERINGIZLILIGI { get; set; } = "";


    }
}
