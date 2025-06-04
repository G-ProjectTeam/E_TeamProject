using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonRotateOnClick : MonoBehaviour, IPointerClickHandler
{
    public float rotationStep = 45f; // 클릭 시 회전 각도

    public void OnPointerClick(PointerEventData eventData)
    {
        transform.Rotate(0f, 0f, rotationStep); // Z축으로 45도 회전
    }
}
