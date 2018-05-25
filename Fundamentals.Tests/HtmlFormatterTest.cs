using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class HtmlFormatterTest
    {
        [Test]
        public void FormatAsBold_BoldTest_ReturnBold()
        {
            var txt = "HEllo";
            var htmlFormatter = new HtmlFormatter();

            var result = htmlFormatter.FormatAsBold(txt);

            Assert.That(result, Is.EqualTo($"<strong>{txt}</strong>"));
        }

    }
}
