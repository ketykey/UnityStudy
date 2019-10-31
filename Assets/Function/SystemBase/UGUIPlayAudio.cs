using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UGUIPlayAudio : MonoBehaviour
{
    public new AudioSource audio;
    public Slider volumeSlider;
    public float volume;
    void Start() {
        volume = 0.2f;
        volumeSlider.value = volume;
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartOnclick()
    {
        if (!audio.isPlaying)
        {
            audio.Play();
        }
    }
    public void PauseOnclick()
    {
        if (audio.isPlaying)
        {
            audio.Pause();
        }
    }

    public void StopClick()
    {
        if (audio.isPlaying)
        {
            audio.Stop();
        }
    }
    public void SliderChange() {
        if (audio.isPlaying)
        {
            volume = volumeSlider.value;
            audio.volume = volume;
        }
    }
}
