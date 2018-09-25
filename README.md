<p align="center">
    <img width=40% src="LibraryWebApp/img/logo.jpg?raw=true" alt="Лого на апликацијата/Application logo">
</p>

<h1 align="center">LibaryWebApp</h1>
<p align="center">Веб апликација/онлајн <b>продавница за книги </b></p>
<p align="center">Web application/online <b>store for books</b></p>

<div>
    <h3 align="center">
        <span><a href="#Содржина">Македонски</a></span>
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
- Имплементирана потрошувачка кошничка за купување на книги
- 4 улоги (**Администратор**, **Вработен/Кадар**, **Член**, **Корисник**)
- **Систем со поени** кои членот ги добива при купување на некоја книга. Истите можат да се искористат за попуст при понатамошни купувања
- **Посебен поглед** за секоја од улогите
- **Манипулација** со податоците преку соодветно креирана база
<br>

## Краток опис на апликацијата
Оваа апликација е наменета за продажба на книги. Истата го користи шаблонот *grid of equals* за соодветен приказ на книгите на Home Page-от. Корисникот има можност за пребарување на соодветна книга. Исто така има опција и да ги сортира книгите врз основа на неколку критериуми како што се: цена, наслов, количина или датум на издавање. Апликацијата располага со 4 улоги: Администратор, Вработен, Член и Корисник. Корисникот има опција да пристапи до деталите за секоја книга, одделно, со едноставен клик на копчето *Details*. При клик на копчето *Details* му се отвора нов поглед на кој се прикажани деталите за книгата (цена, автор, издавач) како и можност за пристап до соодветен поглед за истите. Корисникот има можност да ја купи книгата само доколку е најавен, т.е. доколку е член, во спротива истиот се редиректира на соодветен поглед за најава/регистрација. Регистрираниот корисник има можност да купи книга и притоа за секоја купена книга му се пресметуваат соодветни поени, кои му носат попуст при понатамошни купувања, доколку одлучи да стане член (*Member*) во библиотеката. Секој корисник има соодветна потрошувачка кошничка во која се наоѓаат книгите кои ги купил, нивната количина и вкупниот износ за плаќање. Притоа истиот има увид во книгите кои ги купил во својот кориснички поглед. Исто така, секој член може да остави критика за било која книга. Вработените и Администраторите имаат дополнителни можности како промена на податоците за соодветна книга, автор, издавач или жанр.

<br>

## Упатство за користење

### 1. Опис на формите во апликацијата

При стартувањето на апликацијата се прикажува Home Page-от кој е прикажан на Слика 1

<p align="center">
    <img width=90% height="60%" src="LibraryWebApp/img/1.png?raw=true"> <br>
    <i>Слика 1: Главен поглед на апликацијата</i>
</p>

Откако му се прикажува Home Page-от корисникот има можност да изврши пребарување за да ја најде посакуваната книга или пак да изврши
сортирање врз основа на понудените критериуми.

<p align="center">
    <img width=30% src="LibraryWebApp/img/2.png?raw=true" alt="Search box">
    <img width=30% src="LibraryWebApp/img/3.png?raw=true" alt="Sort list">
    <br>
    <span><i>Слика 2, 3: Функционалности на алатките за пребарување и сортирање</i></span>
</p>

Резултатите се прикажуваат во истиот поглед:

<p align="center">
    <img width=60% height=50% src="LibraryWebApp/img/4.png?raw=true">
    <br>
    <span><i>Слика 4: Приказ на резултатите </i></span>
</p>

При клик на копчето *Details* за било која книга се отвора нов поглед со соодветни детали за истата (автор, издавач, залиха), а во долниот дел од погледот има имплементирано carousel на кој се прикажани предлози за книги кои припаѓаат на истиот жанр како тековната.

<p align="center">
    <img width=60% height=50% src="LibraryWebApp/img/5.png?raw=true">
    <br>
    <span><i>Слика 5: Приказ на Details поглед за книга </i></span>
</p>

Со клик на копчето *Add review* се отвора диалог-прозорец во кој може да се напише соодветната критика за книгата.

<p align="center">
    <img width=30% height=30% src="LibraryWebApp/img/6.png?raw=true">
    <img width=30% height=30% src="LibraryWebApp/img/7.png?raw=true"> <br>
    <span><i>Слика 6, 7: Прозорец за оставање критика за книгата и прикажување на истата </i></span>
</p>

Со клик на линковите кои водат до авторот и издавачот на книгата се отвораат соодветни погледи:

<p align="center">
    <img width=30% height=30% src="LibraryWebApp/img/8.png?raw=true">
    <img width=30% height=30% src="LibraryWebApp/img/9.png?raw=true"> <br>
 <span><i>Слика 8, 9: Погледи за автор и издавач </i></span>
</p>

Секој член има своја потрошувачка кошничка во која има увид во книгите кои ги избрал за купување. Со клик на копчето *Go to checkout* се отвора нов поглед во кој треба да ги потполни соодветните податоци за да може да се изврши трансакцијата.

<p align="center">
    <img width=30% height=30% src="LibraryWebApp/img/10.png?raw=true">
    <img width=30% height=30% src="LibraryWebApp/img/11.png?raw=true">
     <img width=30% height=30% src="LibraryWebApp/img/12.png?raw=true">
    <br>
 <span><i>Слика 10, 11, 12: Потрошувачка кошничка </i></span>
</p>

Врз база на улогата секој член има достапност до различен панел:

<p align="center">
    <img width=20%  src="https://user-images.githubusercontent.com/36881871/45983958-30ec0380-c05f-11e8-93f3-90effffdfe10.png">
    <img width=20% src="https://user-images.githubusercontent.com/36881871/45983728-241ae000-c05e-11e8-9b9c-5bad67c78271.png?raw=true">
    <img width=20%  src="https://user-images.githubusercontent.com/36881871/45983734-29782a80-c05e-11e8-92ef-f14e645dfa97.png?raw=true">
    <img width=20%  src="https://user-images.githubusercontent.com/36881871/45983738-3006a200-c05e-11e8-9fd4-e3138299d2c4.png?raw=true">
    <br>
 <span><i>Слика 13, 14, 14, 14: Кориснички панели </i></span>
</p>

### 2. Опис на имплементацијата
Имплементацијата се одвива врз база на неколку поврзани класи Book,Publisher,Author,Genre,ShoppingCart кои се сместени во соодветна база која овозможува нивна меѓусебна манипулација. Целокупната апликација, во главно, се базира на Bootstrap, HTML, jQuery и AJAX код кој овозможи дизајнирање на тековниот изглед и функционалност. Исто така направивме и драстични измени во контролерите и погледите за секоја од класите преку додавање на custom код за постигнување максимална финкционалност.


## Користени библиотеки/сервиси
Во рамките на нашата веб апликација искористивме неколку библиотеки кои беа инсталирани преку **NuGet** package manager. Некои од поважните библиотеки кои беа искористени се:
- **EntityFramework** (ORM for .NET framework, за манипулација со базата на податоци)
- **Bootstrap** (front-end CSS library, за изгледот на апликацијата)
- **jQuery** (front-end JS library, за AJAX повиците и манипулација на DOM структурата на HTML-oт)
- **jQuery DataTables** (jQuery plugin, за креирање на дата табели со помош на jQuery)
- **NotFoundMvc** (за препокривање на стандардната 404 NotFound порака)
- **PagedList** (за имплементација на страничење на книгите прикажани во Home Page-от)

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
- Using an appropriate desing pattern for books offered for sale, implementing search and sorting techniques
- Relatively easy navigation through the content of the application
- A shopping bag for purchasing books
- 4 roles (**Administrator**, **Employee / Staff**, **Member**, **User**)
- **Points** that the member gets when purchasing a book. They can be used fs discounts for further payments
- **Special view** for each of the roles separately
- **Manipulation** with data using database
<br>

## Brief description of the application
This application is used for selling books. It uses the *grid of equals* design pattern for a proper display of books on the Home Page. The user has the ability to search for an appropriate book. Also has the option of sorting books based on criteria such as: price, book title, quantity or date of publish. The application has 4 roles: Administrator, Staff, Member and User. The user has the option to access the details of each book separately by simply clicking the *Details* button. Clicking on the *Details* button opens a new view showing the details of the book (price, author, publisher) and the ability to access an appropriate view of them. The user has the ability to buy the book only if he is logged in, in opposite, he will be redirected to an appropriate view for log in/registration. The registered user has the ability to buy a book, and for each purchased book, it is calculated the appropriate points that give him a discount for further payments. Each member has an appropriate shopping bag containing the books he wants to purchase, their amount and the total amount of the payment. Every user has an insight into the books that he has purchased. Also, each user can write reviews for any book. Employees and administrators have additional abilities to edit details for an appropriate book, author, publisher or genre.

<br>

## User manual

### 1. Description of the forms in the application

When starting the application, the Home Page is displayed as shown on Image 1

<p align="center">
    <img width=90% height="60%" src="LibraryWebApp/img/1.png?raw=true"> <br>
    <i>Image 1: Main view of the application</i>
</p>

After the Home Page is displayed, the user has the ability to perform a search to find the desired book or to perform sorting based on the criteria offered.

<p align="center">
    <img width=30% src="LibraryWebApp/img/2.png?raw=true" alt="Search box">
    <img width=30% src="LibraryWebApp/img/3.png?raw=true" alt="Sort list">
    <br>
    <span><i>Image 2, 3: Functions of search and sort tools</i></span>
</p>

The results are displayed in a the same view:

<p align="center">
    <img width=60% height=50% src="LibraryWebApp/img/4.png?raw=true">
    <br>
    <span><i>Image 4: Displaying the results </i></span>
</p>

Clicking on the *Details* button, for any book, opens a new view with appropriate details (author, publisher, quantity, price) and in the bottom of the view there is a carousel that displays recommendations that belong to the same genre as the current one.

<p align="center">
    <img width=60% height=50% src="LibraryWebApp/img/5.png?raw=true">
    <br>
    <span><i>Image 5: Details view for the book </i></span>
</p>

Clicking the *Add review* button opens a modal window in which you can write the appropriate review for the book.

<p align="center">
    <img width=30% height=30% src="LibraryWebApp/img/6.png?raw=true">
    <img width=30% height=30% src="LibraryWebApp/img/7.png?raw=true"> <br>
    <span><i>Image 6, 7: Displaying dialog for leaving a review for the book and showind the review comment </i></span>
</p>

Clicking the links, that lead to the author and the book publisher, will open up appropriate views:

<p align="center">
    <img width=30% height=30% src="LibraryWebApp/img/8.png?raw=true">
    <img width=30% height=30% src="LibraryWebApp/img/9.png?raw=true"> <br>
 <span><i>Image 8, 9: Views for Author and Publisher </i></span>
</p>

Each member has his own shopping bag in which he has an insight into the books he wants to purchase. Clicking the *Go to checkout* button opens a new view in which you need to complete the required data in order to be performe a transaction.

<p align="center">
    <img width=30% height=30% src="LibraryWebApp/img/10.png?raw=true">
    <img width=30% height=30% src="LibraryWebApp/img/11.png?raw=true">
     <img width=30% height=30% src="LibraryWebApp/img/12.png?raw=true">
    <br>
 <span><i>Image 10, 11, 12: Shopping cart</i></span>
</p>

Based on the role each member has access to a different panel:

<p align="center">
    <img width=20%  src="https://user-images.githubusercontent.com/36881871/45983958-30ec0380-c05f-11e8-93f3-90effffdfe10.png">
    <img width=20% src="https://user-images.githubusercontent.com/36881871/45983728-241ae000-c05e-11e8-9b9c-5bad67c78271.png?raw=true">
     <img width=20%  src="https://user-images.githubusercontent.com/36881871/45983734-29782a80-c05e-11e8-92ef-f14e645dfa97.png?raw=true">
     <img width=20%  src="https://user-images.githubusercontent.com/36881871/45983738-3006a200-c05e-11e8-9fd4-e3138299d2c4.png?raw=true">
    <br>
 <span><i>Image 11,12,13,14: User pannels </i></span>
</p>

### 2. Description of the implementation
The implementation takes place on the basis of several related classes Book, Publisher, Author, Genre, ShoppingCart that are placed in a  database that allows manipulation of each other. The overall application is mainly based on Bootstrap, HTML, jQuery and AJAX code that allow designing the current look and functionality. We also made drastic changes in controllers and views of each class by adding custom code to achieve maximum functionality.

## Third-party libraries/services
Within our web application, we used several libraries that were installed through the *NuGet* package manager. Some of the most important libraries used were:

- EntityFramework (ORM for .NET framework, for manipulating the database)
- Bootstrap (front-end CSS library, for the appearance of the application)
- jQuery (front-end JS library, for AJAX calls and manipulation of the DOM structure of the HTML)
- jQuery DataTables (jQuery plugin, to create data tables using jQuery)
- NotFoundMvc (to override the default 404 NotFound message)
- PagedList (for the implementation of pagination for the books shown in the home page)

**Made by:**
1. [Kostadin Krstev](https://github.com/krstevkoki) 161 169
2. [Mihail Zafirovski](https://github.com/mihailz) 161 162
