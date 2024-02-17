using RainbowSchoolLibrary;

namespace SchoolSystem
{
    [TestFixture]
    public class Tests
    {
        SchoolManagement scm;
        [SetUp]
        public void Setup()
        {
            scm = new SchoolManagement();
        }
        [Test]
        public void TeachersTest()
        {
           foreach(Teachers tec in scm.AllTeachers())
            {
                Assert.IsNotNull(tec.Id);
                Assert.IsNotNull(tec.Name);
                Assert.IsNotNull(tec.SubjectTeach);
                Assert.IsNotNull(tec.Doj);
                Assert.IsNotNull(tec.Salary);

            }
        }
        [Test]
        public void StudentTest()
        {
            foreach (Students std in scm.AllStudent())
            {
                Assert.IsNotNull (std.Id);
                Assert.IsNotNull(std.Name);
                Assert.IsNotNull(std.DOB);
            }
        }
        [Test]
        public void SubjectTest()
        {
            foreach (Subjects sub in scm.AllSubjects())
            {
                Assert.IsNotNull(sub.Id);
                Assert.IsNotNull(sub.SubjectName);
            }
        }
    }
}
