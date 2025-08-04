using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class SaveGame : MonoBehaviour
{

    private Dictionary<string, int> fases = new Dictionary<string, int>()
    {
        {"fase", (0)},
        {"fase2", (0)},
        {"fase3", (0)},
        {"fase4", (0)},
        {"fase5", (0)},
        {"fase6", (0)},
        {"fase7", (0)},
        {"fase8", (0)},
        {"fase9", (0)},
        {"fase10", (0)},
        {"fase11", (0)},
        {"fase12", (0)},
        {"fase13", (0)}
    };
    private int checkPoint;
    private float pontos;

    public void SalvarJogo(string fase, int checkPoint, float pontos)
    {
        PlayerPrefs.SetInt(fase, 1);
        PlayerPrefs.SetInt("CheckPoint", checkPoint);
        PlayerPrefs.SetFloat("Pontos", pontos);
        PlayerPrefs.Save();
    }

    public void CarregarJogo()
    {
        foreach (var fase in fases.Keys)
        {
            if (PlayerPrefs.HasKey(fase))
            {
                fases[fase] = PlayerPrefs.GetInt(fase);
            }

            checkPoint = PlayerPrefs.GetInt("CheckPoint");
            pontos = PlayerPrefs.GetFloat("Pontos");
        }
    }

    public bool VerificaSaveGame()
    {
        bool temSave = PlayerPrefs.HasKey("NomeFase") && 
                        PlayerPrefs.HasKey("CheckPoint") &&
                           PlayerPrefs.HasKey("Pontos");
        return temSave;
    }
    public Dictionary<string, int> GetNomeFase()
    {
        return fases;
    }
    public int GetCheckPoint()
    {
        return checkPoint;
    }

    public float GetPontos()
    {
        return pontos;
    }
}