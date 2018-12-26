﻿using DB.Abstract;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Entities
{
    [Table("tbTeachers")]
    public class Teacher : AbstractDbEntity, IDbEntity
    {
        
        //[StringLength(64)]
        public string FirstName { get; set; }
        //[StringLength(64)]
        public string MiddleName { get; set; }
        //[StringLength(64)]
        public string LastName { get; set; }

        [ForeignKey(typeof(Department))]
        public int DepId { get; set; }

        [ManyToOne]
        public Department Department { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<TeachSubj> TeachSubj { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }
}
