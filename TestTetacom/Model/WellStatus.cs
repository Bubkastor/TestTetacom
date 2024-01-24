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
        NotDefined = 0,

        /// <summary> 
        /// Бурение ротором 
        /// </summary> 
        RotaryDrilling = 1,

        /// <summary> 
        /// Слайдирование 
        /// </summary> 
        SlideDrilling = 2,

        /// <summary> 
        /// Наращивание 
        /// </summary> 
        Connection = 3,
        
        /// <summary> 
        /// Циркуляция без вращения 
        /// </summary> 
        CirculationWithoutRotation = 4,

        /// <summary> 
        /// Спуск 
        /// </summary> 
        RunInHole = 5,

        /// <summary> 
        /// Подъём 
        /// </summary> 
        PullOutOfHole = 6,

        /// <summary> 
        /// Неподвижно 
        /// </summary> 
        StandBy = 7,

        /// <summary> 
        /// Каротаж на кабеле 
        /// </summary> 
        WirelineLogs = 8,

        /// <summary> 
        /// Цементаж 
        /// </summary> 
        Cementing = 9,

        /// <summary> 
        /// Ловильные работы 
        /// </summary> 
        FishingOperations = 10,

        /// <summary> 
        /// Ремонт 
        /// </summary> 
        Repair = 11,

        /// <summary> 
        /// Циркуляция c вращением 
        /// </summary> 
        CirculationWithRotation = 12,

        /// <summary> 
        /// В клиньях 
        /// </summary> 
        InSlips = 13,

        /// <summary> 
        /// На поверхности 
        /// </summary> 
        OnSurface = 14,

        /// <summary> 
        /// Прямая проработка 
        /// </summary> 
        DirectReaming = 15,

        /// <summary> 
        /// Обратная проработка 
        /// </summary> 
        ReverseReaming = 16,

        /// <summary> 
        /// Промывка с расхаживанием без вращения 
        /// </summary> 
        CirculationWoRotationWithPacing = 17,

        /// <summary> 
        /// Промывка без расхаживания с вращением 
        /// </summary> 
        CirculationWithRotationWoPacing = 18,

        /// <summary> 
        /// Промывка без расхаживания и вращения 
        /// </summary> 
        CirculationWoRotationWoPacing = 19,

        /// <summary> 
        /// Нет данных 
        /// </summary> 
        NoData = 20,

        /// <summary> 
        /// Некорректные данные 
        /// </summary> 
        IncorrectData = 21,

        /// <summary> 
        /// Бурение 
        /// </summary> 
        Drilling = 22,

        /// <summary> 
        /// Подъём с циркуляцией без вращения 
        /// </summary> 
        PullOfHoleWithRotationWoPacing = 23,

        /// <summary> 
        /// Спуск с циркуляцией без вращения 
        /// </summary> 
        RunInHoleWithRotationWoPacing = 24,

        /// <summary> 
        /// Циркуляция на месте с вращением 
        /// </summary> 
        CirculationInPlaceWithPacing = 25,

        /// <summary> 
        /// Циркуляция на месте без вращения 
        /// </summary> 
        CirculationInPlaceWoPacing = 26,

    }
}
