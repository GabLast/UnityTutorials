using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScripts : MonoBehaviour
{
    public bool background;
    // Start is called before the first frame update
    void Start()
    {
        if (background)
        {
            AudioManager.instance.PlayBackgroundMusic(AudioManager.BackgroundMusic.BackgroundMusic1);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AudioManager.instance.PlaySoundEffect(AudioManager.SoundEffect.Fire1);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            AudioManager.instance.PlaySoundEffect(AudioManager.SoundEffect.Fire2);
        }
        if (Input.GetButtonDown("Fire3"))
        {
            AudioManager.instance.PlaySoundEffect(AudioManager.SoundEffect.Fire3);
        }
        if (Input.GetButtonDown("Jump"))
        {
            AudioManager.instance.PlaySoundEffect(AudioManager.SoundEffect.Jump);
        }
    }
}
