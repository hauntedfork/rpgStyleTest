using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aniSound : MonoBehaviour
{
    AudioSource walkSound;
    // Start is called before the first frame update
    void Start()
    {
        walkSound = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void walkCycle()
    {
        walkSound.Play();
    }
}
