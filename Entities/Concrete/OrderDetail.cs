﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class OrderDetail:IEntity
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public int SalePrice { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean Active { get; set; }
    }
}
