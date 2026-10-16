namespace TimeAgo;

internal static class LanguageFormatStrings
{
    internal class VerifiedByNativeSpeakerAttribute : Attribute { }

    private static DateTimeFormatStrings afrikaans;

    public static DateTimeFormatStrings Afrikaans =>
        afrikaans ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} sekonde gelede",
            SecondsAgo   = "{0} sekondes gelede",
            MinuteAgo    = "{0} minuut gelede",
            MinutesAgo   = "{0} minute gelede",
            HourAgo      = "{0} uur gelede",
            HoursAgo     = "{0} uur gelede",
            DayAgo       = "{0} dag gelede",
            DaysAgo      = "{0} dae gelede",
            MonthAgo     = "{0} maand gelede",
            MonthsAgo    = "{0} maande gelede",
            YearAgo      = "{0} jaar gelede",
            YearsAgo     = "{0} jaar gelede",
            SecondAhead  = "{0} sekondes van nou af",
            SecondsAhead = "{0} sekondes van nou af",
            MinuteAhead  = "{0} minute van nou af",
            MinutesAhead = "{0} minute van nou af",
            HourAhead    = "{0} uur van nou af",
            HoursAhead   = "{0} ure van nou af",
            DayAhead     = "{0} dae van nou af",
            DaysAhead    = "{0} dae van nou af",
            MonthAhead   = "{0} maande van nou af",
            MonthsAhead  = "{0} maande van nou af",
            YearAhead    = "{0} jaar van nou af",
            YearsAhead   = "{0} jaar van nou af"
        };

    private static DateTimeFormatStrings albanian;

    public static DateTimeFormatStrings Albanian =>
        albanian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} sekondë më parë",
            SecondsAgo   = "{0} sekonda më parë",
            MinuteAgo    = "{0} minutë më parë",
            MinutesAgo   = "{0} minuta më parë",
            HourAgo      = "{0} orë më parë",
            HoursAgo     = "{0} orë më parë",
            DayAgo       = "{0} ditë më parë",
            DaysAgo      = "{0} ditë më parë",
            MonthAgo     = "{0} muaj më parë",
            MonthsAgo    = "{0} muaj më parë",
            YearAgo      = "{0} vit më parë",
            YearsAgo     = "{0} vjet më parë",
            SecondAhead  = "{0} sekonda nga tani",
            SecondsAhead = "{0} sekonda nga tani",
            MinuteAhead  = "{0} minuta nga tani",
            MinutesAhead = "{0} minuta nga tani",
            HourAhead    = "{0} orë nga tani",
            HoursAhead   = "{0} orë nga tani",
            DayAhead     = "{0} ditë nga tani",
            DaysAhead    = "{0} ditë nga tani",
            MonthAhead   = "{0} muaj nga tani",
            MonthsAhead  = "{0} muaj nga tani",
            YearAhead    = "{0} vjet nga tani",
            YearsAhead   = "{0} vjet nga tani"
        };

    private static DateTimeFormatStrings arabic;

    public static DateTimeFormatStrings Arabic =>
        arabic ??= new DateTimeFormatStrings
        {
            SecondAgo    = "منذ {0} ثانية",
            SecondsAgo   = "{0} ثوان قبل",
            MinuteAgo    = "منذ {0} دقيقة",
            MinutesAgo   = "قبل {0} دقائق",
            HourAgo      = "منذ {0} ساعة",
            HoursAgo     = "منذ {0} ساعات",
            DayAgo       = "{0} منذ يوم",
            DaysAgo      = "منذ {0} أيام",
            MonthAgo     = "{0} قبل شهر",
            MonthsAgo    = "قبل {0} أشهر",
            YearAgo      = "{منذ سنة {0}",
            YearsAgo     = "قبل {0} سنوات",
            SecondAhead  = "{0} ثانية من الآن",
            SecondsAhead = "{0} ثواني من الآن",
            MinuteAhead  = "{0} دقائق من الآن",
            MinutesAhead = "{0} دقائق من الآن",
            HourAhead    = "بعد {0} ساعات من الآن",
            HoursAhead   = "بعد {0} ساعات من الآن",
            DayAhead     = "{0} أيام من الآن",
            DaysAhead    = "{0} أيام من الآن",
            MonthAhead   = "{0} أشهر من الآن",
            MonthsAhead  = "{0} أشهر من الآن",
            YearAhead    = "{0} سنوات من الآن",
            YearsAhead   = "بعد {0} سنوات من الآن"
        };

    private static DateTimeFormatStrings armenian;

    public static DateTimeFormatStrings Armenian =>
        armenian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} վայրկյան առաջ",
            SecondsAgo   = "{0} վայրկյան առաջ",
            MinuteAgo    = "{0} րոպե առաջ",
            MinutesAgo   = "{0} րոպե առաջ",
            HourAgo      = "{0} ժամ առաջ",
            HoursAgo     = "{0} ամիս առաջ",
            DayAgo       = "{0} օր առաջ",
            DaysAgo      = "{0} օր առաջ",
            MonthAgo     = "{0} տարի առաջ",
            MonthsAgo    = "{0} ամիս առաջ",
            YearAgo      = "{0} տարի առաջ",
            YearsAgo     = "{0} տարի առաջ",
            SecondAhead  = "{0} վայրկյան այսուհետ",
            SecondsAhead = "{0} վայրկյան հետո",
            MinuteAhead  = "{0} րոպե հետո",
            MinutesAhead = "{0} րոպե հետո",
            HourAhead    = "{0} ժամ հետո",
            HoursAhead   = "{0} ժամ հետո",
            DayAhead     = "{0} օր հետո",
            DaysAhead    = "{0} օր հետո",
            MonthAhead   = "{0} ամիս այս պահից",
            MonthsAhead  = "{0} ամիս հետո",
            YearAhead    = "{0} տարի հետո",
            YearsAhead   = "{0} տարի հետո"
        };

    private static DateTimeFormatStrings azerbaijani;

    public static DateTimeFormatStrings Azerbaijani =>
        azerbaijani ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} saniyə əvvəl",
            SecondsAgo   = "{0} saniyə əvvəl",
            MinuteAgo    = "{0} dəqiqə əvvəl",
            MinutesAgo   = "{0} dəqiqə əvvəl",
            HourAgo      = "{0} saat əvvəl",
            HoursAgo     = "{0} saat əvvəl",
            DayAgo       = "{0} gün əvvəl",
            DaysAgo      = "{0} gün əvvəl",
            MonthAgo     = "{0} ay əvvəl",
            MonthsAgo    = "{0} ay əvvəl",
            YearAgo      = "{0} il əvvəl",
            YearsAgo     = "{0} il əvvəl",
            SecondAhead  = "indidən {0} saniyə",
            SecondsAhead = "indidən {0} saniyə",
            MinuteAhead  = "indidən {0} dəqiqə",
            MinutesAhead = "indidən {0} dəqiqə",
            HourAhead    = "indidən {0} saat sonra",
            HoursAhead   = "indidən {0} saat sonra",
            DayAhead     = "indidən {0} gün sonra",
            DaysAhead    = "indidən {0} gün sonra",
            MonthAhead   = "indidən {0} ay",
            MonthsAhead  = "indidən {0} ay sonra",
            YearAhead    = "{0} il sonra",
            YearsAhead   = "{0} il sonra"
        };

    private static DateTimeFormatStrings basque;

    public static DateTimeFormatStrings Basque =>
        basque ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Duela {0} bigarren",
            SecondsAgo   = "Duela {0} segundo",
            MinuteAgo    = "Duela {0} minutu",
            MinutesAgo   = "Duela {0} minutu",
            HourAgo      = "Duela ordu {0}",
            HoursAgo     = "Duela {0} ordu",
            DayAgo       = "Duela {0} egun",
            DaysAgo      = "Duela {0} egun",
            MonthAgo     = "Duela {0} hilabete",
            MonthsAgo    = "Duela {0} hilabete",
            YearAgo      = "Duela urte {0}",
            YearsAgo     = "Duela {0} urte",
            SecondAhead  = "Hemendik {0} segundora",
            SecondsAhead = "Hemendik {0} segundora",
            MinuteAhead  = "Hemendik {0} minutura",
            MinutesAhead = "Hemendik {0} minutura",
            HourAhead    = "Hemendik {0} ordura",
            HoursAhead   = "Hemendik {0} ordura",
            DayAhead     = "Hemendik {0} egunetara",
            DaysAhead    = "Hemendik {0} egunetara",
            MonthAhead   = "Hemendik {0} hilabetera",
            MonthsAhead  = "Hemendik {0} hilabetera",
            YearAhead    = "Hemendik {0} urtera",
            YearsAhead   = "Hemendik {0} urtera"
        };

    private static DateTimeFormatStrings belarusian;

    public static DateTimeFormatStrings Belarusian =>
        belarusian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} секунду таму",
            SecondsAgo   = "{0} секунд таму",
            MinuteAgo    = "{0} хвіліну таму",
            MinutesAgo   = "{0} хвілін таму",
            HourAgo      = "{0}:00 назад",
            HoursAgo     = "{0}:00 назад",
            DayAgo       = "{0} дзень таму",
            DaysAgo      = "{0} дзён таму",
            MonthAgo     = "{0} месяц таму",
            MonthsAgo    = "{0} месяцаў таму",
            YearAgo      = "{0} год таму",
            YearsAgo     = "{0} гадоў таму",
            SecondAhead  = "Праз {0} секунды",
            SecondsAhead = "Праз {0} секунды",
            MinuteAhead  = "Праз {0} хвіліны",
            MinutesAhead = "Праз {0} хвіліны",
            HourAhead    = "Праз {0} гадзіны",
            HoursAhead   = "Праз {0} гадзіны",
            DayAhead     = "Праз {0} дні",
            DaysAhead    = "Праз {0} дні",
            MonthAhead   = "Праз {0} месяцы",
            MonthsAhead  = "Праз {0} месяцы",
            YearAhead    = "праз {0} гады",
            YearsAhead   = "праз {0} гады"
        };

    private static DateTimeFormatStrings bosnian;

    [VerifiedByNativeSpeaker]
    public static DateTimeFormatStrings Bosnian =>
        bosnian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Prije sekundu",
            SecondsAgo   = "Prije {0} sekundi",
            MinuteAgo    = "Prije minutu",
            MinutesAgo   = "Prije {0} minuta",
            HourAgo      = "Prije sat",
            HoursAgo     = "Prije {0} sati",
            DayAgo       = "Prije dan",
            DaysAgo      = "Prije {0} dana",
            MonthAgo     = "Prije mjesec",
            MonthsAgo    = "Prije {0} mjeseci",
            YearAgo      = "Prije godinu",
            YearsAgo     = "Prije {0} godina",
            SecondAhead  = "{0} sekunde od sada",
            SecondsAhead = "{0} sekunde od sada",
            MinuteAhead  = "{0} minute od sada",
            MinutesAhead = "{0} minute od sada",
            HourAhead    = "{0} sata od sada",
            HoursAhead   = "{0} sata od sada",
            DayAhead     = "{0} dana od sada",
            DaysAhead    = "{0} dana od sada",
            MonthAhead   = "{0} mjeseca od sada",
            MonthsAhead  = "{0} mjeseca od sada",
            YearAhead    = "{0} godine od sada",
            YearsAhead   = "{0} godine od sada"
        };

    private static DateTimeFormatStrings bulgarian;

    public static DateTimeFormatStrings Bulgarian =>
        bulgarian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Преди {0} секунди",
            SecondsAgo   = "Преди {0} секунди",
            MinuteAgo    = "Преди {0} минути",
            MinutesAgo   = "{0} минути преди",
            HourAgo      = "Преди {0} час",
            HoursAgo     = "Преди пет часа",
            DayAgo       = "Преди {0} ден",
            DaysAgo      = "Преди {0} дни",
            MonthAgo     = "{0} Преди месец",
            MonthsAgo    = "Преди {0} месеца",
            YearAgo      = "Преди {0} година",
            YearsAgo     = "Преди {0} години",
            SecondAhead  = "{0} секунди от сега",
            SecondsAhead = "след {0} секунди",
            MinuteAhead  = "след {0} минути",
            MinutesAhead = "след {0} минути",
            HourAhead    = "след {0} часа",
            HoursAhead   = "след {0} часа",
            DayAhead     = "{0} дни от сега",
            DaysAhead    = "след {0} дни",
            MonthAhead   = "{0} месеца от сега",
            MonthsAhead  = "{0} месеца от сега",
            YearAhead    = "{0} години от сега",
            YearsAhead   = "след {0} години"
        };

    private static DateTimeFormatStrings catalan;

    public static DateTimeFormatStrings Catalan =>
        catalan ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Fa {0} segon",
            SecondsAgo   = "Fa {0} segons",
            MinuteAgo    = "Fa {0} minut",
            MinutesAgo   = "Fa {0} minuts",
            HourAgo      = "Fa {0} hora",
            HoursAgo     = "Fa {0} hores",
            DayAgo       = "Fa {0} dia",
            DaysAgo      = "Fa {0} dies",
            MonthAgo     = "Fa {0} mes",
            MonthsAgo    = "Fa {0} mesos",
            YearAgo      = "Fa {0} any",
            YearsAgo     = "Fa {0} anys",
            SecondAhead  = "D'aquí a {0} segons",
            SecondsAhead = "D'aquí a {0} segons",
            MinuteAhead  = "D'aquí a {0} minuts",
            MinutesAhead = "D'aquí a {0} minuts",
            HourAhead    = "d'aquí {0} hores",
            HoursAhead   = "d'aquí {0} hores",
            DayAhead     = "d'aquí {0} dies",
            DaysAhead    = "D'aquí a {0} dies",
            MonthAhead   = "d'aquí {0} mesos",
            MonthsAhead  = "D'aquí a {0} mesos",
            YearAhead    = "d'aquí {0} anys",
            YearsAhead   = "d'aquí {0} anys"
        };

    private static DateTimeFormatStrings simplifiedChinese;

    [VerifiedByNativeSpeaker]
    public static DateTimeFormatStrings SimplifiedChinese =>
        simplifiedChinese ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} 秒前",
            SecondsAgo   = "{0} 秒前",
            MinuteAgo    = "{0} 分钟前",
            MinutesAgo   = "{0} 分钟前",
            HourAgo      = "{0} 小时前",
            HoursAgo     = "{0} 小时前",
            DayAgo       = "{0} 天前",
            DaysAgo      = "{0} 天前",
            MonthAgo     = "{0} 个月前",
            MonthsAgo    = "{0} 个月前",
            YearAgo      = "{0} 年前",
            YearsAgo     = "{0} 年前",
            SecondAhead  = "{0} 秒后",
            SecondsAhead = "{0} 秒后",
            MinuteAhead  = "{0} 分钟后",
            MinutesAhead = "{0} 分钟后",
            HourAhead    = "{0} 小时后",
            HoursAhead   = "{0} 小时后",
            DayAhead     = "{0} 天后",
            DaysAhead    = "{0} 天后",
            MonthAhead   = "{0} 个月后",
            MonthsAhead  = "{0} 个月后",
            YearAhead    = "{0} 年后",
            YearsAhead   = "{0} 年后"
        };

    private static DateTimeFormatStrings traditionalChinese;

    [VerifiedByNativeSpeaker]
    public static DateTimeFormatStrings TraditionalChinese =>
        traditionalChinese ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} 秒前",
            SecondsAgo   = "{0} 秒前",
            MinuteAgo    = "{0} 分鐘前",
            MinutesAgo   = "{0} 分鐘前",
            HourAgo      = "{0} 小時前",
            HoursAgo     = "{0} 小時前",
            DayAgo       = "{0} 天前",
            DaysAgo      = "{0} 天前",
            MonthAgo     = "{0} 個月前",
            MonthsAgo    = "{0} 個月前",
            YearAgo      = "{0} 年前",
            YearsAgo     = "{0} 年前",
            SecondAhead  = "{0} 秒後",
            SecondsAhead = "{0} 秒後",
            MinuteAhead  = "{0} 分鐘後",
            MinutesAhead = "{0} 分鐘後",
            HourAhead    = "{0} 小時後",
            HoursAhead   = "{0} 小時後",
            DayAhead     = "{0} 天後",
            DaysAhead    = "{0} 天後",
            MonthAhead   = "{0} 個月後",
            MonthsAhead  = "{0} 個月後",
            YearAhead    = "{0} 年後",
            YearsAhead   = "{0} 年後"
        };

    private static DateTimeFormatStrings croatian;

    public static DateTimeFormatStrings Croatian =>
        croatian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Prije {0}",
            SecondsAgo   = "{0} sekundi prije",
            MinuteAgo    = "Prije {0} minute",
            MinutesAgo   = "Prije {0} minuta",
            HourAgo      = "Prije {0} sat",
            HoursAgo     = "Prije {0} sati",
            DayAgo       = "Prije {0} dan",
            DaysAgo      = "Prije {0} dana",
            MonthAgo     = "Prije {0} mjesec",
            MonthsAgo    = "Prije {0} mjeseci",
            YearAgo      = "Prije {0} godina",
            YearsAgo     = "Prije {0} godina",
            SecondAhead  = "{0} sekunde od sada",
            SecondsAhead = "{0} sekunde od sada",
            MinuteAhead  = "{0} minute od sada",
            MinutesAhead = "{0} minute od sada",
            HourAhead    = "{0} sata od sada",
            HoursAhead   = "{0} sata od sada",
            DayAhead     = "{0} dana od sada",
            DaysAhead    = "{0} dana od sada",
            MonthAhead   = "{0} mjeseca od sada",
            MonthsAhead  = "{0} mjeseca od sada",
            YearAhead    = "{0} godine od sada",
            YearsAhead   = "{0} godine od sada"
        };

    private static DateTimeFormatStrings czech;

    public static DateTimeFormatStrings Czech =>
        czech ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Před {0} sekunda",
            SecondsAgo   = "Před {0} sekund",
            MinuteAgo    = "Před {0} minutou",
            MinutesAgo   = "Před {0} minutami",
            HourAgo      = "Před {0} hodinou",
            HoursAgo     = "{0} hodiny",
            DayAgo       = "Před {0} dnem",
            DaysAgo      = "Před {0} dny",
            MonthAgo     = "{0} před měsícem",
            MonthsAgo    = "Před {0} měsíci",
            YearAgo      = "Před {0} rokem",
            YearsAgo     = "Před {0} lety",
            SecondAhead  = "za {0} sekundy",
            SecondsAhead = "za {0} sekundy",
            MinuteAhead  = "za {0} minuty",
            MinutesAhead = "za {0} minuty",
            HourAhead    = "za {0} hodiny",
            HoursAhead   = "za {0} hodiny",
            DayAhead     = "za {0} dny",
            DaysAhead    = "za {0} dny",
            MonthAhead   = "za {0} měsíce",
            MonthsAhead  = "{0} měsíce ode dneška",
            YearAhead    = "{0} roky ode dneška",
            YearsAhead   = "za {0} roky"
        };

    private static DateTimeFormatStrings danish;

    public static DateTimeFormatStrings Danish =>
        danish ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} sekund siden",
            SecondsAgo   = "{0} sekunder siden",
            MinuteAgo    = "{0} minut siden",
            MinutesAgo   = "{0} minutter siden",
            HourAgo      = "{0} time siden",
            HoursAgo     = "{0} timer siden",
            DayAgo       = "{0} dag siden",
            DaysAgo      = "{0} dage siden",
            MonthAgo     = "{0} Måned siden",
            MonthsAgo    = "{0} måneder siden",
            YearAgo      = "{0} år siden",
            YearsAgo     = "{0} år siden",
            SecondAhead  = "{0} sekunder fra nu",
            SecondsAhead = "{0} sekunder fra nu",
            MinuteAhead  = "{0} minutter fra nu",
            MinutesAhead = "{0} minutter fra nu",
            HourAhead    = "{0} timer fra nu",
            HoursAhead   = "{0} timer fra nu",
            DayAhead     = "{0} dage fra nu",
            DaysAhead    = "{0} dage fra nu",
            MonthAhead   = "{0} måneder fra nu",
            MonthsAhead  = "{0} måneder fra nu",
            YearAhead    = "{0} år fra nu",
            YearsAhead   = "{0} år fra nu"
        };

    private static DateTimeFormatStrings dutch;

    public static DateTimeFormatStrings Dutch =>
        dutch ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} seconde geleden",
            SecondsAgo   = "{0} seconden geleden",
            MinuteAgo    = "{0} minuut geleden",
            MinutesAgo   = "{0} minuten geleden",
            HourAgo      = "{0} uur geleden",
            HoursAgo     = "{0} uur geleden",
            DayAgo       = "{0} dag geleden",
            DaysAgo      = "{0} dagen geleden",
            MonthAgo     = "{0} maand geleden",
            MonthsAgo    = "{0} maanden geleden",
            YearAgo      = "{0} jaar geleden",
            YearsAgo     = "{0} jaar geleden",
            SecondAhead  = "{0} seconden vanaf nu",
            SecondsAhead = "{0} seconden vanaf nu",
            MinuteAhead  = "{0} minuten vanaf nu",
            MinutesAhead = "{0} minuten vanaf nu",
            HourAhead    = "{0} uur vanaf nu",
            HoursAhead   = "{0} uur vanaf nu",
            DayAhead     = "{0} dagen vanaf nu",
            DaysAhead    = "Over {0} dagen",
            MonthAhead   = "{0} maanden vanaf nu",
            MonthsAhead  = "{0} maanden vanaf nu",
            YearAhead    = "{0} jaar vanaf nu",
            YearsAhead   = "{0} jaar vanaf nu"
        };

    private static DateTimeFormatStrings english;

    [VerifiedByNativeSpeaker]
    public static DateTimeFormatStrings English =>
        english ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} second ago",
            SecondsAgo   = "{0} seconds ago",
            MinuteAgo    = "{0} minute ago",
            MinutesAgo   = "{0} minutes ago",
            HourAgo      = "{0} hour ago",
            HoursAgo     = "{0} hours ago",
            DayAgo       = "{0} day ago",
            DaysAgo      = "{0} days ago",
            MonthAgo     = "{0} month ago",
            MonthsAgo    = "{0} months ago",
            YearAgo      = "{0} year ago",
            YearsAgo     = "{0} years ago",
            SecondAhead  = "{0} second from now",
            SecondsAhead = "{0} seconds from now",
            MinuteAhead  = "{0} minute from now",
            MinutesAhead = "{0} minutes from now",
            HourAhead    = "{0} hour from now",
            HoursAhead   = "{0} hours from now",
            DayAhead     = "{0} day from now",
            DaysAhead    = "{0} days from now",
            MonthAhead   = "{0} month from now",
            MonthsAhead  = "{0} months from now",
            YearAhead    = "{0} year from now",
            YearsAhead   = "{0} years from now"
        };

    private static DateTimeFormatStrings estonian;

    public static DateTimeFormatStrings Estonian =>
        estonian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} sekund tagasi",
            SecondsAgo   = "{0} tundi tagasi",
            MinuteAgo    = "{0} minut tagasi",
            MinutesAgo   = "{0} tundi tagasi",
            HourAgo      = "{0} tund tagasi",
            HoursAgo     = "{0} tundi tagasi",
            DayAgo       = "{0} tund tagasi",
            DaysAgo      = "{0} tundi tagasi",
            MonthAgo     = "{0} kuu tagasi",
            MonthsAgo    = "{0} kuud tagasi",
            YearAgo      = "{0} aasta tagasi",
            YearsAgo     = "{0} aastat tagasi",
            SecondAhead  = "{0} sekundi pärast",
            SecondsAhead = "{0} sekundi pärast",
            MinuteAhead  = "{0} minuti pärast",
            MinutesAhead = "{0} minuti pärast",
            HourAhead    = "{0} tunni pärast",
            HoursAhead   = "{0} tunni pärast",
            DayAhead     = "{0} päeva pärast",
            DaysAhead    = "{0} päeva pärast",
            MonthAhead   = "{0} kuu pärast",
            MonthsAhead  = "{0} kuu pärast",
            YearAhead    = "{0} aasta pärast",
            YearsAhead   = "{0} aasta pärast"
        };

    private static DateTimeFormatStrings filipino;

    public static DateTimeFormatStrings Filipino =>
        filipino ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} segundo ang nakalipas",
            SecondsAgo   = "{0} segundo ang nakalipas",
            MinuteAgo    = "{0} minuto ang nakalipas",
            MinutesAgo   = "{0} minuto ang nakalipas",
            HourAgo      = "{0} oras ang nakalipas",
            HoursAgo     = "{0} oras ang nakalipas",
            DayAgo       = "{0} araw ang nakalipas",
            DaysAgo      = "{0} araw ang nakalipas",
            MonthAgo     = "{0} buwan ang nakalipas",
            MonthsAgo    = "{0} buwan na nakalipas",
            YearAgo      = "{0} taon ang nakalipas",
            YearsAgo     = "{0} taon ang nakalipas",
            SecondAhead  = "{0} segundo mula ngayon",
            SecondsAhead = "{0} segundo mula ngayon",
            MinuteAhead  = "{0} minuto mula ngayon",
            MinutesAhead = "{0} minuto mula ngayon",
            HourAhead    = "{0} oras mula ngayon",
            HoursAhead   = "{0} oras mula ngayon",
            DayAhead     = "{0} araw mula ngayon",
            DaysAhead    = "{0} araw mula ngayon",
            MonthAhead   = "{0} buwan mula ngayon",
            MonthsAhead  = "{0} buwan mula ngayon",
            YearAhead    = "{0} taon mula ngayon",
            YearsAhead   = "{0} taon mula ngayon"
        };

    private static DateTimeFormatStrings finnish;

    public static DateTimeFormatStrings Finnish =>
        finnish ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} sekunti sitten",
            SecondsAgo   = "{0} sekuntia sitten",
            MinuteAgo    = "{0} minuutti sitten",
            MinutesAgo   = "{0} minuuttia sitten",
            HourAgo      = "{0} tunti sitten",
            HoursAgo     = "{0} tuntia sitten",
            DayAgo       = "{0} päivä sitten",
            DaysAgo      = "{0} päivää sitten",
            MonthAgo     = "{0} kuukausi sitten",
            MonthsAgo    = "{0} kuukautta sitten",
            YearAgo      = "{0} vuosi sitten",
            YearsAgo     = "{0} vuotta sitten",
            SecondAhead  = "{0} sekunnin kuluttua",
            SecondsAhead = "{0} sekunnin kuluttua",
            MinuteAhead  = "{0} minuutin päästä",
            MinutesAhead = "{0} minuutin päästä",
            HourAhead    = "{0} tunnin päästä",
            HoursAhead   = "{0} tunnin päästä",
            DayAhead     = "{0} päivän päästä",
            DaysAhead    = "{0} päivän päästä",
            MonthAhead   = "{0} kuukauden päästä",
            MonthsAhead  = "{0} kuukauden kuluttua",
            YearAhead    = "{0} vuoden päästä",
            YearsAhead   = "{0} vuoden päästä"
        };

    private static DateTimeFormatStrings french;

    [VerifiedByNativeSpeaker]
    public static DateTimeFormatStrings French =>
        french ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Il ya {0} seconde",
            SecondsAgo   = "Il ya {0} secondes",
            MinuteAgo    = "Il ya {0} minute",
            MinutesAgo   = "Il ya {0} minutes",
            HourAgo      = "Il ya {0} heure",
            HoursAgo     = "Il ya {0} heures",
            DayAgo       = "Il ya {0} jour",
            DaysAgo      = "Il ya {0} jours",
            MonthAgo     = "Il ya {0} mois",
            MonthsAgo    = "Il ya {0} mois",
            YearAgo      = "Il ya {0} an",
            YearsAgo     = "Il ya {0} ans",
            SecondAhead  = "dans {0} secondes",
            SecondsAhead = "dans {0} secondes",
            MinuteAhead  = "dans {0} minutes",
            MinutesAhead = "dans {0} minutes",
            HourAhead    = "dans {0} heures",
            HoursAhead   = "dans {0} heures",
            DayAhead     = "dans {0} jours",
            DaysAhead    = "dans {0} jours",
            MonthAhead   = "dans {0} mois",
            MonthsAhead  = "dans {0} mois",
            YearAhead    = "dans {0} ans",
            YearsAhead   = "dans {0} ans"
        };

    private static DateTimeFormatStrings galician;

    public static DateTimeFormatStrings Galician =>
        galician ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} segundo atrás",
            SecondsAgo   = "{0} segundo atrás",
            MinuteAgo    = "{0} hora",
            MinutesAgo   = "{0} minutos atrás",
            HourAgo      = "{0} hora",
            HoursAgo     = "{0} horas atrás",
            DayAgo       = "{0} día",
            DaysAgo      = "{0} días atrás",
            MonthAgo     = "{0} mes atrás",
            MonthsAgo    = "{0} meses atrás",
            YearAgo      = "{0} ano atrás",
            YearsAgo     = "{0} anos",
            SecondAhead  = "Dentro de {0} segundos",
            SecondsAhead = "Dentro de {0} segundos",
            MinuteAhead  = "Dentro de {0} minutos",
            MinutesAhead = "Dentro de {0} minutos",
            HourAhead    = "Dentro de {0} horas",
            HoursAhead   = "Dentro de {0} horas",
            DayAhead     = "Dentro de {0} días",
            DaysAhead    = "Dentro de {0} días",
            MonthAhead   = "Dentro de {0} meses",
            MonthsAhead  = "Dentro de {0} meses",
            YearAhead    = "Dentro de {0} anos",
            YearsAhead   = "Dentro de {0} anos"
        };

    private static DateTimeFormatStrings georgian;

    public static DateTimeFormatStrings Georgian =>
        georgian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} წამის წინ",
            SecondsAgo   = "{0} წამის წინ",
            MinuteAgo    = "{0} წუთის წინ",
            MinutesAgo   = "{0} წუთის წინ",
            HourAgo      = "{0} საათის წინ",
            HoursAgo     = "{0} საათის წინ",
            DayAgo       = "{0} დღის წინ",
            DaysAgo      = "{0} დღის წინ",
            MonthAgo     = "{0} თვის წინ",
            MonthsAgo    = "{0} თვის წინ",
            YearAgo      = "{0} წლის წინ",
            YearsAgo     = "{0} წლის წინ",
            SecondAhead  = "{0} წამის შემდეგ",
            SecondsAhead = "{0} წამის შემდეგ",
            MinuteAhead  = "{0} წუთის შემდეგ",
            MinutesAhead = "{0} წუთის შემდეგ",
            HourAhead    = "{0} საათის შემდეგ",
            HoursAhead   = "{0} საათის შემდეგ",
            DayAhead     = "{0} დღის შემდეგ",
            DaysAhead    = "{0} დღის შემდეგ",
            MonthAhead   = "{0} თვის შემდეგ",
            MonthsAhead  = "{0} თვის შემდეგ",
            YearAhead    = "{0} წლის შემდეგ",
            YearsAhead   = "{0} წლის შემდეგ"
        };

    private static DateTimeFormatStrings german;

    public static DateTimeFormatStrings German =>
        german ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Vor {0} Sekunde",
            SecondsAgo   = "Vor {0} Sekunden",
            MinuteAgo    = "Vor {0} Minute",
            MinutesAgo   = "Vor {0} Minuten",
            HourAgo      = "Vor {0} Stunde",
            HoursAgo     = "Vor {0} Stunden",
            DayAgo       = "Vor {0} Tag",
            DaysAgo      = "Vor {0} Tage",
            MonthAgo     = "Vor {0} Monat",
            MonthsAgo    = "Vor {0} Monaten",
            YearAgo      = "Vor {0} Jahr",
            YearsAgo     = "Vor {0} Jahren",
            SecondAhead  = "In {0} Sekunden",
            SecondsAhead = "In {0} Sekunden",
            MinuteAhead  = "In {0} Minuten",
            MinutesAhead = "In {0} Minuten",
            HourAhead    = "In {0} Stunden",
            HoursAhead   = "In {0} Stunden",
            DayAhead     = "In {0} Tagen",
            DaysAhead    = "In {0} Tagen",
            MonthAhead   = "In {0} Monaten",
            MonthsAhead  = "In {0} Monaten",
            YearAhead    = "In {0} Jahren",
            YearsAhead   = "In {0} Jahren"
        };

    private static DateTimeFormatStrings greek;

    public static DateTimeFormatStrings Greek =>
        greek ??= new DateTimeFormatStrings
        {
            SecondAgo    = "πριν από {0} δευτερόλεπτο",
            SecondsAgo   = "πριν από {0} δευτερόλεπτα",
            MinuteAgo    = "πριν από {0} λεπτό",
            MinutesAgo   = "πριν από {0} λεπτά",
            HourAgo      = "πριν από {0} ώρα",
            HoursAgo     = "πριν από {0} ώρες",
            DayAgo       = "{0} ημέρα πριν",
            DaysAgo      = "πριν από {0} ημέρες",
            MonthAgo     = "{0} μήνα πριν",
            MonthsAgo    = "πριν από {0} μήνες",
            YearAgo      = "{0} χρόνο πριν",
            YearsAgo     = "πριν από {0} χρόνια",
            SecondAhead  = "{0} δευτερόλεπτα από τώρα",
            SecondsAhead = "{0} δευτερόλεπτα από τώρα",
            MinuteAhead  = "{0} λεπτά από τώρα",
            MinutesAhead = "{0} λεπτά από τώρα",
            HourAhead    = "{0} ώρες από τώρα",
            HoursAhead   = "{0} ώρες από τώρα",
            DayAhead     = "{0} μέρες από τώρα",
            DaysAhead    = "{0} μέρες από τώρα",
            MonthAhead   = "{0} μήνες από τώρα",
            MonthsAhead  = "{0} μήνες από τώρα",
            YearAhead    = "{0} χρόνια από τώρα",
            YearsAhead   = "{0} χρόνια από τώρα"
        };

    private static DateTimeFormatStrings gujarati;

    public static DateTimeFormatStrings Gujarati =>
        gujarati ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} સેકન્ડ પહેલા",
            SecondsAgo   = "{0} સેકન્ડ પહેલા",
            MinuteAgo    = "{0} મિનિટ પહેલા",
            MinutesAgo   = "{0} મિનિટ પહેલા",
            HourAgo      = "{0} કલાક પહેલા",
            HoursAgo     = "{0} કલાક પહેલા",
            DayAgo       = "{0} દિવસ પહેલાં",
            DaysAgo      = "{0} દિવસ પહેલા",
            MonthAgo     = "{0} મહિનો પહેલાં",
            MonthsAgo    = "{0} મહિના પહેલા",
            YearAgo      = "{0} વર્ષ પહેલાં",
            YearsAgo     = "{0} વર્ષ પહેલાં",
            SecondAhead  = "હવેથી {0} સેકન્ડ",
            SecondsAhead = "હવેથી {0} સેકન્ડ",
            MinuteAhead  = "હવેથી {0} મિનિટ",
            MinutesAhead = "હવેથી {0} મિનિટ",
            HourAhead    = "હવેથી {0} કલાક",
            HoursAhead   = "હવેથી {0} કલાક",
            DayAhead     = "હવેથી {0} દિવસ",
            DaysAhead    = "હવેથી {0} દિવસ",
            MonthAhead   = "હવેથી {0} મહિના",
            MonthsAhead  = "હવેથી {0} મહિના",
            YearAhead    = "હવેથી {0} વર્ષ",
            YearsAhead   = "હવેથી {0} વર્ષ"
        };

    private static DateTimeFormatStrings hebrew;

    public static DateTimeFormatStrings Hebrew =>
        hebrew ??= new DateTimeFormatStrings
        {
            SecondAgo    = "לפני שניה",
            SecondsAgo   = "לפני {0} שניות",
            MinuteAgo    = "לפני {0} דקה",
            MinutesAgo   = "לפני {0} דקות",
            HourAgo      = "לפני {0} שעה",
            HoursAgo     = "לפני {0} שעות",
            DayAgo       = "לפני {0} יום",
            DaysAgo      = "לפני {0} ימים",
            MonthAgo     = "לפני {0} חודש",
            MonthsAgo    = "לפני {0} חודשים",
            YearAgo      = "{0} לפני שנה",
            YearsAgo     = "לפני {0} שנים",
            SecondAhead  = "{0} שניות מעכשיו",
            SecondsAhead = "בעוד {0} שניות מעכשיו",
            MinuteAhead  = "עוד {0} דקות מעכשיו",
            MinutesAhead = "עוד {0} דקות מעכשיו",
            HourAhead    = "עוד {0} שעות מהיום",
            HoursAhead   = "עוד {0} שעות מהיום",
            DayAhead     = "בעוד {0} ימים מהיום",
            DaysAhead    = "עוד {0} ימים מהיום",
            MonthAhead   = "בעוד {0} חודשים מהיום",
            MonthsAhead  = "בעוד {0} חודשים מהיום",
            YearAhead    = "{0} שנים מהיום",
            YearsAhead   = "בעוד {0} שנים מהיום"
        };

    private static DateTimeFormatStrings hindi;

    public static DateTimeFormatStrings Hindi =>
        hindi ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} सेकंड पहले",
            SecondsAgo   = "{0} सेकंड पहले",
            MinuteAgo    = "{0} मिनट पहले",
            MinutesAgo   = "{0} मिनट पहले",
            HourAgo      = "{0} घंटे पहले",
            HoursAgo     = "{0} घंटे पहले",
            DayAgo       = "{0} दिन पहले",
            DaysAgo      = "{0} दिन पहले",
            MonthAgo     = "{0} महीने पहले",
            MonthsAgo    = "{0} महीने पहले",
            YearAgo      = "{0} वर्ष पहले",
            YearsAgo     = "{0} साल पहले",
            SecondAhead  = "अब से {0} सेकंड",
            SecondsAhead = "अब से {0} सेकंड बाद",
            MinuteAhead  = "अब से {0} मिनट बाद",
            MinutesAhead = "अब से {0} मिनट बाद",
            HourAhead    = "अब से {0} घंटे बाद",
            HoursAhead   = "अब से {0} घंटे बाद",
            DayAhead     = "अब से {0} दिन बाद",
            DaysAhead    = "अब से {0} दिन बाद",
            MonthAhead   = "अब से {0} महीने बाद",
            MonthsAhead  = "अब से {0} महीने बाद",
            YearAhead    = "अब से {0} साल बाद",
            YearsAhead   = "अब से {0} साल बाद"
        };

    private static DateTimeFormatStrings hungarian;

    [VerifiedByNativeSpeaker]
    public static DateTimeFormatStrings Hungarian =>
        hungarian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} másodperccel ezelőtt",
            SecondsAgo   = "{0} másodperccel ezelőtt",
            MinuteAgo    = "{0} perccel ezelőtt",
            MinutesAgo   = "{0} perccel ezelőtt",
            HourAgo      = "{0} órával ezelőtt",
            HoursAgo     = "{0} órával ezelőtt",
            DayAgo       = "{0} nappal ezelőtt",
            DaysAgo      = "{0} nappal ezelőtt",
            MonthAgo     = "{0} hónappal ezelőtt",
            MonthsAgo    = "{0} hónappal ezelőtt",
            YearAgo      = "{0} évvel ezelőtt",
            YearsAgo     = "{0} évvel ezelőtt",
            SecondAhead  = "{0} másodperc múlva",
            SecondsAhead = "{0} másodperc múlva",
            MinuteAhead  = "{0} perc múlva",
            MinutesAhead = "{0} perc múlva",
            HourAhead    = "{0} óra múlva",
            HoursAhead   = "{0} óra múlva",
            DayAhead     = "{0} nap múlva",
            DaysAhead    = "{0} nap múlva",
            MonthAhead   = "{0} hónap múlva",
            MonthsAhead  = "{0} hónap múlva",
            YearAhead    = "{0} év múlva",
            YearsAhead   = "{0} év múlva"
        };

    private static DateTimeFormatStrings icelandic;

    public static DateTimeFormatStrings Icelandic =>
        icelandic ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} sekúndu síðan",
            SecondsAgo   = "{0} sekúndum síðan",
            MinuteAgo    = "{0} mínútu síðan",
            MinutesAgo   = "{0} mínútum síðan",
            HourAgo      = "{0} klukkustund síðan",
            HoursAgo     = "{0} klst síðan",
            DayAgo       = "{0} degi síðan",
            DaysAgo      = "{0} dagar síðan",
            MonthAgo     = "{0} mánuður síðan",
            MonthsAgo    = "{0} mánuðum síðan",
            YearAgo      = "{0} ári",
            YearsAgo     = "{0} árum síðan",
            SecondAhead  = "Eftir {0} sekúndur",
            SecondsAhead = "Eftir {0} sekúndur",
            MinuteAhead  = "Eftir {0} mínútur",
            MinutesAhead = "Eftir {0} mínútur",
            HourAhead    = "Eftir {0} tíma",
            HoursAhead   = "Eftir {0} tíma",
            DayAhead     = "Eftir {0} daga",
            DaysAhead    = "eftir {0} daga",
            MonthAhead   = "eftir {0} mánuði",
            MonthsAhead  = "eftir {0} mánuði",
            YearAhead    = "eftir {0} ár",
            YearsAhead   = "Eftir {0} ár"
        };

    private static DateTimeFormatStrings igbo;

    public static DateTimeFormatStrings Igbo =>
        igbo ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} abụọ gara aga",
            SecondsAgo   = "{0} sekọnd gara aga",
            MinuteAgo    = "{0} nkeji gara aga",
            MinutesAgo   = "{0} nkeji gara aga",
            HourAgo      = "{0} hour gara aga",
            HoursAgo     = "{0} awa gara aga",
            DayAgo       = "{0} ụbọchị gara aga",
            DaysAgo      = "{0} ụbọchị gara aga",
            MonthAgo     = "{0} ọnwa gara aga",
            MonthsAgo    = "{0} ọnwa gara aga",
            YearAgo      = "{0} afọ gara aga",
            YearsAgo     = "{0} afọ gara aga",
            SecondAhead  = "{0} sekọnd site ugbu a",
            SecondsAhead = "{0} sekọnd site ugbu a",
            MinuteAhead  = "{0} nkeji gara aga",
            MinutesAhead = "Nkeji {0} gara aga",
            HourAhead    = "Oge elekere {0} gara aga",
            HoursAhead   = "awa {0} gara aga",
            DayAhead     = "{0} ụbọchị site ugbu a",
            DaysAhead    = "Ụbọchị {0} gara aga",
            MonthAhead   = "Ọnwa {0} site ugbu a",
            MonthsAhead  = "Ọnwa {0} site ugbu a",
            YearAhead    = "Afọ {0} site ugbu a",
            YearsAhead   = "Afọ {0} gara aga"
        };

    private static DateTimeFormatStrings indonesian;

    public static DateTimeFormatStrings Indonesian =>
        indonesian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} detik yang lalu",
            SecondsAgo   = "{0} detik yang lalu",
            MinuteAgo    = "{0} menit yang lalu",
            MinutesAgo   = "{0} menit yang lalu",
            HourAgo      = "{0} jam yang lalu",
            HoursAgo     = "{0} jam yang lalu",
            DayAgo       = "{0} hari lalu",
            DaysAgo      = "{0} hari yang lalu",
            MonthAgo     = "{0} bulan lalu",
            MonthsAgo    = "{0} bulan lalu",
            YearAgo      = "{0} tahun lalu",
            YearsAgo     = "{0} tahun yang lalu",
            SecondAhead  = "{0} detik dari sekarang",
            SecondsAhead = "{0} detik dari sekarang",
            MinuteAhead  = "{0} menit dari sekarang",
            MinutesAhead = "{0} menit dari sekarang",
            HourAhead    = "{0} jam dari sekarang",
            HoursAhead   = "{0} jam dari sekarang",
            DayAhead     = "{0} hari dari sekarang",
            DaysAhead    = "{0} hari dari sekarang",
            MonthAhead   = "{0} bulan dari sekarang",
            MonthsAhead  = "{0} bulan dari sekarang",
            YearAhead    = "{0} tahun dari sekarang",
            YearsAhead   = "{0} tahun dari sekarang"
        };

    private static DateTimeFormatStrings irish;

    public static DateTimeFormatStrings Irish =>
        irish ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} an dara ó shin",
            SecondsAgo   = "{0} soicind ó shin",
            MinuteAgo    = "{0} nóiméad ó shin",
            MinutesAgo   = "{0} nóiméad ó shin",
            HourAgo      = "{0} uair an chloig ó shin",
            HoursAgo     = "{0} uair an chloig ó shin",
            DayAgo       = "{0} lá ó shin",
            DaysAgo      = "{0} lá ó shin",
            MonthAgo     = "{0} mí ó shin",
            MonthsAgo    = "{0} mí ó shin",
            YearAgo      = "{0} bhliain ó shin",
            YearsAgo     = "{0} bliana ó shin",
            SecondAhead  = "{0} soicind as seo amach",
            SecondsAhead = "{0} soicind ó anois",
            MinuteAhead  = "{0} nóiméad ó anois",
            MinutesAhead = "{0} nóiméad ó anois",
            HourAhead    = "{0} uair an chloig ó anois",
            HoursAhead   = "{0} uair an chloig ó anois",
            DayAhead     = "{0} lá ó anois",
            DaysAhead    = "{0} lá ó anois",
            MonthAhead   = "{0} mhí ó anois",
            MonthsAhead  = "{0} mhí ó anois",
            YearAhead    = "{0} bliana ó anois",
            YearsAhead   = "{0} bliana ó anois"
        };

    private static DateTimeFormatStrings italian;

    public static DateTimeFormatStrings Italian =>
        italian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} secondo fa",
            SecondsAgo   = "{0} secondi fa",
            MinuteAgo    = "{0} minuto fa",
            MinutesAgo   = "{0} minuti fa",
            HourAgo      = "{0} ora fa",
            HoursAgo     = "{0} ore fa",
            DayAgo       = "{0} giorno fa",
            DaysAgo      = "{0} giorni fa",
            MonthAgo     = "{0} mese fa",
            MonthsAgo    = "{0} mesi fa",
            YearAgo      = "{0} anno fa",
            YearsAgo     = "{0} anni fa",
            SecondAhead  = "{0} secondi da adesso",
            SecondsAhead = "{0} secondi da adesso",
            MinuteAhead  = "Tra {0} minuti",
            MinutesAhead = "Tra {0} minuti",
            HourAhead    = "{0} ore da adesso",
            HoursAhead   = "{0} ore da adesso",
            DayAhead     = "{0} giorni da adesso",
            DaysAhead    = "Tra {0} giorni",
            MonthAhead   = "Tra {0} mesi",
            MonthsAhead  = "Tra {0} mesi",
            YearAhead    = "Tra {0} anni",
            YearsAhead   = "Tra {0} anni"
        };

    private static DateTimeFormatStrings japanese;

    public static DateTimeFormatStrings Japanese =>
        japanese ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} 秒前",
            SecondsAgo   = "{0} 秒前",
            MinuteAgo    = "{0} 分前",
            MinutesAgo   = "{0} 分前",
            HourAgo      = "{0} 時間前",
            HoursAgo     = "{0} 時間前",
            DayAgo       = "{0} 日前",
            DaysAgo      = "{0} 日前",
            MonthAgo     = "{0} ヶ月前",
            MonthsAgo    = "{0} ヶ月前",
            YearAgo      = "{0} 年前",
            YearsAgo     = "{0} 年前",
            SecondAhead  = "今から {0} 秒後",
            SecondsAhead = "今から {0} 秒後",
            MinuteAhead  = "今から {0} 分後",
            MinutesAhead = "今から {0} 分後",
            HourAhead    = "今から {0} 時間後",
            HoursAhead   = "今から {0} 時間後",
            DayAhead     = "今から {0} 日後",
            DaysAhead    = "今から {0} 日後",
            MonthAhead   = "今から {0} か月後",
            MonthsAhead  = "今から {0} か月後",
            YearAhead    = "今から {0} 年後",
            YearsAhead   = "今から {0} 年後"
        };

    private static DateTimeFormatStrings kannada;

    public static DateTimeFormatStrings Kannada =>
        kannada ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} ಸೆಕೆಂಡ್ ಹಿಂದೆ",
            SecondsAgo   = "{0} ಸೆಕೆಂಡುಗಳ ಹಿಂದೆ",
            MinuteAgo    = "{0} ನಿಮಿಷ ಹಿಂದೆ",
            MinutesAgo   = "{0} ನಿಮಿಷಗಳ ಹಿಂದೆ",
            HourAgo      = "{0} ಗಂಟೆಯ ಹಿಂದೆ",
            HoursAgo     = "{0} ಗಂಟೆಗಳ ಹಿಂದೆ",
            DayAgo       = "{0} ದಿನ ಹಿಂದೆ",
            DaysAgo      = "{0} ದಿನಗಳ ಹಿಂದೆ",
            MonthAgo     = "{0} ತಿಂಗಳ ಹಿಂದೆ",
            MonthsAgo    = "{0} ತಿಂಗಳ ಹಿಂದೆ",
            YearAgo      = "{0} ವರ್ಷದ ಹಿಂದೆ",
            YearsAgo     = "{0} ವರ್ಷಗಳ ಹಿಂದೆ",
            SecondAhead  = "ಈಗಿನಿಂದ {0} ಸೆಕೆಂಡುಗಳು",
            SecondsAhead = "ಈಗಿನಿಂದ {0} ಸೆಕೆಂಡುಗಳು",
            MinuteAhead  = "ಈಗಿನಿಂದ {0} ನಿಮಿಷ",
            MinutesAhead = "ಈಗಿನಿಂದ {0} ನಿಮಿಷಗಳು",
            HourAhead    = "ಈಗಿನಿಂದ {0} ಗಂಟೆ",
            HoursAhead   = "ಈಗಿನಿಂದ {0} ಗಂಟೆಗಳು",
            DayAhead     = "ಈಗಿನಿಂದ {0} ದಿನ",
            DaysAhead    = "ಈಗಿನಿಂದ {0} ದಿನಗಳು",
            MonthAhead   = "ಈಗಿನಿಂದ {0} ತಿಂಗಳು",
            MonthsAhead  = "ಈಗಿನಿಂದ {0} ತಿಂಗಳು",
            YearAhead    = "ಈಗಿನಿಂದ {0} ವರ್ಷ",
            YearsAhead   = "ಈಗಿನಿಂದ {0} ವರ್ಷಗಳು"
        };

    private static DateTimeFormatStrings kazakh;

    public static DateTimeFormatStrings Kazakh =>
        kazakh ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} екінші бұрын",
            SecondsAgo   = "{0} секунд бұрын",
            MinuteAgo    = "{0} минут бұрын",
            MinutesAgo   = "{0} минут бұрын",
            HourAgo      = "{0} сағат бұрын",
            HoursAgo     = "{0} сағат бұрын",
            DayAgo       = "{0} күн бұрын",
            DaysAgo      = "{0} күн бұрын",
            MonthAgo     = "{0} ай бұрын",
            MonthsAgo    = "{0} ай бұрын",
            YearAgo      = "{0} жыл бұрын",
            YearsAgo     = "{0} жыл бұрын",
            SecondAhead  = "{0} секундтан кейін",
            SecondsAhead = "{0} секундтан кейін",
            MinuteAhead  = "{0} минуттан кейін",
            MinutesAhead = "{0} минуттан кейін",
            HourAhead    = "{0} сағаттан кейін",
            HoursAhead   = "{0} сағаттан кейін",
            DayAhead     = "{0} күннен кейін",
            DaysAhead    = "{0} күннен кейін",
            MonthAhead   = "{0} айдан кейін",
            MonthsAhead  = "{0} айдан кейін",
            YearAhead    = "{0} жылдан кейін",
            YearsAhead   = "{0} жылдан кейін"
        };

    private static DateTimeFormatStrings khmer;

    public static DateTimeFormatStrings Khmer =>
        khmer ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} វិនាទីមុន",
            SecondsAgo   = "{0} វិនាទីមុន",
            MinuteAgo    = "{0} នាទីមុន",
            MinutesAgo   = "{0} នាទីមុន",
            HourAgo      = "{0} ម៉ោងមុន",
            HoursAgo     = "{0} ម៉ោងកន្លងទៅ",
            DayAgo       = "{0} ថ្ងៃមុន",
            DaysAgo      = "{0} ថ្ងៃមុន",
            MonthAgo     = "{0} ខែកន្លង",
            MonthsAgo    = "{0} ខែកន្លងទៅ",
            YearAgo      = "{0} ឆ្នាំមុន",
            YearsAgo     = "{0} ឆ្នាំកន្លងមក",
            SecondAhead  = "{0} វិនាទីពីពេលនេះ",
            SecondsAhead = "{0} វិនាទីពីពេលនេះ",
            MinuteAhead  = "{0} នាទីពីពេលនេះ",
            MinutesAhead = "{0} នាទីពីពេលនេះ",
            HourAhead    = "{0} ម៉ោងពីពេលនេះ",
            HoursAhead   = "{0} ម៉ោងពីពេលនេះ",
            DayAhead     = "{0} ថ្ងៃចាប់ពីពេលនេះទៅ",
            DaysAhead    = "{0} ថ្ងៃចាប់ពីពេលនេះតទៅ",
            MonthAhead   = "{0} ខែចាប់ពីពេលនេះទៅ",
            MonthsAhead  = "{0} ខែចាប់ពីពេលនេះទៅ",
            YearAhead    = "{0} ឆ្នាំចាប់ពីពេលនេះទៅ",
            YearsAhead   = "{0} ឆ្នាំពីពេលនេះ"
        };

    private static DateTimeFormatStrings korean;

    public static DateTimeFormatStrings Korean =>
        korean ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} 초 전",
            SecondsAgo   = "{0} 초 전",
            MinuteAgo    = "{0} 분 전",
            MinutesAgo   = "{0} 분 전",
            HourAgo      = "{0} 시간 전",
            HoursAgo     = "{0} 시간 전",
            DayAgo       = "{0} 일 전",
            DaysAgo      = "{0} 일 전",
            MonthAgo     = "{0} 달 전",
            MonthsAgo    = "{0} 개월 전",
            YearAgo      = "{0} 년 전",
            YearsAgo     = "{0} 년 전",
            SecondAhead  = "지금부터 {0} 초",
            SecondsAhead = "지금부터 {0} 초",
            MinuteAhead  = "지금부터 {0} 분",
            MinutesAhead = "지금부터 {0} 분",
            HourAhead    = "지금부터 {0} 시간",
            HoursAhead   = "지금부터 {0} 시간",
            DayAhead     = "지금부터 {0} 일",
            DaysAhead    = "지금부터 {0} 일",
            MonthAhead   = "지금부터 {0} 개월",
            MonthsAhead  = "지금부터 {0} 개월",
            YearAhead    = "지금부터 {0} 년",
            YearsAhead   = "지금부터 {0} 년"
        };

    private static DateTimeFormatStrings lao;

    public static DateTimeFormatStrings Lao =>
        lao ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} ວິນາທີກ່ອນຫນ້ານີ້",
            SecondsAgo   = "{0} ວິນາທີກ່ອນຫນ້ານີ້",
            MinuteAgo    = "{0} ນາທີກ່ອນຫນ້ານີ້",
            MinutesAgo   = "{0} ນາທີກ່ອນຫນ້ານີ້",
            HourAgo      = "{0} ຊົ່ວໂມງກ່ອນຫນ້ານີ້",
            HoursAgo     = "{0} ຊົ່ວໂມງກ່ອນຫນ້ານີ້",
            DayAgo       = "{0} ມື້ກ່ອນຫນ້ານີ້",
            DaysAgo      = "{0} ມື້ກ່ອນຫນ້ານີ້",
            MonthAgo     = "{0} ເດືອນທີ່ຜ່ານມາ",
            MonthsAgo    = "{0} ເດືອນທີ່ຜ່ານມາ",
            YearAgo      = "{0} ປີກ່ອນຫນ້ານີ້",
            YearsAgo     = "{0} ປີກ່ອນຫນ້ານີ້",
            SecondAhead  = "{0} ວິນາທີຈາກນີ້",
            SecondsAhead = "{0} ວິນາທີຈາກນີ້",
            MinuteAhead  = "{0} ນາທີຈາກຕອນນີ້",
            MinutesAhead = "{0} ນາທີຈາກຕອນນີ້",
            HourAhead    = "{0} ຊົ່ວໂມງຈາກນີ້",
            HoursAhead   = "{0} ຊົ່ວໂມງຈາກນີ້",
            DayAhead     = "{0} ມື້ຈາກນີ້",
            DaysAhead    = "{0} ມື້ຈາກນີ້",
            MonthAhead   = "{0} ເດືອນ​ຈາກ​ນີ້​",
            MonthsAhead  = "{0} ເດືອນຈາກນີ້",
            YearAhead    = "{0} ປີ​ຈາກ​ນີ້​",
            YearsAhead   = "{0} ປີ​ຈາກ​ນີ້​"
        };

    private static DateTimeFormatStrings latvian;

    public static DateTimeFormatStrings Latvian =>
        latvian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Pirms {0} sekundes",
            SecondsAgo   = "{0} sekundes pirms",
            MinuteAgo    = "{0} stunda pirms",
            MinutesAgo   = "{0} minūtes pirms",
            HourAgo      = "Pirms {0} stundas",
            HoursAgo     = "Pirms {0} stundām",
            DayAgo       = "Pirms {0} dienas",
            DaysAgo      = "{0} dienas atpakaļ",
            MonthAgo     = "{0} mēnesis pirms",
            MonthsAgo    = "Pirms {0} mēnešiem",
            YearAgo      = "Pirms {0} gads",
            YearsAgo     = "Pirms {0} gadiem",
            SecondAhead  = "{0} sekundes no šī brīža",
            SecondsAhead = "{0} sekundes no šī brīža",
            MinuteAhead  = "{0} minūtes no šī brīža",
            MinutesAhead = "{0} minūtes no šī brīža",
            HourAhead    = "{0} stundas no šī brīža",
            HoursAhead   = "{0} stundas no šī brīža",
            DayAhead     = "{0} dienas no šī brīža",
            DaysAhead    = "{0} dienas no šī brīža",
            MonthAhead   = "{0} mēneši no šī brīža",
            MonthsAhead  = "{0} mēneši no šī brīža",
            YearAhead    = "{0} gadi no šī brīža",
            YearsAhead   = "{0} gadi no šī brīža"
        };

    private static DateTimeFormatStrings lithuanian;

    public static DateTimeFormatStrings Lithuanian =>
        lithuanian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Prieš {0} sekundę",
            SecondsAgo   = "Prieš {0} sekundes",
            MinuteAgo    = "Prieš {0} minutę",
            MinutesAgo   = "Prieš {0} minutes",
            HourAgo      = "Prieš {0} valandą",
            HoursAgo     = "Prieš {0} val",
            DayAgo       = "Prieš {0} dieną",
            DaysAgo      = "{0} days ago",
            MonthAgo     = "Prieš {0} mėnesį",
            MonthsAgo    = "{0} mėnesiai prieš",
            YearAgo      = "Prieš {0} metus",
            YearsAgo     = "Prieš {0} metų",
            SecondAhead  = "{0} sekundes nuo dabar",
            SecondsAhead = "{0} sekundes nuo dabar",
            MinuteAhead  = "{0} minutes nuo dabar",
            MinutesAhead = "{0} minutes nuo dabar",
            HourAhead    = "{0} valandos nuo dabar",
            HoursAhead   = "{0} valandos nuo dabar",
            DayAhead     = "{0} dienos nuo dabar",
            DaysAhead    = "{0} dienos nuo dabar",
            MonthAhead   = "{0} mėnesiai nuo dabar",
            MonthsAhead  = "{0} mėnesiai nuo dabar",
            YearAhead    = "{0} metai nuo dabar",
            YearsAhead   = "{0} metai nuo dabar"
        };

    private static DateTimeFormatStrings macedonian;

    public static DateTimeFormatStrings Macedonian =>
        macedonian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Пред {0} секунда",
            SecondsAgo   = "Пред {0} секунди",
            MinuteAgo    = "Пред {0} минута",
            MinutesAgo   = "Пред {0} минути",
            HourAgo      = "Пред {0} час",
            HoursAgo     = "Пред {0} часа",
            DayAgo       = "Пред {0} ден",
            DaysAgo      = "Пред {0} дена",
            MonthAgo     = "Пред {0} месец",
            MonthsAgo    = "Пред {0} месеци",
            YearAgo      = "Пред {0} година",
            YearsAgo     = "Пред {0} години",
            SecondAhead  = "{0} секунди од сега",
            SecondsAhead = "{0} секунди од сега",
            MinuteAhead  = "{0} минути од сега",
            MinutesAhead = "{0} минути од сега",
            HourAhead    = "{0} часа од сега",
            HoursAhead   = "{0} часа од сега",
            DayAhead     = "{0} ден од сега",
            DaysAhead    = "{0} дена од сега",
            MonthAhead   = "{0} месеци од сега",
            MonthsAhead  = "{0} месеци од сега",
            YearAhead    = "{0} години од сега",
            YearsAhead   = "{0} години од сега"
        };

    private static DateTimeFormatStrings malagasy;

    public static DateTimeFormatStrings Malagasy =>
        malagasy ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} faharoa lasa izay",
            SecondsAgo   = "{0} segondra lasa izay",
            MinuteAgo    = "{0} minitra lasa izay",
            MinutesAgo   = "{0} minitra lasa izay",
            HourAgo      = "{0} adiny lasa izay",
            HoursAgo     = "{0} adiny lasa izay",
            DayAgo       = "{0} andro lasa izay",
            DaysAgo      = "{0} andro lasa izay",
            MonthAgo     = "{0} volana lasa izay",
            MonthsAgo    = "{0} volana lasa izay",
            YearAgo      = "{0} taona lasa izay",
            YearsAgo     = "{0} taona lasa izay",
            SecondAhead  = "{0} segondra manomboka izao",
            SecondsAhead = "{0} segondra manomboka izao",
            MinuteAhead  = "{0} minitra manomboka izao",
            MinutesAhead = "{0} minitra manomboka izao",
            HourAhead    = "{0} ora manomboka izao",
            HoursAhead   = "{0} ora manomboka izao",
            DayAhead     = "{0} andro manomboka izao",
            DaysAhead    = "{0} andro manomboka izao",
            MonthAhead   = "{0} volana manomboka izao",
            MonthsAhead  = "{0} volana manomboka izao",
            YearAhead    = "{0} taona manomboka izao",
            YearsAhead   = "{0} taona manomboka izao"
        };

    private static DateTimeFormatStrings malayalam;

    public static DateTimeFormatStrings Malayalam =>
        malayalam ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} സെക്കന്റ് മുമ്പ്",
            SecondsAgo   = "{0} സെക്കന്റ് മുമ്പ്",
            MinuteAgo    = "{0} മിനിറ്റ് മുമ്പ്",
            MinutesAgo   = "{0} മിനിറ്റ് മുമ്പ്",
            HourAgo      = "{0} മണിക്കൂർ മുമ്പ്",
            HoursAgo     = "{0} മണിക്കൂര് മുമ്പ്",
            DayAgo       = "{0} ദിവസം മുമ്പ്",
            DaysAgo      = "{0} ദിവസം മുമ്പ്",
            MonthAgo     = "{0} മാസം മുമ്പ്",
            MonthsAgo    = "{0} മാസം മുമ്പ്",
            YearAgo      = "{0} വർഷം മുമ്പ്",
            YearsAgo     = "{0} വർഷങ്ങൾക്ക് മുൻപ്",
            SecondAhead  = "ഇപ്പോൾ മുതൽ {0} സെക്കൻഡ്",
            SecondsAhead = "ഇപ്പോൾ മുതൽ {0} സെക്കൻഡ്",
            MinuteAhead  = "ഇപ്പോൾ മുതൽ {0} മിനിറ്റ്",
            MinutesAhead = "ഇപ്പോൾ മുതൽ {0} മിനിറ്റ്",
            HourAhead    = "ഇപ്പോൾ മുതൽ {0} മണിക്കൂർ",
            HoursAhead   = "ഇപ്പോൾ മുതൽ {0} മണിക്കൂർ",
            DayAhead     = "ഇനി മുതൽ {0} ദിവസം",
            DaysAhead    = "ഇപ്പോൾ മുതൽ {0} ദിവസം",
            MonthAhead   = "ഇപ്പോൾ മുതൽ {0} മാസം",
            MonthsAhead  = "ഇപ്പോൾ മുതൽ {0} മാസം",
            YearAhead    = "ഇപ്പോൾ മുതൽ {0} വർഷം",
            YearsAhead   = "ഇപ്പോൾ മുതൽ {0} വർഷം"
        };

    private static DateTimeFormatStrings maltese;

    public static DateTimeFormatStrings Maltese =>
        maltese ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} it-tieni ilu",
            SecondsAgo   = "{0} sekondi ilu",
            MinuteAgo    = "{0} minuta ilu",
            MinutesAgo   = "{0} minuti ilu",
            HourAgo      = "{0} siegħa ilu",
            HoursAgo     = "{0} sigħat ilu",
            DayAgo       = "{0} jum ilu",
            DaysAgo      = "{0} ijiem ilu",
            MonthAgo     = "{0} xahar ilu",
            MonthsAgo    = "{0} xhur ilu",
            YearAgo      = "{0} sena ilu",
            YearsAgo     = "{0} snin ilu",
            SecondAhead  = "{0} sekondi minn issa",
            SecondsAhead = "{0} sekondi minn issa",
            MinuteAhead  = "{0} minuti minn issa",
            MinutesAhead = "{0} minuti minn issa",
            HourAhead    = "{0} sigħat minn issa",
            HoursAhead   = "{0} sigħat minn issa",
            DayAhead     = "{0} ijiem minn issa",
            DaysAhead    = "{0} ijiem minn issa",
            MonthAhead   = "{0} xhur minn issa",
            MonthsAhead  = "{0} xhur minn issa",
            YearAhead    = "{0} snin minn issa",
            YearsAhead   = "{0} snin minn issa"
        };

    private static DateTimeFormatStrings maori;

    public static DateTimeFormatStrings Maori =>
        maori ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} tuarua i mua",
            SecondsAgo   = "{0} hēkona i mua",
            MinuteAgo    = "{0} meneti i mua",
            MinutesAgo   = "{0} meneti i mua",
            HourAgo      = "{0} haora i mua",
            HoursAgo     = "{0} haora i mua",
            DayAgo       = "{0} ra i mua",
            DaysAgo      = "{0} nga ra i mua",
            MonthAgo     = "{0} marama i mua",
            MonthsAgo    = "{0} marama ki muri",
            YearAgo      = "{0} te tau i mua",
            YearsAgo     = "{0} tau ki muri",
            SecondAhead  = "{0} hēkona mai i tēnei wā",
            SecondsAhead = "{0} hēkona mai i tēnei wā",
            MinuteAhead  = "{0} meneti mai i tenei wa",
            MinutesAhead = "{0} meneti mai i tenei wa",
            HourAhead    = "{0} haora mai i tenei wa",
            HoursAhead   = "{0} haora mai i tenei wa",
            DayAhead     = "{0} ra mai i tenei wa",
            DaysAhead    = "{0} ra mai i tenei wa",
            MonthAhead   = "{0} marama mai i tenei wa",
            MonthsAhead  = "{0} marama mai i tenei wa",
            YearAhead    = "{0} tau mai i tenei wa",
            YearsAhead   = "{0} tau mai i tenei wa"
        };

    private static DateTimeFormatStrings marathi;

    public static DateTimeFormatStrings Marathi =>
        marathi ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} सेकंद पूर्वी",
            SecondsAgo   = "{0} सेकंद पूर्वी",
            MinuteAgo    = "{0} मिनिटा पूर्वी",
            MinutesAgo   = "{0} मिनिटे पूर्वी",
            HourAgo      = "{0} तास पूर्वी",
            HoursAgo     = "{0} तास पूर्वी",
            DayAgo       = "{0} दिवसा पूर्वी",
            DaysAgo      = "{0} दिवसा पूर्वी",
            MonthAgo     = "{0} महिन्या पूर्वी",
            MonthsAgo    = "{0} महिने पूर्वी",
            YearAgo      = "{0} वर्षा पूर्वी",
            YearsAgo     = "{0} वर्षे पूर्वी",
            SecondAhead  = "आतापासून {0} सेकंद",
            SecondsAhead = "आतापासून {0} सेकंद",
            MinuteAhead  = "आतापासून {0} मिनिटे",
            MinutesAhead = "आतापासून {0} मिनिटे",
            HourAhead    = "आतापासून {0} तास",
            HoursAhead   = "आतापासून {0} तास",
            DayAhead     = "{0} दिवसात",
            DaysAhead    = "{0} दिवसात",
            MonthAhead   = "{0} महिन्यात",
            MonthsAhead  = "आतापासून {0} महिने",
            YearAhead    = "आतापासून {0} वर्षे",
            YearsAhead   = "{0} वर्षांत"
        };

    private static DateTimeFormatStrings mongolian;

    public static DateTimeFormatStrings Mongolian =>
        mongolian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} секундын өмнө",
            SecondsAgo   = "{0} секунд өмнө",
            MinuteAgo    = "{0} минут өмнө",
            MinutesAgo   = "{0} минутын өмнө",
            HourAgo      = "{0} цагийн өмнө",
            HoursAgo     = "{0} цагийн өмнө",
            DayAgo       = "{0} өдрийн өмнө",
            DaysAgo      = "{0} өдрийн өмнө",
            MonthAgo     = "{0} сарын өмнө",
            MonthsAgo    = "{0} сар өмнө",
            YearAgo      = "{0} жил өмнө",
            YearsAgo     = "{0} жилийн өмнө",
            SecondAhead  = "Одооноос {0} секунд",
            SecondsAhead = "{0} секундын дараа",
            MinuteAhead  = "Одооноос {0} минутын дараа",
            MinutesAhead = "Одооноос {0} минутын дараа",
            HourAhead    = "Одооноос {0} цагийн дараа",
            HoursAhead   = "Одооноос {0} цагийн дараа",
            DayAhead     = "{0} хоногийн дараа",
            DaysAhead    = "Одооноос {0} хоногийн дараа",
            MonthAhead   = "Одооноос {0} сарын дараа",
            MonthsAhead  = "Одооноос {0} сарын дараа",
            YearAhead    = "{0} жилийн дараа",
            YearsAhead   = "{0} жилийн дараа"
        };

    private static DateTimeFormatStrings nepali;

    public static DateTimeFormatStrings Nepali =>
        nepali ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} सेकेण्ड अघि",
            SecondsAgo   = "{0} सेकेन्ड अघि",
            MinuteAgo    = "{0} मिनट अघि",
            MinutesAgo   = "{0} मिनेट अघि",
            HourAgo      = "{0} घंटा अघि",
            HoursAgo     = "{0} घण्टा अघि",
            DayAgo       = "{0} दिन अघि",
            DaysAgo      = "{0} दिनों अघि",
            MonthAgo     = "{0} महीना अघि",
            MonthsAgo    = "{0} महिना अघि",
            YearAgo      = "{0} वर्ष अघि",
            YearsAgo     = "{0} वर्षसम्म अघि",
            SecondAhead  = "अब देखि {0} सेकेन्ड",
            SecondsAhead = "अब देखि {0} सेकेन्ड",
            MinuteAhead  = "अब देखि {0} मिनेट",
            MinutesAhead = "अब देखि {0} मिनेट",
            HourAhead    = "अब देखि {0} घण्टा",
            HoursAhead   = "अब देखि {0} घण्टा",
            DayAhead     = "अब देखि {0} दिन",
            DaysAhead    = "अब देखि {0} दिन",
            MonthAhead   = "अब देखि {0} महिना",
            MonthsAhead  = "अब देखि {0} महिना",
            YearAhead    = "अब देखि {0} वर्ष",
            YearsAhead   = "अब देखि {0} वर्ष"
        };

    private static DateTimeFormatStrings norwegian;

    public static DateTimeFormatStrings Norwegian =>
        norwegian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} sekund siden",
            SecondsAgo   = "{0} sekunder siden",
            MinuteAgo    = "{0} minutt siden",
            MinutesAgo   = "{0} minutter siden",
            HourAgo      = "{0} time siden",
            HoursAgo     = "{0} timer siden",
            DayAgo       = "{0} dag siden",
            DaysAgo      = "{0} dager siden",
            MonthAgo     = "{0} måned siden",
            MonthsAgo    = "{0} måneder siden",
            YearAgo      = "{0} år siden",
            YearsAgo     = "{0} år siden",
            SecondAhead  = "{0} sekunder fra nå",
            SecondsAhead = "{0} sekunder fra nå",
            MinuteAhead  = "{0} minutter fra nå",
            MinutesAhead = "{0} minutter fra nå",
            HourAhead    = "{0} timer fra nå",
            HoursAhead   = "{0} timer fra nå",
            DayAhead     = "{0} dager fra nå",
            DaysAhead    = "{0} dager fra nå",
            MonthAhead   = "{0} måneder fra nå",
            MonthsAhead  = "{0} måneder fra nå",
            YearAhead    = "{0} år fra nå",
            YearsAhead   = "{0} år fra nå"
        };

    private static DateTimeFormatStrings persian;

    public static DateTimeFormatStrings Persian =>
        persian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} ثانیه پیش",
            SecondsAgo   = "{0} ثانیه قبل",
            MinuteAgo    = "{0} دقیقه قبل",
            MinutesAgo   = "{0} دقیقه پیش",
            HourAgo      = "{0} ساعت پیش",
            HoursAgo     = "{0} ساعات پیش",
            DayAgo       = "{0} روز را پیش",
            DaysAgo      = "{0} روز پیش",
            MonthAgo     = "{0} ماه پیش",
            MonthsAgo    = "{0} ماه پیش",
            YearAgo      = "{0} سال پیش",
            YearsAgo     = "{0} سال پیش",
            SecondAhead  = "{0} ثانیه از الان",
            SecondsAhead = "{0} ثانیه دیگر",
            MinuteAhead  = "{0} دقیقه دیگه",
            MinutesAhead = "{0} دقیقه دیگر",
            HourAhead    = "{0} ساعت دیگه",
            HoursAhead   = "{0} ساعت دیگه",
            DayAhead     = "{0} روز دیگه",
            DaysAhead    = "{0} روز دیگه",
            MonthAhead   = "{0} ماه دیگه",
            MonthsAhead  = "{0} ماه دیگه",
            YearAhead    = "{0} سال دیگه",
            YearsAhead   = "{0} سال دیگه"
        };

    private static DateTimeFormatStrings polish;

    public static DateTimeFormatStrings Polish =>
        polish ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} sekundę temu",
            SecondsAgo   = "{0} sekund temu",
            MinuteAgo    = "{0} minut temu",
            MinutesAgo   = "{0} minut temu",
            HourAgo      = "{0} godzinę temu",
            HoursAgo     = "{0} godzin temu",
            DayAgo       = "{0} dzień temu",
            DaysAgo      = "{0} dni temu",
            MonthAgo     = "{0} miesiąc temu",
            MonthsAgo    = "{0} miesięcy temu",
            YearAgo      = "{0} rok temu",
            YearsAgo     = "{0} lat temu",
            SecondAhead  = "Za {0} sekundy",
            SecondsAhead = "Za {0} sekundy",
            MinuteAhead  = "Za {0} minuty",
            MinutesAhead = "Za {0} minuty",
            HourAhead    = "Za {0} godziny",
            HoursAhead   = "Za {0} godziny",
            DayAhead     = "Za {0} dni",
            DaysAhead    = "Za {0} dni",
            MonthAhead   = "za {0} miesiące",
            MonthsAhead  = "Za {0} miesiące",
            YearAhead    = "Za {0} lata",
            YearsAhead   = "Za {0} lata"
        };

    private static DateTimeFormatStrings portuguese;

    public static DateTimeFormatStrings Portuguese =>
        portuguese ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} segundo atrás",
            SecondsAgo   = "{0} segondos atrás",
            MinuteAgo    = "{0} minuto atrás",
            MinutesAgo   = "{0} minutos atrás",
            HourAgo      = "{0} hora atrás",
            HoursAgo     = "{0} horas atrás",
            DayAgo       = "{0} dia atrás",
            DaysAgo      = "{0} dias atrás",
            MonthAgo     = "{0} mes atrás",
            MonthsAgo    = "{0} meses atrás",
            YearAgo      = "{0} ano atrás",
            YearsAgo     = "{0} anos atrás",
            SecondAhead  = "Daqui a {0} segundos",
            SecondsAhead = "Daqui a {0} segundos",
            MinuteAhead  = "Daqui a {0} minutos",
            MinutesAhead = "Daqui a {0} minutos",
            HourAhead    = "daqui a {0} horas",
            HoursAhead   = "Daqui a {0} horas",
            DayAhead     = "Daqui a {0} dias",
            DaysAhead    = "Daqui a {0} dias",
            MonthAhead   = "Daqui a {0} meses",
            MonthsAhead  = "Daqui a {0} meses",
            YearAhead    = "Daqui a {0} anos",
            YearsAhead   = "Daqui a {0} anos"
        };

    //private static DateTimeFormatStrings punjabi;
    //public static DateTimeFormatStrings Punjabi {
    //	get {
    //		return punjabi ?? (punjabi = new DateTimeFormatStrings {
    //			SecondAgo =  "{0}",
    //			SecondsAgo = "{0}",
    //			MinuteAgo =  "{0}",
    //			MinutesAgo = "{0}",
    //			HourAgo =    "{0}",
    //			HoursAgo =   "{0}",
    //			DayAgo =     "{0}",
    //			DaysAgo =    "{0}",
    //			MonthAgo =   "{0}",
    //			MonthsAgo =  "{0}",
    //			YearAgo =    "{0}",
    //			YearsAgo =   "{0}",
    //		});
    //	}
    //}
    private static DateTimeFormatStrings romanian;

    public static DateTimeFormatStrings Romanian =>
        romanian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "În urmă {0} secundă",
            SecondsAgo   = "În urmă {0} secunde",
            MinuteAgo    = "{0} minut în urmă",
            MinutesAgo   = "{0} minute în urmă",
            HourAgo      = "{0} oră în urmă",
            HoursAgo     = "Acum {0} ore",
            DayAgo       = "{0} zi în urmă",
            DaysAgo      = "{0} zile în urmă",
            MonthAgo     = "{0} lună",
            MonthsAgo    = "{0} luni în urmă",
            YearAgo      = "{0} an în urmă",
            YearsAgo     = "{0} ani în urmă",
            SecondAhead  = "{0} secunde de acum încolo",
            SecondsAhead = "{0} secunde de acum încolo",
            MinuteAhead  = "{0} minute de acum încolo",
            MinutesAhead = "{0} minute de acum încolo",
            HourAhead    = "{0} ore de acum încolo",
            HoursAhead   = "{0} ore de acum încolo",
            DayAhead     = "{0} zile de acum",
            DaysAhead    = "{0} zile de acum",
            MonthAhead   = "{0} luni de acum încolo",
            MonthsAhead  = "{0} luni de acum înainte",
            YearAhead    = "{0} ani de acum încolo",
            YearsAhead   = "{0} ani de acum încolo"
        };

    private static DateTimeFormatStrings russian;

    public static DateTimeFormatStrings Russian =>
        russian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} секунду назад",
            SecondsAgo   = "{0} секунд назад",
            MinuteAgo    = "{0} минута назад",
            MinutesAgo   = "{0} минут назад",
            HourAgo      = "{0} часовая назад",
            HoursAgo     = "{0} часов назад",
            DayAgo       = "{0} день назад",
            DaysAgo      = "{0} дней назад",
            MonthAgo     = "{0} месяц назад",
            MonthsAgo    = "{0} месяцев назад",
            YearAgo      = "{0} года назад",
            YearsAgo     = "{0} года назад",
            SecondAhead  = "через {0} секунды",
            SecondsAhead = "через {0} секунды",
            MinuteAhead  = "через {0} минуты",
            MinutesAhead = "через {0} минуты",
            HourAhead    = "через {0} часа",
            HoursAhead   = "через {0} часа",
            DayAhead     = "через {0} дня",
            DaysAhead    = "через {0} дня",
            MonthAhead   = "через {0} месяца",
            MonthsAhead  = "через {0} месяца",
            YearAhead    = "через {0} года",
            YearsAhead   = "через {0} года"
        };

    private static DateTimeFormatStrings serbian;

    [VerifiedByNativeSpeaker]
    public static DateTimeFormatStrings Serbian =>
        serbian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Пре секунду",
            SecondsAgo   = "Пре {0} секунди",
            MinuteAgo    = "Пре минут",
            MinutesAgo   = "Пре {0} минута",
            HourAgo      = "Пре сат",
            HoursAgo     = "Пре {0} сати",
            DayAgo       = "Пре дан",
            DaysAgo      = "Пре {0} дана",
            MonthAgo     = "Пре месец",
            MonthsAgo    = "Пре {0} месеци",
            YearAgo      = "Пре годинy",
            YearsAgo     = "Пре {0} година",
            SecondAhead  = "{0} секунде од сада",
            SecondsAhead = "{0} секунде од сада",
            MinuteAhead  = "{0} минута од сада",
            MinutesAhead = "{0} минута од сада",
            HourAhead    = "{0} сата од сада",
            HoursAhead   = "{0} сата од сада",
            DayAhead     = "{0} дана од сада",
            DaysAhead    = "{0} дана од сада",
            MonthAhead   = "{0} месеца од сада",
            MonthsAhead  = "{0} месеца од сада",
            YearAhead    = "{0} године од сада",
            YearsAhead   = "{0} године од сада"
        };

    private static DateTimeFormatStrings slovak;

    public static DateTimeFormatStrings Slovak =>
        slovak ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Pred {0} sekunda",
            SecondsAgo   = "Pred {0} sekúnd",
            MinuteAgo    = "Pred {0} minútou",
            MinutesAgo   = "Pred {0} minútami",
            HourAgo      = "Pred {0} hodinou",
            HoursAgo     = "Pred {0} hodiny",
            DayAgo       = "Pred {0} dňom",
            DaysAgo      = "Pred {0} dňami",
            MonthAgo     = "Pred {0} mesiacom",
            MonthsAgo    = "Pred {0} mesiacmi",
            YearAgo      = "Pred {0} rokom",
            YearsAgo     = "Pred {0} rokmi",
            SecondAhead  = "o {0} sekundy",
            SecondsAhead = "o {0} sekundy",
            MinuteAhead  = "O {0} minúty",
            MinutesAhead = "O {0} minúty",
            HourAhead    = "O {0} hodiny",
            HoursAhead   = "{0} hodiny odteraz",
            DayAhead     = "o {0} dni",
            DaysAhead    = "o {0} dni",
            MonthAhead   = "o {0} mesiace",
            MonthsAhead  = "o {0} mesiace",
            YearAhead    = "o {0} roky",
            YearsAhead   = "o {0} roky"
        };

    private static DateTimeFormatStrings slovenian;

    public static DateTimeFormatStrings Slovenian =>
        slovenian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Pred {0} sekundo",
            SecondsAgo   = "Pred {0} sekundami",
            MinuteAgo    = "Pred {0} minuto",
            MinutesAgo   = "{0} minut nazaj",
            HourAgo      = "Pred {0} urni",
            HoursAgo     = "{0} ur nazaj",
            DayAgo       = "{0} dan nazaj",
            DaysAgo      = "{0} dni nazaj",
            MonthAgo     = "{0} mesec ago",
            MonthsAgo    = "Pred {0} meseci",
            YearAgo      = "{0} leto nazaj",
            YearsAgo     = "{0} let nazaj",
            SecondAhead  = "{0} sekunde od zdaj",
            SecondsAhead = "čez {0} sekunde",
            MinuteAhead  = "čez {0} minute",
            MinutesAhead = "čez {0} minute",
            HourAhead    = "čez {0} ure",
            HoursAhead   = "čez {0} ure",
            DayAhead     = "{0} dni od zdaj",
            DaysAhead    = "{0} dni od zdaj",
            MonthAhead   = "čez {0} mesece",
            MonthsAhead  = "{0} mesece od zdaj",
            YearAhead    = "{0} leta od zdaj",
            YearsAhead   = "čez {0} leta"
        };

    private static DateTimeFormatStrings spanish;

    [VerifiedByNativeSpeaker]
    public static DateTimeFormatStrings Spanish =>
        spanish ??= new DateTimeFormatStrings
        {
            SecondAgo    = "Hace {0} segundo",
            SecondsAgo   = "Hace {0} segundos",
            MinuteAgo    = "Hace {0} minuto",
            MinutesAgo   = "Hace {0} minutos",
            HourAgo      = "Hace {0} hora",
            HoursAgo     = "Hace {0} horas",
            DayAgo       = "Hace {0} día",
            DaysAgo      = "Hace {0} días",
            MonthAgo     = "Hace {0} mes",
            MonthsAgo    = "Hace {0} meses",
            YearAgo      = "Hace {0} año",
            YearsAgo     = "Hace {0} años",
            SecondAhead  = "dentro de {0} segundos",
            SecondsAhead = "dentro de {0} segundos",
            MinuteAhead  = "dentro de {0} minutos",
            MinutesAhead = "dentro de {0} minutos",
            HourAhead    = "dentro de {0} horas",
            HoursAhead   = "dentro de {0} horas",
            DayAhead     = "dentro de {0} días",
            DaysAhead    = "dentro de {0} días",
            MonthAhead   = "dentro de {0} meses",
            MonthsAhead  = "dentro de {0} meses",
            YearAhead    = "dentro de {0} años",
            YearsAhead   = "dentro de {0} años"
        };

    private static DateTimeFormatStrings swedish;

    [VerifiedByNativeSpeaker]
    public static DateTimeFormatStrings Swedish =>
        // This can be written in objective form too
        // example: "för {0} sekund sedan" translation in english would be "for {0} hour ago"
        // You could also add the verbal form instead of numerical. 
        // Which is "en sekund sedan" translation in english would be "one hour ago"
        swedish ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} sekund sedan",
            SecondsAgo   = "{0} sekunder sedan",
            MinuteAgo    = "{0} minut sedan",
            MinutesAgo   = "{0} minuter sedan",
            HourAgo      = "{0} timme sedan",
            HoursAgo     = "{0} timmar sedan",
            DayAgo       = "{0} dag sedan",
            DaysAgo      = "{0} dagar sedan",
            MonthAgo     = "{0} månad sedan",
            MonthsAgo    = "{0} månader sedan",
            YearAgo      = "{0} år sedan",
            YearsAgo     = "{0} år sedan",
            SecondAhead  = "{0} sekunder från nu",
            SecondsAhead = "{0} sekunder från nu",
            MinuteAhead  = "{0} minuter från nu",
            MinutesAhead = "{0} minuter från nu",
            HourAhead    = "{0} timmar från nu",
            HoursAhead   = "{0} timmar från nu",
            DayAhead     = "{0} dagar från nu",
            DaysAhead    = "{0} dagar från nu",
            MonthAhead   = "{0} månader från nu",
            MonthsAhead  = "{0} månader från nu",
            YearAhead    = "{0} år från nu",
            YearsAhead   = "{0} år från nu"
        };

    private static DateTimeFormatStrings tajik;

    public static DateTimeFormatStrings Tajik =>
        tajik ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} сония қабл",
            SecondsAgo   = "{0} сония қабл",
            MinuteAgo    = "{0} дақиқа қабл",
            MinutesAgo   = "{0} дақиқа қабл",
            HourAgo      = "{0} соат қабл",
            HoursAgo     = "{0} соат дар қабл",
            DayAgo       = "{0} рӯз қабл",
            DaysAgo      = "{0} рӯз қабл",
            MonthAgo     = "{0} моҳ қабл",
            MonthsAgo    = "{0} моҳи қабл",
            YearAgo      = "{0} сол қабл",
            YearsAgo     = "{0} сол қабл",
            SecondAhead  = "{0} сония аз ҳоло",
            SecondsAhead = "{0} сония баъд",
            MinuteAhead  = "{0} дақиқа баъд",
            MinutesAhead = "{0} дақиқа баъд",
            HourAhead    = "{0} соат баъд",
            HoursAhead   = "{0} соат баъд",
            DayAhead     = "{0} рӯз баъд",
            DaysAhead    = "{0} рӯз баъд",
            MonthAhead   = "{0} моҳ баъд",
            MonthsAhead  = "{0} моҳ баъд",
            YearAhead    = "{0} сол баъд",
            YearsAhead   = "{0} сол баъд"
        };

    private static DateTimeFormatStrings tamil;

    public static DateTimeFormatStrings Tamil =>
        tamil ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} இரண்டாவது முன்பு",
            SecondsAgo   = "{0} வினாடிகள் முன்பு",
            MinuteAgo    = "{0} நிமிடம் முன்பு",
            MinutesAgo   = "{0} நிமிடங்கள் முன்பு",
            HourAgo      = "{0} மணிநேரம் முன்பு",
            HoursAgo     = "{0} மணி நேரம் முன்பு",
            DayAgo       = "{0} நாள் முன்பு",
            DaysAgo      = "{0} நாட்கள் முன்பு",
            MonthAgo     = "{0} மாதம் முன்பு",
            MonthsAgo    = "{0} மாதங்கள் முன்பு",
            YearAgo      = "{0} வருடம் முன்பு",
            YearsAgo     = "{0} ஆண்டுகளுக்கு முன்பு",
            SecondAhead  = "இப்போதிலிருந்து {0} வினாடிகள்",
            SecondsAhead = "இப்போதிலிருந்து {0} வினாடிகள்",
            MinuteAhead  = "இப்போதிலிருந்து {0} நிமிடம்",
            MinutesAhead = "இப்போதிலிருந்து {0} நிமிடங்கள்",
            HourAhead    = "இப்போதிலிருந்து {0} மணி நேரம்",
            HoursAhead   = "இப்போதிலிருந்து {0} மணிநேரம்",
            DayAhead     = "இன்றிலிருந்து {0} நாள்",
            DaysAhead    = "இப்போதிலிருந்து {0} நாட்கள்",
            MonthAhead   = "இனி {0} மாதம்",
            MonthsAhead  = "இப்போதிலிருந்து {0} மாதங்கள்",
            YearAhead    = "இன்னும் {0} வருடம்",
            YearsAhead   = "இப்போது இருந்து {0} ஆண்டுகள்"
        };

    private static DateTimeFormatStrings telugu;

    public static DateTimeFormatStrings Telugu =>
        telugu ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} రెండవ క్రితం",
            SecondsAgo   = "{0} సెకన్ల క్రితం",
            MinuteAgo    = "{0} నిమిషం క్రితం",
            MinutesAgo   = "{0} నిమిషాల క్రితం",
            HourAgo      = "{0} గంట క్రితం",
            HoursAgo     = "{0} గంటల క్రితం",
            DayAgo       = "{0} రోజు క్రితం",
            DaysAgo      = "{0} రోజుల క్రితం",
            MonthAgo     = "{0} నెల క్రితం",
            MonthsAgo    = "{0} నెలల క్రితం",
            YearAgo      = "{0} సంవత్సరం క్రితం",
            YearsAgo     = "{0} సంవత్సరాల క్రితం",
            SecondAhead  = "ఇప్పటి నుండి {0} సెకన్లు",
            SecondsAhead = "ఇప్పటి నుండి {0} సెకన్లు",
            MinuteAhead  = "ఇప్పటి నుండి {0} నిమిషాలు",
            MinutesAhead = "ఇప్పటి నుండి {0} నిమిషాలు",
            HourAhead    = "ఇప్పటి నుండి {0} గంటలు",
            HoursAhead   = "ఇప్పటి నుండి {0} గంటలు",
            DayAhead     = "ఇప్పటి నుండి {0} రోజులు",
            DaysAhead    = "ఇప్పటి నుండి {0} రోజులు",
            MonthAhead   = "ఇప్పటి నుండి {0} నెలలు",
            MonthsAhead  = "ఇప్పటి నుండి {0} నెలలు",
            YearAhead    = "ఇప్పటి నుండి {0} సంవత్సరాలు",
            YearsAhead   = "ఇప్పటి నుండి {0} సంవత్సరాలు"
        };

    private static DateTimeFormatStrings thai;

    public static DateTimeFormatStrings Thai =>
        thai ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} วินาทีที่ผ่านมา",
            SecondsAgo   = "{0} วินาทีที่ผ่านมา",
            MinuteAgo    = "{0} นาทีที่ผ่านมา",
            MinutesAgo   = "{0} นาทีที่ผ่านมา",
            HourAgo      = "{0} ชั่วโมงผ่านมา",
            HoursAgo     = "{0} ชั่วโมงที่แล้วหา",
            DayAgo       = "{0} วันก่อน",
            DaysAgo      = "{0} วันที่แล้ว",
            MonthAgo     = "{0} เดือนก่อน",
            MonthsAgo    = "{0} เดือนที่ที่ผ่านมา",
            YearAgo      = "{0} ปีที่ผ่านมา",
            YearsAgo     = "{0} ปีที่ผ่านมา",
            SecondAhead  = "{0} วินาทีต่อจากนี้",
            SecondsAhead = "{0} วินาทีต่อจากนี้",
            MinuteAhead  = "{0} นาทีต่อจากนี้",
            MinutesAhead = "{0} นาทีต่อจากนี้",
            HourAhead    = "{0} ชั่วโมงต่อจากนี้",
            HoursAhead   = "{0} ชั่วโมงต่อจากนี้",
            DayAhead     = "{0} วันนับจากนี้",
            DaysAhead    = "{0} วันนับจากนี้",
            MonthAhead   = "{0} เดือนนับจากนี้",
            MonthsAhead  = "{0} เดือนนับจากนี้",
            YearAhead    = "{0} ปีนับจากนี้",
            YearsAhead   = "{0} ปีนับจากนี้"
        };

    private static DateTimeFormatStrings turkish;

    public static DateTimeFormatStrings Turkish =>
        turkish ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} saniye önce",
            SecondsAgo   = "{0} saniye önce",
            MinuteAgo    = "{0} dakika önce",
            MinutesAgo   = "{0} dakika önce",
            HourAgo      = "{0} saat açık önce",
            HoursAgo     = "{0} saatleri önce",
            DayAgo       = "{0} gün önce",
            DaysAgo      = "{0} günü önce",
            MonthAgo     = "{0} ay önce",
            MonthsAgo    = "{0} aylar önce",
            YearAgo      = "{0} yıl önce",
            YearsAgo     = "{0} yıl önce",
            SecondAhead  = "{0} saniye sonra",
            SecondsAhead = "{0} saniye sonra",
            MinuteAhead  = "{0} dakika sonra",
            MinutesAhead = "{0} dakika sonra",
            HourAhead    = "{0} saat sonra",
            HoursAhead   = "{0} saat sonra",
            DayAhead     = "{0} gün sonra",
            DaysAhead    = "{0} gün sonra",
            MonthAhead   = "{0} ay sonra",
            MonthsAhead  = "{0} ay sonra",
            YearAhead    = "{0} yıl sonra",
            YearsAhead   = "{0} yıl sonra"
        };

    private static DateTimeFormatStrings ukrainian;

    public static DateTimeFormatStrings Ukrainian =>
        ukrainian ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} секунду тому",
            SecondsAgo   = "{0} секунд тому",
            MinuteAgo    = "{0} хвилини тому",
            MinutesAgo   = "{0} хвилини тому",
            HourAgo      = "{0}:00 тому",
            HoursAgo     = "{0}:00 тому",
            DayAgo       = "{0} день тому",
            DaysAgo      = "{0} днів тому",
            MonthAgo     = "{0} місяць тому",
            MonthsAgo    = "{0} місяців тому",
            YearAgo      = "{0} рiк назад",
            YearsAgo     = "{0} років тому",
            SecondAhead  = "Через {0} секунди",
            SecondsAhead = "Через {0} секунди",
            MinuteAhead  = "через {0} хвилини",
            MinutesAhead = "через {0} хвилини",
            HourAhead    = "через {0} години",
            HoursAhead   = "через {0} години",
            DayAhead     = "через {0} дні",
            DaysAhead    = "через {0} дні",
            MonthAhead   = "через {0} місяці",
            MonthsAhead  = "через {0} місяці",
            YearAhead    = "через {0} роки",
            YearsAhead   = "через {0} роки"
        };

    private static DateTimeFormatStrings urdu;

    public static DateTimeFormatStrings Urdu =>
        urdu ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} سیکنڈ پہلے",
            SecondsAgo   = "{0} سیکنڈ پہلے",
            MinuteAgo    = "{0} منٹ پہلے",
            MinutesAgo   = "{0} منٹ پہلے",
            HourAgo      = "{0} گھنٹے پہلے",
            HoursAgo     = "{0} گھنٹے پہلے",
            DayAgo       = "{0} دن پہلے",
            DaysAgo      = "{0} دن پہلے",
            MonthAgo     = "{0} مہینہ پہلے",
            MonthsAgo    = "{0} ماہ پہلے",
            YearAgo      = "{0} سال پہلے",
            YearsAgo     = "{0} سال پہلے",
            SecondAhead  = "اب سے {0} سیکنڈ",
            SecondsAhead = "اب سے {0} سیکنڈ",
            MinuteAhead  = "اب سے {0} منٹ",
            MinutesAhead = "اب سے {0} منٹ",
            HourAhead    = "اب سے {0} گھنٹے",
            HoursAhead   = "اب سے {0} گھنٹے",
            DayAhead     = "اب سے {0} دن",
            DaysAhead    = "اب سے {0} دن",
            MonthAhead   = "اب سے {0} ماہ",
            MonthsAhead  = "اب سے {0} ماہ بعد",
            YearAhead    = "اب سے {0} سال",
            YearsAhead   = "اب سے {0} سال بعد"
        };

    private static DateTimeFormatStrings uzbek;

    public static DateTimeFormatStrings Uzbek =>
        uzbek ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} soniya oldin",
            SecondsAgo   = "{0} soniya oldin",
            MinuteAgo    = "{0} daqiqa oldin",
            MinutesAgo   = "{0} daqiqa oldin",
            HourAgo      = "{0} soat oldin",
            HoursAgo     = "{0} soat avval",
            DayAgo       = "{0} kun oldin",
            DaysAgo      = "{0} kun oldin",
            MonthAgo     = "{0} oy oldin",
            MonthsAgo    = "{0} oy oldin",
            YearAgo      = "{0} yil oldin",
            YearsAgo     = "{0} yil oldin",
            SecondAhead  = "{0} soniyadan keyin",
            SecondsAhead = "{0} soniyadan keyin",
            MinuteAhead  = "{0} daqiqadan keyin",
            MinutesAhead = "{0} daqiqadan keyin",
            HourAhead    = "{0} soatdan keyin",
            HoursAhead   = "{0} soatdan keyin",
            DayAhead     = "{0} kundan keyin",
            DaysAhead    = "{0} kundan keyin",
            MonthAhead   = "{0} oydan keyin",
            MonthsAhead  = "{0} oydan keyin",
            YearAhead    = "{0} yildan keyin",
            YearsAhead   = "{0} yildan keyin"
        };

    private static DateTimeFormatStrings vietnamese;

    public static DateTimeFormatStrings Vietnamese =>
        vietnamese ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} giây trước",
            SecondsAgo   = "{0} giây",
            MinuteAgo    = "{0} phút trước",
            MinutesAgo   = "{0} phút trước",
            HourAgo      = "{0} giờ trước",
            HoursAgo     = "{0} giờ trước",
            DayAgo       = "{0} ngày trước",
            DaysAgo      = "{0} ngày cách đây",
            MonthAgo     = "{0} tháng trước",
            MonthsAgo    = "{0} vài tháng trước",
            YearAgo      = "{0} năm trước",
            YearsAgo     = "{0} năm trước",
            SecondAhead  = "{0} giây kể từ bây giờ",
            SecondsAhead = "{0} giây kể từ bây giờ",
            MinuteAhead  = "{0} phút kể từ bây giờ",
            MinutesAhead = "{0} phút nữa kể từ bây giờ",
            HourAhead    = "{0} giờ kể từ bây giờ",
            HoursAhead   = "{0} giờ kể từ bây giờ",
            DayAhead     = "{0} ngày kể từ bây giờ",
            DaysAhead    = "{0} ngày kể từ bây giờ",
            MonthAhead   = "{0} tháng kể từ bây giờ",
            MonthsAhead  = "{0} tháng kể từ bây giờ",
            YearAhead    = "{0} năm kể từ bây giờ",
            YearsAhead   = "{0} năm kể từ bây giờ"
        };

    private static DateTimeFormatStrings welsh;

    public static DateTimeFormatStrings Welsh =>
        welsh ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} ail yn ôl",
            SecondsAgo   = "{0} eiliad yn ôl",
            MinuteAgo    = "{0} munud yn ôl",
            MinutesAgo   = "{0} munud yn ôl",
            HourAgo      = "{0} awr yn ôl",
            HoursAgo     = "{0} awr yn ôl",
            DayAgo       = "{0} diwrnod yn ôl",
            DaysAgo      = "{0} diwrnod yn ôl",
            MonthAgo     = "{0} mis yn ôl",
            MonthsAgo    = "{0} mis yn ôl",
            YearAgo      = "{0} flwyddyn yn ôl",
            YearsAgo     = "{0} mlynedd yn ôl",
            SecondAhead  = "{0} eiliad o nawr",
            SecondsAhead = "{0} eiliad o nawr",
            MinuteAhead  = "{0} munud o nawr",
            MinutesAhead = "{0} munud o nawr",
            HourAhead    = "{0} awr o nawr",
            HoursAhead   = "{0} awr o nawr",
            DayAhead     = "{0} diwrnod o nawr",
            DaysAhead    = "{0} diwrnod o nawr",
            MonthAhead   = "{0} mis o nawr",
            MonthsAhead  = "{0} mis o nawr",
            YearAhead    = "{0} blynedd o nawr",
            YearsAhead   = "{0} blynedd o nawr"
        };

    private static DateTimeFormatStrings yoruba;

    public static DateTimeFormatStrings Yoruba =>
        yoruba ??= new DateTimeFormatStrings
        {
            SecondAgo    = "{0} keji seyin",
            SecondsAgo   = "{0} aaya seyin",
            MinuteAgo    = "{0} iseju seyin",
            MinutesAgo   = "{0} iṣẹju seyin",
            HourAgo      = "{0} wakati seyin",
            HoursAgo     = "{0} wakati seyin",
            DayAgo       = "{0} ijọ seyin",
            DaysAgo      = "{0} ijọ seyin",
            MonthAgo     = "{0} osù seyin",
            MonthsAgo    = "{0} osu seyin",
            YearAgo      = "{0} odun kan seyin",
            YearsAgo     = "{0} odun seyin",
            SecondAhead  = "{0} iṣẹju-aaya lati igba yii",
            SecondsAhead = "{0} aaya lati bayi",
            MinuteAhead  = "{0} iseju lati bayi",
            MinutesAhead = "{0} iṣẹju lati bayi",
            HourAhead    = "{0} wakati lati bayi",
            HoursAhead   = "{0} wakati lati bayi",
            DayAhead     = "{0} ọjọ lati bayi",
            DaysAhead    = "{0} ọjọ lati bayi",
            MonthAhead   = "{0} osu lati bayi",
            MonthsAhead  = "{0} osu lati bayi",
            YearAhead    = "{0} odun lati bayi",
            YearsAhead   = "{0} ọdun lati bayi"
        };
}
