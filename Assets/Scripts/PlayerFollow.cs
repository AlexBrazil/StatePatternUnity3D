using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;         // Refer�ncia � esfera
    public float speed = 5.0f;       // Velocidade de movimento do inimigo

    void Update()
    {
        // Se a posi��o do inimigo n�o for a mesma da esfera, mova-se em dire��o � esfera
        if (transform.position != player.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            transform.LookAt(player.position);
        }
    }
}
