using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
//added
using System.Data;
using BusinessLogicLayer;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }



        // how I intend to convert my code
        // So all DATA have to be passed through ToDatatable AppUtil class method

        //option1 (return full dt) 
        //
        // if is a list of elements use this method (how it was designed to be used)

        //option2  (return dt limited to 1 row)
        //
        // create a list consisting of only 1 item and still pass it though.
        // make adjustments in the UI code to account for the data returning to be of type list<elementClass>

        //option 3  (return bool)
        //
        // returns bool 
        // return dt with list of IdAndValue       (it will store the same information twice once as int and once as string)
        // id int value will be:     -1 or 0       
        // value string will be:     false or true


        //option 4  (return String Array)
        // Captures  ---->  string[] strArr = new string[] { "false", "error message" };
        //
        // return dt with list of IdAndValue 
        // id int value will be:     -1 or 0  (boolean)  
        // value string will be:     ( error / success message)
        // -1 == false 
        // 0 == true

        //option5     (return int)
        //
        // return dt with list of IdAndValue    (only using the int ID field)
        // id int value will be:     intValue  (most likely id value or -1 for error)  
        // value string will be:     "undefined"
        // -1 == false 
        // 0 == true


        //option1
        // if is a list of elements use this method (how it was designed to be used)
        [WebMethod]
        public DataTable GetListOfUsers()
        {

            UserLogic userLogic = new UserLogic();
            List<User> users = userLogic.getAllUsers();

            //convert our list to a datatable and return it
            return AppUtil.ToDataTable(users); //returns this in the form of xml to be sent via the internet or local network

        }


        //option 2
        // create a list consisting of only 1 item and still pass it though.
        // make adjustments in the UI code to account for the data returning to be of type list<elementClass>
        [WebMethod]
        public DataTable userLogin(string username, string password)
        {
            UserLogic userLogic = new UserLogic();
            User user = userLogic.userLogin(username, password);

            //sneaky list user of 1 user
            List<User> userList = new List<User>();
            userList.Add(user);

            return AppUtil.ToDataTable(userList);

        }


        //option 3
        // returns bool 
        // return dt with list of IdAndValue       (it will store the same information twice once as int and once as string)
        // id int value will be:     -1 or 0       
        // value string will be:     false or true
        // -1 == false 
        // 0 == true
        [WebMethod]
        public DataTable insertNewUser(string username, string email, string password, int userLevel)
        {
            UserLogic userLogic = new UserLogic();
            bool result = userLogic.insertNewUser(username, email, password, userLevel);

            IdAndValue x = createBoolIdAndValue(result);
            
            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }




        //option 4
        // Captures  ---->  string[] strArr = new string[] { "false", "error message" };
        //
        // return dt with list of IdAndValue       (it will store the same information twice once as int and once as string)
        // id int value will be:     -1 or 0  (boolean)  
        // value string will be:     ( error / success message)
        // -1 == false 
        // 0 == true

        [WebMethod]
        public DataTable deleteMediaById(int mediaId)
        {

            MediaLogic mediaLogic = new MediaLogic();
            string[] resultArr = mediaLogic.deleteMediabyId(mediaId);

            IdAndValue x = createStrArrIdAndValue(resultArr);
            
            
            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }




        //option5     (return int)
        //
        // return dt with list of IdAndValue    (only using the int ID field)
        // id int value will be:     intValue  (most likely id value or -1 for error)  
        // value string will be:     "left undefined at web method"
        // -1 == false 
        // 0 == true
        [WebMethod]
        public DataTable getDirectorIdByName(string directorName)
        {

            MediaLogic mediaLogic = new MediaLogic();
            int result = mediaLogic.getDirectorIdByName(directorName);

            IdAndValue x = new IdAndValue(result, "left undefined at WebMethod");


            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }





        // functions ------

        public IdAndValue createBoolIdAndValue(bool result)
        {
            IdAndValue temp;
            if (result)
            {
                temp = new IdAndValue(0, "true");
            }
            else
            {
                temp = new IdAndValue(-1, "false");
            }

            return temp;
        }



        public IdAndValue createStrArrIdAndValue(string[] strArr)
        {
            IdAndValue temp;
            if (strArr[0] == "true")
            {
                temp = new IdAndValue(0, strArr[1]);
            }
            else
            {
                temp = new IdAndValue(-1, strArr[1]);
            }

            return temp;
        }

        





        // --------------- going to setup up all methods based off of the 2 options above --------------

        //User Logic --------------------------------------
        //-------------------------------------------------

        [WebMethod]
        public DataTable getUserById(int userId)
        {
            UserLogic userLogic = new UserLogic();
            User user = userLogic.getUserById(userId);

            //sneaky list user of 1 user
            List<User> userList = new List<User>();
            userList.Add(user);

            return AppUtil.ToDataTable(userList);

        }



        [WebMethod]
        public DataTable updateUserAll(int userId, string username, string email, string password, int userLevel)
        {
            UserLogic userLogic = new UserLogic();
            bool result = userLogic.updateUserAll(userId, username, email,password, userLevel);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }



        [WebMethod]
        public DataTable updateUserPassword(int userId, string newPassword)
        {
            UserLogic userLogic = new UserLogic();
            bool result = userLogic.updateUserPassword(userId, newPassword);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }


        [WebMethod]
        public DataTable deleteUser(int userId)
        {
            UserLogic userLogic = new UserLogic();
            bool result = userLogic.deleteUser(userId);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }




        //-----------------------------------------------------------------------
        //-- Reserved Logic -----------------------------------------------------

        [WebMethod]
        public DataTable getAllReserved()
        {

            ReservedLogic reserveLogic = new ReservedLogic();
            List<Reserve> resList = reserveLogic.getAllReserved();

            //convert our list to a datatable and return it
            return AppUtil.ToDataTable(resList); //returns this in the form of xml to be sent via the internet or local network

        }



        [WebMethod]
        public DataTable getReservedActive(int userId)
        {

            ReservedLogic reserveLogic = new ReservedLogic();
            List<Reserve> resList = reserveLogic.getReservedActive(userId);

            return AppUtil.ToDataTable(resList); 

        }


        
        [WebMethod]
        public DataTable getMediaExists(int mediaId)
        {

            ReservedLogic reserveLogic = new ReservedLogic();
            bool result = reserveLogic.getMediaExists(mediaId);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }


        [WebMethod]
        public DataTable insertNewReservation(int userId, int mediaId,string dateMonthDayYear)
        {

            ReservedLogic reserveLogic = new ReservedLogic();
            bool result = reserveLogic.insertNewReservation(userId,mediaId,dateMonthDayYear);

            IdAndValue x = createBoolIdAndValue(result);


            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }




        [WebMethod]
        public DataTable deleteReservation(int reservationId)
        {

            ReservedLogic reserveLogic = new ReservedLogic();
            bool result = reserveLogic.deleteReservation(reservationId);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }







        //-----------------------------------------------------------------------
        //-- Media Logic --------------------------------------------------------



        [WebMethod]
        public DataTable getAllMedia()
        {

            MediaLogic mediaLogic = new MediaLogic();
            List<Media> mediaList = mediaLogic.getAllMedia();

            return AppUtil.ToDataTable(mediaList); 

        }

        [WebMethod]
        public DataTable getMediaByTitle(string title)
        {

            MediaLogic mediaLogic = new MediaLogic();
            List<Media> mediaList = mediaLogic.getMediaByTitle(title);

            return AppUtil.ToDataTable(mediaList);

        }


        [WebMethod]
        public DataTable getMediaByYear(int year)
        {

            MediaLogic mediaLogic = new MediaLogic();
            List<Media> mediaList = mediaLogic.getMediaByYear(year);

            return AppUtil.ToDataTable(mediaList); 
        }


        [WebMethod]
        public DataTable getMediaByGenre(string genreName)
        {

            MediaLogic mediaLogic = new MediaLogic();
            List<Media> mediaList = mediaLogic.getMediaByGenre(genreName);


            return AppUtil.ToDataTable(mediaList); 

        }



        [WebMethod]
        public DataTable insertNewMedia(string title, string genre, string director, string language, int publishYear, int budget)
        {

            MediaLogic mediaLogic = new MediaLogic();
            string[] resultArr = mediaLogic.insertNewMedia(title,genre,director,language,publishYear,budget);

            IdAndValue x = createStrArrIdAndValue(resultArr);


            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }


        [WebMethod]
        public DataTable updateMedia(int id, string title, string genre, string director, string language, int publishYear, int budget)
        {

            MediaLogic mediaLogic = new MediaLogic();
            string[] resultArr = mediaLogic.updateMedia(id, title, genre, director, language, publishYear, budget);

            IdAndValue x = createStrArrIdAndValue(resultArr);


            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }





        // director --------------------------
        //------------------------------------

        [WebMethod]
        public DataTable getAllDirectorTable()
        {

            MediaLogic mediaLogic = new MediaLogic();
            List<IdAndValue> idVal = mediaLogic.getAllDirectorTable();

            return AppUtil.ToDataTable(idVal);
        }



        [WebMethod]
        public DataTable deleteDirectorById(int dirId)
        {

            MediaLogic mediaLogic = new MediaLogic();
            string[] resultArr = mediaLogic.deleteDirectorbyId(dirId);

            IdAndValue x = createStrArrIdAndValue(resultArr);


            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }

        [WebMethod]
        public DataTable insertNewDirector(string directorName)
        {
            MediaLogic mediaLogic = new MediaLogic();
            bool result = mediaLogic.insertNewDirector(directorName);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }


        [WebMethod]
        public DataTable getDirectorExists(int dirId)
        {
            MediaLogic mediaLogic = new MediaLogic();
            bool result = mediaLogic.getDirectorExists(dirId);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }













        // language --------------------------
        //------------------------------------

        [WebMethod]
        public DataTable getLanguageExists(int langId)
        {
            MediaLogic mediaLogic = new MediaLogic();
            bool result = mediaLogic.getLanguageExists(langId);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }

        [WebMethod]
        public DataTable GetAllLanguageTable()
        {

            MediaLogic mediaLogic = new MediaLogic();
            List<IdAndValue> idVal = mediaLogic.getAllLanguageTable();


            return AppUtil.ToDataTable(idVal);

        }

        [WebMethod]
        public DataTable getLanguageIdByName(string langName)
        {

            MediaLogic mediaLogic = new MediaLogic();
            int result = mediaLogic.getLanguageIdByName(langName);

            IdAndValue x = new IdAndValue(result, "left undefined at WebMethod");


            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }



        [WebMethod]
        public DataTable insertNewLanguage(string languageName)
        {
            MediaLogic mediaLogic = new MediaLogic();
            bool result = mediaLogic.insertNewLanguage(languageName);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }

        [WebMethod]
        public DataTable deleteLanguageById(int langId)
        {

            MediaLogic mediaLogic = new MediaLogic();
            string[] resultArr = mediaLogic.deleteLanguagebyId(langId);

            IdAndValue x = createStrArrIdAndValue(resultArr);


            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }












        // genre -----------------------------
        //------------------------------------

        [WebMethod]
        public DataTable getGenreExists(int genreId)
        {
            MediaLogic mediaLogic = new MediaLogic();
            bool result = mediaLogic.getGenreExists(genreId);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }


        [WebMethod]
        public DataTable GetAllGenreTable()
        {

            MediaLogic mediaLogic = new MediaLogic();
            List<IdAndValue> idVal = mediaLogic.getAllGenreTable();


            return AppUtil.ToDataTable(idVal);

        }



        [WebMethod]
        public DataTable getGenreIdByName(string genreName)
        {

            MediaLogic mediaLogic = new MediaLogic();
            int result = mediaLogic.getGenreIdByName(genreName);

            IdAndValue x = new IdAndValue(result, "left undefined at WebMethod");


            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }


        [WebMethod]
        public DataTable insertNewGenre(string genreName)
        {
            MediaLogic mediaLogic = new MediaLogic();
            bool result = mediaLogic.insertNewGenre(genreName);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }


        [WebMethod]
        public DataTable deleteGenreById(int genId)
        {

            MediaLogic mediaLogic = new MediaLogic();
            string[] resultArr = mediaLogic.deleteGenrebyId(genId);

            IdAndValue x = createStrArrIdAndValue(resultArr);


            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }












        //Borrow Logic --------------------------------------
        //---------------------------------------------------



        [WebMethod]
        public DataTable GetAllReserved()
        {

            BorrowLogic borrowLogic = new BorrowLogic();
            List<Borrow> borrowList = borrowLogic.getAllReserved();


            return AppUtil.ToDataTable(borrowList);

        }


        [WebMethod]
        public DataTable GetByUserForActiveLateFees(int userId)
        {

            BorrowLogic borrowLogic = new BorrowLogic();
            List<Borrow> borrowList = borrowLogic.getByUserForActiveLateFees(userId);


            return AppUtil.ToDataTable(borrowList);

        }



        [WebMethod]
        public DataTable GetByUserForUserHistory(int userId)
        {

            BorrowLogic borrowLogic = new BorrowLogic();
            List<Borrow> borrowList = borrowLogic.getByUserForUserHistory(userId);


            return AppUtil.ToDataTable(borrowList);

        }



        [WebMethod]
        public DataTable GetByUserForUserActivity(int userId)
        {

            BorrowLogic borrowLogic = new BorrowLogic();
            List<Borrow> borrowList = borrowLogic.getByUserForUserActivity(userId);


            return AppUtil.ToDataTable(borrowList);

        }



        [WebMethod]
        public DataTable getIsMediaAvailable(int mediaId)
        {
            BorrowLogic borrowLogic = new BorrowLogic();
            bool result = borrowLogic.getIsMediaAvailable(mediaId);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }


        [WebMethod]
        public DataTable getMediaExistsBorrowLogic(int mediaId)
        {
            BorrowLogic borrowLogic = new BorrowLogic();
            bool result = borrowLogic.getMediaExists(mediaId);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }




        [WebMethod]
        public DataTable insertForCheckOutMedia(int userId, int mediaId)
        {
            BorrowLogic borrowLogic = new BorrowLogic();
            bool result = borrowLogic.insertForCheckOutMedia(userId, mediaId);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }



        [WebMethod]
        public DataTable updateMediaForReturn(int borrowId, int lateFee)
        {
            BorrowLogic borrowLogic = new BorrowLogic();
            bool result = borrowLogic.updateMediaForReturn(borrowId, lateFee);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }


        [WebMethod]
        public DataTable updateMediaPayLateFee(int borrowId)
        {
            BorrowLogic borrowLogic = new BorrowLogic();
            bool result = borrowLogic.updateMediaPayLateFee(borrowId);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }


        [WebMethod]
        public DataTable deleteBorrowItem(int borrowId)
        {
            BorrowLogic borrowLogic = new BorrowLogic();
            bool result = borrowLogic.deleteBorrowItem(borrowId);

            IdAndValue x = createBoolIdAndValue(result);

            //sneaky list IdAndValue of 1 item
            List<IdAndValue> idValList = new List<IdAndValue>();

            idValList.Add(x);

            return AppUtil.ToDataTable(idValList);

        }

























    }
}
