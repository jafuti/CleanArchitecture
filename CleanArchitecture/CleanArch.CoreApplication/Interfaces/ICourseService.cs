using CleanArch.CoreApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.CoreApplication.Interfaces
{
  public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
