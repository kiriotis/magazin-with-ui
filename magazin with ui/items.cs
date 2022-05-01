using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin_with_ui
{
    class items
    {



        public int leght ;

        public void item_all1()
        {
            string[][] arr = new string[leght][];

        }
        public void item_all( int x,  string name,  string price,  string file)
        {


            string[][] arr = new string[leght][];
            arr[x] = new string[] { name, price, file };
            Console.WriteLine(arr[x][0]);
            Console.WriteLine(arr[x][1]);
            Console.WriteLine(arr[x][2]);
           
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

             }*/


        }

    }
}


