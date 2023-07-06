using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectionSql_Csharp
{
    public class book
    {
        int id;
        string bookname, author;
        decimal price;

        public book()
        {
            id = 0;  //initially value set kelete
            bookname = author = "";
            price = 0.0M;
        }

        public book(string n, string a, decimal p) //user kadun value ghenasati
        {
            bookname = n;    //parameters passed to get set method
            author = a;
            price = p;
        }

        public int bid      //name of get-set method
        {
           
            set { id = value; }
            get { return id; }
        }
        public string bkname
        {
            get { return bookname; }
            set { bookname = value; }
        }
        public string bkauthor
        {
            get { return author; }
            set { author = value; }
        }
        public decimal bkprice
        {
            get { return price; }
            set { price = value; }
        }
    }
    class Sql_Csharp
    {
        static void Main(string[] args)
        {
            book b1 = new book();

            Console.WriteLine("\n\n\t Enter Details of the book");
            Console.Write("\n\n\t Enter name of the book: ");
            b1.bkname = Console.ReadLine();                  
            Console.Write("\n\n\t Enter author of the book: ");
            b1.bkauthor = Console.ReadLine();
            Console.Write("\n\n\t Enter price of the book: ");
            b1.bkprice = decimal.Parse(Console.ReadLine());

           try
            {
                SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(); //its a class used to connection Between C# & sql
                scsb.DataSource = "Komal";      //server name
                scsb.InitialCatalog = "Cs_to_SQL";     //database name
                scsb.IntegratedSecurity = true;        //default value set true
                SqlConnection con = new SqlConnection(scsb.ConnectionString);//It is a class used to queries perform karanasati
                //using sqlConnection class we can store data in database

                //Insert query
                string qry1 = "Insert into books (bookname,author,price)values(@bookname,@author,@price)";
                SqlCommand cmd = new SqlCommand(qry1, con);   //actual parameters passed through cmd 
                cmd.Parameters.AddWithValue("@bookname", b1.bkname);
                cmd.Parameters.AddWithValue("@author", b1.bkauthor);
                cmd.Parameters.AddWithValue("@price", b1.bkprice);

                con.Open();  
                int RowsAffected = cmd.ExecuteNonQuery();//return value & to check actually value passed to database/table or not
                con.Close();

                if(RowsAffected == 1)
                {
                    Console.WriteLine("\n\n\t Record Inserted Successfully.");
                }

                Console.WriteLine("\n\n\t ************************************************************");
                Console.WriteLine("\n\n\t Dislaying all records from Table in SQl Database");
                con.Open();
                string qry2 = "Select * From books";
                SqlCommand cmd2 = new SqlCommand(qry2, con);
                DataSet ds = new DataSet();

                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                sda.Fill(ds, "books");

                int c = ds.Tables.Count;
                con.Close();
                DataTable dt = ds.Tables["books"];
                int count = dt.Rows.Count;

                foreach (DataRow r in dt.Rows)
                {
                    Console.WriteLine("\t {0:D2} {1,-30} {2,-20} {3:0.00}", int.Parse(r["id"].ToString()), r["bookname"].ToString(), r["author"].ToString(), decimal.Parse(r["price"].ToString()));
                }
                Console.WriteLine("\n\n\t *********************************************************");

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
    }
}
