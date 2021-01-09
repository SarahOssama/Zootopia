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

        public DataTable SelectLocations()
        {
            string query= "Select Location_Name From LOCATION;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllHotelName()
        {
            string query = "Select HName from HOTEL;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectProject(string location)
        {
            string query = "SELECT Pname,Dname FROM Department D, Project P, Dept_Locations L"
             +" where P.Dnum=D.Dnumber and L.Dnumber=D.Dnumber and L.Dlocation='"+location+"';"; 
            
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectTrainerInHotel(string HName, int TPriceUp, int TPriceDown, int TRateUp, int TRateDown)
        {
            string query = "Select FName ,LName, T_TotalRate , TPrice from TRAINER, HOTEL  "
             + " Where TRAINER.Hotel_ID=HOTEL.Hotel_ID and HOTEL.HName='" + HName + "' and TPrice>=" + TPriceDown + " and TPrice<=" + TPriceUp + " and T_TotalRate>=" + TRateDown + " and T_TotalRate<=" + TRateUp + ";";

            return dbMan.ExecuteReader(query);
        }

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
