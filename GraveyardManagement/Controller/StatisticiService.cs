using System.Collections.Generic;
using GraveyardManagement.Model.Statistica;

namespace GraveyardManagement.Controller
{
    public class StatisticiService
    {
        private readonly StatisticaDAO _model;
        public StatisticiService()
        {
            _model = new StatisticaDAO();
        }

        public List<StatisticaDTO> SelectMorminteCareExpiraInAnulCurrent()
        {
            return _model.SelectMorminteCareExpiraInAnulCurrent();
        }

        public List<StatisticaDTO> SelectMorminteExpiratePeAni()
        {
            return _model.SelectMorminteExpiratePeAni();
        }

        public List<StatisticaDTO> SelectMormintePlatiteInAnulCurrent()
        {
            return _model.SelectMormintePlatiteInAnulCurrent();
        } 
    }
}
