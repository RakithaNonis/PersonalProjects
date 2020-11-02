using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Rakitha
{
    class Program
    {
     

        public static void QueryCommand(MySqlCommand cmd)
        {
            cmd.CommandText = "SELECT * FROM paper";
            cmd.CommandType = CommandType.Text;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0}, {1}, {2}",
                    reader.GetInt32(0), reader.GetString(1), reader.GetString(2))
                );
            }

            reader.Close();
        }
        public static void InsertCommand(MySqlCommand cmd, string name, string number)
        {
            cmd.CommandText = "insert_data";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new MySqlParameter("param_name", name));
            cmd.Parameters.Add(new MySqlParameter("param_number", number));

            cmd.ExecuteNonQuery();
        }
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder();
            connBuilder.Add("Database", "mypaper");
            connBuilder.Add("Data Source", "localhost");
            connBuilder.Add("User Id", "root");
            connBuilder.Add("Password", "");

            MySqlConnection connection = new MySqlConnection(connBuilder.ConnectionString);

            MySqlCommand cmd = connection.CreateCommand();



            connection.Open();


           
            Console.WriteLine("Enter your name please :");
            String name = Console.ReadLine();

            Console.WriteLine("Enter your admision number  please :");
            String num = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            InsertCommand(cmd, name, num);
            // QueryCommand(cmd);

           /* SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM paper WHERE ([name] = name)", conn);
            SqlParameter sqlParameter = check_User_Name.Parameters.AddWithValue(name, txtBox_UserName.name);
            int UserExist = (int)check_User_Name.ExecuteScalar();

            if (UserExist > 0)
            {
                //Username exist
            }
            else
            {
                //Username doesn't exist.
            }*/

            Random question = new Random();

              string[] array = new string[30];
              array[0] = "-What is the capital of France \n 1) paris  2) daka";
              array[1] = "-What is the capital of Spain \n 1) madrid 2) barcelona";
              array[2] = "-What is the captial of Russia \n 1) moscow 2) johanesburg";
              array[3] = "-What is the capital of Ukraine \n 1) kiev 2) melbourn";
              array[4] = "-What is the capital of Egypt  \n 1) cairo 2) sydney";
              array[5] = "-What is the capital of Sri Lanka \n 1) srijayawardanepura 2) colombo ";
              array[6] = "-What is the value of 2 + 2 :";
              array[7] = "-What is the value of 6 + 6 :";
              array[8] = "-What is the value of 10 + 10 :";
              array[9] = "-What is the value of 20 + 5 :";

            array[10] = "-What is the value of 1 + 1 :";
            array[11] = "-What is the value of 1 * 1 :";
            array[12] = "-What is the value of 2 * 5 :";
            array[13] = "-What is the value of 6 / 2 :";
            array[14] = "-What is the value of 10 / 2 :";
            array[15] = "-What is the value of 22 / 11 : ";
            array[16] = "-What is the value of 2 + 20 :";
            array[17] = "-What is the value of 6 + 3 :";
            array[18] = "-What is the value of 10 + 20 :";
            array[19] = "-What is the value of 4 + 5 :";

            array[20] = "-What is the value of 1 + 0 :";
            array[21] = "-What is the value of 100 - 50 :";
            array[22] = "-What is the value of 20 * 5 :";
            array[23] = "-What is the value of 60 / 2 :";
            array[24] = "-What is the value of 10 / 5 :";
            array[25] = "-What is the value of 40 / 10 : ";
            array[26] = "-What is the value of 25 - 20 :";
            array[27] = "-What is the value of 60 + 3 :";
            array[28] = "-What is the value of 15 + 20 :";
            array[29] = "-What is the value of 4 - 2 :";



            string[] answer = new string[30];
              answer[0] = "paris";
              answer[1] = "madrid";
              answer[2] = "moscow";
              answer[3] = "kiev";
              answer[4] = "cairo";
              answer[5] = "srijayawardanepura";
              answer[6] = "4";
              answer[7] = "12";
              answer[8] = "20";
              answer[9] = "25";

            answer[10] = "2";
            answer[11] = "1";
            answer[12] = "10";
            answer[13] = "3";
            answer[14] = "5";
            answer[15] = "2";
            answer[16] = "22";
            answer[17] = "9";
            answer[18] = "30";
            answer[19] = "9";

              answer[20] = "1";
              answer[21] = "50";
              answer[22] = "100";
              answer[23] = "30";
              answer[24] = "2";
              answer[25] = "4";
              answer[26] = "5";
              answer[27] = "63";
              answer[28] = "35";
              answer[29] = "2";

            ArrayList rep = new ArrayList();

       

              int score = 0;
              int cou = 0;
            int que = 0;

              while (cou < 10)
              { 
                  int x = question.Next(30);
                  if (rep.Contains(x))
                  {
                      // int y = question.Next(5);
                      // Console.WriteLine(array[y]+" "+y);

                  }
                  else
                  {
                    que++;
                    Console.WriteLine("Queshion number " + que);
                    Console.WriteLine(array[x]);
                    
                    
                      string a = Console.ReadLine();
                        
                      if (a == answer[x])
                      {
                          Console.WriteLine("Correct answer");
                          score = score + 10;
                      }
                      else
                      {
                          Console.WriteLine("Incorrect answer");
                      }
                      rep.Add(x);
                      cou++;
                  }

                 // Console.WriteLine(cou);
                  Console.WriteLine();

              }

              Console.WriteLine("score = " + score );
            connection.Close();
            Console.ReadLine();

            /*
            for (int i = 0; i < rep.Count; i++)
            {
                Console.WriteLine(rep[i]);
            }
            */
        }
    }
}
