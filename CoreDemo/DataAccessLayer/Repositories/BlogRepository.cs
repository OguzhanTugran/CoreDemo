using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog Blog)
        {
            using var c = new Context();
            c.Add(Blog);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog Blog)
        {
            using var c = new Context();
            c.Remove(Blog);
            c.SaveChanges();
        }
        public List<Blog> ListAllBlog()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog Blog)
        {
            using var c = new Context();
            c.Update(Blog);
            c.SaveChanges();
        }

        public Blog GetbyId(int İd)
        {
            using var c = new Context();
            return c.Blogs.Find(İd);
        }
    }
}
