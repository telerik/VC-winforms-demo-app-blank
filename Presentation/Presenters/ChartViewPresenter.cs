using Presentation.Views;

namespace Presentation.Presenters
{
    public class ChartViewPresenter : IChartViewPresenter
    {
        public ChartView GetChartView()
        {
            return new ChartView();
        }
    }
} 
