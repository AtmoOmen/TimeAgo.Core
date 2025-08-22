using System.Diagnostics;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TimeAgo.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var dateTimeFuncs = new Func<double, TimeSpan>[]
        {
            TimeSpan.FromSeconds,
            TimeSpan.FromMinutes,
            TimeSpan.FromHours,
            TimeSpan.FromDays,
            x => TimeSpan.FromDays(30  * x),
            x => TimeSpan.FromDays(365 * x)
        };
        
        var allCultures       = CultureInfo.GetCultures(CultureTypes.AllCultures);
        var supportedCultures = new List<CultureInfo>();
        foreach (var culture in allCultures)
        {
            try
            {
                _ = DateTimeExtensions.GetFormatString(culture);
                supportedCultures.Add(culture);
            }
            catch (NotSupportedException)
            {
                // ignored
            }
        }

        var distinctSupportedLanguageCultures = supportedCultures.GroupBy(x => x.ThreeLetterISOLanguageName).Select(x => x.First()).ToList();
        foreach (var culture in distinctSupportedLanguageCultures)
        foreach (var dateTimeFunc in dateTimeFuncs)
        {
            for (var i = 0; i != 3; i++)
            {
                var dateTime = DateTime.Now.Subtract(dateTimeFunc(i));
                var timeAgo  = dateTime.TimeAgo(culture);
                Debug.WriteLine(timeAgo);
            }
        }
    }
}
