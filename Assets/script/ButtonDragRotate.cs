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

        transform.Rotate(0f, 0f, deltaAngle); // ��ư �̹��� ȸ��
        startAngle = currentAngle; // ���� �巡�׸� ���� ���� ���� ����
    }

    private float GetAngle(Vector2 screenPos)
    {
        Vector2 center = RectTransformUtility.WorldToScreenPoint(null, transform.position);
        Vector2 dir = screenPos - center;
        return Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    }
}
