﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.ExceptionClass;

namespace BLL
{
    public class Dentist : Human
    {
        public string DentistryLevel { get; set; }
        public string DentisttInfo()
        {
            string info = "Ім'я та прізвище Дантиста: " + Name + " " + Surname + "\nСтать дантиста: " + Sex +
                "\nІдентифікаційний код: " + IdentificationCode + "\nНавички лікування зубів: " + DentistryLevel +
                "\nЧи вміє готувати:" + Coocking;
            return info;
        }
    }
}
