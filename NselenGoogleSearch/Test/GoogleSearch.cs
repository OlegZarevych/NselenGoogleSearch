using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NSelene;
 
namespace NselenGoogleSearch
{
    [TestFixture]
    public class GoogleSearch : Core.TestBase
    {
        [Test]
        public void GoogleSearchText()
        {
            string url = "http://google.com";
            Selene.GoToUrl(url);
            SeleneElement searchInput = Selene.S("#lst-ib");
            searchInput.SetValue("QA");
            
        }

    }
}
