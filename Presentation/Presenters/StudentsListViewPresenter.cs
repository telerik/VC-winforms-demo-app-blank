using Presentation.Views;

namespace Presentation.Presenters
{
    public class StudentsListViewPresenter : IStudentsListViewPresenter
    {
        public StudentsListView GetStudentsListView()
        {
            return new StudentsListView();
        }
    }
}
