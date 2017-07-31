using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.ListViewMVVMApi.Model;

namespace Xamarin.ListViewMVVMApi.Utils
{
    public class MyHTTP
    {
        public static async Task GetAllNewsAsync(Action<IEnumerable<Carro>> action)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync("https://api.myjson.com/bins/gn719");

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var list =
                        JsonConvert.DeserializeObject<IEnumerable<Carro>>(await response.Content.ReadAsStringAsync());

                    action(list);
                }
            }
            catch (HttpRequestException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}
