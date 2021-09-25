using UnityEngine;

namespace DefaultNamespace {
    public enum MouseType {
        Left = 0,
        Right,
        Middle
    }

    public class WaitForMouse : CustomYieldInstruction {
        private readonly MouseType _mouseType;

        public override bool keepWaiting => !Input.GetMouseButtonUp((int) _mouseType);

        public WaitForMouse(MouseType mouseType) {
            _mouseType = mouseType;
        }
    }
}