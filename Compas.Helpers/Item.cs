﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compas.Helpers
{
    public class Item
    {
        string _id;
        string _name;

        public Item()
        { }

        public Item(string _ID, string _Name)
        {
            _id = _ID;
            _name = _Name;
        }

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


    }

    public class ItemIntValue
    {
        int _id;
        string _name;
        byte[] _image;


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public byte[] Image
        {
            get { return _image; }
            set { _image = value; }
        }


    }
}
