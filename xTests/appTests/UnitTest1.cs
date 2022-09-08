
namespace Program.appTests;
[TestClass]
public class TestClass
{
    [TestMethod]
    public void positive_number_test()
    {
 
        Assert.AreEqual(true, Program.isLeapYear(4));
       
    }

    [TestMethod]
    public void negative_number_test()
    {
 
        Assert.AreEqual(false, Program.isLeapYear(-4));
       
    }

    [TestMethod]
    public void large_leap_test()
    {
 
        Assert.AreEqual(true, Program.isLeapYear(4444));
       
    }

    [TestMethod]
    public void large_nonleap_test()
    {
 
        Assert.AreEqual(false, Program.isLeapYear(4443));
       
    }
    
}