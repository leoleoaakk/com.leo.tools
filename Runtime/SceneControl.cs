using UnityEngine;
using UnityEngine.SceneManagement;

namespace Leo.Tools
{
    /// <summary>
    /// 場景控制，提供載入場景與退出遊戲功能
    /// </summary>
    public class SceneControl : MonoBehaviour
    {
        /// <summary>
        /// 載入場景
        /// </summary>
        /// <param name="sceneName"></param>
        public void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        /// <summary>
        /// 退出遊戲
        /// </summary>
        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
