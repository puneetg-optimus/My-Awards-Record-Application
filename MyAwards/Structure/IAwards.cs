using System;
using System.Collections.Generic;
using MyAwardsCollection.Models;

namespace MyAwardsCollection.Structure
{
   public interface IAwards
    {
        List<MyAwards> GetAll();
        MyAwards GetById(int ItemId);
        void Update(MyAwards awards);
        void Insert(MyAwards awards);
        void Delete(MyAwards awards);
        void Save();
    }
}
