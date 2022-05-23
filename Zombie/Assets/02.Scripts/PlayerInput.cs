using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �÷��̾� ĳ���͸� �����ϱ� ���� ����� �Է��� ����
// ������ �Է°��� �ٸ� ������Ʈ�� ����� �� �ֵ��� ����
public class PlayerInput : MonoBehaviour
{
    // �յ� �������� ���� �Է��� �̸�
    public string moveAxisName = "Vertical";
    // �¿� ȸ���� ���� �Է��� �̸�
    public string rotateAxisName = "Horizontal";
    // �߻縦 ���� �Է� ��ư �̸�
    public string fireButtonName = "Fire1";
    // �������� ���� �Է� ��ư �̸�
    public string reloadButtonName = "Reload";

    // �� �Ҵ��� ���ο����� ����
    /// <summary>
    /// ������ ������ �Է°�(������Ƽ)
    /// </summary>
    public float move { get; private set; }
    /// <summary>
    /// ������ ȸ�� �Է°�(������Ƽ)
    /// </summary>
    public float rotate { get; private set; }
    /// <summary>
    /// ������ �߻� �Է°�(������Ƽ)
    /// </summary>
    public bool fire { get; private set; }
    /// <summary>
    /// ������ ������ �Է°�(������Ƽ)
    /// </summary>
    public bool reload { get; private set; }

    void Update() // �������� ����� �Է��� ����
    {
        // ���ӿ��� ���¿����� ����� �Է��� �������� ����
        if (GameManager.instance != null && GameManager.instance.isGameover)
        {
            move = 0; rotate = 0; fire = false; reload = false;
            return;
        }

        // move�� ���� �Է� ����
        move = Input.GetAxis(moveAxisName);
        // rotate�� ���� �Է� ����
        rotate = Input.GetAxis(rotateAxisName);
        // fire�� ���� �Է� ����
        fire = Input.GetButton(fireButtonName);
        // reload�� ���� �Է� ����
        reload = Input.GetButtonDown(reloadButtonName);
    }

    /// <summary>
    /// ������ó�� �޼���
    /// </summary>
    /// <param name="�ӵ�">������ �̵� �ӷ�</param>
    /// <param name="���⼺">���⼺</param>
    public void Movement(int speed, float a)
    {

    }
}