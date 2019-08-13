using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PersonModel
    {
        private string FirstName;
        private string LastName;
        private int Age;
        private bool IsAlive;

        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public int Age1 { get => Age; set => Age = value; }
        public bool IsAlive1 { get => IsAlive; set => IsAlive = value; }
    }
}