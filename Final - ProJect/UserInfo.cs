﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final___ProJect
{
    public class UserInfo 
    {
        public string Name { get; set; }
        public string Lname { get; set; }
        public string Idcard { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BookName { get; set; }
        public string Type { get; set; }
        public string IdBook { get; set; }
        public string Payment { get; set; }
        public UserInfo(string firstname,string lastname, string idcard, string phone, string email, string bookname, string type, string idbook, string payment) 
        {
            Name = firstname;
            Lname = lastname;
            Idcard = idcard;
            Phone = phone;
            Email = email;
            BookName = bookname;
            Type = type;
            IdBook = idbook;
            Payment = payment;
        }
    }
}
