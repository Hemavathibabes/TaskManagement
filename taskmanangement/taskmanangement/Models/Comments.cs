using System;
using System.Collections.Generic;
using System.Text;


namespace taskmanangement.Models
{
    interface Icomments
    {
        public int taskid { get; set; }
        public string username { get; set; }
        public string commentsummary { get; set; }
    }
    interface Icommentmanager
    {
        public void Addcomment(string username);
    }
    class Comments :Icomments
    {
        public int taskid { get; set; }
        public string username { get; set; }
        public string commentsummary { get; set; }

        public Comments(int id,string u_name,string comments_summary)
        {
            this.taskid = id;
            this.username = u_name;
            this.commentsummary = comments_summary;
           
        }
    }
}
