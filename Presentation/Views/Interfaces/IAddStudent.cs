using System;

namespace Presentation.Views
{
    public interface IAddStudent
    {
        event EventHandler AddStudentLoadEventRaised;
        event EventHandler AddStudentBtnClicked;
        event EventHandler AddTeacherBtnClicked;

        string StudentName { get; }
        string StudentEmail { get; }
        string StudentSpecialty { get; }
        string StudentCourse { get; }

        string TeacherName { get; }
        string TeacherEmail { get; }
        string TeacherRank { get; }

        void AddStudent_Load(object sender, EventArgs e);
        void ShowAddStudentView();
    }
}