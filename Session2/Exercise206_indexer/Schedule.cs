using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise206_indexer
{
    class Schedule
    {
        private Hashtable dates = new Hashtable();

        public string this[DateTime d]
        {
            get
            {
                return (string)dates[d];
            }
            set
            {
                dates[d] = value;
            }
        }

        public string this[string d]
        {
            get
            {
                return (string)dates[DateTime.Parse(d)];
            }
            set
            {
                dates[DateTime.Parse(d)] = value;
            }
        }



    }
}
