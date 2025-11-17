using UnityEngine;
using UnityEngine.Playables;

public class TriggerScript : MonoBehaviour
{
    public PlayableDirector director;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            director.Play();
        }
    }
}