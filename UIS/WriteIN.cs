using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace UIS
{
    class WriteIN
    {
        public int delaytime = 10;
        public WriteIN()
        {

        }

        public bool inwrite = false;
        public void WriteIn(string Line, string filepath)
        {
            inwrite = true;
            if (!File.Exists(filepath))
                File.Create(filepath);
            if (File.Exists(filepath))
            {
                try
                {
                    StreamReader str = new StreamReader(filepath);
                    string previous = str.ReadToEnd();
                    str.Close();
                    string[] p = previous.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    StreamWriter stw = new StreamWriter(filepath, true);
                    try
                    {
                        TimeSpan timeses = getLastestPERSONAL(previous, Line, DateTime.Now);

                        if(timeses.Seconds> delaytime)
                        {
                            int find = p[p.Length - 1].IndexOf(']') + 1;

                            if (p[p.Length - 1].Substring(find, (p[p.Length - 1].Length - 1) - find + 1) != Line)
                            {
                                stw.WriteLine(String.Format("[{0}]{1}", DateTime.Now, Line));
                            }
                        }
                    }
                    catch
                    {
                        stw.WriteLine(String.Format("[{0}]{1}", DateTime.Now, Line));
                    }
                    stw.Close();
                }
                catch { }
            }
            inwrite = false;
        }

        public TimeSpan getLastestPERSONAL(string source,string line,DateTime now)
        {
            TimeSpan result = new TimeSpan();
            DateTime prev = new DateTime();

            string[] lines = source.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = lines.Length - 1; i >= 0; i--)
            {
                if (lines[i].IndexOf(line) != -1)
                {
                    int startindex = lines[i].IndexOf('[');
                    int endindex = lines[i].IndexOf(']');
                    string dt = lines[i].Substring(startindex + 1, endindex - startindex - 1);
                    prev = DateTime.Parse(dt);
                    break;
                }
                else if (lines[i].IndexOf("Person ALL Leave.") != -1) 
                {
                    break;
                }
            }

            if(prev != null) result = now - prev;
            return result;
        }

        public void Open()
        {
            string thisapp = Application.StartupPath;
            Process ps = new Process();
            ps.StartInfo.FileName = "explorer.exe";
            ps.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            ps.StartInfo.WorkingDirectory = thisapp;
            ps.StartInfo.CreateNoWindow = false;
            ps.StartInfo.UseShellExecute = false;
            ps.StartInfo.Arguments = thisapp;
            ps.Start();
        }

    }
}
