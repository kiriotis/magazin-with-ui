using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin_with_ui
{
    class items
    {
        public void item_all(string art,out string name,out string price,out string file)
        {
            name = null;
            price = null;
            file = null;
            int leght = 4;
            string[][] arr = new string[leght][];
            arr[0] = new string[] { "краска", "100", @"paint_1.png" };
            arr[1] = new string[] { "кисть", "30" , @"brush_1.png" };
            arr[2] = new string[] { "лента малярная","10", @"tape_1.jpeg" };
            arr[3] = new string[] { "краска", "200" , @"paint_2.png" };
            for (int i=0;i<=leght;i++)
            {
                
                if (Convert.ToString(i) == art)
                {
                    name = arr[i][0];
                    price= arr[i][1];
                    file = arr[i][2];

                }
            }

           
        }
        
    }
}

