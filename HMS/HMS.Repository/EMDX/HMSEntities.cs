﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;

namespace HMS.Repository
{
    public partial class HMSEntities : DbContext
    {
        //public override int SaveChanges()
        //{
        //    var modifiedEntries = ChangeTracker.Entries()
        //        .Where(x=>x.State == EntityState.Added || x.State == EntityState.Modified);

        //    foreach (var entry in modifiedEntries)
        //    {
        //        var entity = entry.Entity as SyncEntity;
        //        if (entity != null)
        //        {
        //            var identityName = Thread.CurrentPrincipal.Identity.Name;
        //            var now = DateTime.UtcNow;

        //            if (entry.State == EntityState.Added)
        //            {
        //                //entity.IsActive = true;
        //                //entity.CreatedUserID = Convert.ToInt32(identityName);
        //                entity.CreatedDate = now;
        //            }
        //            else
        //            {
        //                // base.Entry(entity).Property(x => x.CreatedUserID).IsModified = false;
        //                base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
        //            }

        //            //entity.LastModifiedUserID = Convert.ToInt32(identityName);
        //            entity.UpdatedDate = now;
        //        }
        //    }

        //    return base.SaveChanges();
        //}

    }
}
