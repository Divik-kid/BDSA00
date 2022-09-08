
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
    
    [TestMethod]
    public void is_valid_String()
    {
        Assert.AreEqual(false, Program.isValid("kasd"));
    }

    [TestMethod]
    public void is_valid_low_number()
    {
        Assert.AreEqual(false, Program.isValid("123"));
    }

    [TestMethod]
    public void is_valid_high_Number()
    {
        Assert.AreEqual(true, Program.isValid("1231451"));
    }

    [TestMethod]
    public void is_valid_null()
    {
        Assert.AreEqual(false, Program.isValid(""));
    }
}