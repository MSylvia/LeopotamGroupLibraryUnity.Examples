using LeopotamGroup.Common;
using LeopotamGroup.FX;
using UnityEngine;

namespace LeopotamGroup.Examples.FX.SoundManagerTest {
    public class SoundManagerTest : MonoBehaviour {
        public AudioClip FXClip = null;

        const string MusicName = "Music/Forest";

        void OnGUI () {
            var sm = Singleton.Get<SoundManager> ();
            if (GUILayout.Button ("Turn on music")) {
                sm.PlayMusic (MusicName, true);
            }
            if (GUILayout.Button ("Turn off music")) {
                sm.StopMusic ();
            }
            if (FXClip != null && GUILayout.Button ("Play FX at channel 1 without interrupt")) {
                sm.PlayFX (FXClip);
            }
            if (FXClip != null && GUILayout.Button ("Play FX at channel 1 with interrupt")) {
                sm.PlayFX (FXClip, SoundFXChannel.First, true);
            }
        }
    }
}