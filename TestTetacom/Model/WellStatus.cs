using TestTetacom.Attribute;

namespace TestTetacom.Model
{
    /// <summary> 
    /// Статус скважины 
    /// </summary> 
    public enum WellStatus
    {
        /// <summary> 
        /// Не определено 
        /// </summary> 
        [EnumLocale("not_defined")]

        NotDefined = 0,

        /// <summary> 
        /// Бурение ротором 
        /// </summary> 
        [EnumLocale("rotary_drilling")]
        RotaryDrilling = 1,

        /// <summary> 
        /// Слайдирование 
        /// </summary> 
        [EnumLocale("slide_drilling")]
        SlideDrilling = 2,


        /// <summary> 
        /// Наращивание 
        /// </summary> 
        [EnumLocale("connection")]
        Connection = 3,

        /// <summary> 
        /// Циркуляция без вращения 
        /// </summary> 
        [EnumLocale("calculation_wo_rotation")]
        CirculationWithoutRotation = 4,

        /// <summary> 
        /// Спуск 
        /// </summary> 
        [EnumLocale("run_in_hole")]
        RunInHole = 5,

        /// <summary> 
        /// Подъём 
        /// </summary> 
        [EnumLocale("pull_of_hole")]
        PullOutOfHole = 6,

        /// <summary> 
        /// Неподвижно 
        /// </summary> 
        [EnumLocale("stand_by")]
        StandBy = 7,

        /// <summary> 
        /// Каротаж на кабеле 
        /// </summary> 
        [EnumLocale("wire_lines")]
        WirelineLogs = 8,

        /// <summary> 
        /// Цементаж 
        /// </summary> 
        [EnumLocale("cementing")]
        Cementing = 9,

        /// <summary> 
        /// Ловильные работы 
        /// </summary> 
        [EnumLocale("finishing_operations")]
        FishingOperations = 10,

        /// <summary> 
        /// Ремонт 
        /// </summary> 
        [EnumLocale("repair")]
        Repair = 11,

        /// <summary> 
        /// Циркуляция c вращением 
        /// </summary> 

        [EnumLocale("circulation_with_rotation")]
        CirculationWithRotation = 12,

        /// <summary> 
        /// В клиньях 
        /// </summary> 

        [EnumLocale("in_slips")]
        InSlips = 13,

        /// <summary> 
        /// На поверхности 
        /// </summary> 
        [EnumLocale("on_surface")]
        OnSurface = 14,

        /// <summary> 
        /// Прямая проработка 
        /// </summary> 
        [EnumLocale("direct_reaming")]
        DirectReaming = 15,

        /// <summary> 
        /// Обратная проработка 
        /// </summary> 
        [EnumLocale("reverse_reaming")]
        ReverseReaming = 16,

        /// <summary> 
        /// Промывка с расхаживанием без вращения 
        /// </summary> 
        [EnumLocale("circulation_wo_rotation_with_pacing")]
        CirculationWoRotationWithPacing = 17,

        /// <summary> 
        /// Промывка без расхаживания с вращением 
        /// </summary> 
        [EnumLocale("circulation_with_rotation_wo_pacing")]
        CirculationWithRotationWoPacing = 18,

        /// <summary> 
        /// Промывка без расхаживания и вращения 
        /// </summary> 
        [EnumLocale("circulation_wo_rotation_wo_pacing")]
        CirculationWoRotationWoPacing = 19,

        /// <summary> 
        /// Нет данных 
        /// </summary> 
        [EnumLocale("no_data")]
        NoData = 20,

        /// <summary> 
        /// Некорректные данные 
        /// </summary> 
        [EnumLocale("incorrect_data")]
        IncorrectData = 21,

        /// <summary> 
        /// Бурение 
        /// </summary> 
        [EnumLocale("drilling")]
        Drilling = 22,

        /// <summary> 
        /// Подъём с циркуляцией без вращения 
        /// </summary> 
        [EnumLocale("pull_of_hole_with_rotation_wo_pacing")]
        PullOfHoleWithRotationWoPacing = 23,

        /// <summary> 
        /// Спуск с циркуляцией без вращения 
        /// </summary> 
        [EnumLocale("run_in_hole_with_rotation_wo_pacing")]
        RunInHoleWithRotationWoPacing = 24,

        /// <summary> 
        /// Циркуляция на месте с вращением 
        /// </summary> 
        [EnumLocale("circulation_in_place_with_pacing")]
        CirculationInPlaceWithPacing = 25,

        /// <summary> 
        /// Циркуляция на месте без вращения 
        /// </summary> 
        [EnumLocale("circulation_in_place_wo_pacing")]
        CirculationInPlaceWoPacing = 26,
    }
}