using Infrastructure;
using Presentation.Views;
using Service;

namespace Presentation.Presenters
{
    public class StudentsGridViewPresenter : IStudentsGridViewPresenter
    {
        public StudentsGridView GetStudentsGridView()
        {
            return new StudentsGridView();
        }
    }
}
