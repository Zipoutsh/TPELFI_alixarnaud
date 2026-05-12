using UnityEngine;

public class LeavesScript : MonoBehaviour
{
    [SerializeField] private AudioSource LeavesAudio;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LeavesAudio.pitch = (Random.Range(0.6f, .9f));
        LeavesAudio.time = Random.value * LeavesAudio.clip.length;
        LeavesAudio.Play();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
