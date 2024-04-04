using UnityEngine;
using UnityEngine.Audio;

public class Slider : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerGroup;

    public void ChangeVolume(float volume)
    {
        _mixerGroup.audioMixer.SetFloat(_mixerGroup.name, Mathf.Lerp(-80, 0, volume));
    }
}
