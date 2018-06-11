using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    [System.Serializable]
    public class ItemStructure
    {
        public string Name;
        public int Id;
        public string ItemType;
        public Sprite Sprite;
        [Multiline] public string Description;
    }
}
