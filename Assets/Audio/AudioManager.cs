using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public Sound[] sounds;
    public static AudioManager instance;

	// Use this for initialization
	void Awake () {
        
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
	}

    void Start()
    {
        Play("1-Stage"); 
    }

    // Play sound when called
    public void Play(string SoundName)
    {
        Sound s = Array.Find(sounds, Sound => Sound.name == SoundName);
        if (s == null)
        {
            Debug.LogWarning("Hello from the AudioManager Class. The sound: " + SoundName + " cannot be found.");
            return;
        }
        else
        {
            s.source.Play();
        }
    }
}
