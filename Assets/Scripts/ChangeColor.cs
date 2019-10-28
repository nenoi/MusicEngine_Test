using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

// SpriteRendererでも可
[RequireComponent(typeof(Image))]
public class ChangeColor : MonoBehaviour {
    public float Time = 0.2f;

    private Image selfImage;

    private void Awake() {
        selfImage = GetComponent<Image>();
    }

    void Update() {
        if (Music.IsPlaying && Music.IsJustChangedBar()) {
            Color color = new Color(
                Random.Range(0.5f, 0.8f),
                Random.Range(0.5f, 0.8f),
                Random.Range(0.5f, 0.8f),
                1f
            );
            selfImage.DOColor(color, Time);
        }
    }
}
