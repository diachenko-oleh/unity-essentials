using UnityEngine;

public class Enemy
{
    //Static variables are shared across all instances
    //of a class.
    public static int enemyCount = 0;

    public Enemy()
    {
        //Increment the static variable to know how many
        //objects of this class have been created.
        enemyCount++;
    }
}
public class Game
{
    void Start()
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();

        //You can access a static variable by using the class name
        //and the dot operator.
        int x = Enemy.enemyCount;
    }
}
public class Player : MonoBehaviour
{
    //Static variables are shared across all instances
    //of a class. 
    public static int playerCount = 0;

    void Start()
    {
        //Increment the static variable to know how many
        //objects of this class have been created.
        playerCount++;
    }
}
public class PlayerManager : MonoBehaviour
{
    void Start()
    {
        //You can access a static variable by using the class name
        //and the dot operator.
        int x = Player.playerCount;
    }
}
public static class Utilities
{
    //A static method can be invoked without an object
    //of a class. Note that static methods cannot access
    //non-static member variables.
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}
public class UtilitiesExample : MonoBehaviour
{
    void Start()
    {
        //You can access a static method by using the class name
        //and the dot operator.
        int x = Utilities.Add(5, 6);
    }
}
