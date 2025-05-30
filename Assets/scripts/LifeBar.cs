using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{

    private PlayerInfo playerInfo;
    public Slider vida;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInfo = GetComponent<PlayerInfo>();
        vida.maxValue = this.playerInfo.getLifeMax();
    }

    // Update is called once per frame
    void Update()
    {
        vida.value = this.playerInfo.getLifeActual();
    }
}
