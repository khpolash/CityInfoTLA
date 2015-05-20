using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityInformationApp.Model;

namespace CityInformationApp.DAL
{
    class Getaway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["CityInfoConString"].ConnectionString;

        public int Save(City aCity)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string insert = "INSERT INTO city_table VALUES('"+aCity.CityName+"','"+aCity.Division+"','"+aCity.Distric+"','"+aCity.Upazila+"','"+aCity.PostCode+"','"+aCity.Country+"')";
            SqlCommand command = new SqlCommand(insert,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<City> GetAllData()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string insert = "SELECT * FROM city_table";
            SqlCommand command = new SqlCommand(insert, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<City> cityList = new List<City>();
            while (reader.Read())
            {
                City aCity = new City();
                aCity.Id = int.Parse(reader["ID"].ToString());
                aCity.CityName = reader["CityName"].ToString();
                aCity.Division = reader["Division"].ToString();
                aCity.Distric = reader["District"].ToString();
                aCity.Upazila = reader["Upazila"].ToString();
                aCity.PostCode = int.Parse(reader["PostCode"].ToString());
                aCity.Country = reader["Country"].ToString();

                cityList.Add(aCity);  
            }
            reader.Close();
            connection.Close();
            return cityList;
       }
        public List<City> SearchData(string search, string value)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string select = GetQuary(search,value);
            SqlCommand command = new SqlCommand(select, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<City> cityList = new List<City>();
            while (reader.Read())
            {
                City aCity = new City();
                aCity.Id = int.Parse(reader["ID"].ToString());
                aCity.CityName = reader["CityName"].ToString();
                aCity.Division = reader["Division"].ToString();
                aCity.Distric = reader["District"].ToString();
                aCity.Upazila = reader["Upazila"].ToString();
                aCity.PostCode = int.Parse(reader["PostCode"].ToString());
                aCity.Country = reader["Country"].ToString();

                cityList.Add(aCity);
            }
            reader.Close();
            connection.Close();
            return cityList;
        }

        public string GetQuary(string search, string value)
        {
            switch (search)
            {
                case "Division":
                    return "SELECT * FROM city_table WHERE Division LIKE'%" + value + "%'";
                case "District":
                    return "SELECT * FROM city_table WHERE District LIKE'%" + value + "%'";
                case "CityName":
                    return "SELECT * FROM city_table WHERE CityName LIKE'%" + value + "%'";
                case "Upazila":
                    return "SELECT * FROM city_table WHERE Upazila LIKE'%" + value + "%'";
                default:
                    return "SELECT * FROM city_table WHERE PostCode LIKE'%" + value + "%'";
            }
        }

        public City GetCityById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string selectQuery = "SELECT * FROM city_table WHERE ID='" + id + "'";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<City> cityList = new List<City>();

            while (reader.Read())
            {
                City aCity = new City();
                aCity.Id = int.Parse(reader["ID"].ToString());
                aCity.CityName = reader["CityName"].ToString();
                aCity.Division = reader["Division"].ToString();
                aCity.Distric = reader["District"].ToString();
                aCity.Upazila = reader["Upazila"].ToString();
                aCity.PostCode = int.Parse(reader["PostCode"].ToString());
                aCity.Country = reader["Country"].ToString();

                cityList.Add(aCity);
            }
            reader.Close();
            connection.Close();
            return cityList.FirstOrDefault();
        }

        public int Update(City aCity,int id)
        {
                SqlConnection connection = new SqlConnection(connectionString);
                string insertQuery = "UPDATE city_table SET Division='" + aCity.Division + "',District='" + aCity.Distric + "',Upazila='" + aCity.Upazila + "',PostCode='" + aCity.PostCode + "' WHERE ID='" + id + "'";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                connection.Open();
                int rowAffected = command.ExecuteNonQuery();
                connection.Close();
                return rowAffected;
        }
    }
}
