using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Media
    {


        //properties  with getters and setters 
        private int id;
        private string title;
        private string genreName;
        private string directorName;
        private string languageName;
        private int publishYear;
        private decimal budget;
        private int genreId;
        private int directorId;
        private int languageId;


        
        //getters and setters   
        public int Id
        {
            set { id = value;  /*extra code, whatever*/ }
            get { return id; }
        }
        public string Title
        {
            set { title = value;}
            get { return title; }
        }
        public string GenreName
        {
            set { genreName = value; }
            get { return genreName; }
        }
        public string DirectorName
        {
            set { directorName = value; }
            get { return directorName; }
        }
        public string LanguageName
        {
            set { languageName = value; }
            get { return languageName; }
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
        public Media()
        {

        }

        public Media(int id, string title, string genreName, string directorName, string languageName, int publishYear, decimal budget, int genreId, int directorId, int languageId)
        {
            this.id = id;
            this.title = title;
            this.genreName = genreName;
            this.directorName = directorName;
            this.languageName = languageName;
            this.publishYear = publishYear;
            this.budget = budget;
            this.genreId = genreId;
            this.directorId = directorId;
            this.languageId = languageId;
        }

        public Media(int id, string title, string genreName, string directorName, string languageName, int publishYear)
        {
            this.id = id;
            this.title = title;
            this.genreName = genreName;
            this.directorName = directorName;
            this.languageName = languageName;
            this.publishYear = publishYear;
        }


    }
}
