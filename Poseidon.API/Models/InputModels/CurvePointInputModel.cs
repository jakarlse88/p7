﻿using System;

namespace Poseidon.API.Models
{
    public class CurvePointInputModel : IInputModel
    {
        public short? CurveId { get; set; }
        public DateTime? AsOfDate { get; set; }
        public double? Term { get; set; }
        public double? Value { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}