using LeopotamGroup.FX;
using UnityEngine;

namespace LeopotamGroup.Examples.EditorHelpers.FadeManagerTest {
    public class FadeManagerTest : MonoBehaviour {
        float _targetFade = 1f;

        bool _isLocked;

        void OnGUI () {
            if (!_isLocked) {
                if (GUILayout.Button ("Fade in/ Fade out")) {
                    _isLocked = true;
                    FadeManager.Instance.StartFadeTo (_targetFade, 1f, () => {
                        _targetFade = _targetFade > 0f ? 0f : 1f;
                        _isLocked = false;
                    });
                }
            }
        }
    }
}