﻿/*Завдання 1
Петро розробив генератор звітів в проекті Delegates.Reports, який рахує просту статистику про погоду за кількома параметрами за кілька днів. 
Його генератор може створювати два звіти: звіт в HTML, який рахує середнє і стандартне відхилення, і звіт в Markdown, який рахує медіани.
Однак, що робити, якщо потрібно порахувати медіани і вивести результат в HTML? 
А якщо потрібен буде третій звіт в HTML? 
Поточне рішення вкрай незручно для таких ситуацій.
Допоможіть Петру перевести його код з успадкування на делегування. 
Розділіть відповідальності за оформлення звіту і по обчисленню показників. 
В результаті сам клас ReportMaker вам, можливо, вже й не знадобиться.
*/

using NUnitLite;

namespace _12112020dz
{
    class Program
    {
        static void Main(string[] args) => new AutoRun().Execute(args);
    }
}