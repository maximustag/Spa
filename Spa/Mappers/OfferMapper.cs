﻿using Spa.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Spa.Mappers
{
    public class OfferMapper: EntityTypeConfiguration<Offer>
    {
        public OfferMapper()
        {
            this.ToTable("Offers");

            this.HasKey(o => o.OfferId);
            this.Property(o => o.OfferId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(o => o.OfferId).IsRequired();

            this.Property(o => o.Amount).IsRequired();

            this.Property(o => o.Price).IsRequired();

            this.Property(o => o.ShipPrice).IsRequired();

            this.HasRequired(o => o.Product).WithMany().Map(p => p.MapKey("ProductId"));
            this.HasRequired(o => o.OfferList).WithMany().Map(p => p.MapKey("OfferListId"));
        }
    }
}