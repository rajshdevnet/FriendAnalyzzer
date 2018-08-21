namespace FriendOrganizer.DataAccess.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
               f => f.FirstName,
               new Friend { FirstName = "Raj", LastName = "Mad" },
            new Friend { FirstName = "Ram", LastName = "Jan" },
            new Friend { FirstName = "Thomas", LastName = "Fred" },
            new Friend { FirstName = "Ian", LastName = "Golski" }
                );
        }
    }
}
