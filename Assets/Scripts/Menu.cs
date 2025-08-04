using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private SaveGame SaveGame;

    
  public void MudarFase(string nome)
    {
        SceneManager.LoadScene(nome);
    }

    public void SalvarFase()
    {
        if (SaveGame != null)
        {
            SaveGame.SalvarJogo(SceneManager.GetActiveScene().name, 0, 0f);
            Debug.Log("Fase salva com sucesso.");
        }
        else
        {
            Debug.LogError("SaveGame não está atribuído.");
        }
    }

    public void SalvarCheckpoint()
    {
        if (SaveGame != null)
        {
            SaveGame.SalvarJogo(SceneManager.GetActiveScene().name, 1, 54.1f);
            Debug.Log("Fase salvo com sucesso, no checkpoint.");
        }
        else
        {
            Debug.LogError("SaveGame não está atribuído.");
        }
    }
}
