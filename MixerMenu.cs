using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerMenu : MonoBehaviour {

    public AudioMixer audioMix;

    public void SetVolume (float v)
    {
        audioMix.SetFloat("volume", v);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

}
