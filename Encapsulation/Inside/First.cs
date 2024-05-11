using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{
    public class First : Third
    {
        //Field
        private int _privateNumber = 10;
        public int PublicNumber = 20;
        protected int ProtectedNumber = 30;

        //Property
        public int PrivateOut { get{return _privateNumber;}}

        public int ProtectedInternalOut{get{return InternalProtected;}}
    }
}