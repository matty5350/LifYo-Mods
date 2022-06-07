/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Bear Knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxBearKnool))
{
    new ScriptObject(LiFxBearKnool)
    {
    };
}
package LiFxBearKnool
{
  function LiFxBearKnool::setup() {
    LiFx::registerCallback($LiFx::hooks::onDatablockLoad, RegisterDatablock, LiFxBearKnool);
    LiFx::registerCallback($LiFx::hooks::onMaterialsLoad, RegisterMaterials, LiFxBearKnool);
  }

  function LiFxBearKnool::RegisterDatablock() {
      LiFx::loadRecursivelyInFolder("yolauncher/modpack/art/datablocks", "knool.cs");
  }
  function LiFxBearKnool::RegisterMaterials() {
    LiFx::loadRecursivelyInFolder("yolauncher/modpack", "materials.cs");
  }
};
activatePackage(LiFxBearKnool);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxBearKnool);