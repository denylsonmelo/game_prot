using UnityEngine;
using UnityEngine.UI;

public class SpecialBar : MonoBehaviour
{

    private PlayerInfo playerInfo;
    public Slider special;

    void Start()
    {
        playerInfo = GetComponent<PlayerInfo>();
        special.maxValue = this.playerInfo.getSpecialMax();
    }

    void Update()
    {
        special.value = this.playerInfo.getSpecialActual();
    }
}
