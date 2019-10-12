﻿using HastaKayitSistemi.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaKayitSistemi.DAL
{
 public class HastaneDoktorMapping:EntityTypeConfiguration<Doktor>
    {
        public HastaneDoktorMapping()
        {
            HasKey(x => x.DoktorID);
            HasRequired(x => x.Hastane).WithMany(x => x.Doktorlar).HasForeignKey(x => x.DoktorID);
        }
    }
}