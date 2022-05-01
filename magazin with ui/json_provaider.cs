using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;


namespace magazin_with_ui
{
    public class json_provaider
    {

        
        public void provide()
        {
            
            items count_items = new items();
            var path = "products.json";
            string jsonFile = File.ReadAllText(path);
            Json_items json_ = JsonConvert.DeserializeObject<Json_items>(jsonFile);
            var res = JsonConvert.DeserializeObject<Dictionary<int,Json_items>>(jsonFile);

            foreach (var person in res)
            {
                count_items.leght= person.Key;
               
            }
            foreach (var person1 in res)
            {
                int x = 0;
                count_items.item_all(x, person1.Value.name, person1.Value.type, person1.Value.img);
                x++;
            }







        }
    }
        
}
