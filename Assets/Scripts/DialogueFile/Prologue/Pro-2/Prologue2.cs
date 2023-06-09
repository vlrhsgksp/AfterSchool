using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Prologue2 : MonoBehaviour
{
    /*
    [Header("DialogueGroup")]
    public TextMeshProUGUI dialogueTxt;
    public TextMeshProUGUI nameTxt;
    public Image backGroundImg;                // 배경 이미지
    public GameObject next;                    // 화살표 오브젝트
    public GameObject textPrefab;              // 백로그 전용 텍스트 프리팹
    public Transform parentContents;           // 백로그의 Contents에서 출력됨

    [Header("TextTypingGroup")]
    public float delay;                        //텍스트 출력 딜레이 
    private bool isTextTyping;                 // 텍스트 출력 여부 확인
    public bool isTextComplete = false;               // 텍스트 출력 완성 여부 확인
    private string completeText;               // 완성된 텍스트

    private bool isDialoge;                   // 대화 여부 확인

    [Header("DialogueEnd")]
    public GameObject dialogueUI;              // 대화씬 전용 UI
    public GameObject dialoguePanelText;
    public GameObject InGameUI;                // 인게임 전용 UI

    [Header("CharacterSprite")]
    public Image hujung_sprite;
    public Image youngjin_sprite;

    [Header("Animation")]
    public Animator Hujung;                    // 효정 전용 애니메이터
    public Animator YoungJin;                  // 용진 전용 애니메이터

    [Header("Direction")]
    public Animator fadeManager;                // 페이드 인 / 아웃 전용 효과
    public GameObject invenTest;
    public GameObject titleObj;

    public Scene NowScene;
    public int SceneNum;

    public Queue<Dialogue_Base.second> dialoguesecond = new Queue<Dialogue_Base.second>();


    // Start is called before the first frame update
    void Start()
    {
        dialoguesecond = new Queue<Dialogue_Base.second>();
    }

    // Update is called once per frame
    void Update()
    {
        NowScene = SceneManager.GetActiveScene(); // 매 프레임마다 현재 씬 확인하기
        SceneNum = NowScene.buildIndex;
    }

    public void EnqueuDialogue(Dialogue_Base db)
    {
        if (isDialoge) return;

        isDialoge = true;

        dialoguesecond.Clear();

        foreach (Dialogue_Base.second info in db.dialogueSecond)
        {
            dialoguesecond.Enqueue(info);
        }

        DequeueDialogue();


    }

    public void DequeueDialogue()
    {
        #region TextTyping
        isTextComplete = false;

        // 해당 대사 리스트가 전부 끝났다면 대화 종료 함수로 이동
        if (dialoguesecond.Count == 0)
        {
            Debug.Log("End");
            EndDialogue();
            return;
        }

        // 텍스트가 출력 중일 경우 
        if (isTextTyping == true)
        {
            CompleteText();
            StopAllCoroutines();
            isTextTyping = false;
            isTextComplete = true;
            return;
        }
        #endregion

        #region DequeueCon

        Dialogue_Base.second info = dialoguesecond.Dequeue();

        completeText = info.myText;

        dialogueTxt.text = info.myText;

        #endregion



        #region CharacterName
        
        if (info.charName == Name.Blank)
        {
            nameTxt.text = "";
        }

        if (info.charName == Name.Player)
        {
            nameTxt.text = "주인공";
        }

        if (info.charName == Name.Hujung)
        {
            nameTxt.text = "정효정";
        }

        if (info.charName == Name.YoungJin)
        {
            nameTxt.text = "이용진";
        }

        if (info.charName == Name.Jisu)
        {
            nameTxt.text = "은지수";
        }

        if (info.charName == Name.MinSeok)
        {
            nameTxt.text = "염민석";
        }

        if (info.charName == Name.Who)
        {
            nameTxt.text = "???";
        }
        #endregion

        #region BackLog
        // 백로그 텍스트 등록
        GameObject clone = Instantiate(textPrefab, parentContents);
        if (info.charName == Name.Blank)
        {
            clone.GetComponent<TextMeshProUGUI>().text = dialogueTxt.text;
        }
        else
        {
            clone.GetComponent<TextMeshProUGUI>().text = nameTxt.text + " : " + dialogueTxt.text;
        }
        #endregion

        dialogueTxt.text = "";
        StartCoroutine(TypeText(info));
    }

    IEnumerator TypeText(Dialogue_Base.second info)
    {
        isTextTyping = true;
        next.SetActive(false);

        foreach (char c in info.myText.ToCharArray())
        {
            yield return new WaitForSeconds(delay);
            dialogueTxt.text += c;
        }
        next.SetActive(true);
        isTextTyping = false;
        yield return new WaitForSeconds(2f);
        isTextComplete = true;

    }

    // 텍스트 자동완성 메소드(클릭 시 자동으로 텍스트가 완성되도록)
    private void CompleteText()
    {
        isTextComplete = true;
        dialogueTxt.text = completeText;
        next.SetActive(true);
    }

    // 대화 종료 메소드
    public void EndDialogue()
    {
        isDialoge = false;
        dialogueUI.SetActive(false);
        //ChapterCheck.instance.isPrologueComplete = true;
        SceneManager.LoadScene(SceneNum + 1);
    }
    */
}
