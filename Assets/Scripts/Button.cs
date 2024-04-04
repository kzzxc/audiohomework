using UnityEngine;
using UnityEngine.Audio;

public class Button : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerGroup;

    private bool _isEnabled;
    private float _currentFloat;

    public void ToogleMusic()
    {
        if (_isEnabled)
        {
            _mixerGroup.audioMixer.SetFloat(_mixerGroup.name, _currentFloat);
            _isEnabled = false;
        }
        else
        {
            _mixerGroup.audioMixer.GetFloat(_mixerGroup.name, out _currentFloat);
            _mixerGroup.audioMixer.SetFloat(_mixerGroup.name, -80f);
            _isEnabled=true;
        }
    }
}
