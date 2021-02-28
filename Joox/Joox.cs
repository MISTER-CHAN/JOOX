using System;
using System.Linq;
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
                string[] lyrics = Regex.Matches(h, "<p class=\"sc-[A-Za-z]{6} [A-Za-z]{6}\">.+?</p>").Cast<Match>().Select(m => m.Value).ToArray();
                if (lyrics.Length == 0)
                {
                    return;
                }
                string l = "";
                if (lyrics.Length >= 3)
                {
                    int i;
                    string[] sixes = lyrics.Select(s => s.Substring(20, 6)).ToArray();
                    string six = sixes[0];
                    if (sixes[1] != six)
                    {
                        if (sixes[2] == sixes[1])
                        {
                            six = sixes[1];
                            i = 0;
                        }
                        else
                        {
                            i = 1;
                        }
                    }
                    else
                    {
                        for (i = 2; i < sixes.Length; i++)
                        {
                            if (sixes[i] != six)
                            {
                                break;
                            }
                        }
                    }
                    l = Regex.Match(lyrics[i], "(?<=<p class=\"sc-[A-Za-z]{6} [A-Za-z]{6}\">).+?(?=</p>)").Value;
                }
                else
                {
                    l = lyrics[0];
                }
                lyric.lblLyric.Text = l;
            }
            catch(Exception)
            {
            }
        }
    }
}
