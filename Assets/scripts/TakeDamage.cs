using UnityEngine;
using UnityEngine.Events;

public class TakeDamage : MonoBehaviour
{
    [SerializeField]
    private int damageAmount = 15;
    private UnityEvent eventTakeDamage;

    void Start()
    {
        if (eventTakeDamage == null)
            eventTakeDamage = new UnityEvent();

        eventTakeDamage.AddListener(TakeDamageEvent);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInfo playerInfo = collision.gameObject.GetComponent<PlayerInfo>();
            if (playerInfo != null)
            {
                playerInfo.takeDamage(damageAmount);
            }
            //Destroy(gameObject);
        }

    }

    void TakeDamageEvent()
    {

    }
}
