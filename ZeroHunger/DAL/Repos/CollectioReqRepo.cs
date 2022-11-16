using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CollectioReqRepo : IRepo<CollectionReq, int>
    {
        public void Add(CollectionReq obj)
        {
            var db = new ZeroHungerEntities();
            db.CollectionReqs.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CollectionReq obj)
        {
            throw new NotImplementedException();
        }

        public List<CollectionReq> Get()
        {
            throw new NotImplementedException();
        }

        public CollectionReq Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
