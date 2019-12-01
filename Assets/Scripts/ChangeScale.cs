using UnityEngine;
using DG.Tweening;

public class ChangeScale : MonoBehaviour {
    public float Rate = 1.1f;
    public float Time = 0.2f;

    private Vector3 baseScale;

    void Start() {
        this.baseScale = this.gameObject.transform.localScale;
    }

    void Update() {
        // IsJustChangedBeat
        // ビートが打たれたタイミングを判定
        if (Music.IsPlaying && Music.IsJustChangedBeat()) {
            // オブジェクトのサイズを変更し、すぐ戻す
            this.gameObject.transform.DOScale(this.baseScale * this.Rate, 0.0f);
            this.gameObject.transform.DOScale(this.baseScale, this.Time);
        }
    }
}
