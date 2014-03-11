using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Generics
{
    class GenericList<T>
    {
        private const int InitialSize = 16;

        private T[] elements;
        private int frontIndex;
        private int backIndex;


        public int Count 
        { 
            get
            {
               return this.backIndex - this.frontIndex - 1;
            }
        }



        public GenericList()
            : this(InitialSize)
        {
            this.elements = new T[InitialSize];
        }

        public GenericList(int initialSize)
        {
            if (initialSize < 2)
            {
                throw new IndexOutOfRangeException("Initial size must be bigger than 1!");
            }
            this.elements = new T[initialSize];
            this.frontIndex = this.elements.Length / 2 - 1;
            this.backIndex = this.elements.Length / 2;
        }

        public void AddBack(T element)
        {
            throw new NotImplementedException();
        }

        public void AddFront(T element)
        {
            throw new NotImplementedException();
        }

        public void InsertAt(int p1, T element)
        {
            if (this.Count == 0 && p1 > 0)
            {
                throw new InvalidOperationException("List is empty!");
            }
            throw new NotImplementedException();
        }


        public void ElementOnIndex(int p)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }
            throw new NotImplementedException();
        }

        public void IndexOf(T element)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }
            throw new NotImplementedException();
        }

        public void RemoveAt(int p)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }
            throw new NotImplementedException();
        }


        internal void Clear()
        {
            throw new NotImplementedException();
        }


        
    }
}
