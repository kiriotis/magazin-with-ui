using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin_with_ui
{
    class items
    {
        public void item_all(string art,int x,out string name,out string price,out string file)
        {
            name = null;
            price = null;
            file = null;
            int leght = 4;
            string[][] arr = new string[leght][];
            arr[0] = new string[] { "краска haus prof3", "100", @"https://raw.githubusercontent.com/kiriotis/magazin-with-ui/master/magazin%20with%20ui/Resources/paint_1.png" };
            arr[1] = new string[] { "кисть", "30" , @"https://raw.githubusercontent.com/kiriotis/magazin-with-ui/master/magazin%20with%20ui/Resources/brush_1.png" };
            arr[2] = new string[] { "лента малярная","15", @"https://raw.githubusercontent.com/kiriotis/magazin-with-ui/master/magazin%20with%20ui/Resources/tape_1.jpeg" };
            arr[3] = new string[] { "краска object ", "200" , @"https://raw.githubusercontent.com/kiriotis/magazin-with-ui/master/magazin%20with%20ui/Resources/paint_2.png" };
            if (x == 1)
            {
                for (int i = 0; i < leght; i++)
                {

                    if (Convert.ToString(i) == art)
                    {
                        name = arr[i][0];
                        price = arr[i][1];
                        file = arr[i][2];

                    }
                }
            }
            else if (x == 2)
            {
                
                
                for ( int  i = 0; i < leght; i++)
                {
                    
                    if (arr[i][0] == art)
                    {
                        name = arr[i][0];
                        price = arr[i][1];
                        file = arr[i][2];

                    }
                }

            }
            else if (x == 3)
            { 
            
            }

           
        }
        
    }
}

