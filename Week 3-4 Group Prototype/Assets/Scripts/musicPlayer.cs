using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicPlayer : MonoBehaviour
{
    //public bool testing = false;

    public AudioClip playingNow;
    public AudioClip[] clips;
    public bool audioMuted;
    public bool testing;
    private AudioSource audioSource;
    //public Text nameMusicClip;

    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        audioSource.loop = false;
        audioMuted = false;
    }

    public void SkipSong()
    {
        audioSource.clip = GetRandomClip();
    }
    private AudioClip GetRandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
        //nameMusicClip.text = audioSource.clip.ToString();
    }

    void Update()
    {
        if(!audioSource.isPlaying)
        {
            audioSource.clip = GetRandomClip();
            audioSource.Play();
        }

        if(Input.GetKeyDown(KeyCode.Equals))
        {
            SkipSong();
            testing = true;
        }
        if (Input.GetKeyUp(KeyCode.Equals))
        {
            testing = false;
        }
        if (Input.GetKeyUp("m"))
        {
            if(audioMuted == true)
            {
                audioSource.Stop();
                audioSource.Play();
            }
            audioMuted = !audioMuted;
            audioSource.mute = !audioSource.mute;
        }
    }
    private void LateUpdate()
    {
        playingNow = audioSource.clip;
    }
}
