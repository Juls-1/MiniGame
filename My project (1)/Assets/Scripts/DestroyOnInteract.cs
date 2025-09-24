using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class DestroyOnInteract : MonoBehaviour
{
    [Header("Special Effect")]
    public VisualEffect specialEffect; 
    public float effectLifetime = 2f;     

    public void OnInteract()
    {
      
        if (specialEffect != null)
        {
            specialEffect.Play();
        }

        // Destroy this object
        Destroy(gameObject);
    }
}
