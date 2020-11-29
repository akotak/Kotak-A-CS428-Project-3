using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOn : MonoBehaviour
{
    public AudioSource audiosource1, audiosource2, audiosource3, audiosource4;

    public void turnOnOff()
    {
        if (audiosource1.isPlaying)
        {
            audiosource1.Stop();
            audiosource2.Stop();
            audiosource3.Stop();
            audiosource4.Stop();
        }
        else
        {
            audiosource1.Play();
            audiosource2.Play();
            audiosource3.Play();
            audiosource4.Play();
        }
    }
}
