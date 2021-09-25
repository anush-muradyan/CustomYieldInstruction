using UnityEngine;

public sealed class WaitForKeyCode : CustomYieldInstruction {
    private readonly KeyCode _keyCode;

    public override bool keepWaiting => !Input.GetKeyUp(_keyCode);

    public WaitForKeyCode(KeyCode keyCode) {
        _keyCode = keyCode;
    }
}