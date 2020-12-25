using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GyreRigTask.Task3
{
    interface ISomeInterface
    {
        void Call();
    }
    class SomeStruct : ISomeInterface
    {
        public void Call(){ }
    }
    class SomeClass
    {
        public void Run()
        {
            var someStruct = new SomeStruct();
            SomeMethod(someStruct);
        }

        public void SomeMethod(ISomeInterface @interface)
        {
            @interface.Call();
            return @interface;
        }
    }
}

