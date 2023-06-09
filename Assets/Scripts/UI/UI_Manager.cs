using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    
    [Header("메인 로비")]
    [SerializeField]
    private GameObject popUpObj;                       // 팝업창
    [SerializeField]
    private GameObject nameQuestionPop;                // 이름 설정 팝업 여부(임시)
    [SerializeField]
    private GameObject nameSelectObj;                  // 이름 설정 팝업
    [SerializeField]
    private GameObject gameOptionObj;                  // 메인 로비 기능 목록(임시)
    [SerializeField]
    private GameObject chapterSelectObj;               // 챕터 선택 목록

    [Header("미니 게임")]
    [SerializeField]
    private GameObject thinkGoNext;

    
    public Scene NowScene;
    public int SceneNum;

    public int saveSceneNum;

    private void Start()
    {
        // StroyDataMgn의 isAutoLive가 true일 때 각 대화씬 오토 버튼 활성화인 상태로 두기

        // 2배속도 마찬가지
       
    }

    private void Update()
    {
        NowScene = SceneManager.GetActiveScene(); // 매 프레임마다 현재 씬 확인하기
        SceneNum = NowScene.buildIndex;
    }


    #region Button Click Next Scene
    public void GoMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }

    public void StartPrologue()
    {
        SceneManager.LoadScene(1);
    }

    /*
    public void StartChapter1()
    {

    }


    public void StartChapter2()
    {

    }

    public void StartChapter3()
    {

    }

    public void StartChapter4()
    {

    }

    */

    public void GameExit()
    {
        Application.Quit();
    }
    #endregion

    #region Dialogue Logic
    
    public void AutoOn()
    {
        StroyDataMgn.instance.isAutoLive = true;
    }

    public void AutoOff()
    {
        StroyDataMgn.instance.isAutoLive = false;
    }

    public void TwoSpeedOn()
    {
        StroyDataMgn.instance.isTwoSpeed = true;
    }

    public void TwoSpeedOff()
    {
        StroyDataMgn.instance.isTwoSpeed = false;
    }

    #endregion

    #region GameOption
    public void ChapterListOn()
    {
        gameOptionObj.gameObject.SetActive(false);
        chapterSelectObj.gameObject.SetActive(true);
    }

    public void ChapterListOff()
    {
        chapterSelectObj.gameObject.SetActive(false);
        gameOptionObj.gameObject.SetActive(true);
    }

    public void popUpOn()
    {
        popUpObj.gameObject.SetActive(true);
    }

    public void popUpOff()
    {
        popUpObj.gameObject.SetActive(false);
    }

    public void namePopUpOn()
    {
        nameQuestionPop.gameObject.SetActive(true);
    }

    public void namePopUpOff()
    {
        nameQuestionPop.gameObject.SetActive(false);
    }

    public void nameSelectOn()
    {
        nameQuestionPop.gameObject.SetActive(false);
        nameSelectObj.gameObject.SetActive(true);
    }

    #endregion

    #region ThinkGame
    public void GoToDialogueScene()
    {
        SceneManager.LoadScene(SceneNum + 1);
    }

    #endregion

    #region SceneLoading
    public void LoadScene()
    {
        StartCoroutine(SceneLoading());
    }

    IEnumerator SceneLoading()
    {
        yield return null;

        SceneManager.LoadScene(SaveLoadMgn.instance.loadNum);
    }
    #endregion

   

}
