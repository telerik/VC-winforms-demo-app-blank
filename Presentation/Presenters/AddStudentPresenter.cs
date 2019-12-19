using Presentation.Views;

namespace Presentation.Presenters
{
    public class AddStudentPresenter : IAddStudentPresenter
    {
        public AddStudent GetAddStudentView()
        {
            return new AddStudent();
        }
    }
}
