using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Assets.Scripts.Models;

public class WebAPIClient : MonoBehaviour
{
    private UnityWebRequest www;
    private const string API_URL = "http://localhost:8080/jugador";

 
    public void SendScore(string nombreJugador, long score)
    {
        StartCoroutine(sendNewScore(nombreJugador, score));
    }

    IEnumerator sendNewScore(string nombreJugador, long score)
    {
        S3score newScore = new S3score();
        newScore.nombreJugador = nombreJugador;
        newScore.score = score;

        www = UnityWebRequest.Put(API_URL, JsonUtility.ToJson(newScore));
        www.SetRequestHeader("Content-Type", "application/json");
        yield return www.SendWebRequest();
        Debug.Log(www.downloadHandler.text);
    }

    public void GetScores()
    {
        StartCoroutine(getAllScores());
    }

    IEnumerator getAllScores()
    {
        www = UnityWebRequest.Get(API_URL);
        www.SetRequestHeader("Content-Type", "application/json");

        /*List<S3score> data = JsonUtility.FromJson<List<S3score>>(www.downloadHandler.text);*/
        yield return www.SendWebRequest();
        S3scoreContainer data = JsonUtility.FromJson<S3scoreContainer>("{\"scoreList\": " + www.downloadHandler.text + "}");
        Debug.Log(data.scoreList.Count);
        /*foreach (S3score score in data.scoreList)
        {
            Debug.Log(score.nombreJugador + " - " + score.score);
        }*/

        
    }
}
