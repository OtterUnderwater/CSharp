using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library8Interface
{
    /// <summary>
    /// Интерфейс видов спорта
    /// </summary>
    interface ISport
    {
        //У каждого вида спорта есть дата создания
        int DataСreation();

        //У каждого вида спорта есть правила для детского и взрослого спорта
        void PrintRules(int age);
    }

    /// <summary>
    /// Абстрактный класс игр с мячом реализует интерфейс видов спорта
    /// </summary>
    abstract class GamesTheBall : ISport
    {
        protected int date;
        public int DataСreation()
        {
            return date;
        }
        public void PrintRules(int age) { }

        //Для каждой игры есть свой мяч
        public abstract int Ball { get; set; }

        //У каждой игры с мячом есть название
        public abstract string PrintName();

    }

    /// <summary>
    /// Класс волейбол наследуется от класса игр с мячом
    /// </summary>
    internal class Volleyball : GamesTheBall
    {
        int diameterBall;
        bool adult;
        public override string PrintName()
        {
            return "Волейбол";
        }
        public int DataСreation()
        {
            return 1895;
        }
        public void PrintRules(int age)
        {
            if (age <= 18)
            {
                adult = true;
                Console.WriteLine("Правила детской игры:");
                Console.WriteLine("Играют две команды, каждая состоит из 6 - и человек(3 – атакующая линия,\n" +
                    "3 – линия защиты).За один розыгрыш команде разрешается касаться мяча\n" +
                    "только 3 раза(блокирование не считается касанием). Запрещается ловить\n" +
                    "бросать или удерживать мяч. Игрок не может дважды касаться мяча(блок не считается).");
            }
            else
            {
                adult = false;
                Console.WriteLine("Правила игры:");
                Console.WriteLine("Игра состоит из отдельных партий. Их количество — от трех до пяти в одном матче.\n" +
                    "Время партии не ограничено.Она завершается, когда одна команда набирает 25 очков.\n" +
                    "Очко засчитывается, если мяч ударяется об пол на стороне противника.\n" +
                    "Выигравшей в матче считается команда, получившая преимущество в трех партиях.\n" +
                    "Всего в команде 14 игроков, на поле находятся шестеро.\n" +
                    "В процессе игры спортсмены меняют позиции.");
            }
        }
        public override int Ball
        {
            get
            {
                return diameterBall;
            }
            set
            {
                if (adult)
                {
                    diameterBall = value;
                }
                else
                {
                    diameterBall = value - 1;
                }
            }
        }
        public Volleyball(int age)
        {
            Console.WriteLine($"Наименование игры: {PrintName()}");
            Console.WriteLine($"Год создания: {DataСreation()}");
            PrintRules(age);
            Ball = 7;
            Console.WriteLine($"Для игры понадобится: мяч с диаметром {Ball} см");
        }
    }
}
