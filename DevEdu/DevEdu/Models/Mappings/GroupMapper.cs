using DevEdu.Data.Models;
using DevEdu.Models.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEdu.Models.Mappings
{
	public class GroupMapper
	{
		public static IEnumerable<GroupOutputModel> ToOutputModels(IEnumerable<Group> groups)
		{
			List<GroupOutputModel> result = new List<GroupOutputModel>();
			foreach (var group in groups)
			{
				result.Add(ToOutputModel(group));
			}
			return result;
		}


		public static GroupOutputModel ToOutputModel(Group group)
		{
			return new GroupOutputModel
			{
				GroupId = (int)group.Id,
				StartDate = group.StartDate,
				EndDate = group.EndDate,
				TimeStartString = group.TimeStart.ToString(@"hh\:mm")
			};
		}

        public static IEnumerable<GroupWithCourseProgramOutputModel> ToGroupsWithCourseProgram(IEnumerable<GroupWithCourseProgram> groups)
        {
            List<GroupWithCourseProgramOutputModel> result = new List<GroupWithCourseProgramOutputModel>();
            foreach (var group in groups)
            {
                result.Add(ToGroupWithCourseProgram(group));
            }
            return result;
		}

        public static GroupWithCourseProgramOutputModel ToGroupWithCourseProgram(GroupWithCourseProgram group)
        {
			return new GroupWithCourseProgramOutputModel()
            {
                GroupId = (int)group.Id,
                StartDate = group.StartDate,
                EndDate = group.EndDate,
                TimeStartString = group.TimeStart.ToString(@"hh\:mm"),
				Title = group.Title
			};
        }
	}
}