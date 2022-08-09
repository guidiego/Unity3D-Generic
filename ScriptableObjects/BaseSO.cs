using UnityEngine;
using UnityEngine.InputSystem;

public class BaseSO<T> : ScriptableObject
{
    [SerializeField]
    protected T _value;

    [SerializeField]
    protected GameEvent _onChange;

    [SerializeField]
    protected bool _isConstant;

    public T Value
    {
        get { return _value; }
        set
        {
            if (_isConstant) return;

            _value = value;
            _onChange?.Invoke();
        }
    }
}
