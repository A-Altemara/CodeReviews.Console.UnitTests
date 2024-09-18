using System.Diagnostics;
using CodingTracker.A_Altemara.Menus;
using CodingTracker.A_Altemara.Models;

namespace TestProject1;

[TestClass]
public class UnitTest1
{
    private IEnumerable<IEntry> ListOfIdsToTestAgainst = ((List<CodingGoal>)
    [
        new CodingGoal { Id = 0 },
        new CodingGoal { Id = 1 },
        new CodingGoal { Id = 3 },
        new CodingGoal { Id = 4 },
        new CodingGoal { Id = 5 },
        new CodingGoal { Id = 6 },
        new CodingGoal { Id = 7 },
    ]);

    [DataTestMethod]
    [DataRow("1", true)]
    [DataRow("", false)]
    [DataRow("one", false)]
    [DataRow("-1", false)]
    [DataRow("e", true)]
    public void GetValidIdWithValidInput(string value, bool expected)
    {
        var sessionIdHash = ListOfIdsToTestAgainst.Select(h => h.Id.ToString()).ToHashSet();
        var result = Menu.IsValidId(value, sessionIdHash);
        Assert.AreEqual(expected, result);
    }

}