using UnityEngine;
using UnityEngine.SceneManagement;  // シーンの切り替えに必要
using UnityEngine.InputSystem; //InputSystemを使うのに必要

public class TitleManager : MonoBehaviour
{
    public string sceneName;            // 読み込むシーン名
    //public InputAction submitAction; //InputAction型の入力情報

    //このスクリプトがゲーム上で有効になったとき
    //private void OnEnable()
    //{
    //    submitAction.Enable(); //InputActionを有効化
    //}
    ////このスクリプトがゲーム上で無効になったとき
    //private void OnDisable()
    //{
    //    submitAction.Disable(); //InputActionを無効化
    //}

    //On+[InputActionアセットデータのアクション名](InputValue)でメソッドを定義する
    void OnSubmit(InputValue value)
    {
        Load();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //Keyboard kb = Keyboard.current;
        //if (kb != null) //kbに何か具体的な情報があった
        //{
        //    //特定のキーが押されたかどうかを確認
        //    if (kb.enterKey.wasPressedThisFrame)
        //    {
        //        Load();
        //    }

        //if(submitAction.WasPressedThisFrame())
        //{
        //    Load();
        //}
    }

    // シーンを読み込む
    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }
}
