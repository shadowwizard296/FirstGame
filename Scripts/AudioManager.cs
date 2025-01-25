using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("--------- Audio Source --------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Clip -------------")]
    public AudioClip HomeScreenMusic;
    public AudioClip StageOneMusic;
    public AudioClip StageTwoMusic;
    public AudioClip StageThreeMusic;
    public AudioClip Jump;
    public AudioClip Death;
    public AudioClip StageComplete;
    public AudioClip OnClickSFX;

    private void Start()
    {
        musicSource.clip = HomeScreenMusic;
        musicSource.Play();
    }

    public void PlaySFX (AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
