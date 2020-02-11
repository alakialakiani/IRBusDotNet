﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IRBusDotNet.Models
{
    public class BusServiceResult<T>
    {
        public bool Status { get; set; } = false;
        public bool Unauthorized { get; set; } = false;
        public string Message { get; set; } = "بدون خطا";
        public T Result { get; set; }
    }
}
