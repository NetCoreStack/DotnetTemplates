using NetCoreStack.Contracts;
using System;

namespace Hisar.Component.Template.Models
{
    public class GuidelineEntityBson : EntityIdentityBson
    {
        public string Name { get; set; }
        public int Age { get; set; } 
        public DateTime BirthDate { get; set; }
    }
}