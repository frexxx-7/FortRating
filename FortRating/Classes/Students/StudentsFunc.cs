using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortRating.Classes.Students
{
    internal class StudentsFunc
    {
        public DataTable ReadItemsEvents(string idStudent, double startRows, double numberRows, string searchText)
        {
            DB db = new DB();

            db.openConnection();

            string query = null;
            if (idStudent != null)
            {
                query = searchText == null ?
                    $"SELECT students.id as idStudent, students.id, concat(students.surname,' ', students.name,' ', students.patronymic) as FIO, groups.name FROM students " +
                    $"left join groups on groups.id = students.idGroup " +
                    $"WHERE idStudent = {idStudent} " +
                    $"ORDER BY idStudent DESC " +
                    $"LIMIT {startRows}, {numberRows};"
                    :
                    $"SELECT students.id as idStudent, students.id, concat(students.surname,' ', students.name,' ', students.patronymic) as FIO, groups.name FROM students " +
                    $"left join groups on groups.id = students.idGroup " +
                    $"WHERE idStudent = {idStudent} AND concat(students.surname,' ', students.name,' ', students.patronymic, groups.name) LIKE '%{searchText}%' " +
                    $"ORDER BY idStudent DESC " +
                    $"LIMIT {startRows}, {numberRows};"
                    ;
            }
            else
            {
                query = searchText == null ?
                    $"SELECT students.id as idStudent, students.id, concat(students.surname,' ', students.name,' ', students.patronymic) as FIO, groups.name FROM students " +
                    $"left join groups on groups.id = students.idGroup " +
                    $"ORDER BY idStudent DESC " +
                    $"LIMIT {startRows}, {numberRows};"
                    :
                    $"SELECT students.id as idStudent, students.id, concat(students.surname,' ', students.name,' ', students.patronymic) as FIO, groups.name FROM students " +
                    $"left join groups on groups.id = students.idGroup " +
                    $"WHERE concat(students.surname,' ', students.name,' ', students.patronymic, groups.name) LIKE '%{searchText}%' " +
                    $"ORDER BY idStudent DESC " +
                    $"LIMIT {startRows}, {numberRows};"
                    ;
            }

            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
