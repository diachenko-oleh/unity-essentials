using UnityEngine;

public class Humanoid
{
    //Base version of the Yell method
    public void Yell()
    {
        Debug.Log("Humanoid version of the Yell() method");
    }
}

public class Enemy_ : Humanoid
{
    //This hides the Humanoid version.
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}
public class Orc : Enemy_
{
    //This hides the Enemy version.
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}
public class WarBand : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy_();
        Humanoid orc = new Orc();

        //Notice how each Humanoid variable contains
        //a reference to a different class in the
        //inheritance hierarchy, yet each of them
        //calls the Humanoid Yell() method.
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
