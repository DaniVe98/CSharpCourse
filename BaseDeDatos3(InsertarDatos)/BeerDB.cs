﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos2
{
    public class BeerDB : DB
    {
        public BeerDB(string server, string db, string user, string password) :
        base(server, db, user, password)
            {
                
            }

        public List<Beer> GetAll()
        {
            Connect();
            List<Beer> beers = new List<Beer>();
            string query = "SELECT Id, Name, BrandId FROM BEER";
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int brandId = reader.GetInt32(2);
                beers.Add(new Beer(id, name, brandId));
            }

            Close();

            return beers;
        }
        public void Add(Beer beer)
        {
            Connect();
            string query = "INSERT INTO Beer(Name, BrandID) " +
                "VALUES(@name, @brandID)";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", beer.Name);
            command.Parameters.AddWithValue("@brandID", beer.BrandId);
            command.ExecuteNonQuery();

            Close();

        }
    }
}
