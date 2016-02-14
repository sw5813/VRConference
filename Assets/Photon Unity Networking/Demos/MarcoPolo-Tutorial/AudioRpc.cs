<<<<<<< HEAD
using UnityEngine;

public class AudioRpc : Photon.MonoBehaviour
{

    public AudioClip marco;
    public AudioClip polo;

    AudioSource m_Source;

    void Awake()
    {
        m_Source = GetComponent<AudioSource>();
    }

    [PunRPC]
    void Marco()
    {
        if( !this.enabled )
        {
            return;
        }

        Debug.Log( "Marco" );

        m_Source.clip = marco;
        m_Source.Play();
    }

    [PunRPC]
    void Polo()
    {
        if( !this.enabled )
        {
            return;
        }

        Debug.Log( "Polo" );

        m_Source.clip = polo;
        m_Source.Play();
    }

    void OnApplicationFocus( bool focus )
    {
        this.enabled = focus;
    }
}
=======
using UnityEngine;

public class AudioRpc : Photon.MonoBehaviour
{

    public AudioClip marco;
    public AudioClip polo;

    AudioSource m_Source;

    void Awake()
    {
        m_Source = GetComponent<AudioSource>();
    }

    [PunRPC]
    void Marco()
    {
        if( !this.enabled )
        {
            return;
        }

        Debug.Log( "Marco" );

        m_Source.clip = marco;
        m_Source.Play();
    }

    [PunRPC]
    void Polo()
    {
        if( !this.enabled )
        {
            return;
        }

        Debug.Log( "Polo" );

        m_Source.clip = polo;
        m_Source.Play();
    }

    void OnApplicationFocus( bool focus )
    {
        this.enabled = focus;
    }
}
>>>>>>> 3fcd8fda4bc9610008a6f5ef1ff24faad1bce302
