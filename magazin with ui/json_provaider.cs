using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;
using System.Net;



namespace magazin_with_ui
{
    public class json_provaider
    {

        
        public int  provide()
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://raw.githubusercontent.com/kiriotis/magazin-with-ui/master/magazin%20with%20ui/Resources/products.json");
            StreamReader reader = new StreamReader(stream);
            var jsonFile = reader.ReadToEnd();
            items count_items = new items();            
            int x=0;
            int y = 1;

           
            var res = JsonConvert.DeserializeObject<Dictionary<int,Json_items>>(jsonFile);

            foreach (var person in res)
            { 
               x = person.Key;
              
                
            }
            foreach (var person1 in res)
            {
               
                count_items.item_all(y, person1.Value.name, person1.Value.price, person1.Value.img);
                y++;
            }

            return x;





        }
    }
        
}
