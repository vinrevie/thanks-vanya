﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface ICup
    {
        string Type { get; set; }
        double Capacity { get; set; }
        void Refill();

         void Wash();
    }
}
