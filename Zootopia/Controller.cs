using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Zootopia
{
    public class Controller
    {
        //Sara
        //sandy Sara
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public DataTable SelectAllTrainers()
        {
            string query = "SELECT * FROM TRAINER;";
            return dbMan.ExecuteReader(query);
        }


        public int InsertProject(string Pname, int pnumber, string Plocation, int Dnum)
        {
            string query = "INSERT INTO Project (Pname, Pnumber, Plocation, Dnum)" +
                            "Values ('" + Pname + "'," + pnumber + ",'" + Plocation + "'," + Dnum + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertHotel(string hotelname,int phonenum, int num_room, float price, string username,int locID )
        {
            string query = "INSERT INTO HOTEL (HName, HPrice, Num_Rooms, HotelPhoneNum, Username, Location_ID)" +
                "Values ('" + hotelname + ",'" + price + ",'" + num_room + ",'" + phonenum + ",'" + username + ",'" + locID + "');";

            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertPetShop(string Pshop_Name,int PShopPhoneNum,string Username,int Location_ID)
        {
            string query = "INSERT INTO PETSHOP (Pshop_Name, PShopPhoneNum, Username, Location_ID)"+
                "Values ('"+ Pshop_Name+ ",'" + PShopPhoneNum+ ",'" + Username + ",'" + Location_ID + "');";
            return dbMan.ExecuteNonQuery(query);

        }
        public int InsertVet(string Vet_Name,float Vet_Price,int VetPhonenum, string Username, int Location_ID)
        {
            string query = "INSERT INTO VET (Vet_Name, Vet_Price, VetPhonenum, Username, Location_ID)"+
                "Values ('"+ Vet_Name + ",'" + Vet_Price + ",'" + VetPhonenum + ",'" + Username + ",'" + Location_ID +"');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertPetOwner(int OPhoneNum, string Fname, string Lname, string Username, int Location_ID)
        {
            string query = "INSERT INTO OWNER(OPhoneNum, Fname, Lname, Username, Location_ID)"+
                "Values ('" + OPhoneNum + ",'" + Fname + ",'" + Lname + ",'" + Username + ",'" + Location_ID+"');";

            return dbMan.ExecuteNonQuery(query);
        }


        public int InsertLocation(string locname)
        {
            string query = "INSERT INTO LOCATION (Location_Name)" +
                "Values ('" + locname + "');";

            return dbMan.ExecuteNonQuery(query);
        }
        public int SelectLocID(string locname)
        {
            string query = "SELECT location_ID FROM LOCATION where Location_Name = '" + locname + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable SelectUsername(string username)
        {
            string query = "SELECT Username FROM LOGIN where Username like '___"+username+"';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPasswordByUsername(string username)
        {
            string query = "SELECT Password FROM LOGIN where Username ='"+ username + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectLocations()
        {
            string query= "Select Location_ID ,Location_Name From LOCATION;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllHotelName()
        {
            string query = "Select HName from HOTEL;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAdminPass(string admp)
        {
            string query = "Select Pass_Admin FROM ADMINPASS where Pass_Admin ='"+admp+"';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllAdmins()
        {
            string query = "Select Pass_Admin FROM ADMINPASS ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectHotelRates()
        {
            string query = "Select Hotel_ID, H_TotalRate, HName FROM HOTEL;";
            return dbMan.ExecuteReader(query);
        }
        public int InsertAdminPass(string admp)
        {
            string query = "INSERT INTO ADMINPASS (Pass_Admin)" +
                "Values ('" + admp + "');";

            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateAdminPass(string admp,string newpass)
        {
            string query = "UPDATE ADMINPASS Set Pass_Admin ='"+newpass+"'where Pass_Admin='"+admp+"';";

            return dbMan.ExecuteNonQuery(query);
        }
       

        public int DeleteAdminPass(string admp)
        {
            string query = "DELETE FROM ADMINPASS where Pass_Admin ='"+admp +"';";

            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectProject(string location)
        {
            string query = "SELECT Pname,Dname FROM Department D, Project P, Dept_Locations L"
             +" where P.Dnum=D.Dnumber and L.Dnumber=D.Dnumber and L.Dlocation='"+location+"';"; 
            
            return dbMan.ExecuteReader(query);
        }


        #region HireTrainer

        public int HireTrainer(int Tnum, int HotelID, int PetID)
        {
            string query = "insert into Trained (Tnum,Hotel_ID,Pet_ID) " +
                            "Values (" + Tnum + "," + HotelID + ",'" + PetID + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectTrainerName(string HotelName)
        {
            string query = "Select FName,LName from trainer,Hotel where HOTEL.Hotel_ID=TRAINER.Hotel_ID and HOTEL.HName='" + HotelName + "';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPetNametoTrain(string OwnerUsername)
        {
            string query = "Select PName from OWNER,PET where Owner.Owner_ID = PET.Owner_ID and Owner.Username='OW-" + OwnerUsername + "';";
            return dbMan.ExecuteReader(query);
        }

        public int SelectTrainerNumberToHire(string HotelName, string TName)
        {
            string query = "Select Tnum from trainer,Hotel where HOTEL.Hotel_ID=TRAINER.Hotel_ID and HOTEL.HName='" + HotelName + "'and FName='" + TName + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int SelectHotelIDToHire(string HotelName)
        {
            string query = "Select Hotel_ID from HOTEL where HName='" + HotelName + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int SelectPetIDToHire(string OwnerUsername, string PName)
        {
            string query = "Select Pet_ID from OWNER,PET where Owner.Owner_ID = PET.Owner_ID and Owner.Username=OW-'" + OwnerUsername + "' and PName='" + PName + "';";
            return (int)dbMan.ExecuteScalar(query);
        }


        public DataTable SelectTrainerInHotel(string HName, int TPriceUp, int TPriceDown, int TRateUp, int TRateDown)
        {
            string query = "Select FName ,LName, T_TotalRate , TPrice from TRAINER, HOTEL  "
             + " Where TRAINER.Hotel_ID=HOTEL.Hotel_ID and HOTEL.HName='" + HName + "' and TPrice>=" + TPriceDown + " and TPrice<=" + TPriceUp + " and T_TotalRate>=" + TRateDown + " and T_TotalRate<=" + TRateUp + ";";

            return dbMan.ExecuteReader(query);
        }
        #endregion


        #region OwnerSearch
        public DataTable SearchHotel(string HLocation, int HPriceUp, int HPriceDown, int HRateUp, int HRateDown)
        {

            string StoredProcedureName = StoredProcedures.SearchHotelProc;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Hlocation", HLocation);
            Parameters.Add("@HPriceUp", HPriceUp);
            Parameters.Add("@HPriceDown", HPriceDown);
            Parameters.Add("@HRateUp", HRateUp);
            Parameters.Add("@HRateDown", HRateDown);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

            //string query = "Select HName, HotelPhoneNum,HPrice from HOTEL, LOCATION "
            // + " where Hotel.Location_ID=LOCATION.Location_ID and LOCATION.Location_Name='"+ HLocation + "' and HPrice>=" + HPriceDown + " and HPrice<=" + HPriceUp + " and H_TotalRate>=" + HRateDown + " and H_TotalRate<=" + HRateUp + ";";

            //return dbMan.ExecuteReader(query);
        }


        public DataTable SearchPetShop(string PSLocation)
        {

            //string StoredProcedureName = StoredProcedures.SearchPetShopProc;
            //Dictionary<string, object> Parameters = new Dictionary<string, object>();
            //Parameters.Add("@PSLocation", PSLocation);
            //Parameters.Add("@PSPriceUp", PSPriceUp);
            //Parameters.Add("@PSPriceDown", PSPriceDown);
            //Parameters.Add("@PSRateUp", PSRateUp);
            //Parameters.Add("@PSRateDown", PSRateDown);
            //return dbMan.ExecuteReader(StoredProcedureName, Parameters);

            string query = "Select Pshop_Name, PShopPhoneNum from PETSHOP, LOCATION "
             + " where PETSHOP.Location_ID=LOCATION.Location_ID and LOCATION.Location_Name='" + PSLocation+ "';";

            return dbMan.ExecuteReader(query);
        }

        public DataTable SearchVet(string VLocation, int VPriceUp, int VPriceDown, int VRateUp, int VRateDown)
        {

            //string StoredProcedureName = StoredProcedures.SearchHotelProc;
            //Dictionary<string, object> Parameters = new Dictionary<string, object>();
            //Parameters.Add("@Hlocation", VLocation);
            //Parameters.Add("@HPriceUp", VPriceUp);
            //Parameters.Add("@HPriceDown", VPriceDown);
            //Parameters.Add("@HRateUp", VRateUp);
            //Parameters.Add("@HRateDown", VRateDown);
            //return dbMan.ExecuteReader(StoredProcedureName, Parameters);

            string query = "Select Vet_Name, VetPhoneNum,Vet_Price from VET, LOCATION  "
             + " where VET.Location_ID=LOCATION.Location_ID and LOCATION.Location_Name='" + VLocation + "' and Vet_Price>=" + VPriceDown + " and Vet_Price<=" + VPriceUp + " and V_TotalRate>=" + VRateDown + " and V_TotalRate<=" + VRateUp + ";";

            return dbMan.ExecuteReader(query);
        }
        #endregion
    }
}
