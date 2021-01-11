using System;
using System.Collections.Generic;

namespace Menutree8Jan21
{
    public class Program
    {
        static void Main(string[] args)
        {           
            List<DataItem> ItemList = new List<DataItem>
            {
                new DataItem(){ItemId = 100},
                new DataItem(){ItemId = 101},
                new DataItem(){ItemId = 102},
                new DataItem(){ItemId = 103},
                new DataItem(){ItemId = 200},
                new DataItem(){ItemId = 201},
                new DataItem(){ItemId = 202},
                new DataItem(){ItemId = 203},
                new DataItem(){ItemId = 204},
                new DataItem(){ItemId = 300},
                new DataItem(){ItemId = 301},
                new DataItem(){ItemId = 302},
                new DataItem(){ItemId = 400},
                new DataItem(){ItemId = 401},
                new DataItem(){ItemId = 402},
                new DataItem(){ItemId = 403},
                new DataItem(){ItemId = 404},
                new DataItem(){ItemId = 500},
                new DataItem(){ItemId = 501},
                new DataItem(){ItemId = 502},
                new DataItem(){ItemId = 503},
                new DataItem(){ItemId = 504}
            };

            List<DataItem> ParentList = new List<DataItem>
            {
                new DataItem(){ParentId =   -1},
                new DataItem(){ParentId = 100},
                new DataItem(){ParentId = 100},
                new DataItem(){ParentId = 100},
                new DataItem(){ParentId =  -1},
                new DataItem(){ParentId = 200},
                new DataItem(){ParentId = 200},
                new DataItem(){ParentId = 200},
                new DataItem(){ParentId = 200},
                new DataItem(){ParentId =  -1},
                new DataItem(){ParentId = 300},
                new DataItem(){ParentId = 300},
                new DataItem(){ ParentId =  -1},
                new DataItem(){ ParentId = 400},
                new DataItem(){ ParentId = 400},
                new DataItem(){ ParentId = 400},
                new DataItem(){ ParentId = 400},
                new DataItem(){ ParentId =  -1},
                new DataItem(){ ParentId = 500},
                new DataItem(){ ParentId = 500},
                new DataItem(){ParentId = 500},
                new DataItem(){ ParentId = 500}
            };

            /*//public Array DataId { get;set;}
             * List<DataItem> DataList = new List<DataItem>
            {
                new DataItem() { DataId = ItemList },
                new DataItem() { DataId = ParentList }

            };*/


            /*for (var i = 0; i < ItemList.Count; i++)
            {
                Console.WriteLine(ItemList[i]);   
            }*/

            Console.WriteLine(ItemList[5]);

            
        }
    }

    public class DataItem
    {
        public int ItemId { get; set; }
        public int ParentId {get; set; }
        

        public override string ToString()
        {
            return $"{ItemId} {ParentId}";
        }

        
    }
}
