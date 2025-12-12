/* 
 *  Copyright © yiroth, all right reserved 
 *  Creation date: 2025-11-25
 *  Purpose: Inventory component
*/

using System.Collections.Generic;
using UnityEngine;

namespace LibYiroth.Inventory
{
    public class Inventory : MonoBehaviour
    {
        public List<Data.Node> items = new();
        
        public Data.Node GetItemAt(int index)
        {
            return items[index];
        }
    }
}