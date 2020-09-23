using ReCourseWork.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCourseWork.Controller
{
    class VehicleController
    {
       static public  List<Vehicle> shop = new List<Vehicle>();
       private static List<string> invalidChars = new List<string>() { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-","+","/","`","~","<",">",".",",","?",";"
                                                                        ,":","'","}","{","]","[","=","|","_","+ ","1","2","3","4","5","6","7","8","9","0"};
       

        public static int option;

        //private static void checkvalidate(string input) 
        //{
        //    if (input!=null)
        //    {
        //        do
        //        {
        //            if (input.Length > 10)
        //            {
        //                Console.WriteLine("too long ");
        //                Console.WriteLine("get brand :");
        //                input = Console.ReadLine();
        //            }
        //           else
        //            {
        //                foreach (string item in invalidChars)
        //                {
        //                    if (input.Contains(item))
        //                    {
        //                        Console.WriteLine("invalid chars");
        //                        Console.WriteLine("get brand :");
        //                        input = Console.ReadLine();
        //                    }
        //                }
        //            }


        //        } while (false);
        //    }
        //}
        private static void check(string input)
        {
            if (input!=null)
            {
                 if (input.Length > 10)
                {
                    Console.WriteLine("too long ");
                    Console.WriteLine("re enter input :");
                    input = Console.ReadLine();
                }
                //else if (string.IsNullOrEmpty(input))
                //{
                //    Console.WriteLine("cant enter empty brand");
                //    Console.WriteLine("re enter input :");
                //    input = Console.ReadLine();
                //}
                else
                {
                    foreach (string item in invalidChars)
                    {
                        if (input.Contains(item))
                        {
                            Console.WriteLine("invalid chars");
                            Console.WriteLine("re enter input :");
                            input = Console.ReadLine();
                        }
                    }
                }

            }
            else 
            {
                Console.WriteLine("can not empty");
                Console.WriteLine("re enter input :");
                input = Console.ReadLine();
            }

          

        }
        public static void AddItem()
        {

            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            do
            {
             Console.WriteLine("select the option :");
            Console.WriteLine("1) CAR section 2)BIKE section");
            //option = Convert.ToInt32(Console.ReadLine());
            string option_ = Console.ReadLine();
            int option;
            while (!int.TryParse(option_, out option) )
            {
                Console.WriteLine("invalid input");
                option_ = Console.ReadLine();
            }

           
                if (option == 1)
                {
                    Car c = new Car();

                    Console.WriteLine("CAR SECTION");
                    Console.WriteLine("get vehicle ID :");
                    string UID_ = Console.ReadLine();
                    //int UID = Convert.ToInt32(UID_);
                    int UID;

                    while (!int.TryParse(UID_, out UID))
                    {
                        Console.WriteLine("This is not a number");
                        UID_ = Console.ReadLine();
                    }


                    Console.WriteLine("get brand :");
                    string brand;
                    brand = Console.ReadLine();



                    while (string.IsNullOrEmpty(brand))
                    {
                        Console.WriteLine("not a valid brand");
                        Console.WriteLine("get brand :");
                        brand = Console.ReadLine();

                    }

                    // checkvalidate(brand);
                    check(brand);

                    //while (brand.Length > 0)
                    //{
                    //    if (brand.Length > 10)
                    //    {
                    //        Console.WriteLine("too long ");
                    //        Console.WriteLine("get brand :");
                    //        brand = Console.ReadLine();
                    //    }

                    //    else if (string.IsNullOrEmpty(brand))
                    //    {
                    //        Console.WriteLine("cant enter empty brand");
                    //        Console.WriteLine("get brand :");
                    //        brand = Console.ReadLine();
                    //    }

                    //    {
                    //        foreach (string item in invalidChars)
                    //        {
                    //            if (brand.Contains(item))
                    //            {
                    //                Console.WriteLine("invalid chars");
                    //                Console.WriteLine("get brand :");
                    //                brand = Console.ReadLine();
                    //            }
                    //        }
                    //    }
                    //}

                    Console.WriteLine("get owner :");
                    string owner;
                    owner = Console.ReadLine();

                    while (string.IsNullOrEmpty(owner) || owner.Length > 10)
                    {

                        Console.WriteLine("not a valid brand");
                        Console.WriteLine("get brand :");
                        owner = Console.ReadLine();


                    }

                    check(owner);

                    Console.WriteLine("get price :");
                    string price_ = Console.ReadLine();
                    //decimal price = Convert.ToDecimal(Console.ReadLine());

                    decimal price;
                    while (!decimal.TryParse(price_, out price) || price < 0)
                    {
                        Console.WriteLine("This is not a number");
                        price_ = Console.ReadLine();
                    }

                    Console.WriteLine("get seat :");
                    string seat_ = Console.ReadLine();
                    int seat;
                    while (!int.TryParse(seat_, out seat) || seat <= 0 || seat > 6)
                    {
                        Console.WriteLine("This is not a number...please enter 1-5 seats");
                        seat_ = Console.ReadLine();
                    }
                    int vtype = 1;
                    int ConAdd = 0;
                    //DateTime thisDate = new DateTime();
                    //string Vehdate = thisDate.ToString("d");

                    DateTime time = DateTime.Now;
                    string format = "yyyy-MM-dd HH:mm:ss";
                    string Vehdate = time.ToString(format);


                    SqlCommand cmd1;
                    SqlCommand cmd;

                    c.getUserId = UID;
                    c.getBrand = brand;
                    c.getOwner = owner;
                    c.getPrice = price;
                    c.getVehType = vtype;
                    c.getVehDate = Vehdate;
                    c.getConAdd = ConAdd;

                    string sql = "SELECT COUNT(*) FROM VehicleController WHERE UserId = @UID";
                    cmd1 = new SqlCommand(sql, conn);
                    cmd1.Parameters.AddWithValue("@UID", UID);
                    int UserExist = (int)cmd1.ExecuteScalar();

                    if (UserExist > 0)
                    {
                        Console.WriteLine("user id is already exist ");
                    }
                    else
                    {
                        string query = "INSERT INTO VehicleController (UserId,Brand,Owner,Price,VehId,AddDate,ConfirmDel) VALUES (@UID,@brand,@owner, @price,@vtype,@Vehdate,@ConAdd)";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@UID", c.getUserId);
                        cmd.Parameters.AddWithValue("@brand", c.getBrand);
                        cmd.Parameters.AddWithValue("@owner", c.getOwner);
                        cmd.Parameters.AddWithValue("@price", c.getPrice);
                        cmd.Parameters.AddWithValue("@vtype", c.getVehType);
                        cmd.Parameters.AddWithValue("@Vehdate", c.getVehDate);
                        cmd.Parameters.AddWithValue("@ConAdd",c.getConAdd);
                        cmd.ExecuteNonQuery();
                    }

                }
                if (option == 2)
                {
                    Bike b = new Bike();

                    Console.WriteLine("BIKE SECTION");

                    Console.WriteLine("get vehicle ID :");
                    //int UID = Convert.ToInt32(Console.ReadLine());
                    string UID_ = Console.ReadLine();
                    int UID;
                    while (!int.TryParse(UID_, out UID))
                    {
                        Console.WriteLine("This is not a number");
                        UID_ = Console.ReadLine();
                    }

                    Console.WriteLine("get brand :");
                    string brand;
                    brand = Console.ReadLine();

                    while (string.IsNullOrEmpty(brand) || brand.Length > 10)
                    {

                        Console.WriteLine("not a valid brand");
                        Console.WriteLine("get brand :");
                        brand = Console.ReadLine();


                    }
                    check(brand);

                    Console.WriteLine("get owner :");
                    string owner;
                    owner = Console.ReadLine();

                    while (string.IsNullOrEmpty(owner) || owner.Length > 10)
                    {

                        Console.WriteLine("not a valid brand");
                        Console.WriteLine("get brand :");
                        owner = Console.ReadLine();


                    }
                    check(owner);

                    Console.WriteLine("get price :");
                    string price_ = Console.ReadLine();
                    //decimal price = Convert.ToDecimal(Console.ReadLine());

                    decimal price;
                    while (!decimal.TryParse(price_, out price))
                    {
                        Console.WriteLine("This is not a number");
                        price_ = Console.ReadLine();
                    }
                    check(price_);

                    Console.WriteLine("get color :");
                    string color = Console.ReadLine();
                    check(color);

                    int vtype = 2;
                    int ConAdd = 0;

                    DateTime time = DateTime.Now;
                    string format = "yyyy-MM-dd HH:mm:ss";
                    string Vehdate = time.ToString(format);



                    b.getUserId = UID;
                    b.getBrand = brand;
                    b.getOwner = owner;
                    b.getPrice = price;
                    b.getVehType = vtype;
                    b.getVehDate = Vehdate;
                    b.getConAdd = ConAdd;

                    SqlCommand cmd1;
                    SqlCommand cmd;

                    string sql = "SELECT COUNT(*) FROM VehicleController WHERE UserId = @UID";
                    cmd1 = new SqlCommand(sql, conn);
                    cmd1.Parameters.AddWithValue("@UID", UID);
                    int UserExist = (int)cmd1.ExecuteScalar();

                    if (UserExist > 0)
                    {
                        Console.WriteLine("user id is already exist ");
                    }
                    else
                    {
                        string query = "INSERT INTO VehicleController (UserId,Brand,Owner,Price,VehId,AddDate,ConfirmDel) VALUES (@UID,@brand,@owner, @price,@vtype,@Vehdate,@ConAdd)";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@UID", b.getUserId);
                        cmd.Parameters.AddWithValue("@brand", b.getBrand);
                        cmd.Parameters.AddWithValue("@owner", b.getOwner);
                        cmd.Parameters.AddWithValue("@price", b.getPrice);
                        cmd.Parameters.AddWithValue("@vtype", b.getVehType);
                        cmd.Parameters.AddWithValue("Vehdate", b.getVehDate);
                        cmd.Parameters.AddWithValue("@ConAdd", b.getConAdd);
                        cmd.ExecuteNonQuery();
                    }
                }
                
            } while (false);
               

            
            

        }
        public static void DeleteItem() 
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();



            
                
            Console.WriteLine("give the vehicle del_ID:");
            //int delId = Convert.ToInt32(Console.ReadLine());
            string delId_ = Console.ReadLine();
            int delId;
            while (!int.TryParse(delId_,out  delId))
            {
                Console.WriteLine("not a number");
            }

            SqlCommand cmd1;
            string sql = "SELECT COUNT(*) FROM VehicleController WHERE UserId = @delId";
            cmd1 = new SqlCommand(sql, conn);
            cmd1.Parameters.AddWithValue("@delId", delId);
            int UserExist = (int)cmd1.ExecuteScalar();

             

            if (UserExist>0)
            {
                    DateTime time = DateTime.Now;
                    string format = "yyyy-MM-dd HH:mm:ss";
                    string VehDeldate = time.ToString(format);

                    int ConfirmDel = 1;

                // string qry = "UPDATE VehicleController SET DelDate=@'"+ VehDeldate + "' WHERE UserId='" + delId + "'";

                string qry = "UPDATE VehicleController SET DelDate=@DelDate, ConfirmDel=@ConfirmDel  WHERE UserId=@delId  AND ConfirmDel!=@ConfirmDel;";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@DelDate", VehDeldate);
                    cmd.Parameters.AddWithValue("@ConfirmDel", ConfirmDel);
                    cmd.Parameters.AddWithValue("@delId", delId);
                    cmd.Parameters.AddWithValue("@ConfirmDel", ConfirmDel);
                    // string qry = "DELETE FROM  VehicleController WHERE UserId = '" + delId + "'";
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("The item has been deleted");
                


                
            }
            else 
            {
                Console.WriteLine("there are no any user in that ID");
            }


            //string sql = "Select ConfirmDel from VehicleController";
            //SqlCommand cmd1;
            //cmd1 = new SqlCommand(sql, conn);
            //SqlDataReader dreader1;
            //dreader1 = cmd1.ExecuteReader();

            //Vehicle vc = new Vehicle();

            //if (dreader1.Read())
            //{

            //    vc.getConDel = dreader1.GetInt32(0);
            //    dreader1.Close();

            //}


            //if (vc.getConDel == 1)
            //{

            //    Console.WriteLine("already deleted");


            //}



      

            //string sql = "SELECT DelDate from VehicleController";






        }
        public static void UpdateItem() 
        {
            SqlConnection conn;
            string connString = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connString);
            conn.Open();

            Console.WriteLine("give the vehicle id :");
            string updt_id_ = Console.ReadLine();
            int updt_id;
            while (!int.TryParse(updt_id_,out updt_id))
            {
                Console.WriteLine("not a number");
                updt_id_ = Console.ReadLine();
            }
            check(updt_id_);
            Console.WriteLine("give the update element \n 1) brand 2)owner 3)price  :");
            string ele_num_ = Console.ReadLine();
            //int ele_num = Convert.ToInt32(Console.ReadLine());
            int ele_num;
            while (!int.TryParse(ele_num_,out ele_num))
            {
                Console.WriteLine("not a number");
                updt_id_ = Console.ReadLine();
            }


            if (ele_num == 1)
            {
                Console.WriteLine("give the update brand :");
                string u_brand = Console.ReadLine();
                check(u_brand);

                string qryB = "UPDATE VehicleController SET Brand=@Brand where DelDate IS NULL AND UserId=@" + updt_id;
                SqlCommand cmd = new SqlCommand(qryB, conn);
                cmd.Parameters.AddWithValue("@Brand", u_brand);
                cmd.Parameters.AddWithValue("@" + updt_id, updt_id);
                cmd.ExecuteNonQuery();
            }
            if (ele_num == 2)
            {
                Console.WriteLine("give the update owner :");
                string u_owner = Console.ReadLine();
                check(u_owner);

                string qryO = "UPDATE VehicleController SET Owner=@Owner where DelDate IS NULL AND UserId=@" + updt_id;
                SqlCommand cmd = new SqlCommand(qryO, conn);
                cmd.Parameters.AddWithValue("@Owner", u_owner);
                cmd.Parameters.AddWithValue("@" + updt_id, updt_id);
                cmd.ExecuteNonQuery();
            }
            if (ele_num == 3)
            {
                Console.WriteLine("give the update price :");
                string u_price = Console.ReadLine();
                check(u_price);


                string qryP = "UPDATE VehicleController SET Price=@Price where DelDate IS NULL AND UserId=@" + updt_id;
                SqlCommand cmd = new SqlCommand(qryP, conn);
                cmd.Parameters.AddWithValue("@Price", u_price);
                cmd.Parameters.AddWithValue("@" + updt_id, updt_id);
                cmd.ExecuteNonQuery();

            }
        }

        public static void PrintItem()  
        {
            //int select;
            string select_;
            Console.WriteLine("1)Get the current vehicle list   2)Get the removed vehicle list");
            select_=Console.ReadLine();
            int select;
            //select = Convert.ToInt32(Console.ReadLine());
            while (!int.TryParse(select_, out select) || select < 1  || select > 2)
            {
                Console.WriteLine("not a number");
                select_ = Console.ReadLine();
            }

            if (select == 1)
            {
                SqlConnection conn;
                string connString = Properties.Settings.Default.ConStr;
                conn = new SqlConnection(connString);
                conn.Open();


                Console.WriteLine("Current vehicle list");

                string sql1 = "SELECT VehicleController.UserId,VehicleController.Brand,VehicleController.Owner," +
                "VehicleController.Price,VehicleController.AddDate,VehicleType.VehType FROM VehicleController " +
                "INNER JOIN VehicleType ON VehicleController.VehId = VehicleType.VehId WHERE DelDate IS NULL ORDER BY UserId ";

                SqlCommand cmd1;
                cmd1 = new SqlCommand(sql1, conn);
                SqlDataReader dreader1;
                dreader1 = cmd1.ExecuteReader();

                while (dreader1.Read())
                {
                    VehicleType vt = new VehicleType();
                    Vehicle v = new Vehicle();

                    v.getUserId = dreader1.GetInt32(0);
                    v.getBrand = dreader1.GetString(1);
                    v.getOwner = dreader1.GetString(2);
                    v.getPrice = dreader1.GetDecimal(3);
                    v.getVehDate = dreader1.GetString(4);
                    vt.getVehTy = dreader1.GetString(5);


                    Console.WriteLine("User id || " + v.getUserId + " " + " Brand || " + v.getBrand + " " + " Owner || " + v.getOwner + " " + " Price || " + v.getPrice
                        + " " + " Type || " + vt.getVehTy + " " + "Added date and time ||" + v.getVehDate);
                }
            }
            else if (select == 2)
            {
                SqlConnection conn;
                string connString = Properties.Settings.Default.ConStr;
                conn = new SqlConnection(connString);
                conn.Open();


                Console.WriteLine("Removed vehicle list");

                string sql1 = "SELECT VehicleController.UserId,VehicleController.Brand,VehicleController.Owner," +
                "VehicleController.Price,VehicleController.AddDate,VehicleController.DelDate,VehicleType.VehType FROM VehicleController " +
                "INNER JOIN VehicleType ON VehicleController.VehId = VehicleType.VehId WHERE DelDate IS NOT  NULL ORDER BY UserId ";

                SqlCommand cmd1;
                cmd1 = new SqlCommand(sql1, conn);
                SqlDataReader dreader1;
                dreader1 = cmd1.ExecuteReader();

                while (dreader1.Read())
                {
                    VehicleType vt = new VehicleType();
                    Vehicle v = new Vehicle();


                    v.getUserId = dreader1.GetInt32(0);
                    v.getBrand = dreader1.GetString(1);
                    v.getOwner = dreader1.GetString(2);
                    v.getPrice = dreader1.GetDecimal(3);
                    v.getVehDate = dreader1.GetString(4);
                    v.getVehDelDate = dreader1.GetString(5);
                    vt.getVehTy = dreader1.GetString(6);


                    Console.WriteLine("User id || " + v.getUserId + " " + " Brand || " + v.getBrand + " " + " Owner || " + v.getOwner + " " + " Price || " + v.getPrice
                        + " " + " Type || " + vt.getVehTy + " " + "Added date and time ||" + v.getVehDate + " deleted date || " + v.getVehDelDate);
                }
            }



            //SqlConnection conn;
            //string connString = Properties.Settings.Default.ConStr;
            //conn = new SqlConnection(connString);
            //conn.Open();

            //SqlDataReader dreader;
            //string sql;
            //sql = "Select UserId, Brand,Owner,Price,VehId from VehicleController";
            //SqlCommand cmd;

            //cmd = new SqlCommand(sql, conn);
            //dreader = cmd.ExecuteReader();

            //string sql1 = "SELECT VehicleController.UserId,VehicleController.Brand,VehicleController.Owner,VehicleController.Price,VehicleController.VehId,VehicleType.VehType FROM VehicleController INNER JOIN VehicleType ON VehicleController.VehId = VehicleType.VehId";

            //string sql1 = "SELECT VehicleController.UserId,VehicleController.Brand,VehicleController.Owner," +
            //    "VehicleController.Price,VehicleController.AddDate,VehicleType.VehType FROM VehicleController " +
            //    "INNER JOIN VehicleType ON VehicleController.VehId = VehicleType.VehId WHERE DelDate IS NULL ORDER BY UserId ";

            //SqlCommand cmd1;
            //cmd1 = new SqlCommand(sql1, conn);
            //SqlDataReader dreader1;
            //dreader1 = cmd1.ExecuteReader();


            //while (dreader1.Read())
            //{
            //    VehicleType vt = new VehicleType();
            //    Vehicle v = new Vehicle();

            //    v.getUserId = dreader1.GetInt32(0);
            //    v.getBrand = dreader1.GetString(1);
            //    v.getOwner = dreader1.GetString(2);
            //    v.getPrice = dreader1.GetDecimal(3);
            //     v.getVehDate = dreader1.GetString(4);
            //    vt.getVehTy = dreader1.GetString(5);


            //    Console.WriteLine("User id || " + v.getUserId + " " + " Brand || " + v.getBrand + " " + " Owner || " + v.getOwner + " " + " Price || " + v.getPrice
            //        + " " + " Type || "+vt.getVehTy+" "+"Added date and time ||"+v.getVehDate );
            //}


            // string sql1 = "Select VehId,VehType from VehicleType";
            //SqlCommand cmd1;

            //cmd1 = new SqlCommand(sql1, conn);
            //cmd = new SqlCommand(sql1, conn);




            //SqlDataReader dataReader1;
            //  SqlCommand cmd1;
            //string sql1;
            //sql1 = "Select VehType from VehicleType";
            //cmd1 = new SqlCommand(sql1, conn);
            //dataReader1 = cmd1.ExecuteReader();

            //var qu = from VehicleType in parts join Vehicle in shop on VehicleType equals Vehicle.getUserId 
            //         select new { OwnerUserId = Vehicle.getUserId, OwnerType=VehicleType.getVehTy};



            //while (dreader.Read())
            //{
            //   //VehicleType vt = new VehicleType();
            //    Vehicle v = new Vehicle();

            //    v.getUserId = dreader.GetInt32(0);
            //    v.getBrand = dreader.GetString(1);
            //    v.getOwner = dreader.GetString(2);
            //    v.getPrice = dreader.GetDecimal(3);
            //    // v.getVehType = dreader.GetInt32(4);
            //    //shop.Add(v);

            //    //vt.getVehTyId = dreader.GetInt32(0);
            //    //vt.getVehTy = dreader.GetString(1);
            //  //  parts.Add(vt);




            //  //  vt.getVehTy = dreader.GetString(0);


            //    Console.WriteLine("User id || " + v.getUserId + " " + " Brand || " +v.getBrand + " " + " Owner || " +v.getOwner + " " + " Price || " + v.getPrice
            //        + " " + " Type || ");

            //}


        }
    }
}
