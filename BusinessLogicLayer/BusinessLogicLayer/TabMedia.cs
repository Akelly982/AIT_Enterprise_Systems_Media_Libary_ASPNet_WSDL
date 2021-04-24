using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    class TabMedia
    {

        //properties  with getters and setters 
        private int mediaId;
        private string title;
        private int publishYear;
        private decimal budget;
        private int genreId;
        private int directorId;
        private int languageId;



        //getters and setters   
        public int MediaId
        {
            set { mediaId = value;  /*extra code, whatever*/ }
            get { return mediaId; }
        }
        public string Title
        {
            set { title = value; }
            get { return title; }
        }
        
        public int PublishYear
        {
            set { publishYear = value; }
            get { return publishYear; }
        }
        public decimal Budget
        {
            set { budget = value; }
            get { return budget; }
        }
        public int GenreId
        {
            set { genreId = value; }
            get { return genreId; }
        }
        public int DirectorId
        {
            set { directorId = value; }
            get { return directorId; }
        }
        public int LanguageId
        {
            set { languageId = value; }
            get { return languageId; }
        }





        // constructors
        public TabMedia()
        {

        }

        public TabMedia(int mediaId, string title, int publishYear, decimal budget, int genreId, int directorId, int languageId)
        {
            this.mediaId = mediaId;
            this.title = title;
            this.publishYear = publishYear;
            this.budget = budget;
            this.genreId = genreId;
            this.directorId = directorId;
            this.languageId = languageId;
        }





    }
}
