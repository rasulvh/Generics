using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Datas<T>
    {
        public T[] _datas;

        public Datas()
        {
            _datas = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = data;
        }

        public T[] GetAll()
        {
            return _datas;
        }
    }
}
