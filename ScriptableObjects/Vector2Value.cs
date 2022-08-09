using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "NewVector2Value", menuName = "Generic/Vector2")]
public class Vector2Value : BaseSO<Vector2> {
    public void SetFromInputAction(InputAction.CallbackContext ctx)
    {
        Value = ctx.ReadValue<Vector2>();
    }
}
