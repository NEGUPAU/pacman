using UnityEngine;

public class Player : MonoBehaviour
{
    private int numero;
    
    public float velocidade = 5.0f;

    void Start()
    {
        numero = 0;
    }

    //Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.A))
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.D))
            gameObject.transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.S))
            gameObject.transform.position += new Vector3(0, -velocidade * Time.deltaTime, 0); // Corrigindo a linha aqui

        if (Input.GetKey(KeyCode.W))
            gameObject.transform.position += new Vector3(0, velocidade * Time.deltaTime, 0); // Corrigindo a linha aqui
    }
}