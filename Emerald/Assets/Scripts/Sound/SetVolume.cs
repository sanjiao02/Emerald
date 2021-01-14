using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    [SerializeField] string volumeName = "MasterVolume";
    // Start is called before the first frame update

    public void SetLevel(float Slidervalue)
    {
        mixer.SetFloat(volumeName, Mathf.Log10(Slidervalue) * 20);
    }
}
