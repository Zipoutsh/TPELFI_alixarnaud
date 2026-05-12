using UnityEngine;

public class CrowScript : MonoBehaviour
{
    [SerializeField] private AudioSource CrowAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(PlayCrow), (Random.Range(3f, 5f)), (Random.Range(5f, 9f)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayCrow()
    {
        CrowAudio.Play();
        Debug.Log("JOUE");
    }
}
