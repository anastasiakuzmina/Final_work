# Итоговая работа 
## 1.1 Блок схема
На вход поступает массив состоящий из строк. 

Выполняется выборка элементов, длина которых меньше или равна 3:
 
 1) Создается переменная k равная 0
 2) Создаем новый массив размерностью равной исходному
 3) Создаем цикл в теле которого выполняем проверку каждого элемента исходного массива.
 Если элемент массива содержит не более 3 символов то записываем его в новый массив и увеличиваем счетчик k на 1.
 4)  Изменям размерность полученного массива, указывая размерность равной k (т.е. числу элементов в новом массиве).
 

Вывод нового массива.

![Блок_схема](Блок_Схема.png)

## 1.2 Функции программы
GetShortStr

    GetShortStr - функция формирует новый массив из элементов исходного, где количество символов в элементе масива меньше 3


Printstr

    Printstr - функция выводит массив на экран.


RunProgramm

    RunProgramm - данная функция включает в себя вызов функции Printstr и GetShortStr, тем самым упрощает ввод и вывод данных в программе
    