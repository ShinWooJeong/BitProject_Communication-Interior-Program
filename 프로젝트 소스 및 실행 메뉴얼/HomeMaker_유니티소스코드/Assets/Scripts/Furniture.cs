using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class Furniture
    {

        private string name;
        private string furnitureType;
        private string company;
        private int price;
        private Transform locatedTransform;

        public string Name{ get { return name; } set { name = value; } }
        public string FurnitureType { get { return furnitureType; } set { furnitureType = value; } }
        public string Company { get { return company; } set { company = value; } }
        public int Price { get { return price; } set { price = value; } }
        public Transform LocatedTransform { get { return locatedTransform; } set { locatedTransform = value; } }

        public Furniture(string name, string furnitureType, string company, int price, Transform locatedTransform)
        {
            this.name = name;
            this.furnitureType = furnitureType;
            this.company = company;
            this.price = price;
            this.locatedTransform = locatedTransform;
        }

    }
}
