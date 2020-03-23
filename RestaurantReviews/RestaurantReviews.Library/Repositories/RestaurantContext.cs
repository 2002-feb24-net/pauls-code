using System;
using Microsoft.EntityFrameworkCore;
using RestaurantReviews.Library.Models;

namespace RestaurantReviews.Library.Repositories
{
    // this context class represents the whole database
    public class RestaurantContext : DbContext
    {
        // you need DbSet properties, one per table (one per type of data you want to store)
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Review> Review { get; set; }


        // in order to connect to any database (or many other kinds of data source)
        // we need a "connection string"

        // we need to give each DbContext instance a connection string...
        // one clumsy hardcoded easy one is OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=../../../restaurant.db";
            // need another package for this (Microsoft.EntityFrameworkCore.Sqlite)
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
