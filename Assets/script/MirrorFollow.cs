using UnityEngine;

public class MirrorFollow : MonoBehaviour
{
    public RectTransform source;

    void Update()
    {
        if (source == null) return;

        // ��ư�� Z�� ȸ�� ���� ��� (0~360���� ����ȭ)
        float zAngle = source.eulerAngles.z;

        // ���� ����� 90�� ������ �ݿø�
        float snappedAngle = Mathf.Round(zAngle / 90f) * 90f;

        // �ſ� �̹����� ������ ������ ȸ��
        transform.rotation = Quaternion.Euler(0f, 0f, snappedAngle);
    }
}
