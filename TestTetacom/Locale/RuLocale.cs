namespace TestTetacom.Locale
{
    public static class RuLocale
    {
        public static Dictionary<string, string> Locale { get; set; } = new Dictionary<string, string>()
            {
                { "not_defined", "Не определено"},
                { "rotary_drilling", "Бурение ротором"},
                { "slide_drilling", "Слайдирование"},
                { "connection", "Наращивание"},
                { "calculation_wo_rotation", "Циркуляция без вращения"},
                { "run_in_hole", "Спуск"},
                { "pull_of_hole", "Подъём"},
                { "stand_by", "Неподвижно"},
                { "wire_lines", "Каротаж на кабеле"},
                { "cementing", "Цементаж"},
                { "finishing_operations", "Ловильные работы"},
                { "repair", "Ремонт"},
                { "circulation_with_rotation", "Циркуляция c вращением"},
                { "in_slips", "В клиньях"},
                { "on_surface", "На поверхности"},
                { "direct_reaming", "Прямая проработка"},
                { "reverse_reaming", "Обратная проработка"},
                { "circulation_wo_rotation_with_pacing", "Промывка с расхаживанием без вращения"},
                { "circulation_with_rotation_wo_pacing", "Промывка без расхаживания с вращением"},
                { "circulation_wo_rotation_wo_pacing", "Промывка без расхаживания и вращения"},
                { "no_data", "Нет данных"},
                { "incorrect_data", "Некорректные данные"},
                { "drilling", "Бурение"},
                { "pull_of_hole_with_rotation_wo_pacing", "Подъём с циркуляцией без вращения"},
                { "run_in_hole_with_rotation_wo_pacing", "Спуск с циркуляцией без вращения"},
                { "circulation_in_place_with_pacing", "Циркуляция на месте с вращением"},
                { "circulation_in_place_wo_pacing", "Циркуляция на месте без вращения"}
            };
    }
}

