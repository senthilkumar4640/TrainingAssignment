namespace ArrayList
{
    public partial class List <Type>
    {   
        //Field
        private int _count;
        private int _capacity;

        //Property
        public int Count{get{return _count;}}//ReadOnly
        public int Capacity{get{return _capacity;}}//ReadOnly

        //Indexer Property
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index] = value;}
        }

        //Field
        private Type [] _array;

        //Constructor
        public List()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }

        public List(int size)//Parameterized Constructor
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }

        //Methods of list
        public void Add(Type element) //Creating method for add element in list
        {
            if(_count == _capacity)
            {
                GrowSize();//To increase or double the size of the list
            }
            _array[_count] = element;
            _count++;
        }

        void GrowSize()//Dynamically grow the element or size of array or list
        {
            _capacity = _capacity * 2;
            Type [] temp = new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }

        //AddRange method used to add a list in a list
        public void AddRange(List<Type> elements)
        {
            _capacity = _count + elements.Count+4;
            Type [] temp = new Type[_capacity];
            for(int i=0; i<_count;i++)
            {
                temp[i] = _array[i];
            }
            int k=0;
            for(int i=_count; i<_count+elements.Count;i++)
            {
                temp[i] = elements[k]; //here we changing a object to arrray, so we need indexer
                k++;
            }
            _array=temp;
            _count = _count + elements.Count;
        }

        //Contains Method
        public bool Contains(Type element)
        {
            bool isFlag = false;
            foreach (Type data in _array)
            {
                if(data.Equals(element))
                {
                    isFlag = true;
                    break;
                }
            }
            return isFlag;
        }

        //IndexOf Method
        public int IndexOf(Type element)
        {
            int index = -1;
            for(int i=0; i<_count;i++)
            {
                if(element.Equals(_array[i]))
                {
                    index=i;
                    break;
                }
            }
            return index;
        }

        //Insert Method
        public void Insert(int position, Type element)
        {
            _capacity = _capacity+1+4;
            Type [] temp = new Type[_capacity];
            for(int i=0;i<=_count;i++)
            {
                if(i<position)
                {
                    temp[i] = _array[i];
                }
                else if(i==position)
                {
                    temp[i] = element;
                }
                else
                {
                    temp[i] = _array[i-1];
                }
            }
            _count++;
            _array = temp;
        }

        //RemoveAt Method
        public void RemoveAt(int position)
        {
             for(int i=0;i<_count-1;i++)
             {
                if(i>=position)
                {
                    _array[i] = _array[i+1];
                }
             }
             _count--;
        }

        //Remove Method
        public bool Remove(Type element)
        {
            int position = IndexOf(element);
            if(position>=0)
            {
                RemoveAt(position);
                return true;
            }
            return false;
        }

    }
}