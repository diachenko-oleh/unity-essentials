using UnityEngine;
using System.Collections;

public class SomeClass_
{
    //Here is a generic method. Notice the generic
    //type 'T'. This 'T' will be replaced at runtime
    //with an actual type.
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
public class SomeOtherClass : MonoBehaviour
{
    void Start()
    {
        SomeClass_ myClass = new SomeClass_();
        myClass.GenericMethod<int>(5);
    }
}
public class GenericClass<T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}
public class Generic : MonoBehaviour
{
    void Start()
    {
        //In order to create an object of a generic class, you must
        //specify the type you want the class to have.
        GenericClass<int> myClass = new GenericClass<int>();

        myClass.UpdateItem(5);
    }
}

