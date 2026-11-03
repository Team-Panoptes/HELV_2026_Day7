using UnityEngine;
using UnityEngine.Audio;

public class TriggerSound : MonoBehaviour
{

    [SerializeField] AudioSource source;

    [SerializeField] AudioMixerSnapshot snapshot;

    void OnTriggerEnter(Collider other)
    {
        source.Play();
        snapshot.TransitionTo(2);
    }

}
