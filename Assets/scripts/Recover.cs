using UnityEngine;

public class Recover : MonoBehaviour
{

    [SerializeField]
    private int recoverAmount = 5;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInfo playerInfo = collision.gameObject.GetComponent<PlayerInfo>();
            if (playerInfo != null)
            {
                playerInfo.recover(recoverAmount);
            }
            Destroy(gameObject);
        }

    }
}
