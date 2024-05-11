using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace MovieTicketBooking
{
    public class CustomList<Type> : IEnumerable,IEnumerator
    {
        //Field
        private int _count;
        private int _capacity;
        private Type[] _array;

        //Property
        public int Count { get{return _count;} }
        public int Capacity { get{return _capacity;} }

        //Indexers
        public Type this[int index]
        {
           get{return _array[index];}
           set{_array[index] = value;}

        }

        //Default Constructors
        public CustomList()
        {
            _count=0;
            _capacity=4;
            _array = new Type[_capacity];
        }

        //Parameterised Constructor
        public CustomList(int value)
        {
            _count=0;
            _capacity=value;
            _array = new Type[_capacity];
        }

        //foreach
        int position;
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(position<_count-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position=-1;
        }
        public object Current{get {return _array[position];}}

        //Add
        public void Add(Type element)
        {
            if(_count == _capacity)
            {
                GrowMore();
            }
            else
            {
                _array[_count] = element;
                _count++;
            }
        }
        void GrowMore()
        {
            _capacity = _capacity*2;
            Type[] temp = new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
    }
}