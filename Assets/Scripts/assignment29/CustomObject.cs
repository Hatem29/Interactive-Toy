using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

namespace Assignment29
{
    public class CustomObject : Object
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public CustomObject(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        override
        public string ToString()
        {
            string st = $"Object [ID : {ID}, Name: {Name}]";
            return st;
        }

        //override
        //public bool Equals(CustomObject obj) 
        //{
        //    if (obj == null) return false;
        //    if (this.ID == obj.ID && this.Name == obj.Name) return true;
        //    return false;
        //}

        public static bool operator ==(CustomObject a, CustomObject b)
        {
            if (a == null || b == null) return false;
            if (a.ID == b.ID && a.Name == b.Name) return true;
            return false;
        }
        public static bool operator !=(CustomObject a, CustomObject b)
        {
            if (a == null || b == null) return true;
            if (a.ID == b.ID && a.Name == b.Name) return false;
            return true;
        }
    }
}
