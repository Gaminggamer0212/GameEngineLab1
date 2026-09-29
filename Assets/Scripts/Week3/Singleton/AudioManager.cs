using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    public AudioSource source;
    public AudioSource musicSource;
    
    [Range(0f, 1f)] public float musicVolume = 1f;
    [Range(0f, 1f)] public float sfxVolume = 1f;

    public void PlaySound(AudioClip clip)
    {
        source.PlayOneShot(clip, sfxVolume);
    }
    
    public void PlayMusic(AudioClip clip, bool loop)
    {
        musicSource.clip = clip;
        musicSource.loop = loop;
        musicSource.volume = musicVolume;
        musicSource.Play();
    }

    public void ChangeSfxVolume(float volume)
    {
        //just to protect make sure it's within 0 to 1
        sfxVolume = Mathf.Clamp01(volume);
    }

    public void ChangeMusicVolume(float volume)
    {
        musicVolume = Mathf.Clamp01(volume);
        musicSource.volume = musicVolume;
    }
}
