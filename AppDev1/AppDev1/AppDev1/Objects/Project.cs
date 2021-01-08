using System;
using System.Collections.Generic;
using System.Text;

namespace AppDev1.Objects
{
    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Days { get; set; }
        public ProjectTypes ProjectType { get; set; }

        public Project(ProjectTypes projectType, string title, string description, string days)
        {
            Title = title;
            Description = description;
            Days = days;
            ProjectType = projectType;
        }

        public enum ProjectTypes
        {
            AppDevelopment = 0,
            WebDevelopment = 1,
            NativeAppDevelopment = 2,
            HardwareDevelopment = 3
        }

    }
}
