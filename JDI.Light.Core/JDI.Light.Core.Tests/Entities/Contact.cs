﻿using System.Collections.Generic;

namespace JDI.Light.Core.Tests.Entities
{
    public class Contact
    {
        public static readonly Contact DefaultContact = new Contact("Test", "Testov", "Test description", 3, 4);

        public Contact(string firstName, string lastName, string description, int firstSummary, int secondSummary)
        {
            FirstName = firstName;
            LastName = lastName;
            Description = description;
            FirstSummary = firstSummary;
            SecondSummary = secondSummary;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public int FirstSummary { get; set; }
        public int SecondSummary { get; set; }

        public IList<string> ToList()
        {
            return new List<string> { FirstName, LastName, Description };
        }

        public override string ToString()
        {
            return "Summary: 3";
        }
    }
}
