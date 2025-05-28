using Lesson6.Core.Enities;
using Lesson6.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Data.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskitDB _db;
        public TaskRepository(TaskitDB taskitDB)
        {
            this._db = taskitDB;
        }
        public MyTask Add(MyTask entity)
        {
            this._db.Tasks.Add(entity);
            _db.SaveChanges();//כאן ברגע זה המשימה קיבלה קוד
            return entity;
        }

        public MyTask Delete(int id)
        {
            MyTask entity = this._db.Tasks.Find(id);//פיינד של דטה בייס מוגדר שמקבל מזהה לחיפוש 
            this._db.Tasks.Remove(entity);
            _db.SaveChanges();
            return entity;
        }

        public MyTask Get(int id)
        {
            return this._db.Tasks.FirstOrDefault(item => item.Id == id);
        }

        public List<MyTask> GetAll()
        {
            return _db.Tasks.ToList();
        }

        public MyTask? Update(int id, MyTask entity)
        {//ישנו שוני גדול בין 2 האובייקטים 
            //מה שקיבלנו מהקליינט הוא סתם אובייקט פשוט
            // עוקב אחרי השינויים שלו ושומר סטטוס שלוefומה ששלפנו מהדטה בייס זה אובייקט ש
            //השינויים יישמרוsave chnages במקרה ועשינו שינוי כשהעשה 
            MyTask? entityFound = this._db.Tasks.Find(id);//פיינד של דטה בייס מוגדר שמקבל מזהה לחיפוש 
            if (entityFound == null)
                return null;
            entityFound.Priority = entity.Priority;
          //  entityFound.ProjectId = entity.ProjectId;
            entityFound.Created = entity.Created;
            entityFound.Title = entity.Title;
            _db.SaveChanges();
            return entityFound;
        }
    }
}
