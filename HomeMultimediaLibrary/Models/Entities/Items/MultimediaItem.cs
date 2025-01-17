﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeMultimediaLibrary.Models.Entities.Items
{
    [Table("MultimediaItems")]
    public class MultimediaItem: Item
    {
        [Required(AllowEmptyStrings = false)]
        public int LengthMinutes { get; set; }
    }
}