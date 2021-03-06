﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Website.Sample.DbModels
{
    [TableName("Person")]
    public class Person
    {
        [PrimaryKeyColumn]
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int Age { get; set; }
        public string Avatar { get; set; }
    }

}
