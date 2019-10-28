using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(AudioSource))]
public class SEPlayQuantizeButton : MonoBehaviour, IPointerDownHandler {
    public void OnPointerDown(PointerEventData eventData) {
        Music.QuantizePlay(this.GetComponent<AudioSource>());
    }
}
