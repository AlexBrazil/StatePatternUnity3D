public class ManagerState<T>
{
    private IState<T> _state;

    public void SetState(IState<T> state, T entity)
    {
        _state?.ExitState();
        _state = state;
        _state.EnterState(entity);
    }

    public void UpdateState()
    {
        _state?.UpdateState();
    }
}
