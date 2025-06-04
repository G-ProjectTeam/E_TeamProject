using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonRotateOnClick : MonoBehaviour, IPointerClickHandler
{
    public float rotationStep = 45f; // Ŭ�� �� ȸ�� ����

    public void OnPointerClick(PointerEventData eventData)
    {
        transform.Rotate(0f, 0f, rotationStep); // Z������ 45�� ȸ��
    }
}
