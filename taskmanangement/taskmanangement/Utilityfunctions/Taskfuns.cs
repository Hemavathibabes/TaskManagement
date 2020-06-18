using System;
using System.Collections.Generic;
using System.Text;
using taskmanangement.Models;

namespace taskmanangement.Utilityfunctions
{
    class Taskfuns :ITask
    {
        List<Task> task = new List<Task>();
        public void addtask(string username)
        {
            if (username == " ")

            {
                Console.WriteLine("Log in please!!");

            }
            else
            {


                Console.WriteLine("Enter the Task details");
                Console.WriteLine("Assign a task to (Myself/Other employee)");
                string assign = Console.ReadLine();
                String assignedto;
                if (assign == "other employee" || assign == "Other employee")
                {
                    Console.WriteLine("Enter a username of the employee");
                    assignedto = Console.ReadLine();
                }
                else
                {
                    assignedto = username;
                }
                String assignedby = username;
                Console.WriteLine("Enter the Unique Task id:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Taskname:");
                String name = Console.ReadLine();
                Console.WriteLine("Enter the Task Description:");
                string des = Console.ReadLine();

                DateTime assignedat = DateTime.Now;
                Console.WriteLine("Enter the Task start date");
                DateTime sdate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Task End date:");
                DateTime edate = DateTime.Parse(Console.ReadLine());

                Task addtask = new Task(id, name, des, assignedat, sdate, edate, assignedto, assignedby);
                task.Add(addtask);

                Console.WriteLine("Task created Successfullly!!!!");



            }
        }
        public void showtask(string username)
        {
            if (username == " ")

            {
                Console.WriteLine("Log in please!!");
            }

            else
            {
                bool flag2 = false;
                foreach (Task t in task)
                {
                    if (username == t.assignedto)
                    {
                        Console.WriteLine("AssignedBy:{0} at {1}", t.assignedby, t.Assignedat);

                        Console.WriteLine("Taskname:{0}\n Taskid:{1}\n Taskdescription:{2} \nStartdate:{3} \nEnddate:{4} ", t.taskname, t.taskid, t.taskdescription, t.startdate, t.enddate);
                        flag2 = true;
                    }
                }
                if (flag2 == false)
                {
                    Console.WriteLine("No tasks are assigned...Be happy!!");
                }
            }
        }
    }
}
