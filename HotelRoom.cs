﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class HotelRoom
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; } // Deluxe, Suite, Standard
        public bool IsAvailable { get; set; }
    }
}
