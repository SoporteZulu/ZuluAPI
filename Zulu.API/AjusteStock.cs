namespace Zulu.API
{
    public class AjusteStock
    {
        public AjusteStock()
        {
            Detalle= new List<DetailAjusteStock>();
        }

        public DateTime FechaComprobante { get; set; }
        public int idUsuario { get; set; }
        public int FN_pfac_id { get; set; }  
        public string Observaciones{ get; set; }
        public List<DetailAjusteStock> Detalle{ get; set; }
        public string Key { get; set; }
    }
}