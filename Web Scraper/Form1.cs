//private string siteUrl = "https://www.oceannetworks.ca/news/stories";
//public string[] QueryTerms { get; } = { "Ocean", "Nature", "Pollution" };

using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.Text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace Web_Scraper
{
    public partial class Form1 : Form
    {
        private string Title { get; set; }
        private string Url { get; set; }
        private string siteUrl;
        public string[] QueryTerms;
        public Form1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            siteUrl = txb_Website.Text;
            QueryTerms = txb_SearchTerms.Text.Split(',');

            ScrapeWebsite();
        }

        private void mRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        internal async void ScrapeWebsite()
        {
            FromIsEnabled(false);

            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage request = await httpClient.GetAsync(siteUrl);
            cancellationToken.Token.ThrowIfCancellationRequested();

            Stream response = await request.Content.ReadAsStreamAsync();
            cancellationToken.Token.ThrowIfCancellationRequested();

            HtmlParser parser = new HtmlParser();
            IHtmlDocument document = parser.ParseDocument(response);

            //Add connection between initial scrape, and parsing of results
            GetScrapeResults(document);

            FromIsEnabled(true);
        }

        private void FromIsEnabled(bool setting)
        {
            button1.Enabled = setting;
            txb_Website.Enabled = setting;
            txb_SearchTerms.Enabled = setting;
            rtb_debugDisplay.Enabled = setting;
        }

        private void GetScrapeResults(IHtmlDocument document)
        {
            IEnumerable<IElement> articleLink = null;

            foreach (var term in QueryTerms)
            {
                articleLink = document.All.Where(x =>
                    x.ClassName == "views-field views-field-nothing" &&
                    (x.ParentElement.InnerHtml.Contains(term) || x.ParentElement.InnerHtml.Contains(term.ToLower())));

                //Overwriting articleLink above means we have to print it's result for all QueryTerms
                //Appending to a pre-declared IEnumerable (like a List), could mean taking this out of the main loop.
                if (articleLink.Any())
                {
                    PrintResults(articleLink);
                }
            }
        }

        public void PrintResults(IEnumerable<IElement> articleLink)
        {
            rtb_debugDisplay.Clear();

            //Every element needs to be cleaned and displayed
            foreach (var element in articleLink)
            {
                CleanUpResults(element);

                rtb_debugDisplay.AppendText($"{Title} - {Url}{Environment.NewLine}");
            }
        }

        private void CleanUpResults(IElement result)
        {
            string htmlResult = result.InnerHtml.ReplaceFirst("        <span class=\"field-content\"><div><a href=\"", @"https://www.oceannetworks.ca");
            htmlResult = htmlResult.ReplaceFirst("\">", "*");
            htmlResult = htmlResult.ReplaceFirst("</a></div>\n<div class=\"article-title-top\">", "-");
            htmlResult = htmlResult.ReplaceFirst("</div>\n<hr></span>  ", "");

            //Seperate the results into our class fields for use in PrintResults()
            SplitResults(htmlResult);
        }

        private void SplitResults(string htmlResult)
        {
            string[] splitResults = htmlResult.Split('*');
            Url = splitResults[0];
            Title = splitResults[1];
        }

        private void rtb_debugDisplay_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
