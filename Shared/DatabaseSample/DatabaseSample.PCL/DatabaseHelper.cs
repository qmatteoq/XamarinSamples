using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseSample.PCL.Entities;
using SQLitePCL;

namespace DatabaseSample.PCL
{
    public class DatabaseHelper
    {
        public void CreateDatabase()
        {
            using (SQLiteConnection conn = new SQLiteConnection("people.db"))
            {
                string query = "CREATE TABLE IF NOT EXISTS PEOPLE " +
                               "(Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                               "Name varchar(100), " +
                               "Surname varchar(100))";
                ISQLiteStatement statement = conn.Prepare(query);
                statement.Step();
            }
        }

        public List<Person> GetUsers()
        {
            List<Person> users = new List<Person>();

            using (SQLiteConnection conn = new SQLiteConnection("people.db"))
            {
                using (var statement = conn.Prepare("SELECT * FROM People ORDER BY Name;"))
                {
                    while (statement.Step() == SQLiteResult.ROW)
                    {
                        long id = (long) statement[0];
                        string name = (string) statement[1];
                        string surname = (string) statement[2];

                        Person person = new Person
                        {
                            Id = id,
                            Name = name,
                            Surname = surname
                        };

                        users.Add(person);
                    }
                }
            }

            return users;
        }

        public void Add(Person person)
        {
            using (SQLiteConnection conn = new SQLiteConnection("people.db"))
            {
                using (var statement = conn.Prepare("INSERT INTO People (Name, Surname) VALUES(@Name, @Surname);"))
                {
                    statement.Bind("@Name", person.Name);
                    statement.Bind("@Surname", person.Surname);
                    statement.Step();
                }
            }
        }
    }
}