using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflowPost
{
    class Post
    {
        //private string _title;
        //private string _description;
        private DateTime _created = DateTime.Now;
        private int _votes = 0;

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created 
        {
            get { return _created; }
        }
        public int Votes
        {
            get { return _votes; }
            //set { _votes = value; }
        }
        public void VoteUp()
        {
            _votes++;
        }
        public void VoteDown()
        {
            _votes--;
        }
    }
}
