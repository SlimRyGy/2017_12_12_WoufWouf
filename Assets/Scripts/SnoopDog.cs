using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnoopDog : Dog 
{
    #region Public Members

    public Rigidbody m_rigidbody;
    public AudioSource m_audioSource;

    #endregion

    #region Public void

    public override void Bark(float volume, float frequence)
    {
        if (volume <= 0f || volume > 1)
        {
            Debug.LogWarning("Volume of bark out of range");
        }
        else if (volume <= 0.5f)
        {
            Debug.Log(" wouf ? ");
        }
        else
        {
            Debug.Log(" WOUF ! ");
        }
        m_audioSource.volume = Mathf.Clamp01(volume);
        m_audioSource.Play();
    }

    public override void Jump(float heighCm)
    {
        m_rigidbody.AddForce(Vector3.up * 0.1f * heighCm, ForceMode.Impulse);
    }

    #endregion

    #region System

    void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion

}
