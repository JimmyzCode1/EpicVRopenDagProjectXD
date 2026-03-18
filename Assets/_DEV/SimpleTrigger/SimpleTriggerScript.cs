using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerScript : MonoBehaviour
{
    public UnityEvent OnTriggerEnterEvent;
    public UnityEvent OnTriggerExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            Debug.Log("Player entered the trigger.");
            OnTriggerEnterEvent?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            Debug.Log("Player left the trigger.");
            OnTriggerExitEvent?.Invoke();
        }
    }
}