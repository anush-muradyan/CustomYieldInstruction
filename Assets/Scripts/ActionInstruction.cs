using System;
using UnityEngine;

namespace DefaultNamespace {
    public class ActionInstruction : CustomYieldInstruction {
        private Func<bool> func;

        public override bool keepWaiting => !func.Invoke();

        public ActionInstruction(Func<bool> _func) {
            func = _func;
        }
    }
}