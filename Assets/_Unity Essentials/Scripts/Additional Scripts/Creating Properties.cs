using UnityEngine;
using System.Collections;

public class Player_
{
    //Member variables can be referred to as fields.
    private int experience;

    //Experience is a basic property
    public int Experience
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }
    }

    //Level is a property that converts experience
    //points into the leve of a player automatically
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    public int Health { get; set; }
}
public class Game_ : MonoBehaviour
{
    void Start()
    {
        Player_ myPlayer = new Player_();

        //Properties can be used just like variables
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}
