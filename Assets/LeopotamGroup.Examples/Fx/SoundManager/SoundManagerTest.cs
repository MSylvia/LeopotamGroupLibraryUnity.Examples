using LeopotamGroup.Common;
using LeopotamGroup.Fx;
using UnityEngine;

namespace LeopotamGroup.Examples.FX.SoundManagerTest {
    public class SoundManagerTest : MonoBehaviour {
        [SerializeField]
        AudioClip _fxClip = null;

        const string MusicName = "Music/Forest";

        // ReSharper disable once InconsistentNaming
        void OnGUI () {
            var sm = Singleton.Get<SoundManager> ();
            if (GUILayout.Button ("Turn on music")) {
                sm.PlayMusic (MusicName, true);
            }
            if (GUILayout.Button ("Turn off music")) {
                sm.StopMusic ();
            }
            if (_fxClip != null && GUILayout.Button ("Play FX at channel 1 without interrupt")) {
                sm.PlayFx (_fxClip);
            }
            if (_fxClip != null && GUILayout.Button ("Play FX at channel 1 with interrupt")) {
                sm.PlayFx (_fxClip, SoundFxChannel.First, true);
            }
        }
    }
}