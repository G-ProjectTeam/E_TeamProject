using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonDragRotate : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    private float startAngle;

    public void OnBeginDrag(PointerEventData eventData)
    {
        startAngle = GetAngle(eventData.position);
    }

    public void OnDrag(PointerEventData eventData)
    {
        float currentAngle = GetAngle(eventData.position);
        float deltaAngle = currentAngle - startAngle;

        transform.Rotate(0f, 0f, deltaAngle); // 버튼 이미지 회전
        startAngle = currentAngle; // 다음 드래그를 위해 시작 각도 갱신
    }

    private float GetAngle(Vector2 screenPos)
    {
        Vector2 center = RectTransformUtility.WorldToScreenPoint(null, transform.position);
        Vector2 dir = screenPos - center;
        return Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    }
}
