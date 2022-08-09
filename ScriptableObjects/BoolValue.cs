using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "NewBoolValue", menuName = "Generic/Bool")]
public class BoolValue : BaseSO<bool> {
    public void SetFromInputAction(InputAction.CallbackContext ctx)
    {
        Value = ctx.action.triggered;
    }
}
