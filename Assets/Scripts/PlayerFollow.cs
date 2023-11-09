using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform player;         // Referência à esfera
    public float speed = 5.0f;       // Velocidade de movimento do inimigo

    void Update()
    {
        // Se a posição do inimigo não for a mesma da esfera, mova-se em direção à esfera
        if (transform.position != player.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            transform.LookAt(player.position);
        }
    }
}
