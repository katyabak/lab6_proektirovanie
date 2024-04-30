# Лабораторная работа №6 «Модульные тесты. Библиотека xUnit.»
Задание: 
Написать статический класс Calculator со статическим методом, который в качестве аргумента принимает строку с числами вида «3,8,4,2,7» и возвращаем сумму 
этих чисел со следующими условиями:
- При обнаружении символов, не являющихся цифрами, программа выдаёт ошибку (Exception);
- При нахождении в ряде чисел, чисел больше 10, пропускать их и не учитывать в операциях;
- Учитываются только первые 5 чисел, остальные игнорируются;
- Если программа обнаружит отрицательное число, то она должна вернуть цифру 0;
- Также требуется предоставить пользователю возможность задавать разделители между числами кроме запятой в программе. По умолчанию разделителем является запятая.
Написать минимум 7 модульных тестов, покрывающих различные 
кейсы для работы класса Calculator. Тесты должны находиться в отдельном 
проекте, должны использовать библиотеку xUnit и должны успешно 
проходить.
