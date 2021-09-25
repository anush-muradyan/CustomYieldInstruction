using System.Collections;
using DefaultNamespace;
using UnityEngine;

class Test : MonoBehaviour {
    private Coroutine coroutine;

    private void Start() {
        // coroutine = StartCoroutine(waitForKeyCode());
        // coroutine = StartCoroutine(waitForMouse());
        coroutine = StartCoroutine(waitForAction());
    }

    private IEnumerator waitForKeyCode() {
        while (true) {
            Debug.LogError("First step after key code");
            yield return new WaitForKeyCode(KeyCode.Space);
            Debug.LogError("Last step after key code");
        }
    }

    private IEnumerator waitForMouse() {
        while (true) {
            Debug.LogError("First step after mouse");
            yield return new WaitForMouse(0);
            Debug.LogError("Last step after mouse");
        }
    }

    private IEnumerator waitForAction() {
        while (true) {
            Debug.LogError("First step after action");
            yield return new ActionInstruction(() => Input.GetKeyDown(KeyCode.Space));
            Debug.LogError("Last step after action");
        }
    }

    private void OnDestroy() {
        StopCoroutine(coroutine);
    }
}