using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SecondTry
{
    public partial class Character
    {
        public int TrueId { get; set; }
        [Required(ErrorMessage = "Обязательно поле")]
        [Display(Name = "Истинное ID")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Обязательно поле")]
        [Display(Name = "Имя")]
        public int? Side { get; set; }
        [Display(Name = "Сторона")]
        public int? Id { get; set; }
        [Display(Name = "ID")]
        public int? MaxHealth { get; set; }
        [Display(Name = "Максимальное здоровье")]
        public int? NowHealth { get; set; }
        [Display(Name = "Текущее здоровье")]
        public int? MaxEnergy { get; set; }
        [Display(Name = "Максимальная энергия")]
        public int? NowEnergy { get; set; }
        [Display(Name = "Текущая энергия")]
        public int? MaxSatiety { get; set; }
        [Display(Name = "Максимальная сытость")]
        public int? NowSatiety { get; set; }
        [Display(Name = "Текущая сытость")]
        public int? MaxSanity { get; set; }
        [Display(Name = "Максимальный рассудок")]
        public int? NowSanity { get; set; }
        [Display(Name = "Текущий рассудок")]
        public int? Status { get; set; }
        [Display(Name = "Состояние")]
        public int? Strength { get; set; }
        [Display(Name = "Сила")]
        public int? HeavyWeapone { get; set; }
        [Display(Name = "Тяжёлое оружие")]
        public int? ResourceGather { get; set; }
        [Display(Name = "Сбор ресурсов")]
        public int? Carrying { get; set; }
        [Display(Name = "Перенос грузов")]
        public int? HandToHand { get; set; }
        [Display(Name = "Рукопашный бой")]
        public int? Bruteforce { get; set; }
        [Display(Name = "Грубая сила")]
        public int? Dexterity { get; set; }
        [Display(Name = "Ловкость")]
        public int? LightWeapone { get; set; }
        [Display(Name = "Лёгкое оружие")]
        public int? RangedWeapone { get; set; }
        [Display(Name = "Оружие дальнего боя")]
        public int? Sneak { get; set; }
        [Display(Name = "Скрытность")]
        public int? Dodge { get; set; }
        [Display(Name = "Уклонение")]
        public int? Agility { get; set; }
        [Display(Name = "Мобильность")]
        public int? Constitution { get; set; }
        [Display(Name = "Телосложение")]
        public int? Shield { get; set; }
        [Display(Name = "Щиты")]
        public int? Armour { get; set; }
        [Display(Name = "Броня")]
        public int? Stamina { get; set; }
        [Display(Name = "Выносливость")]
        public int? Health { get; set; }
        [Display(Name = "Здоровье")]
        public int? Balance { get; set; }
        [Display(Name = "Баланс")]
        public int? Intelligence { get; set; }
        [Display(Name = "Интеллект")]
        public int? MagickPower { get; set; }
        [Display(Name = "Сила магии")]
        public int? Medicine { get; set; }
        [Display(Name = "Медицина")]
        public int? Cooking { get; set; }
        [Display(Name = "Кулинария")]
        public int? Science { get; set; }
        [Display(Name = "Наука")]
        public int? Craft { get; set; }
        [Display(Name = "Создание предметов")]
        public int? Memory { get; set; }
        [Display(Name = "Память")]
        public int? Willpower { get; set; }
        [Display(Name = "Сила воли")]
        public int? MagickLevel { get; set; }
        [Display(Name = "Уровень магии")]
        public int? Languages { get; set; }
        [Display(Name = "Языки")]
        public int? Learning { get; set; }
        [Display(Name = "Обучение")]
        public int? Logistics { get; set; }
        [Display(Name = "Логистика")]
        public int? Perception { get; set; }
        [Display(Name = "Внимательность")]
        public int? Hunting { get; set; }
        [Display(Name = "Охота")]
        public int? Traps { get; set; }
        [Display(Name = "Ловушки")]
        public int? Foraging { get; set; }
        [Display(Name = "Фуражирование")]
        public int? Spotting { get; set; }
        [Display(Name = "Обнаружение")]
        public int? Pathfinding { get; set; }
        [Display(Name = "Поиск пути")]
        public int? Charisma { get; set; }
        [Display(Name = "Харизма")]
        public int? Persuation { get; set; }
        [Display(Name = "Убеждение")]
        public int? Intimidation { get; set; }
        [Display(Name = "Запугивание")]
        public int? Trade { get; set; }
        [Display(Name = "Торговля")]
        public int? Music { get; set; }
        [Display(Name = "Музыка")]
        public int? Discussion { get; set; }
        [Display(Name = "Дискуссии")]
        public int? Leadership { get; set; }
        [Display(Name = "Лидерство")]
        public int? Command { get; set; }
        [Display(Name = "Командование")]
        public int? Tactic { get; set; }
        [Display(Name = "Тактика")]
        public int? Strategy { get; set; }
        [Display(Name = "Стратегия")]
        public int? Survival { get; set; }
        [Display(Name = "Выживание")]
        public int? Adjutant { get; set; }
        [Display(Name = "Адьютант")]
        public int? Epathy { get; set; }
        [Display(Name = "Эмпатия")]
        public int? Lie { get; set; }
        [Display(Name = "Ложь")]
        public int? LieDetector { get; set; }
        [Display(Name = "Обнаружение лжи")]
        public int? Psycology { get; set; }
        [Display(Name = "Психология")]
        public int? Pacification { get; set; }
        [Display(Name = "Успокоение")]
        public int? AnimalHandling { get; set; }
        [Display(Name = "Обращение с животными")]
        public int? Weapone { get; set; }
        [Display(Name = "Оружие")]
        public int? Hike { get; set; }
        [Display(Name = "Поход")]
        public int? BattleTactic { get; set; }
        [Display(Name = "Тактика в бою")]
        public virtual Tactic BattleTacticNavigation { get; set; }
        public virtual Hike HikeNavigation { get; set; }
        public virtual Item WeaponeNavigation { get; set; }
    }
}
