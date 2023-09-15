using NUnitTestProject.WorkArea.Model;

namespace NUnitTestProject.WorkArea
{
    public class JobApp
    {
        private const int minYear = 1999;
        private const int maxYear = 2030;
        private List<string> tagList = new() { "A1", "A2", "A3", "A4", "A5" };

        public JobResult ApplicationJob(JobAppModel jobAppModel)
        {
            if(jobAppModel.Year > maxYear &&  jobAppModel.Year < minYear)
            {
                return JobResult.Reject;
            }


            var checkRate = CheckListRate(jobAppModel.Tags);

            if (checkRate < 25)
            {
                return JobResult.Reject;
            }
            else if(checkRate > 75 && jobAppModel.Year > 2020)
            {
                return JobResult.Success;
            }



            return JobResult.Check;

        }

        private int CheckListRate(List<string> list)
        {
            var getCnt = list.Where(x => x.Contains(x, StringComparison.OrdinalIgnoreCase)).Count();
            var getRate = (double)getCnt / tagList.Count() * 100;
            return (int)getCnt;
        
        }

    }
}