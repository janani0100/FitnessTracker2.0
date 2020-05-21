using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FitnessTracker2._0
{
    public partial class HomePage : Form
    {
        public static string constr1 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection condatabase = new MySqlConnection(constr1);
        int uid = 0;
        public HomePage()
        {
            InitializeComponent();
            FindingUser();
            AddPic();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
        void FindingUser()
        {

            condatabase.Open();
            string Query = "select * from user where name='" + Program.userName + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, condatabase);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    uid = myReader.GetInt32("UserID");
                }
            }
            catch (Exception ex)
            {
                
            }
            condatabase.Close();
        }
        void AddPic()
        {
            MySqlCommand cmd;
            MySqlDataReader myReader;
            decimal cb=0, ci=0, CaloriToBurn=0, gi=0;
            int flag = 0;
            decimal sum = 0, sum1 = 0;
            List<string> list = new List<string>();
            list.Add("welcome");
            list.Add("super");
            list.Add("ok");
            list.Add("bad");
            list.Add("cook");
            list.Add("fitness");
            string Query = "select sum(CaloriesIntake) as CI from dietchart where dietDate=CURDATE() and Userid=" + uid + ";";
            string Query1 = "select sum(CaloriesBurnt) as CB from activitychart where Adate=CURDATE() and Userid=" + uid + "; ";
            try
            {
                condatabase.Open();
                cmd = new MySqlCommand(Query, condatabase);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    ci = myReader.GetDecimal("CI");
                    flag = 1;
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            condatabase.Close();
            try
            {
                condatabase.Open();
                cmd = new MySqlCommand(Query1, condatabase);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    cb = myReader.GetDecimal("CB");
                    flag = 1;               
                }
               
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            condatabase.Close();
            condatabase.Open();
            Query = "select * from user where Userid=" + uid + ";";
            try
            {
                cmd = new MySqlCommand(Query, condatabase);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                     gi = myReader.GetDecimal("GoalCalorieIntake");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            condatabase.Close();
            condatabase.Open();
            Query = " select sum(Actduration*CaloriesPerMin) as CaloriesToBeBurnt from mustdo natural join activitymaster where userid=" + uid + ";";
            try
            {
                cmd = new MySqlCommand(Query, condatabase);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                     CaloriToBurn = myReader.GetDecimal("CaloriesToBeBurnt");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            if(cb<=((CaloriToBurn*25)/100)&&ci<=((gi*25)/100))
            {
                pb.Image= (Bitmap)Properties.Resources.ResourceManager.GetObject(list[3]);
            }
            else if((cb<=( (CaloriToBurn * 25) / 100) && ci>((gi*25)/100)) || (cb> (CaloriToBurn * 25) / 100 && ci<=((gi*25)/100)))
            {
                pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(list[2]);
            }
            else if(cb>=((CaloriToBurn*75)/100) && ci>=((gi*75)/100))
            {
                pb.Image= (Bitmap)Properties.Resources.ResourceManager.GetObject(list[1]);
            }
            else
            {
                pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(list[2]);
            }
            pic.Text = "About Today";
            if (flag == 0)
            {
                pic.Text = "Welcome To Fitness Traker";
                pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(list[0]);
            }
            else
            {
                if(cb>ci)
                {
                    AboutYouLabel.Text = "Fitness Freak";
                    AboutYouPic.Image= (Bitmap)Properties.Resources.ResourceManager.GetObject(list[5]);
                }
                else
                {
                    AboutYouLabel.Text = "Foody";
                    AboutYouPic.Image= (Bitmap)Properties.Resources.ResourceManager.GetObject(list[4]);
                 

                }
            }


        }

        private void pic1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}


