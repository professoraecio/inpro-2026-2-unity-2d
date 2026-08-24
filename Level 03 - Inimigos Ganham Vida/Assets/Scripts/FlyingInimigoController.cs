using UnityEngine;
using System.Collections;
public class FlyingInimigoController : MonoBehaviour
{
    [Header("Configuração de movimento")]
    public float velocidade = 2f;

    private Vector2 direcaoAtual;
    private Rigidbody2D rb;

    public string direcao = "";

    public float yMin = -2.2f;
    public float yMax = 2.2f;
    public float xMin = -6.8f;
    public float xMax = 6.8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(MovimentoAleatorio());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EscolherDirecaoVerticalParaDentro()
    {
        if(transform.position.y <= yMin)
        {
            direcaoAtual = Vector2.up;
            direcao = "Cima";
        }
        else if (transform.position.y >= yMax)
        {
            direcaoAtual = Vector2.down;
            direcao = "Baixo";
        }
    }

    void EscolherDirecaoHorizontalParaDentro()
    {
        if(transform.position.x <= xMin)
        {
            direcaoAtual = Vector2.right;
            direcao = "Direita";
        }
        else if (transform.position.x >= xMax)
        {
            direcaoAtual = Vector2.left;
            direcao = "Esquerda";
        }
    }

    void EscolherDirecaoAleatoria()
    {
        int sorteio = Random.Range(0,4);
        switch (sorteio)
        {
            case 0:
                direcaoAtual = Vector2.up;
                direcao = "Cima";
                break;
            case 1:
                direcaoAtual = Vector2.down;
                direcao = "Baixo";
                break;
            case 2:
                direcaoAtual = Vector2.left;
                direcao = "Esquerda";
                break;
            case 3:
                direcaoAtual = Vector2.right;
                direcao = "Direita";
                break;            
        }
    }

    IEnumerator MovimentoAleatorio()
    {
        while(true)
        {
            EscolherDirecaoAleatoria();
            yield return new WaitForSeconds(3f);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = direcaoAtual * velocidade;
        Vector2 posicao = transform.position;
        if(posicao.x <= xMin)
        {
            transform.position = new Vector2(xMin,posicao.y);
            EscolherDirecaoHorizontalParaDentro();
        }
        else if (posicao.x >= xMax)
        {
            transform.position = new Vector2(xMax,posicao.y);
            EscolherDirecaoHorizontalParaDentro();
        }

        if(posicao.y <= yMin)
        {
            transform.position = new Vector2(posicao.x,yMin);
            EscolherDirecaoHorizontalParaDentro();
        }
        else if (posicao.y >= yMax)
        {
            transform.position = new Vector2(posicao.x,yMax);
            EscolherDirecaoHorizontalParaDentro();
        }
    }
}
