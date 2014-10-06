using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace HTMLAgilityPackScreenScraper
{
    public class Eniro : Interface1
    {
        public void TestCompany()
        {
            var getHtmlWeb = new HtmlWeb();
            long orgNr = 5565995239;
            var document = getHtmlWeb.Load("http://gulasidorna.eniro.se/hitta:" + orgNr);
            //var span = document.DocumentNode.SelectNodes("//span");
            int counter = 1;
        }
    }
}