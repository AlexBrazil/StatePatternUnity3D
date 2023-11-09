using UnityEngine;

public class IdleState<T> : IState<T> where T : Enemy
{
    private T _entity;

    public void EnterState(T entity)
    {
        _entity = entity;
        _entity.ChangeMaterialRed();
    }

    public void UpdateState()
    {
        Debug.Log("Estou atualizando o Estado Idle");
    }

    public void ExitState()
    {
        Debug.Log("Acabei de sair do Estado Idle");
    }
}