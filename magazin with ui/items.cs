using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin_with_ui
{
    class items
    {

        

        static  string[][] arr = new string[1000][];
        
        public string[][]  item_all(int x, string  name, string price, string file)
        {


            Console.WriteLine(x);
            arr[x] =new string[] { name, price , file };
             
               

            Console.WriteLine(arr[x][0]);
            Console.WriteLine(arr[x][1]);
            Console.WriteLine(arr[x][2]);
            return arr;
            

        }


        
        public void item_search(string art,int x, int id , out string name, out string  price, out string file )
        {
            
            name = null;
            price =null;
            file = null;
          
            
            if (x == 1)
            {
               
                for (int i = 1; i <= id ; i++)
                {
                    if (i == Convert.ToInt32(art))
                    {
                        
                        name = arr[i][0];
                        price= arr[i][1];
                        file=  arr[i][2];
                    }
                    

                    
                }
            }
        }

    }
}


