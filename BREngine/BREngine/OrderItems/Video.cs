﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BREngine.OrderItems
{
    public class Video : OrderItem
    {
        public Video(string name) { _name = name; }
        public static OrderItem GetOrderItem(string name)
        {
            return new Video(name);
        }

    }
}
