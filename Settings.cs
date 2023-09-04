using ModSettings;

namespace ForsakenHangerWorkbench
{
    internal class ForsakenHangerWorkbench : JsonModSettings
    {
        //Blackrock
        [Section("Forsake nHanger Workbench")]

        [Name("Enable")]
        [Description("Enable the Workbench (and tool cabinets).")]
        public bool FASCEnable = false;


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
            options.AddToModSettings("Forsaken Hanger Workbench", MenuType.Both);
        }
    }

}