﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Data.Configuration
{
    public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
    {
        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {
            builder.ToTable("FeedBack");
            builder.HasKey(x => x.FeedBackId) ;


            builder.HasOne(x => x.User).WithMany(x => x.FeedBacks)
                .HasForeignKey(x => x.UserIdForeignKey).IsRequired(false);
                


            builder.HasOne(x => x.Booking).WithMany(x => x.FeedBacks)
                .HasForeignKey(x => x.BookingIdForeignKey).IsRequired(false);
                
        }
    }
}