using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.CoreApplication.ViewModels
{
   public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
