﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godisbutiken12.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public string ShoppingCartId { get; set; }
        public Godis Godis { get; set; }
        public int Amount { get; set; }

    }
}
