using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Joox
{
    public partial class Joox : Form
    {
        public Lyric lyric;
        public Joox(Lyric lyric)
        {
            InitializeComponent();
            EO.WebEngine.Engine.Default.Options.AllowProprietaryMediaFormats();
            this.lyric = lyric;
        }

        private void Joox_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Joox_Load(object sender, EventArgs e)
        {
            webView.Url = "www.joox.com";
        }

        private void Joox_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                lyric.FormBorderStyle = FormBorderStyle.FixedSingle;
                lyric.WindowState = FormWindowState.Normal;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                string h = webView.EvalScript("document.documentElement.outerHTML").ToString();
                MatchCollection ms = new Regex("<p class=\"sc-[A-Za-z]{6} [A-Za-z]{6}\">.+?</p>").Matches(h);
                if (ms.Count == 0)
                {
                    return;
                }
                string l = "", first6 = ms[0].Value.Substring(20, 6), second6 = "";
                if (ms.Count >= 3)
                {
                    int i;
                    for (i = 1; i < ms.Count; i++)
                    {
                        string s6 = ms[i].Value.Substring(20, 6);
                        if (s6 == first6)
                        {
                            continue;
                        }
                        else if (i == 1)
                        {
                            second6 = s6;
                        }
                        else if (second6 == "")
                        {
                            break;
                        }
                        else if (s6 == first6)
                        {
                            i = 1;
                            break;
                        }
                        else
                        {
                            i = 0;
                            break;
                        }
                    }
                    l = new Regex("(?<=>).+?(?=<)").Match(ms[i].Value).Value;
                }
                else
                {
                    l = ms[0].Value;
                }
                lyric.lblLyric.Text = l;
            }
            catch(Exception)
            {
            }
        }
    }
}
