using UnityEngine;
using UnityEngine.EventSystems;

public class DragRotateByMouse : MonoBehaviour, IBeginDragHandler, IDragHandler
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

        transform.Rotate(0f, 0f, deltaAngle);  // Z축 회전
        startAngle = currentAngle;             // 다음 회전을 위해 갱신
    }

    private float GetAngle(Vector2 screenPos)
    {
        Vector2 objectPos = RectTransformUtility.WorldToScreenPoint(null, transform.position);
        Vector2 direction = screenPos - objectPos;
        return Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    }
}
