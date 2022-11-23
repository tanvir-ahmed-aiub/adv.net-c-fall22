using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class GroupRepoV2 : IRepo<Group, int, bool>
    {
        public bool Add(Group obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Group id)
        {
            throw new NotImplementedException();
        }

        public List<Group> Get()
        {
            throw new NotImplementedException();
        }

        public Group Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Group obj)
        {
            throw new NotImplementedException();
        }
    }
}
