//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prequalApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class MVR
    {
        public long ID { get; set; }
        public string accountNumber { get; set; }
        public string meterNumber { get; set; }
        public string comment { get; set; }
        public string rdgRead { get; set; }
        public Nullable<System.DateTime> readDate { get; set; }
        public Nullable<System.TimeSpan> readTime { get; set; }
        public string readCode { get; set; }
        public string skipCode { get; set; }
        public string tCode1 { get; set; }
        public string tCode2 { get; set; }
        public string mReaderId { get; set; }
        public string readType { get; set; }
        public string preReading { get; set; }
        public string readMethod { get; set; }
        public string textPrompt { get; set; }
        public string FileName { get; set; }
    }
}
