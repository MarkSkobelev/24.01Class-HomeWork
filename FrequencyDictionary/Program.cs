﻿// Дан текст string необходимо сформировать частотный словарь слов

string str = @"Я к вам пишу – чего же боле?
Что я могу еще сказать?
Теперь, я знаю, в вашей воле
Меня презреньем наказать.
Но вы, к моей несчастной доле
Хоть каплю жалости храня,
Вы не оставите меня.
Сначала я молчать хотела;
Поверьте: моего стыда
Вы не узнали б никогда,
Когда б надежду я имела
Хоть редко, хоть в неделю раз
В деревне нашей видеть вас,
Чтоб только слышать ваши речи,
Вам слово молвить, и потом
Все думать, думать об одном
И день и ночь до новой встречи.
Но, говорят, вы нелюдим;
В глуши, в деревне всё вам скучно,
А мы… ничем мы не блестим,
Хоть вам и рады простодушно.

Зачем вы посетили нас?
В глуши забытого селенья
Я никогда не знала б вас,
Не знала б горького мученья.
Души неопытной волненья
Смирив со временем (как знать?),
По сердцу я нашла бы друга,
Была бы верная супруга
И добродетельная мать.

Другой!.. Нет, никому на свете
Не отдала бы сердца я!
То в вышнем суждено совете…
То воля неба: я твоя;
Вся жизнь моя была залогом
Свиданья верного с тобой;
Я знаю, ты мне послан богом,
До гроба ты хранитель мой…
Ты в сновиденьях мне являлся,
Незримый, ты мне был уж мил,
Твой чудный взгляд меня томил,
В душе твой голос раздавался
Давно… нет, это был не сон!
Ты чуть вошел, я вмиг узнала,
Вся обомлела, запылала
И в мыслях молвила: вот он!
Не правда ль? Я тебя слыхала:
Ты говорил со мной в тиши,
Когда я бедным помогала
Или молитвой услаждала
Тоску волнуемой души?
И в это самое мгновенье
Не ты ли, милое виденье,
В прозрачной темноте мелькнул,
Приникнул тихо к изголовью?
Не ты ль, с отрадой и любовью,
Слова надежды мне шепнул?
Кто ты, мой ангел ли хранитель,
Или коварный искуситель:
Мои сомненья разреши.
Быть может, это все пустое,
Обман неопытной души!
И суждено совсем иное…
Но так и быть! Судьбу мою
Отныне я тебе вручаю,
Перед тобою слезы лью,
Твоей защиты умоляю…
Вообрази: я здесь одна,
Никто меня не понимает,
Рассудок мой изнемогает,
И молча гибнуть я должна.
Я жду тебя: единым взором
Надежды сердца оживи
Иль сон тяжелый перерви,
Увы, заслуженным укором!

Кончаю! Страшно перечесть…
Стыдом и страхом замираю…
Но мне порукой ваша честь,
И смело ей себя вверяю";
int howManyWord = 1;
str = str.Replace("!","");
str = str.Replace(".","");
str = str.Replace(",","");
str = str.Replace("?","");
str = str.Replace(":","");
str = str.Replace("...","");
str = str.Replace("-","");
str = str.Replace("(","");
str = str.Replace(")","");
str = str.Replace(";","");
for(int i = 0; i < str.Length; i++)
{
    str = str.ToLower(); 
}
for(int i = 1; i < str.Length; i++)
{
    if(str[i-1]==' ')
    {
        howManyWord++;
    }
}
Console.WriteLine(howManyWord);
string[] allWords = new string[howManyWord];
int k = 0;
for(int i = 0; i < str.Length; i++)
{
    if(str[i]!=' ')
    {
        allWords[k] = allWords[k]+str[i];
    }
    else 
    {
        k++;
    }
}
int count = 0;
int repeats = 1;
while(count < howManyWord)
{
    repeats = 1;
    for(int i = 0; i < allWords.Length; i++)
    {
        if(allWords[count]==allWords[i] && count!=i)
        {
            repeats++;
            allWords[i] = " ";
            allWords[i] = allWords[i].Replace(" ","");
        }
    }
    Console.WriteLine($"{repeats} раз встречается слово {allWords[count]}");
    count++;
}
/*for(int i = 0; i < allWords.Length; i++)
{
    Console.WriteLine(allWords[i]);
}*/

