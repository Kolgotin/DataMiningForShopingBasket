﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMiningForShopingBasket.Models
{
    class UserInterfaceModel : Products
    {
        public int Count { get; set; }

        public UserInterfaceModel(int i , string s)
        {
            id = i;
            ProductName = s;
        }
    }
}
