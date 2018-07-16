using UnityEngine;
using System.Collections;
using System.Text;
// anti cheat key를 자주바꿔주고 여기서도 정의 도움말봐야됨



public class ScoreManager : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText;
    StringBuilder scoreTextBuilder = new StringBuilder();




    static ScoreManager _instance = null;
    int _bestScore = 0;
    int _myScore = 0;

    void Update()
    {
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreTextBuilder.Length = 0;
        scoreTextBuilder.AppendFormat("Best Score:{0}\nScore:{1}", bestScore, myScore);
        scoreText.text = scoreTextBuilder.ToString();
    }

    public int bestScore
    {
        get
        {
            return _bestScore;
        }


    }

    public int myScore
    {
        get
        {
            return _myScore;
        }
        set
        {
            _myScore = value;
            if(_myScore > _bestScore)
            {
                _bestScore = _myScore;
            }
        }
    }





    public static ScoreManager Instance()
    {
        return _instance;
    }

    void Start()
    {
        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }














}
