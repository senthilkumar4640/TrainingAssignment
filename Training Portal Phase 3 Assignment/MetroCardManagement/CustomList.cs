using System.Linq;

namespace MetroCardManagement
{
    public partial class CustomList<Type>
    {
        //Field
        private int _count;
        private int _capacity;
        private Type[] _array;
        
        //Property
        public int Count { get{return _count;}}
        public int Capacity {get{return _capacity;}}

        
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index] = value;}
        }

        //Non parameterized Constructor
        public CustomList()
        {
            _count =0;
            _capacity = 4;
            _array = new Type[_capacity];

        }

        //Parameterized Constructor
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }

        //Add Method
        public void Add(Type element)
        {
            if(_count ==_capacity)
            {
                GrowSize();
            }
            _array[_count] = element;
            _count++;
        }


        void GrowSize()
        {
            _capacity = _capacity * 2;
            Type [] temp = new Type[_capacity];
            for(int i=0; i<_count;i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }


        //AddRange method
        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _count + elements.Count+4;
            Type[] temp = new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i] = _array[i];
            }
            int k=0;
            for(int i=_count;i<_count+elements.Count;i++)
            {
                temp[i] = elements[k];
                k++; //changing object to array
            }
            _array = temp;
            _count = _count + elements.Count;
        }
    }
}