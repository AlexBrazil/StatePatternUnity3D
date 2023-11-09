using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingState<T> : IState<T> where T : Enemy
{
    private T _entity;

    public void EnterState(T entity)
    {
        _entity = entity;
        _entity.ChangeMaterialGreen();
    }

    public void UpdateState()
    {
        Debug.Log("Estou atualizando o Estado Searche");
    }

    public void ExitState()
    {
        Debug.Log("Acabei de sair do Estado Searche");
    }
}
