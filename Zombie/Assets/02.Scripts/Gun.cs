using System.Collections;
using UnityEngine;

// ���� ����
public class Gun : MonoBehaviour
{
    // ���� ���¸� ǥ���ϴ� �� ����� Ÿ���� ����
    public enum State
    {
        Ready, // �߻� �غ��
        Empty, // źâ�� ��
        Reloading //  ������ ��
    }

    public State state { get; private set; } // ���� ���� ����

    public Transform fireTransform; // ź���� �߻�� ��ġ

    public ParticleSystem muzzleFlashEffect; // �ѱ� ȭ�� ȿ��
    public ParticleSystem shellEjectEffect; // ź�� ���� ȿ��

    private LineRenderer bulletLineRenderer; // ź�� ������ �׸��� ���� ������
    
    private AudioSource gunAudioPlayer; //  �� �Ҹ� ������

    public GunData gunData; // ���� ���� ������

    private float fireDistance = 50f; // �����Ÿ�

    public int ammoRemain = 100; // ���� ��ü ź��
    public int magAmmo; // ���� źâ�� �����ִ� ź��

    private float lastFireTime; // ���� ���������� �߻��� ����
    
    private void Awake()
    {
        // ����� ������Ʈ�� ���� ��������
    }

    private void OnEnable()
    {
        // �� ���� �ʱ�ȭ
    }

    // �߻� �õ�
    public void Fire()
    {

    }

    // ���� �߻� ó��
    private void Shot()
    {

    }
    // �߻� ����Ʈ�� �Ҹ��� ����ϰ� ź�� ������ �׸�
    private IEnumerator ShotEffect(Vector3 hitPosition)
    {
        // ���� �������� Ȱ��ȭ�Ͽ� ź�� ������ �׸�
        bulletLineRenderer.enabled = true;

        // 0.03�� ���� ��� ó���� ���
        yield return new WaitForSeconds(0.03f);

        // ���� �������� ��Ȱ��ȭ�Ͽ� ź�� ������ ����
        bulletLineRenderer.enabled = false;
    }

    // ������ �õ� 
    public bool Reload()
    {
        return false;
    }

    // ���� ������ ó���� ����
    private IEnumerator ReloadRoutine()
    {
        // ���� ���¸� ������ �� ���·� ��ȯ
        state = State.Reloading;

        // ������ �ҿ� �ð���ŭ ó�� ����
        yield return new WaitForSeconds(gunData.reloadTime);

        // ���� ���� ���¸� �߻� �غ�� ���·� ����
        state = State.Ready;
    }
}
