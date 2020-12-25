using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GyreRigTask.Task3
{
    interface ISomeInterface
    {
        void Call();
    }
    struct SomeStruct : ISomeInterface
    {
        public void Call(){ }
    }
    class SomeClass
    {
        public void Run()
        {
            var someStruct = new SomeStruct();
            someStruct = (SomeStruct)SomeMethod(someStruct);
        }

        public ISomeInterface SomeMethod(ISomeInterface @interface)
        {
            @interface.Call();
            return @interface;
        }
    }
}

