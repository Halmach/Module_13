using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Module_13
{
    public class Contact : IComparable<Contact> // модель класса
    {
        public Contact(string name, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public long PhoneNumber { get; }
        public String Email { get; }

        public int CompareTo(Contact p)
        {
            return this.Name.CompareTo(p.Name);
        }
    }
}
