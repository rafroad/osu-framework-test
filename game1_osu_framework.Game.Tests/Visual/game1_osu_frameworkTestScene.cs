using osu.Framework.Testing;

namespace game1_osu_framework.Game.Tests.Visual
{
    public class game1_osu_frameworkTestScene : TestScene
    {
        protected override ITestSceneTestRunner CreateRunner() => new game1_osu_frameworkTestSceneTestRunner();

        private class game1_osu_frameworkTestSceneTestRunner : game1_osu_frameworkGameBase, ITestSceneTestRunner
        {
            private TestSceneTestRunner.TestRunner runner;

            protected override void LoadAsyncComplete()
            {
                base.LoadAsyncComplete();
                Add(runner = new TestSceneTestRunner.TestRunner());
            }

            public void RunTestBlocking(TestScene test) => runner.RunTestBlocking(test);
        }
    }
}
