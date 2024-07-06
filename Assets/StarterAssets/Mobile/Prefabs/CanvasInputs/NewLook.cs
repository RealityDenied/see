using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;

public class NewLook : MonoBehaviour, IDragHandler {
    private Vector2 previousPosition;
    private Vector2 currentPosition;
    private Coroutine dragCoroutine;
    public float checkDelay = 0.01f; // Adjust this value according to your preference

    public UnityEvent<Vector2> touchZoneOutputEvent;

    void Start() {
        previousPosition = Vector2.zero;
        currentPosition = Vector2.zero;
    }

    public void OnDrag(PointerEventData eventData) {
        currentPosition = eventData.position;

        if (previousPosition != Vector2.zero) {
            Vector2 deltaPosition = currentPosition - previousPosition;
            deltaPosition.y *= -1; // Invert Y-axis
            touchZoneOutputEvent.Invoke(deltaPosition *10f );

            // Cancel the coroutine since the panel is still moving
            if (dragCoroutine != null) {
                StopCoroutine(dragCoroutine);
                dragCoroutine = null;
            }
        }

        previousPosition = currentPosition;

        // Start the coroutine to check if the panel has stopped moving
        dragCoroutine = StartCoroutine(CheckPanelMovement());
    }

    IEnumerator CheckPanelMovement() {
        yield return new WaitForSeconds(checkDelay);

        // Check if the panel has stopped moving
        if (previousPosition == currentPosition && previousPosition != Vector2.zero) {
            touchZoneOutputEvent.Invoke(Vector2.zero);
            previousPosition = Vector2.zero; // Reset previous position
        }

        dragCoroutine = null;
    }
}
