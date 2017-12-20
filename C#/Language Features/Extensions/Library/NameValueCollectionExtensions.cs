using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace Extensions.Library
{
    public static class NameValueCollectionExtensions
    {
        // Usage: var qs = collection.ToQueryString(); // returns name=bob&age=15&location=Columbus
        public static string ToQueryString(this NameValueCollection nvc)
        {
            return string.Join("&",
                nvc.AllKeys.Select(
                    key => string.Format("{0}={1}",
                        HttpUtility.UrlEncode(key),
                        HttpUtility.UrlEncode(nvc[key]))));
        }
    }
}
