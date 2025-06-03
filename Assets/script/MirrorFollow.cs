using UnityEngine;

public class MirrorFollow : MonoBehaviour
{
    public RectTransform source;
    public float smoothSpeed = 5f;  // �ε巴�� ȸ���ϴ� �ӵ�

    private float targetAngle;

    void Update()
    {
        if (source == null) return;

        // ��ư Z�� ����
        float zAngle = source.eulerAngles.z;

        // ��ǥ ȸ�� ���� (90�� ������ �ݿø�)
        targetAngle = Mathf.Round(zAngle / 90f) * 90f;

        // ���� ȸ�� ����
        float currentAngle = transform.eulerAngles.z;

        // �ε巴�� ȸ��
        float newAngle = Mathf.LerpAngle(currentAngle, targetAngle, Time.deltaTime * smoothSpeed);

        // ȸ�� ����
        transform.rotation = Quaternion.Euler(0f, 0f, newAngle);
    }
}
