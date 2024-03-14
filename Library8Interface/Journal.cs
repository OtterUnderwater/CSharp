using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library8Interface
{
    /// <summary>
    /// Интерфейс информации о студенте
    /// </summary>
    interface IStudents
    {
        int getEvaluations(string name);
    }

    /// <summary>
    /// Интерфейс статистики/информации об оценке
    /// </summary>
    interface IEvaluations
    {
        string getStudents(int evaluation);
    }

    /// <summary>
    /// Тема: Электронный журнал с оценками
    /// </summary>
    internal class Journal : IEvaluations, IStudents
    {
        int evaluation;
        public string NameStudent { get; set; }
        public int Evaluation
        {
            get
            {
                return evaluation;
            }
            set
            {
                if (value >= 2 && value <= 5)
                {
                    evaluation = value;
                }
                else
                {
                    evaluation = 0;
                }
            }
        }

        public Journal(string nameStudent, int evaluation)
        {
            NameStudent = nameStudent;
            Evaluation = evaluation;
        }

        public int getEvaluations(string name)
        {
            if (NameStudent == name)
            {
                return Evaluation;
            }
            else
            {
                return 0;
            }
        }

        public string getStudents(int num)
        {
            if (Evaluation == num)
            {
                return NameStudent;
            }
            else
            {
                return null;
            }
        }
    }
}
