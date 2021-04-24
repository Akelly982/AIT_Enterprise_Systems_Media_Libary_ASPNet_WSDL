using DataAccessLayer.MediaDSTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MediaDAO
    {

        private MediaDS mediaDataSet;
        private TabMediaTableAdapter tabMediaAdapter;   
        private ViewMediaTableAdapter viewMediaTableAdapter;

        //added access to the genre, director and language tables for CRUD
        private TabGenreTableAdapter tabGenreTableAdapter;
        private TabDirectorTableAdapter tabDirectorTableAdapter;
        private TabLanguageTableAdapter tabLanguageTableAdapter;


        public MediaDAO()
        {
            mediaDataSet = new MediaDS();
            tabMediaAdapter = new TabMediaTableAdapter();
            viewMediaTableAdapter = new ViewMediaTableAdapter();
            tabGenreTableAdapter = new TabGenreTableAdapter();
            tabLanguageTableAdapter = new TabLanguageTableAdapter();
            tabDirectorTableAdapter = new TabDirectorTableAdapter();
        }


        public MediaDS.TabMediaDataTable getAllMediaTab()
        {
            try
            {
                tabMediaAdapter.FillAll(mediaDataSet.TabMedia);
                return mediaDataSet.TabMedia;
            }
            catch (Exception e)
            {
                throw e;
            }

        }



        // name of data table within the DS
        public MediaDS.ViewMediaDataTable getMediaByGenreId(int genreId)
        {
            try
            {
                //adapter in ds schema    //yourFill method   //the schema u are using  // variables needed if any
                viewMediaTableAdapter.FillByGenre(mediaDataSet.ViewMedia, genreId);
                //return the now filled schema / table
                return mediaDataSet.ViewMedia;
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public MediaDS.ViewMediaDataTable getMediaByGenreName(string genreName)
        {
            try
            {
                viewMediaTableAdapter.FillByGenreName(mediaDataSet.ViewMedia, genreName);
                return mediaDataSet.ViewMedia;
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public MediaDS.ViewMediaDataTable getMediaByYear(int year)
        {

            try
            {
                viewMediaTableAdapter.FillByPublishYear(mediaDataSet.ViewMedia, year);
                return mediaDataSet.ViewMedia;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public MediaDS.ViewMediaDataTable getMediaByTitle(string title)
        {
            try
            {
                viewMediaTableAdapter.FillByTitleNameLike(mediaDataSet.ViewMedia, title);
                return mediaDataSet.ViewMedia;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        //tabMedia if fk from external table exists
        public MediaDS.TabMediaDataTable getDirectorExists(int directorId)
        {
            try
            {
                tabMediaAdapter.FillByDirectorIdForIfDirectorExists(mediaDataSet.TabMedia,directorId);
                return mediaDataSet.TabMedia;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public MediaDS.TabMediaDataTable getLanguageExists(int languageId)
        {
            try
            {
                tabMediaAdapter.FillByLanguageIdForIfLanguageExists(mediaDataSet.TabMedia, languageId);
                return mediaDataSet.TabMedia;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public MediaDS.TabMediaDataTable getGenreExists(int genreId)
        {
            try
            {
                tabMediaAdapter.FillByGenreIdForIfGenreExists(mediaDataSet.TabMedia, genreId);
                return mediaDataSet.TabMedia;
            }
            catch (Exception e)
            {
                throw e;

            }
        }







        // Note this is media View not media Table
        public MediaDS.ViewMediaDataTable getAllMediaView()
        {

            try
            {
                
                viewMediaTableAdapter.FillAll(mediaDataSet.ViewMedia);
                return mediaDataSet.ViewMedia;

            }
            catch (Exception e)
            {
                throw e;
            }

        }









        //TabMedia create, update, delete ----------

        public bool insertNewMedia(string title,int genreId, int directorId, int languageId, int publishYear, int budget)
        {
            try
            {
                tabMediaAdapter.InsertWithTitleGenreIdDirectorIdLanguageIdPublishYearBudget(title, genreId, directorId, languageId, publishYear, budget);
                return true;
            }
            catch (Exception e)
            {
                throw e;
                
            }
        }

        public bool deleteMediaById(int mediaId)
        {
            try
            {
                tabMediaAdapter.DeleteByMediaId(mediaId);
                return true;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public bool updateMedia(int mediaId, string title, int genreId, int directorId, int languageId, int publishYear, int budget)
        {
            try
            {
                tabMediaAdapter.UpdateByMediaIdForTitleGenreIdDirectorIdLanguageIdPublishYearBudget(title, genreId, directorId, languageId, publishYear, budget, mediaId);
                return true;
            }
            catch (Exception e)
            {
                throw e;

            }
        }





        //TabDirector CRUD ----------
        public bool insertNewDirector(string directorName)
        {
            try
            {
                tabDirectorTableAdapter.InsertDirectorByName(directorName);
                return true;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public bool deleteDirectorById(int id)
        {
            try
            {
                tabDirectorTableAdapter.DeleteByDirectorId(id);
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public MediaDS.TabDirectorDataTable getDirectorByName(string directorName)
        {
            try
            {
                tabDirectorTableAdapter.FillByDirectorName(mediaDataSet.TabDirector, directorName); //use the fill method not the get metod becuse you are filling a data table 
                return mediaDataSet.TabDirector;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

       
        public MediaDS.TabDirectorDataTable getAllDirectors()
        {
            try
            {
                tabDirectorTableAdapter.FillAll(mediaDataSet.TabDirector);
                return mediaDataSet.TabDirector;
            }
            catch (Exception e)
            {
                throw e;

            }
        }





        //TabGenre CRUD ----------
        public bool insertNewGenre(string genreName)
        {
            try
            {
                tabGenreTableAdapter.InsertGenreByName(genreName);
                return true;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public bool deleteGenreById(int id)
        {
            try
            {
                tabGenreTableAdapter.DeleteByGenreId(id);
                return true;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public MediaDS.TabGenreDataTable getGenreByName(string genreName)
        {
            try
            {
                tabGenreTableAdapter.FillByGenreName(mediaDataSet.TabGenre, genreName);
                return mediaDataSet.TabGenre;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public MediaDS.TabGenreDataTable getAllGenre()
        {
            try
            {
                tabGenreTableAdapter.FillAll(mediaDataSet.TabGenre);
                return mediaDataSet.TabGenre;
            }
            catch (Exception e)
            {
                throw e;

            }
        }





        //TabLanguage CRUD ----------
        public bool insertNewLanguage(string languageName)
        {
            try
            {
                tabLanguageTableAdapter.InsertLanguageByName(languageName);
                return true;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public bool deleteLanguageById(int id)
        {
            try
            {
                tabLanguageTableAdapter.DeleteByLanguageID(id);
                return true;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public MediaDS.TabLanguageDataTable getLanguageByName(string languageName)
        {
            try
            {
                tabLanguageTableAdapter.FillByLanguageName(mediaDataSet.TabLanguage, languageName);
                return mediaDataSet.TabLanguage;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public MediaDS.TabLanguageDataTable getAllLanguages()
        {
            try
            {
                tabLanguageTableAdapter.FillAll(mediaDataSet.TabLanguage);
                return mediaDataSet.TabLanguage;
            }
            catch (Exception e)
            {
                throw e;

            }
        }




    }
}
