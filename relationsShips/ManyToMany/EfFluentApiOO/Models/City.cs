﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfFluentApiOO.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CityInformationId { get; set; }

        public CityInformation CityInformation { get; set; }
    }
}
