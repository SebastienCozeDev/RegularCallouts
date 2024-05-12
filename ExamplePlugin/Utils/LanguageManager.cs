using Rage;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularCallouts.Stuff
{
    internal static class LanguageManager
    {
        // AccidentOnHighway Callout
        internal static List<string> AccidentOnHighwayCallout__dialogwithFire5;
        internal static List<string> AccidentOnHighwayCallout__dialogwithdriver2;
        internal static List<string> AccidentOnHighwayCallout__dialogwithcop2;
        internal static List<string> AccidentOnHighwayCallout__dialogwithmedic;
        internal static List<string> AnimalCarCrash__DialogWithOwner;

        internal static void Initialize()
        {
            InitializationFile initializationFile = new InitializationFile("Plugins/LSPDFR/RegularCallouts.ini");
            initializationFile.Create();
            Game.LogTrivial("Loading of translation for Regular Callouts");
            LanguageManager.AccidentOnHighwayCallout__dialogwithFire5 = new List<string>
            {
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithFire5_1", "~g~Firefighter:~s~ Hello Officer, we already freed everyone. Two of them require medical assistance and one of them died on impact. (1/3)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithFire5_2", "~g~Firefighter:~s~ Everything is secure from our side, we'll let you handle the cleanups. (2/3)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithFire5_3", "~b~You:~s~ I'll take care of it. Thanks. (3/3)"))
            };
            LanguageManager.AccidentOnHighwayCallout__dialogwithdriver2 = new List<string>
            {
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithdriver2_1", "~b~You:~s~ Good day to you. Can you tell me what happened? (1/4)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithdriver2_2", "~o~Driver:~s~ The car on the roof lost control and I hit it afterwards, when I tried to break the other cars drove into me. (2/4)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithdriver2_3", "~b~You:~s~ Could you please stay if I have further questions? (3/4)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithdriver2_4", "~o~Driver:~s~ Absolutely. (4/4)"))
            };
            LanguageManager.AccidentOnHighwayCallout__dialogwithcop2 = new List<string>
            {
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithcop2_1", "~g~Officer:~s~ Hey good to see you here. As you can see we already secured the scene (1/4)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithcop2_2", "~g~Officer:~s~ We still don't know what happened, you can talk to the victims and medics. (2/4)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithcop2_3", "~g~Officer:~s~ When you are done you can tell the other officer to remove the roadblock. (3/4)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithcop2_4", "~b~You:~s~ Alright thanks for the information (4/4)."))
            };
            LanguageManager.AccidentOnHighwayCallout__dialogwithmedic = new List<string>
            {
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithmedic_1", "~b~You:~s~ What information can you give me? (1/3)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithmedic_2", "~g~Medic:~s~ This one died when we arrived, two of them have minor injures and the ones sitting on the ground need to go to the hospital. (2/3)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "dialogwithmedic_3", "~g~Medic:~s~ If you are done questioning them come back to me so we can transport them. (3/3)"))
            };
            LanguageManager.AnimalCarCrash__DialogWithOwner = new List<string>
            {
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "DialogWithOwner_1", "~b~You:~s~ Good morning Sir, can you tell me what happened? (1/5)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "DialogWithOwner_2", "~r~Driver:~s~ This dog just ran out o the street, I had no chance to react anymore. I'm sorry I'm still a bit shocked. (2/5)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "DialogWithOwner_3", "~b~You:~s~ Do you need an ambulance? (3/5)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "DialogWithOwner_4", "~r~Driver:~s~ No thanks. (4/5)")),
                Utils.ConvertInUTF8(initializationFile.ReadString(Settings.Language, "DialogWithOwner_5", "~b~You:~s~ I'll have a look around, stay here for a moment (5/5)"))
            };
        }

    }
}
