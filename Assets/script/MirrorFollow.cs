using UnityEngine;

public class MirrorFollow : MonoBehaviour
{
    public RectTransform source;

    void Update()
    {
        if (source == null) return;

        // 버튼의 Z축 회전 각도 얻기 (0~360으로 정규화)
        float zAngle = source.eulerAngles.z;

        // 가장 가까운 90도 각도로 반올림
        float snappedAngle = Mathf.Round(zAngle / 90f) * 90f;

        // 거울 이미지를 스냅된 각도로 회전
        transform.rotation = Quaternion.Euler(0f, 0f, snappedAngle);
    }
}
