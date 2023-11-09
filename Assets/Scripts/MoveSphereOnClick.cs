using UnityEngine;

public class MoveSphereOnClick : MonoBehaviour
{
    public Camera cam;           // A c�mera usada para o Raycast (geralmente a c�mera principal)
    public Transform player;     // A esfera que voc� quer mover

    void Update()
    {
        // Verifica se o bot�o esquerdo do mouse foi pressionado
        if (Input.GetMouseButtonDown(0))
        {
            // Cria um raio a partir da posi��o do mouse na tela
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Se esse raio colidir com algo
            if (Physics.Raycast(ray, out hit))
            {
                // Se o objeto colidido for o plano
                if (hit.collider.gameObject.CompareTag("Plano"))
                {
                    // Reposiciona a esfera para o ponto de colis�o
                    player.position = hit.point + new Vector3(0, player.localScale.y / 2, 0);
                }
            }
        }
    }
}
