using System.Net;
using System.IO;
using System;

namespace TinyURL
{
    public static class Extension
    {
        public static string Shrink(this string url)
        {
            string shrunk = string.Empty;
            url = "http://tinyurl.com/api-create.php?url=" + url.ToLower();

            HttpWebResponse rep = null;
            HttpWebRequest o = WebRequest.Create(url) as HttpWebRequest;
            o.Method = "GET";

            rep = o.GetResponse() as HttpWebResponse;

            using (StreamReader sr = new StreamReader(rep.GetResponseStream()))
            {
                shrunk = sr.ReadToEnd();
                rep.Close();
                o.Abort();
            }

            return shrunk;
        }

        public static string Shrink(this Uri url) => Shrink(url.OriginalString);
    }
}
