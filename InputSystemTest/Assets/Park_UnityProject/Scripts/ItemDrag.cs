using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrag : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler   //IPointerClickHandler : �������̽�
{
    private Canvas uiCanvas = default;
    private RectTransform itemRect = default;

    private GameObject sdPlayer = default;

    private bool isDraging = false;

    public delegate void MyLogFunc(object message);
    public MyLogFunc myLogFunc = default;

    private System.Action<object, int, int> myAction;
    private delegate void myAction001(object message, int number1, int number2);

    private System.Func<float, float, int, int, string> myFunc;
    private delegate string myFunction001(float f1, float f2, int i1, int i2);

    private void Awake()
    {
        uiCanvas = GFunc.GetRootObj("UiCanvas").GetComponent<Canvas>();
        itemRect = GetComponent<RectTransform>();

        //sdPlayer = GFunc.GetRootObj("Set Costume_03 SD Misaki");
        //GameObject MisakiLeftEye = sdPlayer.FindChildObj("Eye_L");
        //Debug.LogFormat("Misaki is null {0}, Misaki's left eye is null {1}", sdPlayer == null, MisakiLeftEye == null);

        isDraging = false;

        int number = 100;

        //myLogFunc myLogFunc = Debug.Log;
        myLogFunc = (object obj_) =>
        {
            Debug.Log("�� �αװ� �� �������� �׽�Ʈ");
            Debug.Log("�Ѱܹ��� �޽�����");
            Debug.Log(obj_);

            Debug.LogFormat("���⼭ number ���� ���������� ����� �� ������?? {0}", number);
        };

        myLogFunc("�������� �� �α� �Լ��� �� ���ϴ�.");
    }

    // Start is called before the first frame update
    void Start()
    {
        //itemRect.anchoredPosition += new Vector2(100f, 0f);     //��Ŀ�� ������
        //itemRect.localPosition += new Vector3(100f, 0f,0f);     //���� ������
    }

    // Update is called once per frame
    void Update()
    {

    }

    // ���콺 ������ ���
    public void OnPointerDown(PointerEventData eventData)
    {
        isDraging = true;

        Debug.Log("���콺 ���ʹ�ư Ŭ���� �ٷ� �� ����");
    }

    // ������ �巡�� �����̱�
    public void OnDrag(PointerEventData eventData)
    {
        if (isDraging == true)
        {
            // LEGACY:
            //itemRect.anchoredPosition += eventData.delta;
            itemRect.anchoredPosition += (eventData.delta / uiCanvas.scaleFactor);

            //Debug.LogFormat("�������� ������ �غ� �Ǿ���. -> {0}", eventData.delta);
        }
    }

    // ���콺 ������ ���� ���
    public void OnPointerUp(PointerEventData eventData)
    {
        isDraging = false;
    }

    // ���콺 Ŭ���� ���
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("�̰� �Լ� ����� ���ε� ������ Ŭ���� �ǳ�??");
    }
}
