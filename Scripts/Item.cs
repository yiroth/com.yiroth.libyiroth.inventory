using UnityEngine;
using System.Collections.Generic;
using LibYiroth;

namespace LibYiroth.Inventory
{
    [CreateAssetMenu(fileName = "Item", menuName = "LibYiroth/Inventory/New Item", order = 0)]
    public class Item : Data.Node
    {
        public List<Variant.Container> attributeContainer;
    }
}