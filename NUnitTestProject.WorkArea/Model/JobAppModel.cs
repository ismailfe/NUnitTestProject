using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject.WorkArea.Model
{
    public class JobAppModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int ExperienceYear { get; set; }
        public DateTime ApplyDate { get; set; }
        public List<string> Tags { get; set; }
    }

    public enum JobResult
    {
        Success,
        Reject,
        Check,
        Cancel
    }
}
