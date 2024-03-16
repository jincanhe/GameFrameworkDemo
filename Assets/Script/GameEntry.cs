using UMainGame;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Tutorial
{
    public partial class GameEntry : MonoBehaviour
    {
        public static BaseComponent Base
        {
            get;
            private set;
        }

        public static UIComponent UI
        {
            get;
            private set;
        }

        private static void InitBuiltinComponents()
        {
            Base = UnityGameFramework.Runtime.GameEntry.GetComponent<BaseComponent>();
            UI = UnityGameFramework.Runtime.GameEntry.GetComponent<UIComponent>();
        }
    }

    public partial class GameEntry : MonoBehaviour
    {
        private static void InitCustomComponents()
        {
            // 将来在这里注册自定义的组件
        }

        private static void InitCustomDebuggers()
        {
            // 将来在这里注册自定义的调试器
        }
    }

    /// <summary>
    /// 游戏入口。
    /// </summary>
    public partial class GameEntry : MonoBehaviour
    {
        private void Start()
        {
            // 初始化内置组件
            InitBuiltinComponents();

            // 初始化自定义组件
            InitCustomComponents();

            // 初始化自定义调试器
            InitCustomDebuggers();

            var mainGame = new MainGame();
            mainGame.SendGameSpeed();
        }
    }
}