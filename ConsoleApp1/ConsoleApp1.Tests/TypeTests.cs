namespace ConsoleApp1.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenVariablesAreStrings()
        {
            // arange
            string string1 = "test stringa";
            string string2 = "test";
            string string3 = "string";
            string string4 = string2 + " " + string3 + "a";

            // act

            // assert
            Assert.AreEqual(string1, string4);
        }


        [Test]
        public void WhenTheSameLetterButLowerAndUpperCase()
        {
            // arange
            string string1 = "Test Stringa";
            string string2 = "test stringa";

            // act

            // assert
            Assert.AreNotEqual(string1, string2);
        }


        [Test]
        public void WhenTwoIntVariables()
        {
            // arange
            var number1 = 3 * 6;
            var employee0 = new Employee("HisName", "HisSurname", 18);

            // act

            // assert
            Assert.AreEqual(number1, employee0.Age);
        }


        [Test]
        public void WhenVariablesAreFloat()
        {
            // arange
            float num1 = 12.5f;
            float num2 = 25/2f;

            // act

            // assert
            Assert.AreEqual(num1, num2);
        }

        [Test]
        public void WhenTwoVariableAreReference()
        {
            // arange
            var employee1 = GetUser("Michael");
            var employee2 = GetUser("Michael");

            // act

            // asserts
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetUser(string name)
        {
            return new Employee(name);
        }

        [Test]
        public void WhenSecondReferenceVariableEqualFirstVariable()
        {
            // arange
            Employee emp1 = new Employee("Michael");
            Employee emp2 = emp1;

            // act

            // asserts
            Assert.AreEqual(emp1, emp2);
        }
    }
}
