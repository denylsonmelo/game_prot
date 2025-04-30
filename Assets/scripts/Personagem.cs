using UnityEngine;

//[AnimatorController]
public class Personagem : MonoBehaviour
{

    [HideInInspector]
    public int variavel = 1;
    //AnimatorController animacao;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("dentr do start");
        //animacao = GetComponent<AnimatorController>();  animacao.SetBool("mover", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (variavel < 10)
        {
            Debug.Log("dentro d update: ");
            variavel++;
        }
    }

    private void Awake()
    {
        Debug.Log("dentr do awake");

    }

    private void FixedUpdate()
    {

    }
}
