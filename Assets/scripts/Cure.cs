using UnityEngine;

public class Cure : MonoBehaviour
{
    public int healAmount = 10;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInfo playerInfo = collision.gameObject.GetComponent<PlayerInfo>();
            if (playerInfo != null)
            {
                playerInfo.heal(healAmount);
            }
            Destroy(gameObject);
        }

    }
}
