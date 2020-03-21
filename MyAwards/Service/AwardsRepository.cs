using MyAwardsCollection.Data;
using MyAwardsCollection.Models;
using MyAwardsCollection.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAwardsCollection.Service
{
    public class AwardsRepository : IAwards
    {
        private AwardsContext _context;
        public AwardsRepository(AwardsContext context)
        {
            _context = context;
        }
        public void Delete(MyAwards awards)
        {
            _context.awards.Remove(awards);
        }
        public List<MyAwards> GetAll()
        {
            return _context.awards.ToList();
        }

        public MyAwards GetById(int Id)
        {
            return  _context.awards.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Insert(MyAwards collection)
        {
            _context.Add(collection);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(MyAwards collection)
        {
            _context.awards.Update(collection);
        }
    
    }
}
