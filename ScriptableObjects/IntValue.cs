using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "NewIntValue", menuName = "Generic/Integer")]
public class IntValue : BaseSO<int> {
    public void SetFromInputAction(InputAction.CallbackContext ctx)
    {
        Value = (int) ctx.ReadValue<float>();
    }
}
