using UnityEngine;

public class MirrorFollow : MonoBehaviour
{
    public RectTransform source;
    public float smoothSpeed = 5f;  // 부드럽게 회전하는 속도

    private float targetAngle;

    void Update()
    {
        if (source == null) return;

        // 버튼 Z축 각도
        float zAngle = source.eulerAngles.z;

        // 목표 회전 각도 (90도 단위로 반올림)
        targetAngle = Mathf.Round(zAngle / 90f) * 90f;

        // 현재 회전 각도
        float currentAngle = transform.eulerAngles.z;

        // 부드럽게 회전
        float newAngle = Mathf.LerpAngle(currentAngle, targetAngle, Time.deltaTime * smoothSpeed);

        // 회전 적용
        transform.rotation = Quaternion.Euler(0f, 0f, newAngle);
    }
}
