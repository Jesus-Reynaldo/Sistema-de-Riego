using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EN.Reportes;

namespace BL
{
    public class CalendarioReport
    {
        public List<ReporteCalendarioEN> CalenListing { get; set; }
        // Metodos
        public void createalendarioReport(int codigo)
        {
            var _calDAL = new CalendarioDAL();
            var result = _calDAL.Mostrar_Calendario(codigo);
            CalenListing = new List<ReporteCalendarioEN>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var CalenModel = new ReporteCalendarioEN()
                {
                    NUM = Convert.ToInt32(rows[0]),
                    MES = Convert.ToString(rows[1]),
                    CULTIVO = Convert.ToString(rows[2]),
                    PERIODO = Convert.ToInt32(rows[3])
                };
                CalenListing.Add(CalenModel);
            }
        }
    }
}
