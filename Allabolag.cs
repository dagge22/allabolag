using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;

namespace HTMLAgilityPackScreenScraper
{
    public class Allabolag : Interface1
    {
        public void TestCompany()
        {
            var getHtmlWeb = new HtmlWeb();
            long orgNr = 5565995239;
            var document = getHtmlWeb.Load("http://www.allabolag.se/" + orgNr );
            var span = document.DocumentNode.SelectNodes("//span");
            //var td = document.DocumentNode.SelectNodes("//td");
            //var metaTags = document.DocumentNode.SelectNodes("//meta");
            int counter = 1;

            //if (metaTags != null)
            //{
            //    foreach (var tag in metaTags)
            //    {
            //        if (tag.Attributes["name"] != null && tag.Attributes["content"] != null)
            //        {
            //            OutputLabel.Text = tag.Attributes["name"].Value + "<br>";
            //            OutputLabel.Text = tag.Attributes["content"].Value + "<br>";

            //        }
            //    }
            //}

            if (span != null)
            {
                foreach (var spans in span.Where(tag => tag.Id == "printTitle"))
                {
                    foreach (var tag in span.Where(tag => tag.Id == "printOrgnr"))
                    {
                        OutputLabel.Text += counter + ". " + spans.InnerHtml + "\t" + "<br>";
                        counter++;
                        OutputLabel.Text += counter + ". " + tag.InnerHtml + "\t" + "<br>";
                        counter++;

                    }
                }
            }
        }
    }
}