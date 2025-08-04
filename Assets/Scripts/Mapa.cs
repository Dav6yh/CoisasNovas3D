using System.Collections.Generic;
using UnityEngine;

public class Mapa : MonoBehaviour
{
    [SerializeField] private List<GameObject> fases = new List<GameObject>();
    [SerializeField] SaveGame saveGame;

    private void Awake()
    {
        if (saveGame != null)
        {
            saveGame = FindFirstObjectByType<SaveGame>();
        }
    }

    private void Start()
    {
        VerificarFases();
    }
    public void VerificarFases()
    {
        
        if (saveGame.VerificaSaveGame())
        {
            saveGame.CarregarJogo();
            Debug.Log("Jogo carregado com sucesso");

            foreach(KeyValuePair<string, int> fase in saveGame.GetNomeFase())
            {
                foreach (GameObject faseObj in fases)
                {
                    if (faseObj)
                }
            }
        }
        else
        {
            Debug.Log("Nenhum jogo encontrado");
        }
    }
}
