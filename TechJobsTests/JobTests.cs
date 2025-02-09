using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobID()
        {
            Job jobOne = new Job();
            Job jobTwo = new Job();

            Assert.IsTrue(jobOne.Id == jobTwo.Id - 1);
            //Assert.IsTrue(jobOne.Id == 1 && jobTwo.Id == 2);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job fullJob = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(fullJob.Name, "Product Tester");
            Assert.AreEqual(fullJob.EmployerName.Value, "ACME");
            Assert.AreEqual(fullJob.EmployerLocation.Value, "Desert");
            Assert.AreEqual(fullJob.JobType.Value, "Quality control");
            Assert.AreEqual(fullJob.JobCoreCompetency.Value, "Persistence");

            
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job firstJob = new Job("TDA", new Employer("Google"), new Location("Philly"), new PositionType("Data Analyst"), new CoreCompetency("Multi-tasking")); 
            Job secondJob = new Job("TDA", new Employer("Google"), new Location("Philly"), new PositionType("Data Analyst"), new CoreCompetency("Multi-tasking"));

            Assert.AreEqual(firstJob.Id, secondJob.Id);
        }

        [TestMethod]
        public void TestToString()
        {

            Job jobString = new Job(null, new Employer("Google"), new Location("Philly"), new PositionType(null), new CoreCompetency("Multi-tasking"));

            var test = $"\nID: {jobString.Id}\n" +
                $"Name: Data not available\n" +
                $"Employer: {jobString.EmployerName.Value}\n" +
                $"Location: {jobString.EmployerLocation.Value}\n" +
                $"Position Type: Data not available\n" +
                $"Core Competency: {jobString.JobCoreCompetency.Value}\n";

            Assert.AreEqual(jobString.ToString(), test);
            
        }

    }
}
