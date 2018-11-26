using System.Collections.Generic;

namespace MaxDecorationLevel
{
    class Data
    {
        /// <summary>
        /// Max level of all decorations.
        /// </summary>
        public static readonly Dictionary<string, int> MAX_DECORATION_LEVEL_MAP = new Dictionary<string, int>
        {
            { "JU_DOKU_NAME", 3 },
            { "JU_MAHI_NAME", 3 },
            { "JU_SUIMIN_NAME", 3 },
            { "JU_KIZETSU_NAME", 3 },
            { "JU_BAKUHA_NAME", 3 },
            { "JU_RESSYOU_NAME", 3 },
            { "JU_BOUDOWN_NAME", 3 },
            { "JU_MIMISEN_NAME", 5 },
            { "JU_BOUHUU_NAME", 5 },
            { "JU_TAISHIN_NAME", 3 },
            { "JU_KOUGEKI_NAME", 7 },
            { "JU_BOUGYO_NAME", 7 },
            { "JU_TAIRYOKU_NAME", 3 },
            { "JU_KAISOKU_NAME", 3 },
            { "JU_HI_NAME", 3 },
            { "JU_MIZU_NAME", 3 },
            { "JU_KOORI_NAME", 3 },
            { "JU_KAMINARI_NAME", 3 },
            { "JU_RYUU_NAME", 3 },
            { "JU_TAIZOKU_NAME", 3 },
            { "JU_HIZOKU_NAME", 5 },
            { "JU_MIZUZOKU_NAME", 5 },
            { "JU_KOURIZOKU_NAME", 5 },
            { "JU_RAIZOKU_NAME", 5 },
            { "JU_RYUUZOKU_NAME", 5 },
            { "JU_DOKUATK_NAME", 3 },
            { "JU_MAHIATK_NAME", 3 },
            { "JU_SUIMINATK_NAME", 3 },
            { "JU_BAKUHAATK_NAME", 3 },
            { "JU_DOKUBIN_NAME", 1 },
            { "JU_MAHIBIN_NAME", 1 },
            { "JU_SUIMINBIN_NAME", 1 },
            { "JU_BAKUHABIN_NAME", 1 },
            { "JU_ZOKUKAI_NAME", 3 },
            { "JU_MIKIRI_NAME", 7 },
            { "JU_TYOKAISIN_NAME", 3 },
            { "JU_TUUGEKI_NAME", 3 },
            { "JU_TANSYUKU_NAME", 3 },
            { "JU_TAKUMI_NAME", 5 },
            { "JU_BATTOU_NAME", 3 },
            { "JU_JUUGEKI_NAME", 3 },
            { "JU_KO_NAME", 3 },
            { "JU_GENKIAT_NAME", 3 },
            { "JU_HIEN_NAME", 1 },
            { "JU_HONKI_NAME", 5 },
            { "JU_TYOUSEN_NAME", 5 },
            { "JU_FULPOWER_NAME", 3 },
            { "JU_SOKODIKARA_NAME", 5 },
            { "JU_GYAKKYOU_NAME", 1 },
            { "JU_GYAKUJYO_NAME", 5 },
            { "JU_FUE_NAME", 1 },
            { "JU_SOUTENUP_NAME", 1 },
            { "JU_TOKUSYA_NAME", 2 },
            { "JU_HOUJUTU_NAME", 3 },
            { "JU_HOUSYU_NAME", 2 },
            { "JU_SUTAMINA_NAME", 3 },
            { "JU_TAIJYUTSU_NAME", 5 },
            { "JU_KIRYOKU_NAME", 3 },
            { "JU_HARAHERI_NAME", 3 },
            { "JU_KAIHI_NAME", 5 },
            { "JU_KAIHIKYORI_NAME", 3 },
            { "JU_GUARDSEI_NAME", 5 },
            { "JU_NOUTOU_NAME", 3 },
            { "JU_KOUIKI_NAME", 5 },
            { "JU_JIZOKU_NAME", 3 },
            { "JU_ITEMSAVE_NAME", 1 },
            { "JU_HAYAGUI_NAME", 3 },
            { "JU_TOISHI_NAME", 3 },
            { "JU_BAKUSHI_NAME", 3 },
            { "JU_LOVEKINOKO_NAME", 3 },
            { "JU_KAGO_NAME", 3 },
            { "JU_OTOMOUP_NAME", 5 },
            { "JU_SYOKUGAKU_NAME", 4 },
            { "JU_TIGAKU_NAME", 3 },
            { "JU_KONSHIN_NAME", 3 },
            { "JU_TOUSEKI_NAME", 3 },
            { "JU_INZYA_NAME", 3 },
            { "JU_TAISYOUGEKI_NAME", 3 },
            { "JU_ENHUKU_NAME", 3 },
            { "JU_NUMAWATARI_NAME", 3 },
            { "JU_MUSHIUTI_NAME", 3 },
            { "JU_TAISYOUKI_NAME", 3 },
            { "JU_KYUUKAKU_NAME", 1 },
            { "JU_IKAKU_NAME", 3 },
            { "JU_KASSOU_NAME", 1 },
            { "JU_TIYU_NAME", 3 },
            { "JU_KYOUDAN_NAME", 1 },
            { "JU_KANTUU_NAME", 1 },
            { "JU_SANDAN_NAME", 1 },
            { "JU_KOUYOU_NAME", 3 },
            { "JU_KYUUTI_NAME", 1 },
            { "JU_RYUUHUU_NAME", 1 },
            { "JU_SEIBI_NAME", 3 },
            { "JU_GOUKYU_NAME", 1 },
            { "JU_SINGAN_NAME", 1 },
            { "JU_KYOHEKI_NAME", 1 },
            { "JU_GOUZIN_NAME", 1 },
            { "JU_MUGEKI_NAME", 1 },
        };

        /// <summary>
        /// The keys of decorations which are in .gmd file but not available in game.
        /// </summary>
        public static readonly List<string> INVALID_DECORATION_LIST = new List<string>
        {
            "JU_KOYASHI_NAME", // Fertilizer Jewel 1
            "JU_TEKIOU_NAME", // Heat Resist Jewel 2
            "JU_KYOUBIN_NAME", // Powercoat Jewel 3
            "JU_NORI__NAME", // Rodeo Jewel 2
            "JU_TOBIKOMI_NAME", // Flying Leap Jewel 1
            "JU_TURI_NAME", // Angler Jewel 1
            "JU_TYOURI_NAME", // Chef Jewel 1
            "JU_UNPAN_NAME", // Transporter Jewel 1
            "JU_SAISYU_NAME", // Gathering Jewel 1
            "JU_HONEY_NAME", // Honeybee Jewel 1
            "JU_HAGITORI_NAME", // Carver Jewel 1
            "JU_DOUTYU_NAME", // Scoutfly Jewel 1
            "JU_KUSSOKU_NAME", // Crouching Jewel 1
            "JU_HABATOBI_NAME", // Longjump Jewel 1
            "JU_HEKITOU_NAME", // Climber Jewel 1
            "JU_KOUKAKU_NAME", // Radiosity Jewel 1
            "JU_KENKYU_NAME", // Research Jewel 1
            "JU_TOTUGEKI_NAME", // Slider Jewel 1
            "JU_TAIKYOU_NAME", // Hazmat Jewel 1
            "JU_TAIDEI_NAME", // Mudshield Jewel 1
            "JU_GOZOKU_NAME", // Element Resist Jewel 1
            "JU_HAKKEN_NAME", // Discovery Jewel 2
            "JU_TANTI_NAME", // Detector Jewel 1
        };
    }
}
