using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    private Transform player;         // Referência à esfera
    [SerializeField]
    private float speed = 5.0f;       // Velocidade de movimento do inimigo
    [SerializeField]
    private Material materialRed;
    [SerializeField]
    private Material materialGreen;



    private ManagerState<Enemy> _context;

    private void Start()
    {
        _context = new ManagerState<Enemy>();
        _context.SetState(new IdleState<Enemy>(), this);
    }

    private void Update()
    {
        //_context.UpdateState();
        // Se a posição do inimigo não for a mesma da esfera, mova-se em direção à esfera
        if (transform.position != player.position)
        {
            _context.SetState(new LookingState<Enemy>(), this);
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            transform.LookAt(player.position);
        }
        else
        {
            _context.SetState(new IdleState<Enemy>(), this);
        }
    }

    public void ChangeMaterialRed()
    {
        Renderer renderer = GetComponent<Renderer>(); // Pega o componente Renderer do GameObject
        if (renderer != null)
        {
            renderer.material = materialRed; // Muda o material
        }
    }

    public void ChangeMaterialGreen()
    {
        Renderer renderer = GetComponent<Renderer>(); // Pega o componente Renderer do GameObject
        if (renderer != null)
        {
            renderer.material = materialGreen; // Muda o material
            
        }
    }
}
