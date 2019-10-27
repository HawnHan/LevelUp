using Verse;

namespace LevelUp
{
    public class Engine : GameComponent
    {
        public Engine(Game game)
        {
            ServiceConfigurator.ConfigureServices();

        }

        public override void GameComponentTick()
        {
            if (LevelEvent.LevelEventQueue.Count == 0)
                return;

            LevelEvent levelEvent = LevelEvent.LevelEventQueue.Dequeue();
            switch (levelEvent.LevelType)
            {
                case LevelEventType.LevelUp:
                    levelEvent.NotifyLevelUp();
                    break;

                case LevelEventType.LevelDown:
                    levelEvent.NotifyLevelDown();
                    break;
            }
        }
    }
}