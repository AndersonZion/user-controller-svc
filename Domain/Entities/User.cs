﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Status { get; set; }

        public User()
        {

        }

        public User(int id, string name, string status)
        {
            Id = id;
            Name = name;
            Status = status;
        }
    }
}
