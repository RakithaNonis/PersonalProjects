using System;
using System.Collections.Generic;
using System.Text;

namespace NextConsole
{
    class DeleteItem
    {
        public static void del_item()
        {
            Console.WriteLine("give the del_ID:");
            string delId = Console.ReadLine();

            for (int i = 0; i < AddItem.shop.Count; i++)
            {
                if (delId == AddItem.shop[i].getId)
                {
                    AddItem.shop.RemoveAt(i);

                }
            }
            Console.WriteLine("The item has been deleted");
        }
    }
}
