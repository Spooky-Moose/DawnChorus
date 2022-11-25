using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioController : MonoBehaviour
{
    [Header("List of Tracks")]
    [SerializeField] private RadioTrack[] audioTracks;
    private int trackIndex;

    private AudioSource radioAudioSource;

    private void Start()
    {
        radioAudioSource = GetComponent<AudioSource>();

        trackIndex = 0;
        radioAudioSource.clip = audioTracks[trackIndex].trackAudioClip;

        radioAudioSource.Play();
    }

    public void SkipForward()
    {
        if (trackIndex < audioTracks.Length - 1)
        {
            trackIndex++;
            UpdateTrack(trackIndex);
        }
        
    }

    public void SkipBackward()
    {
        if (trackIndex >= 1)
        {
            trackIndex--;
            UpdateTrack(trackIndex);
        }
        
    }

    void UpdateTrack(int index)
    {
        radioAudioSource.clip = audioTracks[index].trackAudioClip;
    }

}
