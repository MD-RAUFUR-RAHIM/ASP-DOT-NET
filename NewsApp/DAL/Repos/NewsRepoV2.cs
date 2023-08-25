using DAL.EF.Models;
using DAL.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class NewsRepoV2 : Repo, IRepo<News, int, bool>
    {
        public bool Create(News obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<News> Get()
        {
            throw new NotImplementedException();
        }

        public News Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(News obj)
        {
            throw new NotImplementedException();
        }
    }
}
