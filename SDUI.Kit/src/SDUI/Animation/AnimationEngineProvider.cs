using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SDUI.Animation
{
    public static class AnimationEngineProvider
    {
        private static List<AnimationEngine> animationEngines = new ();
        static AnimationEngineProvider ()
        {
            Task.Run (async () => {
                while (true) {
                    onTimerTick (null, EventArgs.Empty);
                    await Task.Delay (1000 / 60);
                }
            });
        }

        public static void Handle (AnimationEngine animationEngine)
        {
            animationEngines.Add (animationEngine);
        }

        private static void onTimerTick (object sender, EventArgs e)
        {
            foreach (var animationEngine in animationEngines)
                if (animationEngine.Running)
                    animationEngine.AnimationTimerOnTick (sender, e);
        }
    }
}
