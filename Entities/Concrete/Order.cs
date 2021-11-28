﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public int OrderStatusId { get; set; }
        public int Count { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean Active { get; set; }
    }
}
