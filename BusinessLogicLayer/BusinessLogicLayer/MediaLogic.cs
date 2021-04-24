using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;

namespace BusinessLogicLayer
{
    public class MediaLogic
    {


        private MediaDAO mediaDAO;
        private BorrowLogic borrowLogic;
        private ReservedLogic reservedLogic;

        public MediaLogic()
        {
            mediaDAO = new MediaDAO();
            borrowLogic = new BorrowLogic();
            reservedLogic = new ReservedLogic();
        }



        public List<Media> getAllMedia()
        {
            List<Media> myList = new List<Media>();

            MediaDS.ViewMediaDataTable myData = mediaDAO.getAllMediaView();

            //parse data from datatable rows to list elements
            myList = parseMediaDataTolistAll(myData);

            return myList;

        }

        public List<Media> getMediaByTitle(String title)
        {
            List<Media> myList = new List<Media>();

            MediaDS.ViewMediaDataTable myData = mediaDAO.getMediaByTitle(title);

            //parse data from datatable rows to list elements
            myList = parseMediaDataTolistAll(myData);

            return myList;

        }

        public List<Media> getMediaByYear(int year)
        {
            
            List<Media> myList = new List<Media>();

            MediaDS.ViewMediaDataTable myData = mediaDAO.getMediaByYear(year);

            //parse data from datatable rows to list elements
            myList = parseMediaDataTolistAll(myData);


            return myList;

        }


        public List<Media> getMediaByGenre(String genreName)
        {
            List<Media> myList = new List<Media>();

            MediaDS.ViewMediaDataTable myData = mediaDAO.getMediaByGenreName(genreName);

            //parse data from datatable rows to list elements
            myList = parseMediaDataTolistAll(myData);

            return myList;

        }



        public string[] deleteMediabyId(int id)
        {
            string[] strArr = new string[] { "false", "error message" };

            //check if id exist in borrow
            bool result = borrowLogic.getMediaExists(id);
            if(result)
            {
                strArr[0] = "false";
                strArr[1] = "item exists in the Borrow DB Table as historic/current data.";
                return strArr;
            }

            //check if id exists in reserve
            result = reservedLogic.getMediaExists(id);
            if(result)
            {
                strArr[0] = "false";
                strArr[1] = "item exists in the Reserved DB Table table as historic/current data.";

                return strArr;
            }

            //try delete 
            result = mediaDAO.deleteMediaById(id);
            if (result)
            {
                strArr[0] = "true";
                strArr[1] = "successfully deleted media item";
            }
            else
            {
                strArr[0] = "false";
                strArr[1] = "error deleting from media table.";
            }

            return strArr;

        }




        public string[] insertNewMedia(string title, string genre, string director, string language, int publishYear, int budget)
        {
            //going to return an string array 
            //   index 0 == "boolean on if was successfull"
            //   index 1 == "error message"
            string[] resultArr= new string[] {"false","error message"};

            //given director, language and genre are their own tables check to see if the given value
            // alerady exists for each table

            // How below method works
            // method return -1 if result in rows is null and id if given value already exists (should only ever be one of each row)


            //check director and convert to id
            int dirId = getDirectorIdByName(director);
            if (dirId == -1)
            {
                //director is new could not find in db
                if (insertNewDirector(director)) //if worked
                {
                    dirId = getDirectorIdByName(director);
                }
                else
                {
                    //could not create a new director field
                    resultArr[0] = "false";
                    resultArr[1] = "Error Could not create a new Director field with: " + director;
                    return resultArr;
                }
            }

            //rinse and repeat for language and genre (check/convert)
            int langId = getLanguageIdByName(language);
            if (langId == -1)
            {
                if (insertNewLanguage(language))
                {
                    langId = getLanguageIdByName(language);
                }
                else
                {
                    resultArr[0] = "false";
                    resultArr[1] = "Error Could not create a new Language field with: " + language;
                    return resultArr;
                }
            }

            //rinse and repeat for language and genre (check/convert)
            int genId = getGenreIdByName(genre);
            if (genId == -1)
            {
                if (insertNewGenre(genre))
                {
                    genId = getGenreIdByName(genre);
                }
                else
                {
                    resultArr[0] = "false";
                    resultArr[1] = "Error Could not create a new Genre field with: " + genre;
                    return resultArr;
                }
            }




            // add new media item 
            bool insertResult = mediaDAO.insertNewMedia(title, genId, dirId, langId, publishYear, budget);

            if (insertResult)
            {
                resultArr[0] = "true";
                return resultArr;
            }
            else
            {
                resultArr[0] = "false";
                resultArr[1] = "Error on insert of new media";
                return resultArr;
            }



        }


        public string[] updateMedia(int id, string title, string genre, string director, string language, int publishYear, int budget)
        {

            // same setup as insertNewMedia method but now has id for media item aswell
            // NOTE: i better document what happens here in the insertNewMedia method 
         
            string[] resultArr = new string[] { "false", "error message" };

           
            //check director and convert to id
            int dirId = getDirectorIdByName(director);
            if (dirId == -1)
            {
                //director is new could not find in db
                if (insertNewDirector(director)) //if worked
                {
                    dirId = getDirectorIdByName(director);
                }
                else
                {
                    //could not create a new director field
                    resultArr[0] = "false";
                    resultArr[1] = "Error Could not create a new Director field with: " + director;
                    return resultArr;
                }
            }

            //rinse and repeat for language and genre (check/convert)
            int langId = getLanguageIdByName(language);
            if (langId == -1)
            {
                if (insertNewLanguage(language))
                {
                    langId = getLanguageIdByName(language);
                }
                else
                {
                    resultArr[0] = "false";
                    resultArr[1] = "Error Could not create a new Language field with: " + language;
                    return resultArr;
                }
            }

            //rinse and repeat for language and genre (check/convert)
            int genId = getGenreIdByName(genre);
            if (genId == -1)
            {
                if (insertNewGenre(genre))
                {
                    genId = getGenreIdByName(genre);
                }
                else
                {
                    resultArr[0] = "false";
                    resultArr[1] = "Error Could not create a new Genre field with: " + genre;
                    return resultArr;
                }
            }

            // update media item 
            bool insertResult = mediaDAO.updateMedia(id, title, genId, dirId, langId, publishYear, budget);

            if (insertResult)
            {
                resultArr[0] = "true";
                return resultArr;
            }
            else
            {
                resultArr[0] = "false";
                resultArr[1] = "Error on insert of new media";
                return resultArr;
            }

        }






        //Director tabel
        public List<IdAndValue> getAllDirectorTable()
        {
            List<IdAndValue> myList = new List<IdAndValue>();

            MediaDS.TabDirectorDataTable myData = mediaDAO.getAllDirectors();

            //parse data from datatable rows to list elements
            myList = parseDirectorDataTolist(myData);

            return myList;
        }

        public int getDirectorIdByName(string directorName)
        {
            //get data from DAO
            MediaDS.TabDirectorDataTable myData = mediaDAO.getDirectorByName(directorName);

            int recievedId = -1;

            foreach (MediaDS.TabDirectorRow row in myData.Rows) //should only result to one row
            {

                if (row != null)
                {
                    recievedId = row.DID;
                }

            }

            return recievedId; //if is -1 their is an error
        }

        public bool insertNewDirector(string directorName)
        {
            bool checker = mediaDAO.insertNewDirector(directorName);
            return checker;
        }

        public string[] deleteDirectorbyId(int id)
        {

            string[] strArr = new string[] { "false", "error message" };

            //check if id exist in media table
            bool result = getDirectorExists(id);
            if (result)
            {
                strArr[0] = "false";
                strArr[1] = "Director ID exists in the Media DB Table as historic/current data.";
                return strArr;
            }


            //try delete 
            result = mediaDAO.deleteDirectorById(id);
            if (result)
            {
                strArr[0] = "true";
                strArr[1] = "successfully deleted Director item";
            }
            else
            {
                strArr[0] = "false";
                strArr[1] = "error deleting from Director table.";
            }

            return strArr;

        }



        //checking if fields exists within tab media
        public bool getLanguageExists(int languageId)
        {
            List<TabMedia> myList = new List<TabMedia>();

            MediaDS.TabMediaDataTable myData = mediaDAO.getLanguageExists(languageId);

            //parse data from datatable rows to list elements
            myList = parseTabMediaDataTolistAll(myData);

            // results list count == 0
            if (myList.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

       

        public bool getGenreExists(int genreId)
        {
            List<TabMedia> myList = new List<TabMedia>();

            MediaDS.TabMediaDataTable myData = mediaDAO.getGenreExists(genreId);

            //parse data from datatable rows to list elements
            myList = parseTabMediaDataTolistAll(myData);

            // results list count == 0
            if (myList.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool getDirectorExists(int directorId)
        {
            List<TabMedia> myList = new List<TabMedia>();

            MediaDS.TabMediaDataTable myData = mediaDAO.getDirectorExists(directorId);

            //parse data from datatable rows to list elements
            myList = parseTabMediaDataTolistAll(myData);

            // results list count == 0
            if (myList.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }





        //Genre tabel ---------------------
        public List<IdAndValue> getAllGenreTable()
        {
            List<IdAndValue> myList = new List<IdAndValue>();

            MediaDS.TabGenreDataTable myData = mediaDAO.getAllGenre();

            //parse data from datatable rows to list elements
            myList = parseGenreDataTolist(myData);

            return myList;
        }


        


        public int getGenreIdByName(string genreName)
        {
            //get data from DAO
            MediaDS.TabGenreDataTable myData = mediaDAO.getGenreByName(genreName);

            int recievedId = -1;

            foreach (MediaDS.TabGenreRow row in myData.Rows) //should only result to one row
            {

                if (row != null)
                {
                    recievedId = row.GID;
                }

            }

            return recievedId; //if is -1 their is an error
        }

        public bool insertNewGenre(string genreName)
        {
            bool checker = mediaDAO.insertNewGenre(genreName);
            return checker;
        }

        public string[] deleteGenrebyId(int id)
        {
            string[] strArr = new string[] { "false", "error message" };

            //check if id exist in media table
            bool result = getGenreExists(id);
            if (result)
            {
                strArr[0] = "false";
                strArr[1] = "Genre ID exists in the Media DB Table as historic/current data.";
                return strArr;
            }


            //try delete 
            result = mediaDAO.deleteGenreById(id);
            if (result)
            {
                strArr[0] = "true";
                strArr[1] = "successfully deleted Genre item";
            }
            else
            {
                strArr[0] = "false";
                strArr[1] = "error deleting from Genre table.";
            }

            return strArr;
        }



        //Language tabel
        public List<IdAndValue> getAllLanguageTable()
        {
            List<IdAndValue> myList = new List<IdAndValue>();

            MediaDS.TabLanguageDataTable myData = mediaDAO.getAllLanguages();

            //parse data from datatable rows to list elements
            myList = parseLanguageDataTolist(myData);

            return myList;
        }


        public int getLanguageIdByName(string languageName)
        {
            //get data from DAO
            MediaDS.TabLanguageDataTable myData = mediaDAO.getLanguageByName(languageName);

            int recievedId = -1;

            foreach (MediaDS.TabLanguageRow row in myData.Rows) //should only result to one row
            {

                if (row != null)
                {
                    recievedId = row.LID;
                }

            }

            return recievedId; //if is -1 their is an error
        }


        public bool insertNewLanguage(string languageName)
        {
            bool checker = mediaDAO.insertNewLanguage(languageName);
            return checker;
        }

        public string[] deleteLanguagebyId(int id)
        {
            string[] strArr = new string[] { "false", "error message" };

            //check if id exist in media table
            bool result = getLanguageExists(id);
            if (result)
            {
                strArr[0] = "false";
                strArr[1] = "language id exists in the media DB Table as historic/current data.";
                return strArr;
            }


            //try delete 
            result = mediaDAO.deleteLanguageById(id);
            if (result)
            {
                strArr[0] = "true";
                strArr[1] = "successfully deleted language item";
            }
            else
            {
                strArr[0] = "false";
                strArr[1] = "error deleting from Language table.";
            }

            return strArr;
        }










        //functions ---------

        private List<TabMedia> parseTabMediaDataTolistAll(MediaDS.TabMediaDataTable myData)
        {

            List<TabMedia> mediaList = new List<TabMedia>();

            foreach (MediaDS.TabMediaRow row in myData.Rows)
            {

                if (row == null)
                {
                    return null;
                }
                else
                {
                    TabMedia mTabItem = new TabMedia(row.MediaID,row.Title,row.PublishYear,row.Budget,row.Genre,row.Director,row.Language);
                    mediaList.Add(mTabItem);
                }

            }

            return mediaList;
        }

        public List<Media> parseMediaDataTolistAll(MediaDS.ViewMediaDataTable myDataTable)
        {
            List<Media> mediaList = new List<Media>();

            foreach (MediaDS.ViewMediaRow row in myDataTable.Rows)
            //foreach (UserDS.TabUserRow row in myDataTable.Rows)
            {

                if (row == null)
                {
                    return null;
                }
                else
                {
                    Media mItem = new Media(row.MediaID, row.Title, row.GenreName, row.DirectorName, row.LanguageName, row.PublishYear, row.Budget, row.Genre, row.Director, row.Language);
                    //Media mItemNoFk = new Media(row.MediaID, row.Title, row.GenreName, row.DirectorName, row.LanguageName, row.PublishYear);
                    mediaList.Add(mItem);
                }

            }

            return mediaList;

        }



        //Parse genre director and language tables usign IdAndValueClass
        //tableDirector
        public List<IdAndValue> parseDirectorDataTolist(MediaDS.TabDirectorDataTable myDataTable)
        {
            List<IdAndValue> idVal = new List<IdAndValue>();

            foreach (MediaDS.TabDirectorRow row in myDataTable.Rows)
            //foreach (UserDS.TabUserRow row in myDataTable.Rows)
            {

                if (row == null)
                {
                    return null;
                }
                else
                {
                    IdAndValue item = new IdAndValue(row.DID, row.DirectorName);
                    idVal.Add(item);
                }

            }
            return idVal;
        }


        //tableGenre
        public List<IdAndValue> parseGenreDataTolist(MediaDS.TabGenreDataTable myDataTable)
        {
            List<IdAndValue> idVal = new List<IdAndValue>();

            foreach (MediaDS.TabGenreRow row in myDataTable.Rows)
            //foreach (UserDS.TabUserRow row in myDataTable.Rows)
            {

                if (row == null)
                {
                    return null;
                }
                else
                {
                    IdAndValue item = new IdAndValue(row.GID, row.GenreName);
                    idVal.Add(item);
                }

            }
            return idVal;
        }

        //tableLanguage
        public List<IdAndValue> parseLanguageDataTolist(MediaDS.TabLanguageDataTable myDataTable)
        {
            List<IdAndValue> idVal = new List<IdAndValue>();

            foreach (MediaDS.TabLanguageRow row in myDataTable.Rows)
            //foreach (UserDS.TabUserRow row in myDataTable.Rows)
            {

                if (row == null)
                {
                    return null;
                }
                else
                {
                    IdAndValue item = new IdAndValue(row.LID, row.LanguageName);
                    idVal.Add(item);
                }

            }
            return idVal;
        }




    }
}
