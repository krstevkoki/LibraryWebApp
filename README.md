<p align="center">
    <img width=40% src="https://user-images.githubusercontent.com/36881871/45978732-4fe19a00-c04d-11e8-9bbd-f9e3c8de1aba.jpg?raw=true" alt="Лого на апликацијата/Application logo">
</p>

<h1 align="center">LibaryWebApp</h1>
<p align="center">Веб апликација/онлајн <b>продавница за книги </b></p>
<p align="center">Web application/online <b>store for books</b></p>

<div align="center">
    <h3>
        <span align="center"><a href="#Содржина">Македонски</a></span>
        <span>&nbsp;|&nbsp;<span>
        <span><a href="#table-of-contents">English</a></span>
    </h3>
</div>
      <br>

## Содржина

- [Карактеристики](#Карактеристики)
- [Краток опис на апликацијата](#Краток-опис-на-апликацијата)
- [Упатство за користење](#Упатство-за-користење)
- [Користени библиотеки/сервиси](#Користени-библиотекисервиси)

<br>

## Карактеристики
- Користење на соодветен шаблон за презентација на книгите кои се нудат за продажба, имплементација на техники за пребарување и сортирање
- Релативно лесна навигација низ содржината на апликацијата
- Имплементирана потрошувачка кошничка во која секој регистриран член може да види кои книги ги купил
- 4 улоги(**Администратор**, **Вработен/Кадар**, **Член**, **Корисник**)
- **Систем со поени** кои членот ги добива при купување на некоја книга. Истите можат да се искористат за попуст при купување на книги
- **Посебен преглед** за секоја од улогите одделно 
- **Манипулација** со податоците преку соодветно креирана база
<br>

## Краток опис на апликацијата
Оваа апликација е наменета за продажба на книги. Истата го користи шаблонот liquit lauout за соодветен приказ на книгите на Home Page-от. Корисникот има можност за пребарување на соодветна книга. Исто така има опција да ги сортира книгите врз основа на наколку критериуми како што се: цена, азбучен ред, количина или датум на издавање. Апликацијата располага со 4 улоги: Администратор, Вработен, Член и Корисник.Корисникот има опција да пристапи до деталите за секоја книга одделно со едноставен клик на копчето details. При клик на копчето details му се отвора нов преглед на кој се прикажани деталите за книгата, цена, автор, издавач како и можност за пристап до соодветен поглед за истите.  Корисникот има можност да ја купи книгата само доколку е најавен т.е доколку е член во спротива истиот се редиректира на соодветен поглед за регистрација. Регистрираниот корисник има можност да купи книга и при тоа за секоја купена книга му се пресметуваат соодветни поени кои му носат попуст при купувањето на следната. Секој член има соодветна потрошувачка кошничка во која се наоѓаат книгите кои ги купил, нивната количина и вкупниот износ за плаќање. При тоа истиот има увид во книгите кои ги купил. Исто така секој член може да напише критика за било која книга. Вработените и администраторот имаат дополнителни можности како промена на податоците за соодветна книга, автор или издавач.

<br>

## Упатство за користење

### 1. Опис на формите во апликацијата

При стартувањето на апликацијата се прикажува Home Page-от кој е прикажан на Слика 1

<p align="center">
    <img width=90% height="60%" src="https://user-images.githubusercontent.com/36881871/45980933-ab168b00-c053-11e8-9257-9f12a12567f9.png?raw=true"> <br>
    <i>Слика 1: Главен поглед на апликацијата</i>
</p>

Откако му се прикажува Home Pag-от корисникот има можност да изврши пребарување за да ја најде посакуваната книга или пак да изврши 
сортирање врз основа на понудените критериуми.

<p align="center">
    <img width=30% src="https://user-images.githubusercontent.com/36881871/45981545-ad79e480-c055-11e8-804a-45ea374266bc.png?raw=true" alt="Search box"> 
    <img width=30% src="https://user-images.githubusercontent.com/36881871/45981547-aeab1180-c055-11e8-97e1-9c2560f2bffd.png?raw=true" alt="Sort list">
    <br>
    <span><i>Слика 2, 3: Функционалности на алатките за пребарување и сортирање</i></span>
</p>


Пронајдената книга се прикажува во нов поглед како единствен елемент

<p align="center">
    <img width=60% height=50% src="https://user-images.githubusercontent.com/36881871/45981838-b15a3680-c056-11e8-96fb-16943d50abdb.png?raw=true"> 
    <br>
    <span><i>Слика 4: Приказ на пребараната книга </i></span>
</p>

При клик на Details за било која книга се отвора нов поглед со соодветни детали за истата, автор, издавач, залиха, а во долниот дел од погледот има имплементирано carousel на кој се прикажани сите останати достапни книги кои припаѓаат на истиот жанр како тековната.

<p align="center">
    <img width=60% height=50% src="https://user-images.githubusercontent.com/36881871/45982211-27ab6880-c058-11e8-9cfe-e70f8e89defc.png?raw=true"> 
    <br>
    <span><i>Слика 5: Приказ на Default поглед за книга </i></span>
</p>

Со клик на копчето Add review се отвора прозорец во кој можете да ја пишете соодветната критика за книгата. 

<p align="center">
    <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45982653-dac89180-c059-11e8-9d3f-0aac8e96ea70.png?raw=true"> 
    <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45982657-e025dc00-c059-11e8-9304-b420101d2f50.png?raw=true"> <br>
    <span><i>Слика 6,7: Прозорец за оставање критика за книгата и прикажување на истата </i></span>
</p>

Со клик налинковите кои водат до авторот и издавачот на книгата се отвораат соодветни погледи

<p align="center">
    <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45982809-8ffb4980-c05a-11e8-91d8-4765264f136c.png?raw=true"> 
    <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45982815-95f12a80-c05a-11e8-8c2c-3a7913c765f0.png?raw=true"> <br>
 <span><i>Слика 8,9: Погледи за автор и издавач </i></span>
</p>

Секој член има своја потрочувачка кошничка во која има увид во книгите кои ги купил. Со клик на Go to checkout му се отвора нов поглед во кој треба да ги потполни соодветните податоци за да може да се изврши трансакцијата.

<p align="center">
    <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45983192-f896f600-c05b-11e8-8e5e-b097d2392aad.png?raw=true"> 
    <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45983195-fa60b980-c05b-11e8-89d1-f6b5f6ffb9ba.png?raw=true"> 
     <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45983200-fe8cd700-c05b-11e8-983c-43da441f914f.png?raw=true"> 
    <br>
 <span><i>Слика 9,10,11: Потрошувачка кошничка </i></span>
</p>

Врз база на улогата секој член има достапност до различен панел

<p align="center">
    <img width=20%  src="https://user-images.githubusercontent.com/36881871/45983958-30ec0380-c05f-11e8-93f3-90effffdfe10.png"> 
    <img width=20% src="https://user-images.githubusercontent.com/36881871/45983728-241ae000-c05e-11e8-9b9c-5bad67c78271.png?raw=true"> 
     <img width=20%  src="https://user-images.githubusercontent.com/36881871/45983734-29782a80-c05e-11e8-92ef-f14e645dfa97.png?raw=true"> 
     <img width=20%  src="https://user-images.githubusercontent.com/36881871/45983738-3006a200-c05e-11e8-9fd4-e3138299d2c4.png?raw=true"> 
    <br>
 <span><i>Слика 11,12,13,14: Кориснички панели </i></span>
</p>

### 2. Опис на имплементацијата
Имплементацијата се одвива врз база на неколку поврзани класи Book,Publisher,Author,Genre,ShoppingCart кои се сместени во соодветна база која овозможува нивна меѓусебна манипулација. Целокупната апликација во главно се базира на bootstrap, html, jquery и ajax код кој овозможи дизајнирање на тековниот изглед. Исто така направивме и драстични измени во контролерите и погледите за секоја од класите преку додавање на custom код за постигнување максимална финкционалност. 


## Користени библиотеки/сервиси
Во изработката на апликацијата ги користевме пакетите кои ни ги нудеше **Nuget packet manager** како и некои **bootstrap i jquery** 
библиотеки од надвор кои ги имплементиравме во апликацијата за да го добиеме посакуваиот изглед.

**Изработено од:**
1. [Костадин Крстев](https://github.com/krstevkoki) 161 169
2. [Михаил Зафировски](https://github.com/mihailz) 161 162


---
---
## Table of Contents

- [Features](#features)
- [Brief description of the application](#brief-description-of-the-application)
- [User manual](#user-manual)
- [Third-party libraries/services](#third-party-librariesservices)

<br>

## Features
- Using an appropriate presentation template for books offered for sale, implementing search and sorting techniques
- Relatively easy navigation through the content of the application
- A consumable basket in which each registered member can see which books they have
- 4 roles (**Administrator**, **Employee / Staff**, **Member**, **User**)
- **Points system** that the member gets when buying a book. They can be used for discounts when buying books
- **Special review** for each of the roles separately
- **Manipulation** with data structures using database
<br>

## Brief description of the application
This application is used for selling books. It uses the grid of equals template for a proper display of books on the Home Page. The user has the opportunity to search for an appropriate book. It also has the option of sorting books based on criteria such as: price, alphabetical order, quantity or date of issue. The application has 4 roles: Administrator, Employee, Member and User. The user has the option to access the details of each book separately by simply clicking the details button. Clicking on the details button opens a new overview showing the details of the book, price, author, publisher, and the ability to access an appropriate view of them. The user has the opportunity to buy the book only if he is logged in, or if he is a member in the opposite, he will be redirect to an appropriate view for registration. The registered user has the opportunity to buy a book, and for each purchased book, it is calculated the appropriate points that give him a discount when buying the next one. Each member has an appropriate consumer basket containing the books he has purchased, their amount and the total amount of payment. Every member has an insight into the books that he has purchased. Also, each member can write reviews for any book. Employees and administrators have additional opportunities to change data for an appropriate book, author or publisher.
<br>

## User manual

### 1. Description of the forms in the application

When starting the application, the Home Page is displayed as shown on Image 1

<p align="center">
    <img width=90% height="60%" src="https://user-images.githubusercontent.com/36881871/45980933-ab168b00-c053-11e8-9257-9f12a12567f9.png?raw=true"> <br>
    <i>Image 1: Main view of the application</i>
</p>

After the Home Pag is displayed, the user has the opportunity to perform a search to find the desired book or perform
sorting based on the criteria offered.

<p align="center">
    <img width=30% src="https://user-images.githubusercontent.com/36881871/45981545-ad79e480-c055-11e8-804a-45ea374266bc.png?raw=true" alt="Search box"> 
    <img width=30% src="https://user-images.githubusercontent.com/36881871/45981547-aeab1180-c055-11e8-97e1-9c2560f2bffd.png?raw=true" alt="Sort list">
    <br>
    <span><i>Image 2, 3: Functions of search and sort tools</i></span>
</p>


The book found is displayed in a new view as a single element

<p align="center">
    <img width=60% height=50% src="https://user-images.githubusercontent.com/36881871/45981838-b15a3680-c056-11e8-96fb-16943d50abdb.png?raw=true"> 
    <br>
    <span><i>Image 4: View of searched book </i></span>
</p>

Clicking on Details for any book opens a new view with appropriate details about it, author, publisher, inventory, and in the lower part of the view there is a carousel that displays all the other available books that belong to the same genre as the current one.

<p align="center">
    <img width=60% height=50% src="https://user-images.githubusercontent.com/36881871/45982211-27ab6880-c058-11e8-9cfe-e70f8e89defc.png?raw=true"> 
    <br>
    <span><i>Image 5: Details view for the book </i></span>
</p>

Clicking the Add review button opens a window in which you can write the appropriate reviews for the book.

<p align="center">
    <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45982653-dac89180-c059-11e8-9d3f-0aac8e96ea70.png?raw=true"> 
    <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45982657-e025dc00-c059-11e8-9304-b420101d2f50.png?raw=true"> <br>
    <span><i>Image 6,7: Displaying dialog for leaving a review for the book and showind the review comment </i></span>
</p>

Clicking the links that lead to the author and the book publisher will open up appropriate views

<p align="center">
    <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45982809-8ffb4980-c05a-11e8-91d8-4765264f136c.png?raw=true"> 
    <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45982815-95f12a80-c05a-11e8-8c2c-3a7913c765f0.png?raw=true"> <br>
 <span><i>Image 8,9: Views for Author and Puslisher </i></span>
</p>

Each member has his own shopping cart in which he has an insight into the books he has purchased. Clicking Go to checkout opens a new view in which you need to complete the relevant data in order for the transaction to be performed.

<p align="center">
    <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45983192-f896f600-c05b-11e8-8e5e-b097d2392aad.png?raw=true"> 
    <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45983195-fa60b980-c05b-11e8-89d1-f6b5f6ffb9ba.png?raw=true"> 
     <img width=30% height=30% src="https://user-images.githubusercontent.com/36881871/45983200-fe8cd700-c05b-11e8-983c-43da441f914f.png?raw=true"> 
    <br>
 <span><i>Image 9,10,11: Shopping cart </i></span>
</p>

Based on the role each member has access to a different panel

<p align="center">
    <img width=20%  src="https://user-images.githubusercontent.com/36881871/45983958-30ec0380-c05f-11e8-93f3-90effffdfe10.png"> 
    <img width=20% src="https://user-images.githubusercontent.com/36881871/45983728-241ae000-c05e-11e8-9b9c-5bad67c78271.png?raw=true"> 
     <img width=20%  src="https://user-images.githubusercontent.com/36881871/45983734-29782a80-c05e-11e8-92ef-f14e645dfa97.png?raw=true"> 
     <img width=20%  src="https://user-images.githubusercontent.com/36881871/45983738-3006a200-c05e-11e8-9fd4-e3138299d2c4.png?raw=true"> 
    <br>
 <span><i>Image 11,12,13,14: User pannels </i></span>
</p>

### 2. Description of the implementation
The implementation takes place on the basis of several related classess Book, Publisher, Author, Genre, ShoppingCarts that are placed in a suitable base that allows them to manipulate each other. The overall application is mainly based on bootstrap, html, jquery and ajax code that allow designing the current look. We also made drastic changes in controllers and views of each class by adding custom code to achieve maximum functionality. 


## Third-party libraries/services
In the development of the application we used the packages offered by us **Nuget packet manager** as well as some **bootstrap and jquery** libraries from the outside that we implemented in the application to get the desired look.

**Made by:**
1. [Kostadin Krstev](https://github.com/krstevkoki) 161 169
2. [Mihail Zafirovski](https://github.com/mihailz) 161 162

