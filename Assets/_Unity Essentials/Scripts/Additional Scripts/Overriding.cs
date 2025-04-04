using UnityEngine;
using System.Collections;

public class Fruit_
{
    public Fruit_()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    //These methods are virtual and thus can be overriden
    //in child classes
    public virtual void Chop_()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public virtual void SayHello_()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
public class Apple_ : Fruit_
{
    public Apple_()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    //These methods are overrides and therefore
    //can override any virtual methods in the parent
    //class.
    public override void Chop_()
    {
        base.Chop_();
        Debug.Log("The apple has been chopped.");
    }

    public override void SayHello_()
    {
        base.SayHello_();
        Debug.Log("Hello, I am an apple.");
    }
}
public class FruitSalad : MonoBehaviour
{
    void Start()
    {
        Apple_ myApple = new Apple_();

        //Notice that the Apple version of the methods
        //override the fruit versions. Also notice that
        //since the Apple versions call the Fruit version with
        //the "base" keyword, both are called.
        myApple.SayHello_();
        myApple.Chop_();

        //Overriding is also useful in a polymorphic situation.
        //Since the methods of the Fruit class are "virtual" and
        //the methods of the Apple class are "override", when we 
        //upcast an Apple into a Fruit, the Apple version of the 
        //Methods are used.
        Fruit_ myFruit = new Apple_();
        myFruit.SayHello_();
        myFruit.Chop_();
    }
}
