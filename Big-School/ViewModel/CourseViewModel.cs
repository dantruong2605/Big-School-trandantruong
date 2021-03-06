using Big_School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Big_School.ViewModel
{
    public class CourseViewModel
    {
        [Require]
        public string Place { get; set; }
        public string Date { get; set; }
        [Require]
        [ValidTime]
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}