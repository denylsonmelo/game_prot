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

    public int getLifeMax()
    {
        return lifeMax;
    }

    public int getSpecialMax()
    {
        return 100;
    }

    public int getLifeActual()
    {
        return lifeActual;
    }

    public int getSpecialActual()
    {
        return special;
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

    public void recover(int amount)
    {
        if (amount < 0)
            return;

        special += amount;
        if (special > getSpecialMax()) special = getSpecialMax();
    }
}
