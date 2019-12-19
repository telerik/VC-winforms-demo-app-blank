using Presentation.Views;

namespace Presentation.Presenters
{
    public class SchedulerViewPresenter : ISchedulerViewPresenter
    {
        public SchedulerView GetSchedulerView()
        {
            return new SchedulerView();
        }
    }
}
