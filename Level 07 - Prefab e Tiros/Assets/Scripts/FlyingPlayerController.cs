using UnityEngine;

public class FlyingPlayerController : MonoBehaviour
{
    private Teclado teclado;
    [SerializeField]
    private float velocidade = 2.5f;
    // Executa antes do Start()
    private void Awake()
    {
        teclado = GetComponent<Teclado>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tempoFrame = Time.deltaTime;
        float distancia = velocidade * tempoFrame;
        if(teclado.cima) Mover(0,distancia);
        if(teclado.baixo) Mover(0,-distancia);
        if(teclado.direita) Mover(distancia,0);
        if(teclado.esquerda) Mover(-distancia,0);
    }

    private void Mover(float distX,float distY)
    {
        transform.Translate(new Vector2(distX,distY));
    }
}
