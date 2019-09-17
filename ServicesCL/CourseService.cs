using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesCL;

namespace ServicesCL
{
    public class CourseService : ICourseService
    {
        public IList<Course> GetCourses()
        {
            return new List<Course>() {
                new Course { CourseId = 1, Description = "English", InstitutionId = 1, Title = "English" },
                new Course { CourseId = 2, Description = "Tamil", InstitutionId = 2, Title = "Tamil" },
                new Course { CourseId = 3, Description = "Maths", InstitutionId = 1, Title = "Maths" },
                new Course { CourseId = 4, Description = "Science", InstitutionId = 3, Title = "Science" }
            };
        }
    }
}
