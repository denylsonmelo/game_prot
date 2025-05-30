using UnityEngine;

public class PlayerInfo : MonoBehaviour
{

    [SerializeField]
    private int lifeMax = 100;
    [SerializeField]
    private int lifeActual = 50;
    [SerializeField]
    private int special = 10;

    [SerializeField]
    private int attack = 10;

    void Start()
    {
        //healthActual = healthMax;
    }

    public int getLifeMax()
    {
        return lifeMax;
    }
    public int getLifeActual()
    {
        return lifeActual;
    }

    public void takeDamage(int amount)
    {
        if (lifeActual > 0)
        {
            lifeActual -= amount;
            if (lifeActual < 0) lifeActual = 0;
        }
    }

    public void heal(int amount)
    {

        if (amount < 0)
            return;

        lifeActual += amount;
        if (lifeActual > lifeMax) lifeActual = lifeMax;
    }
}
