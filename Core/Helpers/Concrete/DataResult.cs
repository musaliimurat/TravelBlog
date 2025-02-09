﻿using Core.Helpers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success,string message) : base(success,message)
        {
            Data = data;
        }
        public DataResult(T data,bool success) : base(success)
        {
            
        }
        public T Data { get; set; }
    }
}
