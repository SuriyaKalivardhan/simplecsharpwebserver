using Microsoft.VisualStudio.TestTools.UnitTesting;
using simplewebserverlib;

namespace simplewebservertest;

[TestClass]
public class AddTests
{
    [TestMethod]
    public void SimpleAddTests()
    {
        var request = new AddRequest(3, 6);
        var response = RequestProcessor.Process(request);
        Assert.AreEqual(9, response.Result);
    }
}