using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerScript : MonoBehaviour
{
    // Deze events kun je in de Inspector vullen
    public UnityEvent OnTriggerEnterEvent;
    public UnityEvent OnTriggerExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        // Check of het object een CharacterController heeft (VR rig)
        if (other.gameObject.GetComponent<CharacterController>())
        {
            Debug.Log("Speler is door de kubus gelopen!");
            // Trigger het UnityEvent
            OnTriggerEnterEvent?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            Debug.Log("Speler verlaat de kubus.");
            OnTriggerExitEvent?.Invoke();
        }
    }
}