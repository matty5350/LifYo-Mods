/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxWitchmod))
{
    new ScriptObject(LiFxWitchmod)
    {
    };
}

package LiFxWitchmod

{
    function LiFxWitchmod::setup() {
        LiFx::registerCallback($LiFx::hooks::onPostInitCallbacks, Datablock, LiFxWitchmod);
        
        // Register new objects
        LiFx::registerObjectsTypes(LiFxWitchmod::ObjectsTypesWitchCarcass(), LiFxWitchmod);
        LiFx::registerObjectsTypes(LiFxWitchmod::ObjectsTypesWitch(), LiFxWitchmod);

    }
    function LiFxWitchmod::version() {
        return "0.0.3";
    }
    function LiFxWitchmod::Datablock() {
        exec ("yolauncher/modpack/art/datablocks/animals/knool.cs");
    }


    function LiFxWitchmod::ObjectsTypesWitchCarcass() {
        return new ScriptObject(ObjectsTypesWitchCarcass : ObjectsTypes)
        {
            id = 2362; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Witch Carcass";
            ParentID = 76;
            IsContainer = 1;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 10000000;
            Length = 10; 
            MaxStackSize = 1;
            UnitWeight = 1000;
            BackgrndImage = "art\\\\images\\\\bag";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }

        function LiFxWitchmod::ObjectsTypesWitch() {
        return new ScriptObject(ObjectsTypesWitch : ObjectsTypes)
        {
            id = 2398; // has to be globally unique, please reserve ids here: https://www.lifxmod.com/info/object-id-list/
            ObjectName = "Witch Knool";
            ParentID = 751;
            IsContainer = 0;
            IsMovableObject = 1;
            IsUnmovableobject = 0;
            IsTool = 0;
            IsDevice = 0;
            IsDoor = 0;
            IsPremium = 0;
            MaxContSize = 1000000;
            Length = 6; 
            MaxStackSize = 0;
            UnitWeight = 1;
            BackgrndImage = "art\\\\images\\\\universal";
            WorkAreaTop = 0;
            WorkAreaLeft = 0;
            WorkAreaWidth = 0;
            WorkAreaHeight = 0;
            BtnCloseTop = 0;
            BtnCloseLeft = 0;
            FaceImage = "";
            Description = "";
            BasePrice = 0;
            OwnerTimeout = 300;
            AllowExportFromRed = 0;
            AllowExportFromGreen = 0;
        };
    }
};
activatePackage(LiFxWitchmod);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxWitchmod);