using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

using OpenTDB;

public class QuestionRequest : MonoBehaviour
{

    [SerializeField]
    private string url = "https://opentdb.com/api.php?amount=1";

    private Action<Response> successCallback = null;


    private IEnumerator Request()
    {
        UnityWebRequest req = UnityWebRequest.Get(url);
        yield return req.SendWebRequest();


            byte[] byteResponse = req.downloadHandler.data;
            Success(ToText(byteResponse));
    }

    private void Success(string response)
    {
        Response res = JsonUtility.FromJson<Response>(response);
        successCallback(res);
    }

    public static string ToText(byte[] bytes)
    {
        return System.Text.Encoding.Default.GetString(bytes);
    }

    public void MakeRequest(Action<Response> successCallback)
    {
        this.successCallback = successCallback;
        StartCoroutine(Request());
    }
}
