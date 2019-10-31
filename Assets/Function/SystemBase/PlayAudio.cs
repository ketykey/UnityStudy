using UnityEngine;
using System.Collections;
public class PlayAudio : MonoBehaviour
{
    public new AudioSource audio;
    public float volume;
    void Start() {
        volume = 0.2f;
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 200, 100), "Play"))
        {
            if (!audio.isPlaying)
            {
                audio.Play();
            }
        }
        if (GUI.Button(new Rect(10, 120, 200, 100), "Close"))
        {
            if (audio.isPlaying)
            {
                audio.Stop();
            }
        }
        if (GUI.Button(new Rect(10, 230, 200, 100), "Pause"))
        {
            if (audio.isPlaying)
            {
                audio.Pause();
            }
        }
        volume = GUI.HorizontalSlider(new Rect(250, 50, 200, 50), volume, 0, 1);
        GUI.Label(new Rect(250, 70, 300, 20), "Volume:" + (int)(volume * 100) + "%");
        if (audio.isPlaying)
        {
            audio.volume = volume;
        }
    }
    public void StartOnclick() {
        if (!audio.isPlaying)
        {
            audio.Play();
        }
    }
    public void PauseOnclick() {
        if (audio.isPlaying)
        {
            audio.Pause();
        }
    }

    public void StopClick() {
        if (audio.isPlaying)
        {
            audio.Stop();
        }
    }
}

