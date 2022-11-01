using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AdaptiveAudioManager : Singleton<AdaptiveAudioManager> {

    public int currentAdaptiveLevel;
    public AudioMixerSnapshot[] snapshotLevels;
    public float transitionTime = 1;

	public void AdjustAudioLevel(int level)
    {
        currentAdaptiveLevel = level;

        snapshotLevels[currentAdaptiveLevel-1].TransitionTo(transitionTime);
        Debug.Log(level);
    }
}
