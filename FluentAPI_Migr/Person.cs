using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FluentAPI_Migr
{
    /*
     * TODO 0. Цель работы - изучение технологии Entity Framework Core Fluent API
     * https://docs.microsoft.com/ru-ru/ef/core/modeling/
     * и выполнение миграций
     * https://docs.microsoft.com/ru-ru/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
     * 
     * Перед выполнением работы нужно установить пакеты NuGet:
     *     Microsoft.EntityFrameworkCore
     *     Microsoft.EntityFrameworkCore.SqlServer
     *     Microsoft.EntityFrameworkCore.Tools
     * В этом проекте они уже установлены (версия 2.2.6)
     * 
     * При выполнении этой работы мы ни разу не будем запускать программу
     * В отчёте надо будет отобразить не только итоговый код, 
     * но и процесс выполнения миграций (изменение кода модели классов и контекста, создание и выполнение миграций),
     * а также изменения, произошедшие в БД
     */

    /*
     * TODO 1. Создание модели классов
     * Пока это обычные классы, скопированные из предыдущей программы (Code First)
     * с небольшими изменениями
     * По этой причине, лучше сгенерировать новую БД, а не использовать ту, которая создана на предыдущей ЛР
     * 
     * Обратите внимание, что часть кода закомментирована
     * Пока так и оставьте
     * Он будет раскомментирован для изменения структуры БД
     */

    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int? House { get; set; }

        public virtual List<Person> Persons1 { get; set; }
    }

        public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? BirthYear { get; set; }

        /* 
         * TODO 5. Изменение структуры БД
         * TODO 5.1. Добавляем новые свойства
         * Раскомментируйте блок кода ниже, чтобы добавить новые свойства в модель классов
         */

        /*
        public string StupidProperty { get; set; } // это свойство не будет отображаться на БД
        public string SomeStr { get; set; } // новое свойство, его пока нет в БД
        public string SomeStr2 { get; set; } // новое свойство, его пока нет в БД
        public DateTime Created { get; set; } // тоже новое свойство
        */

        public virtual Address Adress { get; set; }
    }
    
}
