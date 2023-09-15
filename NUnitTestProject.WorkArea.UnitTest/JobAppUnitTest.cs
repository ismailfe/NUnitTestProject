using NUnitTestProject.WorkArea.Model;

namespace NUnitTestProject.WorkArea.UnitTest
{
    public class JobAppUnitTest
    {
        #region YEAR LIMIT
        [Test]
        public void JobApp_InYearLimit_Success()
        {
            //Arrange
            JobApp jobApp = new JobApp();
            JobAppModel jobAppModel = new JobAppModel()
            {
                Year = 2010
            };

            //Action
            var result =   jobApp.ApplicationJob(jobAppModel);

            //Assert
            Assert.AreEqual(JobResult.Success, result);
        }

        [Test]
        public void JobApp_InYearLimit_Reject()
        {
            //Arrange
            JobApp jobApp = new JobApp();
            JobAppModel jobAppModel = new JobAppModel()
            {
                Year = 1980
            };

            //Action
            var result = jobApp.ApplicationJob(jobAppModel);

            //Assert
            Assert.AreEqual(JobResult.Reject, result);
        }
        #endregion


        [Test]
        public void JobApp_TagRateCheckWithoutTargetRate_Reject()
        {
            //Arrange
            JobApp jobApp = new JobApp();
            JobAppModel jobAppModel = new JobAppModel()
            {
                Year = 2021,
                Tags = new() {"A1","A2", "A3", "A4", "A5" }
            };

            //Action
            var result = jobApp.ApplicationJob(jobAppModel);

            //Assert
            Assert.AreEqual(JobResult.Reject, result);
        }





    }
}