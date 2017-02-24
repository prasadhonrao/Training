using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockHoldingsApp
{
    public class UserAuthenticationService
    {
        static Dictionary<string, string> users = new Dictionary<string, string>();

         static UserAuthenticationService()
        {
            users.Add("Prasad", "Prasad");
            users.Add("Admin", "Admin");
        }

        public async static Task<bool> AuthenticateAsync(string userName, string password)
        {
            await Task.Delay(5000);

            foreach (KeyValuePair<string,string> item in users)
            {
                if (item.Key.Equals(userName) && item.Value.Equals(password))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
