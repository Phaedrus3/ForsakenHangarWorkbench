using ModSettings;

namespace ForsakenHangerWorkbench
{
    internal class ForsakenHangerWorkbench : JsonModSettings
    {
        //Hanger
        [Section("Forsaken Hangar Workbench")]

        [Name("Enable")]
        [Description("Move the Workbench (and tool cabinets).")]
        public bool FAHWEnable = false;


        protected override void OnConfirm()
        {
            base.OnConfirm();

            Patches.ChangeObjects();
        }

    }

    internal static class Settings
    {
        public static ForsakenHangerWorkbench options;

        public static void OnLoad()
        {
            options = new ForsakenHangerWorkbench();
            options.AddToModSettings("Forsaken Hangar Workbench", MenuType.Both);
        }
    }

}