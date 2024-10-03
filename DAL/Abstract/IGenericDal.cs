﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> GetAll();

        T GetById(int id);

        void Add(T entity);

        void Remove(T entity);

        void Update(T entity);
    }
}
