﻿<details>
<summary>Lesson 1</summary>
<h3>Task 1</h3>
<p>
Ввести вес и рост человека. Рассчитать и вывести индекс массы тела по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах.
</p>

<h3>Task 2</h3>
<p>
Найти максимальное из четырех чисел. Массивы не использовать.
</p>

<h3>Task 3</h3>
<p>
Написать программу обмена значениями двух целочисленных переменных:
<list>
    <li>с использованием третьей переменной;</li>
    <li>***без использования третьей переменной.**</li>
</list>
</p>

<h3>Task 4</h3>
<p>
Написать программу нахождения корней заданного квадратного уравнения.
</p>

<h3>Task 5</h3>
<p>
С клавиатуры вводится номер месяца. Требуется определить, к какому времени года он относится.
</p>

<h3>Task 6</h3>
<p>
Ввести возраст человека (от 1 до 150 лет) и вывести его вместе с последующим словом «год», «года» или «лет».
</p>

<h3>Task 7</h3>
<p>
С клавиатуры вводятся числовые координаты двух полей шахматной доски (x1,y1,x2,y2). Требуется определить, относятся поля к одному цвету или нет.
</p>

<h3>Task 8</h3>
<p>
Ввести a и b и вывести квадраты и кубы чисел от a до b.
</p>

<h3>Task 9</h3>
<p>
Даны целые положительные числа N и K. Используя только операции сложения и вычитания, найти частное от деления нацело N на K, а также остаток от этого деления.
</p>

<h3>Task 10</h3>
<p>
Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка от деления определить, имеются ли в записи числа N нечетные цифры. Если имеются, то вывести True, если нет — вывести False.
</p>

<h3>Task 11</h3>
<p>
С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее арифметическое всех положительных четных чисел, оканчивающихся на 8.
</p>

<h3>Task 12</h3>
<p>
Написать функцию нахождения максимального из трех чисел.
</p>

<h3>Task 13</h3>
<p>
***Написать функцию, генерирующую случайное число от 1 до 100.**
<list>
    <li>с использованием стандартной функции rand()</li>
    <li>без использования стандартной функции rand()</li>
</list>
</p>

<h3>Task 14</h3>
<p>
***Автоморфные числа. Натуральное число называется автоморфным, если оно равно последним цифрам своего квадрата. Например, 252 = 625. Напишите программу, которая вводит натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.**
</p>

</details>  

<details>
<summary>Lesson 2</summary>
<h3>Task 1</h3>
<p>
Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.
</p>

<h3>Task 2</h3>
<p>
Реализовать функцию возведения числа a в степень b:
<list>
    <li>без рекурсии;</li>
    <li>рекурсивно;</li>
    <li>*рекурсивно, используя свойство четности степени.</li>
</list>
</p>

<h3>Task 3</h3>
<p>
Исполнитель Калькулятор преобразует целое число, записанное на экране. У исполнителя две команды, каждой команде присвоен номер:
<list>
    <li>Прибавь 1;</li>
    <li>Умножь на 2</li>
</list>

Первая команда увеличивает число на экране на 1, вторая увеличивает это число в 2 раза. Сколько существует программ, которые число 3 преобразуют в число 20?
<list>
    <li>с использованием массива;</li>
    <li>с использованием рекурсии.</li>
</list>
</p>

Реализовать меню с выбором способа заполнения массива: из файла, случайными числами, с клавиатуры.
</details> 


<details>
<summary>Lesson 3</summary>
<h3>Task 1</h3>
<p>
Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и не оптимизированной программы. Написать функции сортировки, которые возвращают количество операций.
</p>

<h3>Task 2</h3>
<p>
Реализовать шейкерную сортировку.
</p>

<h3>Task 3</h3>
<p>
Реализовать бинарный алгоритм поиска в виде функции, которой передается отсортированный массив. Функция возвращает индекс найденного элемента или -1, если элемент не найден.
</p>

<h3>Task 4</h3>
<p>
Подсчитать количество операций для каждой из сортировок и сравнить его с асимптотической сложностью алгоритма
</p>
</details> 

<details>
<summary>Lesson 4</summary>
<h3>Task 1</h3>
<p>
*Количество маршрутов с препятствиями. Реализовать чтение массива с препятствием и нахождение количество маршрутов.
Например, карта:
3 3
1 1 1
0 1 0
0 1 0
</p>

<h3>Task 2</h3>
<p>
Решить задачу о нахождении длины максимальной последовательности с помощью матрицы.
Update: по аналогии с тем что мы делали на уроке в Excel с двумерной матрицей, нужно сделать программу которая рассчитает сама элементы двумерного массива.
Нужно чтобы пользователь ввел 2 строки которые сформируют размер матрицы.
Затем строка за строкой рассчитываем значения элементов. Решение без рекурсии, цикл for внутри другого for.
</p>

<h3>Task 3</h3>
<p>
***Требуется обойти конем шахматную доску размером NxM, пройдя через все поля доски по одному разу. Здесь алгоритм решения такой же, как в задаче о 8 ферзях. Разница только в проверке положения коня.
</p>
</details> 

<details>
<summary>Lesson 5</summary>
<h3>Task 1</h3>
<p>
Реализовать перевод из десятичной в двоичную систему счисления с использованием стека.
</p>

<h3>Task 2</h3>
<p>
Написать программу, которая определяет, является ли введенная скобочная последовательность правильной. Примеры правильных скобочных выражений: (), ([])(), {}(), ([{}]), неправильных — )(, ())({), (, ])}), ([(]) для скобок [, (, {. Например: (2+(2*2)) или [2/{5*(4+7)}].
</p>

<h3>Task 3</h3>
<p>
*Создать функцию, копирующую односвязный список (то есть создающую в памяти копию односвязного списка без удаления первого списка).
</p>

<h3>Task 4</h3>
<p>
*Реализовать алгоритм перевода из инфиксной записи арифметического выражения в постфиксную.
</p>

<h3>Task 5</h3>
<p>
Реализовать очередь: С использованием массива. С использованием односвязного списка.
</p>

<h3>Task 6</h3>
<p>
***Реализовать двустороннюю очередь.

</p>
</details> 

<details>
<summary>Lesson 6</summary>
<h3>Task 1</h3>
<p>
Реализовать простейшую хеш-функцию. На вход функции подается строка, на выходе сумма кодов символов.
</p>

<h3>Task 2</h3>
<p>
Переписать программу, реализующую двоичное дерево поиска.
<list>
    <li>Добавить в него обход дерева различными способами;</li>
    <li>Реализовать поиск в двоичном дереве поиска;</li>
    <li>*Добавить в программу обработку командной строки, с помощью которой можно указывать, из какого файла считывать данные, каким образом обходить дерево.</li>
</list>
</p>

<h3>Task 3</h3>
<p>
*Разработать базу данных студентов из полей «Имя», «Возраст», «Табельный номер», в которой использовать все знания, полученные на уроках.
</p>

Считайте данные в двоичное дерево поиска. Реализуйте поиск по какому-нибудь полю базы данных (возраст, вес).
</details> 

<details>
<summary>Lesson 7</summary>
<h3>Task 1</h3>
<p>
Реализовать алгоритм Дейкстра. Сформируйте вручную граф, найдите матрицу кратчайших расстояний, выведите на экран матрицу и кратчайший путь.
</p>

</details> 
