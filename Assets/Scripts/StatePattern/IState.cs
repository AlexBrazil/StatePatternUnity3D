public interface IState<T>
{
    void EnterState(T entity);
    void UpdateState();
    void ExitState();
}