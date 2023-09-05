using UnityEngine;
using Il2Cpp;

namespace ForsakenHangerWorkbench
{
    public class Patches : MonoBehaviour                               //public class Patches:MonoBehaviour
    {


        public static string[,] itemDataArray =
        {
            //OBJECTS
            {"0_Delete","1_Scene",              "2_Name",                               "3_EulerY", "4_Position" },


            //Forsaken Airfield HANGAR
            {"false",   "AFHangar",        "CONTAINER_ToolCabinetMedium",             "272.431",       "12.426, 0.0472, 11.6872"},
            {"false",   "AFHangar",        "INTERACTIVE_WorkBench",             "270.984",       "20.5129, -7.3998, 5.78"},
            {"false",   "AFHangar",        "CONTAINER_ToolCabinetSmall",             "0",       "-3.9489, 0.0472, -6.0205"},


        };

        public static void ChangeObjects()
        {

            GameObject findTargetGO = new GameObject();

            Vector3 FAHWworkbenchOrigPos = new Vector3(20.5129f, -7.3998f, 5.78f);
            Quaternion FAHWworkbenchOrigRot = Quaternion.Euler(-0, 270.984f, 0);

            Vector3 FAHWworkbenchNewPos = new Vector3(0.0573f, 0.7473f, 9.1183f);
            Quaternion FAHWworkbenchNewRot = Quaternion.Euler(-0, 271.4934f, 0);

            Vector3 FAHWsmallcabinetOrigPos = new Vector3(-3.9489f, 0.0472f, -6.0205f);
            Quaternion FAHWsmallcabinetOrigRot = Quaternion.Euler(0, 0, 0);

            Vector3 FAHWsmallcabinetNewPos = new Vector3(0.448f, 1.5972f, 7.0595f);
            Quaternion FAHWsmallcabinetNewRot = Quaternion.Euler(0, 272.5925f, 0);  

            Vector3 FAHWmediumcabinetOrigPos = new Vector3(12.426f, 0.0472f, 11.6872f);
            Quaternion FAHWmediumcabinetOrigRot = Quaternion.Euler(0, 272.431f, 0);

            Vector3 FAHWmediumcabinetNewPos = new Vector3(0.4362f, 0.0472f, 7.0872f);
            Quaternion FAHWmediumcabinetNewRot = Quaternion.Euler(0, 272.431f, 0);


            for (int i = 1; i < itemDataArray.GetLength(0); i++)
            {
                // ----- Find Name -----------------------------------------------------------------
                if (GameObject.Find(itemDataArray[i, 2]) == null)
                {
                    //MelonLogger.Msg("ChangeObjcet is null.");
                    continue;
                }
                else
                {
                    findTargetGO = GameObject.Find(itemDataArray[i, 2]);
                    // GameObject.Find cannot find for already inactive game objects. So this needs to be reloaded after confermation.
                }
                // ---------------------------------------------------------------------------------------


                if (findTargetGO != null)
                {
                    // ----- Scene check -----------------------------------------------------------------
                    if (findTargetGO.scene.name != itemDataArray[i, 1]) // Scene 
                    {
                        //MelonLogger.Msg("Scene name does not match.");
                        continue;
                    }
                    // -------------------------------------------------------------------------------------


                    // ==============================================================================================================
                    // Forsaken Airfield HANGAR
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "AFHangar")
                    {

                        // Medium Cabinet ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "CONTAINER_ToolCabinetMedium")
                        {

                            if (Settings.options.FAHWEnable)
                            {
                                findTargetGO.transform.position = FAHWmediumcabinetOrigPos;
                                findTargetGO.transform.rotation = FAHWmediumcabinetOrigRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = FAHWmediumcabinetNewPos;
                                findTargetGO.transform.rotation = FAHWmediumcabinetNewRot;
                            }
                        }

                        // Workbench ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "INTERACTIVE_WorkBench")
                        {

                            if (Settings.options.FAHWEnable)
                            {
                                findTargetGO.transform.position = FAHWworkbenchOrigPos;
                                findTargetGO.transform.rotation = FAHWworkbenchOrigRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = FAHWworkbenchNewPos;
                                findTargetGO.transform.rotation = FAHWworkbenchNewRot;
                            }
                        }


                        // Entrance Bridge ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "CONTAINER_ToolCabinetSmall")
                        {

                            if (Settings.options.FAHWEnable)
                            {
                                findTargetGO.transform.position = FAHWsmallcabinetOrigPos;
                                findTargetGO.transform.rotation = FAHWsmallcabinetOrigRot;
                            }
                            else
                            {
                                findTargetGO.transform.position = FAHWsmallcabinetNewPos;
                                findTargetGO.transform.rotation = FAHWsmallcabinetNewRot;
                            }
                        }
                        //--------------------------------------------------------------------------------------


                    }

                }
            }
        }

    }
}