using UnityEngine;

// Classe principal do script.
// MonoBehaviour permite que o script funcione como componente do Unity.
public class ObjetoInterativo : MonoBehaviour
{
    // Variável pública para receber o componente AudioSource pelo Inspector.
    // Aqui será ligado o som que o objeto deve tocar.
    public AudioSource audioSource;

    // Variável de controle para impedir que o áudio toque infinitamente.
    // Começa como false porque o objeto ainda não foi ativado.
    private bool jaTocou = false;

    // Método chamado automaticamente pelo Unity
    // quando outro objeto entra na área do collider marcado como Trigger.
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o som ainda não foi tocado.
        if (!jaTocou)
        {
            // Marca como verdadeiro para impedir novas execuções.
            jaTocou = true;

            // Exibe mensagem no Console do Unity.
            // Útil para testes e depuração.
            Debug.Log("Objeto ativado!");

            // Verifica se existe um AudioSource atribuído.
            // Evita erro caso o componente esteja vazio.
            if (audioSource != null)
            {
                // Executa o áudio ligado ao objeto.
                audioSource.Play();
            }
        }
    }
}