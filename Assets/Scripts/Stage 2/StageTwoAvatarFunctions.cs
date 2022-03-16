using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class StageTwoAvatarFunctions : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioMixer _audioMixer;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void ResetDeformations(GameObject targetObject)
    {
        DeformMesh(targetObject,-1* targetObject.transform.position);
    }

    public void DeformMesh(GameObject targetObject,Vector3 positionDeformation)
    {
        targetObject.transform.position = targetObject.transform.position + positionDeformation;
    }

    public void PlaySound(AudioClip clipToPlay, float volume, float clipTempo)
    {
        if(!_audioSource.isPlaying)
        {
            _audioSource.Stop();
            _audioSource.pitch = clipTempo;
            _audioMixer.SetFloat("pitchBend", 1f / clipTempo);
            _audioSource.volume = volume;
            _audioSource.clip = clipToPlay;
            _audioSource.Play(0);
        }
            
    }

    public void StopSound()
    {
        _audioSource.Stop();
        _audioSource.pitch = 1f;
        _audioMixer.SetFloat("pitchBend", 1f);
    }

}
