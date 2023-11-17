using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20Dom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            // if you want to use example.html from a local folder (saved in c:\temp for example):
            this.webBrowser1.Navigate("c:\\temp\\example.html");

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");




        }
        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            HtmlElementCollection h1Elements = webBrowser.Document.GetElementsByTagName("h1");
            //change the inner text of the h1 element
            h1Elements[0].InnerText = "My UFO Page";

            HtmlElementCollection h2Elements = webBrowser.Document.GetElementsByTagName("h2");

            //change the text of the first two h2s and empty out the last one
            h2Elements[0].InnerText = "My UFO Info";
            h2Elements[1].InnerText = "My UFO Pictures";
            h2Elements[2].InnerText = string.Empty;

            HtmlElement bodyElement = webBrowser1.Document.Body;
            //change the styles of the body
            bodyElement.Style += "font-family: sans-serif;";
            bodyElement.Style += "color: darkred;";

            //change the first paragraph

            HtmlElementCollection paraElements = webBrowser.Document.GetElementsByTagName("p");
            paraElements[0].InnerHtml = "Report your UFO sightings here: <a href=\"http://www.nuforc.org\">http://www.nuforc.org</a>";
            paraElements[0].Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #a44;";

            //change the second paragraph

            paraElements[1].InnerHtml = string.Empty;

            paraElements[2].InnerHtml = "<img src=\"https://media.vanityfair.com/photos/6480b24fbafc6505d77122c4/1:1/w_1443,h_1443,c_limit/vf623-ufo.jpg\" alt=\"UFO Image\">";

            HtmlElement footerElm = webBrowser1.Document.CreateElement("footer");
            footerElm.InnerText = "© 2023 Autumn Derhammer";
            webBrowser.Document.Body.AppendChild(footerElm);










        }


    }
}
