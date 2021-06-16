using System.Net;
using System.IO;
using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace TinyURL
{
    public static class Extension
    {
        public static async Task<string> ShrinkAsync(this string url)
        {
            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                throw new HttpRequestException("The URL you provided is invalid, it should be formatted to be Absolute.");

            url = "http://tinyurl.com/api-create.php?url=" + url;

            return await (await ApiRequester.RequestAPIAsync(url, RequestType.Get)).Content.ReadAsStringAsync();
        }

        public static async Task<string> ShrinkAsync(this Uri url) => await ShrinkAsync(url.OriginalString);

        public static string Shrink(this string url) => ShrinkAsync(url).Result;
        public static string Shrink(this Uri url) => ShrinkAsync(url).Result;
    }

}
