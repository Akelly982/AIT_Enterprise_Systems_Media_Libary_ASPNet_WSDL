using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Reserve
    {


        //properties  with getters and setters 
        private int reserveId;
        private int userId;
        private int mediaId;
        private string reserveDate;
        

        //getters and setters   
        public int ReserveId
        {
            set { reserveId = value;  /*extra code, whatever*/ }
            get { return reserveId; }
        }
        public int UserId
        {
            set { userId = value; }
            get { return userId; }
        }
        public int MediaId
        {
            set { mediaId = value; }
            get { return mediaId; }
        }

        public string ReserveDate
        {
            set { reserveDate = value; }
            get { return reserveDate; }
        }






        //constructors----------

        public Reserve()
        {

        }

        public Reserve(int reserveId, int userId, int mediaId, string reserveDate)
        {
            this.reserveId = reserveId;
            this.reserveDate = reserveDate;
            this.userId = userId;
            this.mediaId = mediaId;
        }




    }
}
