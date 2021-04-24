using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class IdAndValue
    {

        private int id;
        private string value;

        public int Id
        {
            set { id = value;  /*extra code, whatever*/ }
            get { return id; }
        }

        public string Value 
        {
            set { this.value = value; } 
            get { return this.value; }
        }



        public IdAndValue()
        {

        }

        public IdAndValue(int id, string value)
        {
            this.id = id;
            this.value = value;
        }


    }
}
