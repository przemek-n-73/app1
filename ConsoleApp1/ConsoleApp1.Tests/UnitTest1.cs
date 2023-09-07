namespace ConsoleApp1.Tests
{
    public class Tests
    {
        [Test]
        public void checkTheCorrectOfSummingThePointsForEmployee()
        {
            // arange
            var employee1 = new Employee("hisName", "hisSurname", 39);
            employee1.AddScore(12);
            employee1.AddScore(26);

            // act
            var result = employee1.Result;

            // assert
            Assert.AreEqual(38, result);
        }

        [Test]
        public void checkTheCorrectOfSubtractingThePointsForEmployee()
        {
            // arange 
            var employee2 = new Employee("herName", "herSurname", 35);
            employee2.AddScore(32);
            employee2.AddScore(-12); //negative points 

            // act
            var result = employee2.Result;

            // assert
            Assert.AreEqual(20, result);
        }
    }
}