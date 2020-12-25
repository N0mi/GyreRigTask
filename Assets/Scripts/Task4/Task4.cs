using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GyreRigTask.Task4
{
    public static class Ext
    {
        public static void SetupObjectA(this Task4.ApiSetup<Task4.ObjectA> obj) { }
        public static void SetupObjectB(this Task4.ApiSetup<Task4.ObjectB> obj) { }
    }

    public class Task4
    {
        public struct ApiSetup<T>{ }

        class Api
        {
            public ApiSetup<T> For<T>(T obj)
            {
                return new ApiSetup<T>();
            }
        }       

        interface ISomeInterfaceA{ }
        interface ISomeInterfaceB{ }
        public class ObjectA : ISomeInterfaceA{ }
        public class ObjectB : ISomeInterfaceB{ }

        class SomeClass
        {
            public void Setup()
            {
                Api apiObject = new Api();

                apiObject.For(new ObjectA()).SetupObjectA();
                apiObject.For(new ObjectB()).SetupObjectB();
            }
        }
    }

    


}

